using Syringe_app.Properties;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Management;
using System.Resources;
using System.Threading;
using System.Timers;
using System.Windows.Forms;

namespace Syringe_app
{
    public partial class mainApp : Form
    {
        /// <summary>
        /// Constants and variable
        /// </summary>
        #region VARIABLE AND CONSTANTS:
        private Syringe syringe1 = new Syringe("10", "11", "50", "51", "30", "80{0}", "31{0}", "54", "12", "13", "14", "15");
        Syringe[] syringes;


        // Move coordinates
        int move, moveX, moveY;

        //speed and syringe values:
        int syringe_val = 0;
        double speed_val = 0;

        int lenght = 0;

        //Current syringe status
        private int statusS1;
        private static int RUNNING = 0;
        private static int HOMMING = 1;
        private static int HOME_DONE = 2;
        private static int START_POS = 3;
        private static int START_POS_DONE = 4;
        private static int WAITING = 5;
        private static int MOVING_FORTH = 6;
        private static int MOVING_BACK = 7;
        private static int BOLUS = 8;

        private static int QUARTER = 1;
        private static int HALF = 2;
        private static int FULL = 3;

        //Communication (status -> communication status)
        Communication communication;
        int status;

        //Syringe speeds:
        string[] syringe1ml_speeds = new string[] { "1", "0,72", "0,54", "0,36", "0,18", "0,1" };
        string[] other_syringe_speeds = new string[] { "1", "5", "10", "15", "20" };

        //Time elapsed:
        Stopwatch sw = new Stopwatch();
        TimeSpan ts = new TimeSpan();

        #endregion

        /// <summary>
        /// Colors of every button and form component
        /// </summary>
        #region COLORS:
        Color fore_color = Color.FromArgb(255, 17, 90, 124);
        Color text_color = Color.FromArgb(255, 0, 187, 232);
        Color stop_color = Color.FromArgb(150, 255, 0, 0);
        Color green = Color.FromArgb(255, 0, 255, 0);
        Color grey = Color.DarkGray;
        #endregion

        /// <summary>
        /// Initialization of main form of the program
        /// </summary>
        #region FORM:
        public mainApp()
        {
            InitializeComponent();
        }

        private Point start_connection_location;

        System.Timers.Timer t;

        private void Form1_Load(object sender, EventArgs e)
        {

            syringes = new Syringe[] { syringe1 };

            communication = new Communication(serialPort);

            _arrival.EventArrived += _arrival_EventArrived;
            _removal.EventArrived += _removal_EventArrived;


            this.Width = (syringe1group.Width + 20);
            panel1.Width = (this.Width - 48);
            minimalize_btn.Location = new Point(panel1.Width, 0);
            exit_button.Location = new Point(minimalize_btn.Location.X + 24, 0);

            start_connection_location = connection_group.Location;

            InitializeColorsSyringe1();

            statusS1 = WAITING;

            t = new System.Timers.Timer();
            t.Interval = 25;
            t.Elapsed += new ElapsedEventHandler(getData);
            t.AutoReset = true;
            
            var port = AutodetectArduinoPort();
            if (port != null)
            {
                this.Invoke(new Action(()=> serialConnection(port)));
                _removal.Start();     
            }
            else
            {
                port_txt.Text = "Device unplugged!";
                _arrival.Start();
            }

            syringeCombobox.Focus();
            syringeCombobox.Select();

        }

        private void clear()
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
        }

        private void InitializeColorsSyringe1()
        {
            buttons_enabled(false);
            stop_btn.Enabled = false;

            speedCombobox.Items.Clear();

            //Set Buttons enable on start:
            set_speed.Enabled = false;
            set_syringe.Enabled = false;
            bolus.Enabled = false;

            //Butttons Fore colors set
            port_txt.ForeColor = fore_color;
            speed_lbl.ForeColor = fore_color;
            syringe_lbl.ForeColor = fore_color;
            bolus_distance_lbl.ForeColor = fore_color;
            bolus_speed_lbl.ForeColor = fore_color;
            set_speed.ForeColor = fore_color;
            bolus.ForeColor = fore_color;
            run_status.ForeColor = fore_color;
            set_syringe.ForeColor = fore_color;
            home_1.ForeColor = fore_color;
            exit_bolus.ForeColor = fore_color;
            move_speed_lbl.ForeColor = fore_color;
     
            bolus_start.BackColor = text_color;
            bolus_start.ForeColor = Color.White;

            pos_start_btn.ForeColor = Color.White;

            //progress bar settinges:
            progress_bar.BackColor = fore_color;
            progress_bar_complete = progress_bar.Width;
            progress_bar.Width = 0;

            speed_status.ForeColor = text_color;
            syringe_status.ForeColor = text_color;

            speedCombobox.ForeColor = fore_color;
            syringeCombobox.ForeColor = fore_color;

            //Buttons back colors set
            start_btn.BackColor = text_color;
            forth_btn.BackColor = fore_color;
            back_btn.BackColor = fore_color;
            stop_btn.BackColor = stop_color;
            pos_start_btn.BackColor = fore_color;

            start_btn.ForeColor = Color.White;
            forth_btn.ForeColor = Color.White;
            back_btn.ForeColor = Color.White;
            stop_btn.ForeColor = Color.White;

            //Status colors and text
            run_status.Text = "";
            connection_status.BackColor = Color.IndianRed;
            time_elapsed_txt.Text = "";
            time_elapsed_txt.ForeColor = fore_color;
            syringe1ml.ForeColor = fore_color;


            //Syringe image:
            syringe_pict.Image = Syringe_app.Properties.Resources.Strzykawka_0000;

            // unit labels color:
            syringe_unit.ForeColor = fore_color;
            speed_unit.ForeColor = fore_color;

            //bolus
            bolus_speed_lbl.ForeColor = fore_color;
            bolus_distance_lbl.ForeColor = fore_color;
            
        }

        private void buttons_enabled(bool b)
        {
            move_groupbox.Enabled = b;
            start_btn.Enabled = b;
            set_syringe.Enabled = b;
            set_speed.Enabled = b;
            bolus.Enabled = b;
            stop_btn.Enabled = !b;

            bolus_start.Enabled = b;
            exit_bolus.Enabled = b;

            track_speed1.Enabled = b;

        }

        #endregion

        /// <summary>
        /// Controling form: minimalize and exit
        /// </summary>
        /// <param Buttons Clic sender ="sender"></param>
        /// <param EventArgs="e"></param>
        #region EXIT/MINIMALIZE BUTTON:
        private void exit_button_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you want to close Syringe Pump App?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                try
                {
                    serialPort.Close();
                    Application.Exit();
                }
                catch (IOException ex)
                {
                    MessageBox.Show("Error: " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (dialog == DialogResult.No)
            {

            }
        }

        private void minimalize_btn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            exit_button.PerformClick();
        }
        #endregion

        /// <summary>
        /// Lets make the form moveable
        /// </summary>
        /// <param Mause Button sender="sender"></param>
        /// <param MouseEventArgs="e"></param>
        #region FORM MOVE METHODS:
        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            move = 0;
        }


        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (move == 1)
            {
                this.SetDesktopLocation(MousePosition.X - moveX, MousePosition.Y - moveY);
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            move = 1;
            moveX = e.X;
            moveY = e.Y;
        }

        #endregion


        //End of form control and interface 
        //Begin of real program
        //......................................................................................................................

        /// <summary>
        /// Conection functions
        /// </summary>
        /// <param Serial Port Name="port"></param>
        #region COM:

        private void serialConnection(string port)
        {
            status = communication.connect(port, syringes);
            if (status == 1)
            {
                port_txt.Text = String.Concat("Port: ", port);
                connection_status.Text = "Status: Connected";
                connection_status.BackColor = Color.LimeGreen;


                //Buttons state:
                buttons_enabled(true);

                track_speed1.Value = QUARTER;
                Thread.Sleep(200);           

                t.Start();
            }
            //Disconnect:
            else if (status == 2)
            {
                port_txt.Text = String.Concat("Device unplugged!");
                connection_status.Text = "Status: Disconnected";
                connection_status.BackColor = Color.IndianRed;
                //Buttons state:

                buttons_enabled(false);
                stop_btn.Enabled = false;
                t.Close();

            }
            else if (port == null)
            {
                connection_status.Text = "Status: Error";
                connection_status.BackColor = Color.IndianRed;
            }
        }

        #endregion

        /// <summary>
        /// Methods implements buttons clicks
        /// Move a syringe
        /// </summary>
        #region START/STOP AND MOVE FOR SYRINGES:
        #region SYRINGE ONE START/STOP:
        int pos, pos2 = 0;

        private void start_btn_Click(object sender, EventArgs e)
        {
            
            if (speed_val != 0 && syringe_val != 0)
            {
                track_speed1.Value = QUARTER;
                Thread.Sleep(500);

                communication.setPeriod(syringe1);
                //..................................................

                //syringe_pict.Image = (Bitmap)rm.GetObject(string.Format("Strzykawka_00{0}", j));
                if (prog1 < 100)
                {   
                    communication.run(syringe1);

                    //Buttons state change:
                    buttons_enabled(false);
                    start_btn.BackColor = Color.FromArgb(150, text_color.R, text_color.G, text_color.B);
                    sw.Start();
                    statusS1 = RUNNING;
                    syringe1ml.Visible = true;
                    //................ 
                    pos = a;

                    set_syringe.Enabled = false;
                    syringeCombobox.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("Select a syringe and speed value!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void stop_btn_Click(object sender, EventArgs e)
        {
            communication.stopMoving(syringe1);

            sw.Stop();

            buttons_enabled(true);
            start_btn.BackColor = text_color;

            if (statusS1 == HOMMING)
            {
                injected.Text = "Homming stopped";
                statusS1 = WAITING;
            }
            else if (statusS1 == START_POS)
            {
                injected.Text = "Setting start position stopped";
                statusS1 = WAITING;
            }
            else if(statusS1 == BOLUS)
            {
                bolus_start.Enabled = true;
                exit_bolus.Enabled = true;
                injected.Text = "Bolus stopped";
                statusS1 = WAITING;
            }
            else
                statusS1 = WAITING;

           set_syringe.Enabled = true;
            syringeCombobox.Enabled = true;
        }

        #endregion

        int val = 1;

        int newPos = 0;

        #region MOVE SYRINGE ONE:
        private void track_speed1_ValueChanged(object sender, EventArgs e)
        {
            Thread.Sleep(500);
            int change = val - track_speed1.Value;
            switch (change)
            {
                case -1:
                    x = 2.0;
                    break;

                case -2:
                    x = 4.0;
                    break;

                case 2:
                    x =  0.25;
                    break;

                case 1:
                    x = 0.5;
                    break;
            }
            newPos =    (int)(a / x);
            val = track_speed1.Value;
            if (track_speed1.Value == 3)
                calibration = 4;
            else
                calibration = track_speed1.Value;

            communication.changeStep(syringe1, track_speed1.Value, newPos);
            set_syringe.Enabled = true;
            setSytingeOne();
            //startPos = (int)syringe1.getStartPosition();

            
            
        }

        private void forth_btn_MouseDown(object sender, MouseEventArgs e)
        {

            if (statusS1 == START_POS_DONE || statusS1 == HOME_DONE)
            {
                injected.Text = "";
            }
            if (syringe1ml.Visible != true)
                syringe1ml.Visible = true;
            if (prog1 < 100)
            {
                statusS1 = MOVING_FORTH;
                forward(syringe1);
            }
            else
            {
                statusS1 = WAITING;
            }
        }

        private void forth_btn_MouseUp(object sender, MouseEventArgs e)
        {
            stopMoving(syringe1);
        }

        private void back_btn_MouseDown(object sender, MouseEventArgs e)
        {
            backward(syringe1);
            if (statusS1 == START_POS_DONE || statusS1 == HOME_DONE)
            {
                injected.Text = "";
            }
            if (syringe1ml.Visible != true)
                syringe1ml.Visible = true;

            statusS1 = MOVING_BACK;
        }

        private void back_btn_MouseUp(object sender, MouseEventArgs e)
        {
            stopMoving(syringe1);
        }
        #endregion

        double x = 1;


        #region MOVE METHODS:
        private void forward(Syringe syringe)
        {
            communication.forward(syringe);

        }

        private void stopMoving(Syringe syringe)
        {
            communication.stopMoving(syringe);

        }

        private void backward(Syringe syringe)
        {
            communication.backward(syringe);

        }
        #endregion

        #endregion

        /// <summary>
        /// Status methods: loading, % status and syringe image 
        /// </summary>
        #region STATUS METHODS:
        ResourceManager rm = Resources.ResourceManager;

        private void status_loading(double percentageProgress, TextBox text)
        {
            text.Invoke(new Action(() => text.Text = String.Format("{0:0.00}%", percentageProgress)));
        }

        private void setImage(PictureBox picture, double k)
        {
            if ((int)k <= 20 && (int)k >= 0)
                picture.Image = (Bitmap)rm.GetObject(string.Format("Strzykawka_00{0}", (30 - (int)k)));
            else if ((int)k > 20)
                picture.Image = (Bitmap)rm.GetObject(string.Format("Strzykawka_000{0}", (30 - (int)k)));
            else if ((int)k < 0)
                picture.Image = (Bitmap)rm.GetObject(string.Format("Strzykawka_00{0}", 30));
        }

        int progress_bar_complete;
        private void progress_bar_change(double progress, Panel progressbar)
        {
            progressbar.Invoke(new Action(() => progressbar.Width = progress_bar_complete * (int)progress / 100));
        }

        private void time_text(TimeSpan ts, Label elapsedTime)
        {
            elapsedTime.Invoke(new Action(() => elapsedTime.Text = string.Format("Elapsed time: {0:D2}h:{1:D2}m:{2:D2}s:{3:D3}ms",
                                            ts.Hours,
                                            ts.Minutes,
                                            ts.Seconds,
                                            ts.Milliseconds
                                            )));
        }

        private void reset(Stopwatch sw)
        {
            sw.Stop();
            sw.Reset();
        }

        #endregion

        /// <summary>
        /// Syringes set values
        /// Syringe one set value
        /// Syringe two set value
        /// </summary>
        /// <param sender="sender"></param>
        /// <param EventArgs="e"></param>
        #region SYRINGES SET VALUES:
        #region SYRINGE ONE SET VALUE:
        private void set_speed_Click(object sender, EventArgs e)
        {
            if (speedCombobox.SelectedItem == null)
                MessageBox.Show("Select a speed value!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                speed_val = double.Parse(speedCombobox.Text);

                //Selected speed status:
                speed_status.Text = String.Format("Current speed: {0}", speed_val);
                set_speed.Enabled = false;

                syringe1.setSpeed(speed_val);
                communication.setPeriod(syringe1);
            }

            set_speed.Enabled = false;
            
        }

        private int current_syringe = 0;
        private void set_syringe_Click(object sender, EventArgs e)
        {
            setSytingeOne();
        }

        private void setSytingeOne()
        {
            if (syringeCombobox.SelectedItem == null)
                MessageBox.Show("Select a syringe!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                syringe_val = int.Parse(syringeCombobox.Text);

                //syringe1.setCalibration(track_speed1.Value);

                if (syringe_val != current_syringe)
                {
                    speedCombobox.Items.Clear();
                    speedCombobox.Text = null;
                    current_syringe = syringe_val;

                    speed_val = 0;

                    reset(sw);

                    if (syringe_val == 1)
                    {
                        speedCombo(speedCombobox, syringe1ml_speeds, speed_val, speed_status);
                    }
                    else
                    {
                        speedCombo(speedCombobox, other_syringe_speeds, speed_val, speed_status);
                    }

                }

                syringe1.setCalibration(calibration);

                syringe1.setSyringe(current_syringe);

                startPos = (int)syringe1.getStartPosition();

                lenght = (int)syringe1.getLenght();

                communication.setHardStop(syringe1);

                //Selected syringe status:
                syringe_status.Text = String.Format("Current syringe: {0}", syringe_val);

                set_syringe.Enabled = false;

            }
        }

        private void syringeCombobox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            set_syringe.Enabled = true;
        }

        private void speedCombobox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            set_speed.Enabled = true;
        }

        private void speedCombo(ComboBox combo, string[] range, double speed, TextBox speedo)
        {
            combo.Items.AddRange(range);
            speed = 0;
            speedo.Text = String.Format("Current speed: {0}", speed);
        }

        #endregion
        #endregion

        /// <summary>
        /// Home and start position events
        /// </summary>
        /// <param sender="sender"></param>
        /// <param EventArgs="e"></param>
        #region HOME AND START_POS

        int calibration = 1;

        private void home_1_Click(object sender, EventArgs e)
        {
            track_speed1.Value = FULL;

            buttons_enabled(false);
            communication.home(syringe1);
            sw.Reset();
            ts = TimeSpan.FromMilliseconds(sw.ElapsedMilliseconds);
            time_text(ts, time_elapsed_txt);
            progress_bar_change(0, progress_bar);
            injected.Text = "Homming...";
            statusS1 = HOMMING;
            syringe1ml.Visible = false;
            
        }

        private void pos_start_btn_Click(object sender, EventArgs e)
        {
            if (current_syringe != 0)
            {
                startPos = (int)syringe1.getStartPosition();
                communication.setStartPosition(syringe1,calibration);
                prog1 = 0;
                statusS1 = START_POS;
                buttons_enabled(false);
                syringe1ml.Visible = false;
                injected.Text = "Moving to start position...";
                
            }
            else
            {
                MessageBox.Show("Select a syringe!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        #endregion


        /// <summary>
        /// Data receiveds events - status uptading and control a position
        /// </summary>
        #region DATA RECEIVED:
        int a;
        int l;
        double prog1 = 0;
        string[] message = new string[2];
        double ml1, inj = 0;

        int startPos = 0;

        string progress = "";
        private void getData(object sender, ElapsedEventArgs e)
        {
            progress = communication.readPosition();
            if (progress != "stop")
                progressChange(progress);
            clear(); 
        }

        private void progressChange(string progress)
        {
            if (progress.Length > 0)
            {
                message = progress.Split('\n');

                try
                {
                    if (message[0].Contains("1:") && lenght != 0)
                    {
                        l = message[0].Length;
                        a = Int32.Parse(message[0].Substring(2, l - 2));
                        prog1 = (a - startPos) * 100 / (double)lenght;
                        ml1 = (current_syringe * (a - startPos)) / (double)lenght;
                        inj = (current_syringe * (a - pos)) / (double)lenght;
                    }

                    if (message[0].Contains("12:") && statusS1 == HOMMING)
                    {
                        injected.Invoke(new Action(() => injected.Text = "Homming done!"));
                        statusS1 = HOME_DONE;
                        this.Invoke(new Action(() => stop_btn.PerformClick()));
                    }

                    if (message[0].Contains("14:") && statusS1 == START_POS)
                    {
                        syringe1ml.Invoke(new Action(() => syringe1ml.Visible = true));
                        injected.Invoke(new Action(() => injected.Text = "Syringe on start position!"));
                        statusS1 = START_POS_DONE;
                        this.Invoke(new Action(() => stop_btn.PerformClick()));
                        pos = a;
                    }

                    if (message[0].Contains("18:") && (statusS1 == RUNNING || statusS1 == MOVING_FORTH || statusS1 == WAITING || statusS1 == BOLUS))
                    {
                        communication.stopMoving(syringe1);
                        sw.Stop();
                        ts = TimeSpan.FromMilliseconds(sw.ElapsedMilliseconds);
                        time_text(ts, time_elapsed_txt);
                        this.Invoke(new Action(() => this.buttons_enabled(true)));
                        setImage(syringe_pict, 100 / 3.3);
                        progress_bar_change(100, progress_bar);
                        statusS1 = WAITING;
                        set_syringe.Invoke(new Action(() => set_syringe.Enabled = true));
                        syringeCombobox.Invoke(new Action(() => syringeCombobox.Enabled = true));
                    }
                    else
                    {
                        ts = TimeSpan.FromMilliseconds(sw.ElapsedMilliseconds);
                        time_text(ts, time_elapsed_txt);
                        if (prog1 >= 0)
                            status_loading(prog1, run_status);
                        else
                            status_loading(0, run_status);
                        setImage(syringe_pict, prog1 / 3.3);
                        progress_bar_change(prog1, progress_bar);
                    }

                    if (message[0].Contains("16:") && statusS1 == BOLUS)
                    {
                        sw.Stop();
                        ts = TimeSpan.FromMilliseconds(sw.ElapsedMilliseconds);
                        time_text(ts, time_elapsed_txt);
                        this.Invoke(new Action(() => this.buttons_enabled(true)));
                        statusS1 = WAITING;
                        set_syringe.Invoke(new Action(() => set_syringe.Enabled = true));

                        syringeCombobox.Invoke(new Action(() => syringeCombobox.Enabled = true));
                    }

                    if (current_syringe == 1)
                    {
                        if (statusS1 == RUNNING)
                            injected.Invoke(new Action(() => injected.Text = string.Format("Injected: {0:0.00} ul", inj * 1000)));
                        else
                            syringe1ml.Invoke(new Action(() => syringe1ml.Text = string.Format("Pumped: {0:0.00} ul", ml1 * 1000)));

                    }
                    else
                    {
                        if (statusS1 == RUNNING)
                            injected.Invoke(new Action(() => injected.Text = string.Format("Injected: {0:0.00} ml", inj)));
                        else
                            syringe1ml.Invoke(new Action(() => syringe1ml.Text = string.Format("Pumped: {0:0.00} ml", ml1)));
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        #endregion

        /// <summary>
        /// Detect arrival device or removal
        /// </summary>
        /// <returns></returns>
        #region DEVICE ARRIVAL/REMOVAL
        private string AutodetectArduinoPort()
        {
            ManagementScope connectionScope = new ManagementScope();
            SelectQuery serialQuery = new SelectQuery("SELECT * FROM Win32_SerialPort");
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(connectionScope, serialQuery);

            try
            {
                foreach (ManagementObject item in searcher.Get())
                {
                    string desc = item["PNPDeviceID"].ToString();
                    string deviceId = item["DeviceID"].ToString();

                    if (desc.Contains("VID_2341") && desc.Contains("PID_8036"))
                    {
                        return deviceId;
                    }
                }
            }
            catch (ManagementException e)
            { }

            return null;
        }

        private readonly ManagementEventWatcher _arrival = new ManagementEventWatcher(new WqlEventQuery(
                "SELECT * FROM Win32_DeviceChangeEvent WHERE EventType = 2"));

        private readonly ManagementEventWatcher _removal = new ManagementEventWatcher(new WqlEventQuery(
                "SELECT * FROM Win32_DeviceChangeEvent WHERE EventType = 3"));

        private void _arrival_EventArrived(object sender, EventArrivedEventArgs e)
        {
            Thread.Sleep(1000);
            var port = AutodetectArduinoPort();
            if (port != null)
            {
                this.Invoke(new Action(()=> serialConnection(port)));
                _removal.Start();
                _arrival.Stop();
            }

        }


        private void _removal_EventArrived(object sender, EventArrivedEventArgs e)
        {
            var port = AutodetectArduinoPort();
            if (port == null)
            {
                this.Invoke(new Action(()=> serialPortUnplugged()));
                _removal.Stop();
                _arrival.Start();
            }

        }

        private void serialPortUnplugged()
        {
            connection_status.Text = "Status: Disconnected";
            connection_status.BackColor = Color.IndianRed;
            //Buttons state:
            buttons_enabled(false);
            stop_btn.Enabled = false;
            t.Close();

            sw.Stop();

            //Serial close
            try
            {
                serialPort.Close();
            }
            catch (Exception ex) { }

            port_txt.Invoke(new Action(() => port_txt.Text = String.Concat("Device unplugged!")));

            //Disposing a serialport and create a new instance to connection
            serialPort.Dispose();
            Thread.Sleep(100);
            serialPort = new System.IO.Ports.SerialPort();
            serialPort.BaudRate = 115200;
            communication.setSerialPort(serialPort);

        }

        #endregion

        /// <summary>
        /// Methods to control Bolus mode
        /// only for syringe one
        /// </summary>
        #region BOLUS
        private static void textBoxMaxValue(object sender, int value)
        {
            NumericUpDown tb = sender as NumericUpDown;
            int i = (int)tb.Value;

            if (i >= 0 && i <= value)
                return;
            else if (i < 0)
            {
                tb.Value = 0;
                return;
            }
            else
            {
                tb.Value = value;
                return;
            }

        }

        private void bolusInj_ValueChanged(object sender, EventArgs e)
        {
            int max = (int)bolusInj.Maximum - (int)(ml1 * 1000);
            textBoxMaxValue(sender, max);
        }

        private double distance = 0;

        private void bolus_Click(object sender, EventArgs e)
        {

            syringeCombobox.SelectedIndex = 0;
            set_syringe.PerformClick();
            settings_group.Visible = false;
            bolus_group.Visible = true;
            start_btn.Visible = false;
            
        }

        private void bolus_start_Click(object sender, EventArgs e)
        {
            if (bolusSpeed.Value != 0 && bolusInj.Value != 0)
            {
                track_speed1.Value = QUARTER;
                Thread.Sleep(500);

                int max = (int)bolusInj.Maximum - (int)(ml1 * 1000);
                textBoxMaxValue(bolusInj, max);

                startPos = (int)syringe1.getStartPosition();
                lenght = (int)syringe1.getLenght();
           


                distance = (double)bolusInj.Value / 1000;
                pos = a;
                statusS1 = BOLUS;
                this.Invoke(new Action(() => this.buttons_enabled(false)));
                syringe1.setSpeed((double)bolusSpeed.Value);
                communication.setPeriod(syringe1);
                int stop = (int)(pos + syringe1.get_distance(distance));
                communication.setStopPos(syringe1, stop);
                communication.runBolus(syringe1);
                exit_bolus.Enabled = false;
                bolus_start.Enabled = false;
                sw.Start();
            }
        }

        private void exit_bolus_Click(object sender, EventArgs e)
        {
            settings_group.Visible = true;
            bolus_group.Visible = false;
            start_btn.Visible = true;
            speedCombobox.SelectedIndex = 0;
            set_speed.PerformClick();
        }
        #endregion

    }
}
