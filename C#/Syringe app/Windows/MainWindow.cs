using Syringe_app.Properties;
using System;
using System.Collections.Generic;
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
        #region FORM
        public mainApp()
        {
            InitializeComponent();
            InitializeColorsSyringe();

            decoder = new ProgressDecoder(syringe);
            communication = Communication.createCommunicationManager(serialPort, decoder);

            decoder.NewPositionArrived += new EventHandler<DecoderArgs>(newPosEvent);
            decoder.StartPosArrived += new EventHandler<DecoderArgs>(startPosEvent);
            decoder.SyringeStoppedArrived += new EventHandler<DecoderArgs>(stoppedEvent);
            decoder.HomingDoneArrived += new EventHandler<DecoderArgs>(homingDoneEvent);
            decoder.BolusDoneArrived += new EventHandler<DecoderArgs>(bolusDoneEvent);

            t = new System.Timers.Timer();
            t.Interval = 25;
            t.AutoReset = true;

            t.Elapsed += new ElapsedEventHandler(getData);

            arduino = new ArduinoConnectionManager();
            arduino.ConnectionChanged += new EventHandler<ConnectionArgs>(connectionChanged);

            baseConnector = SyringesBaseConnector.getInstance();
        }

        private void main_Load(object sender, EventArgs e)
        {
            this.Width = (syringe1group.Width + 20);
            panel1.Width = (this.Width - 48);
            minimalize_btn.Location = new Point(panel1.Width, 0);
            exit_button.Location = new Point(minimalize_btn.Location.X + 24, 0);

            updateCombobox(syringeCombobox);
            syringeCombobox.DropDownWidth = 250;
            syringeCombobox.Focus();
            syringeCombobox.Select();

            arduino.connectWithDevice();
            MODE = InjectionMode.WAITING;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if ((keyData == Keys.Tab) || (keyData == (Keys.Shift | Keys.Tab)))
            {
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        #region COLORS:
        VisualProperties.Colors colors = new VisualProperties.Colors();

        private void InitializeColorsSyringe()
        {
            port_txt.ForeColor = colors.fore_color;
            speed_lbl.ForeColor = colors.fore_color;
            syringe_lbl.ForeColor = colors.fore_color;
            bolus_distance_lbl.ForeColor = colors.fore_color;
            bolus_speed_lbl.ForeColor = colors.fore_color;
            set_speed.ForeColor = colors.fore_color;
            bolus.ForeColor = colors.fore_color;
            set_syringe.ForeColor = colors.fore_color;
            home_1.ForeColor = colors.fore_color;
            exit_bolus.ForeColor = colors.fore_color;
            move_speed_lbl.ForeColor = colors.fore_color;

            rbtn_1x.ForeColor = colors.fore_color;
            rbtn_2x.ForeColor = colors.fore_color;
            rbtn_4x.ForeColor = colors.fore_color;

            bolus_start.BackColor = colors.text_color;
            bolus_start.ForeColor = Color.White;

            pos_start_btn.ForeColor = Color.White;

            speed_status.ForeColor = colors.text_color;
            syringe_status.ForeColor = colors.text_color;

            speedUpDown.ForeColor = colors.fore_color;
            syringeCombobox.ForeColor = colors.fore_color;

            start_btn.BackColor = colors.text_color;
            forth_btn.BackColor = colors.fore_color;
            back_btn.BackColor = colors.fore_color;
            stop_btn.BackColor = colors.stop_color;
            pos_start_btn.BackColor = colors.fore_color;

            start_btn.ForeColor = Color.White;
            forth_btn.ForeColor = Color.White;
            back_btn.ForeColor = Color.White;
            stop_btn.ForeColor = Color.White;

            connection_status.BackColor = Color.IndianRed;

            speed_unit.ForeColor = colors.fore_color;

            bolus_speed_lbl.ForeColor = colors.fore_color;
            bolus_distance_lbl.ForeColor = colors.fore_color;

        }
        #endregion

        #region FORM STATE:
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

        #region FORM MOVE
        // Move coordinates
        int move, moveX, moveY;
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

        #endregion

        #region CONTROLS
        private List<Syringe> syringes;
        private SyringesBaseConnector baseConnector = null;

        private void updateCombobox(object sender)
        {
            ComboBox cb = sender as ComboBox;
            cb.Items.Clear();
            syringes = baseConnector.getSyringes();
            foreach (var syr in syringes)
            {
                cb.Items.Add(syr.name);
            }
            cb.Items.Add("Add new syringe...");

        }

        private void buttons_enabled(bool b)
        {
            move_groupbox.Enabled = b;
            start_btn.Enabled = b;
            set_syringe.Enabled = b;
            set_speed.Enabled = b;
            bolus.Enabled = b;
            stop_btn.Invoke(new Action(() => stop_btn.Enabled = !b));

            bolus_start.Enabled = b;
            exit_bolus.Enabled = b;

            rbtn_1x.Enabled = b;
            rbtn_2x.Enabled = b;
            rbtn_4x.Enabled = b;

            set_syringe.Enabled = b;
            syringeCombobox.Enabled = b;
            speedUpDown.Enabled = b;
            set_speed.Enabled = b;

            exit_bolus.Enabled = b;
            bolus_start.Enabled = b;
        }
        #endregion

        #endregion

        #region SYRINGE PROPERTIES:
        private Syringe syringe = new Syringe();
        double speed_val = 0;

        private void set_speed_Click(object sender, EventArgs e)
        {
            SetSpeed(speedUpDown);
        }

        private void SetSpeed(object sender)
        {
            NumericUpDown nud = (NumericUpDown)sender;
            if (nud.Value == 0)
                MessageBox.Show("Select a speed value!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                speed_val = Convert.ToDouble(nud.Value);
                DisplaySpeedValue();

                set_speed.Enabled = false;

                syringe.setSpeed(speed_val);
                communication.sendCommand(Commands.SET_PERIOD.ToString("D"), syringe.getDelay());
            }

            set_speed.Enabled = false;
        }

        private void set_syringe_Click(object sender, EventArgs e)
        {
            SetSyringe(syringeCombobox);
        }

        private void SetSyringe(object sender)
        {
            ComboBox cb = (ComboBox)sender;

            if (syringeCombobox.SelectedItem == null)
                validateSyringe();
            else
            {

                if (syringe != syringes[cb.SelectedIndex])
                {
                    syringe = syringes[cb.SelectedIndex];
                    decoder.setSyringe(syringe);
                    reset(sw);
                }

                DisplaySpeedValue();

                communication.sendCommand(Commands.HARD_STOP.ToString("D"), syringe.getStop());
                set_syringe.Enabled = false;

                t.Start();
                Thread.Sleep(100);
                t.Stop();
            }
        }

        private void reset(Stopwatch sw)
        {
            sw.Stop();
            sw.Reset();
        }

        private void speedUpDown_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                SetSpeed(sender);
        }

        private void syringeCombobox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                SetSyringe(sender);
        }

        private void syringeCombobox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            set_syringe.Enabled = true;
        }

        private void speedCombobox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            set_speed.Enabled = true;
        }

        private void speedUpDown_ValueChanged(object sender, EventArgs e)
        {
            set_speed.Enabled = true;
        }

        private void syringeCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedIndex == cb.Items.Count - 1)
            {
                int id = syringes.Count + 1;
                DialogResult ns = new NewSyringe(id, decoder).ShowDialog();
                if (ns == DialogResult.OK)
                {
                    updateCombobox(cb);
                    cb.SelectedIndex = cb.Items.Count - 2;
                }
                else
                {
                    cb.SelectedIndex = 0;
                }
                rbtn_1x_CheckedChanged(this, new EventArgs());
            }
        }

        private void DisplaySpeedValue()
        {
            speed_status.Text = String.Format("Current speed: {0} ml/h", speed_val);
            syringe_status.Text = String.Format("Current syringe: {0} ml", syringe.volume);
        }

        private bool validateSyringe()
        {
            if (syringe.volume != 0)
                return true;
            else
            {
                MessageBox.Show(this, "Select a syringe!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        #endregion

        #region RECEIVED MESSAGES

        private ProgressDecoder decoder;
        InjectionMode MODE = InjectionMode.WAITING;

        int lastPosition = 0;
        int currentPosition = 0;
        double progressValue = 0;
        double pumpedValue, injectedValue = 0;

        private void bolusDoneEvent(object sender, DecoderArgs e)
        {
            sw.Stop();

            ts = TimeSpan.FromMilliseconds(sw.ElapsedMilliseconds);
            progressPanel.Invoke(new Action(() => progressPanel.setElapsedTime(ts)));

            processDone(e.Mode);
        }

        private void homingDoneEvent(object sender, DecoderArgs e)
        {
            progressPanel.Invoke(new Action(() => progressPanel.setInjectedText("Homming done!")));
            processDone(e.Mode);
        }

        private void processDone(InjectionMode mode)
        {
            MODE = mode;
            this.Invoke(new Action(() => stop_btn.PerformClick()));
            t.Stop();
        }

        private void stoppedEvent(object sender, DecoderArgs e)
        {
            sw.Stop();
            communication.sendCommand(Commands.STOP_MOVE.ToString("D"));


            ts = TimeSpan.FromMilliseconds(sw.ElapsedMilliseconds);
            progressPanel.Invoke(new Action(() => progressPanel.setElapsedTime(ts)));
            progressPanel.Invoke(new Action(() => progressPanel.setSyringeImage(100 / 3.3)));
            progressPanel.Invoke(new Action(() => progressPanel.setProgressValue(100)));

            processDone(e.Mode);

        }

        private void startPosEvent(object sender, DecoderArgs e)
        {
            progressPanel.Invoke(new Action(() => progressPanel.setInjectedText("Syringe on start position!")));
            rbtn_1x.Invoke(new Action(() => rbtn_1x.Checked = true));

            processDone(e.Mode);

            lastPosition = e.Position;
            progressValue = e.Progress;
            pumpedValue = e.Pumped;
            injectedValue = e.Injected;

            progressUpdate();
        }

        private void newPosEvent(object sender, DecoderArgs e)
        {
            currentPosition = e.Position;
            progressValue = e.Progress;
            pumpedValue = e.Pumped;
            injectedValue = e.Injected;

            progressUpdate();
        }

        private void progressUpdate()
        {
            ts = TimeSpan.FromMilliseconds(sw.ElapsedMilliseconds);
            progressPanel.Invoke(new Action(() => progressPanel.setElapsedTime(ts)));
            if (progressValue >= 0)
            {
                progressPanel.Invoke(new Action(() => progressPanel.setPercentageStatusValue(progressValue)));
                progressPanel.Invoke(new Action(() => progressPanel.setSyringeImage(progressValue / 3.3)));
                progressPanel.Invoke(new Action(() => progressPanel.setProgressValue(progressValue)));
            }
            else
                progressPanel.Invoke(new Action(() => progressPanel.setPercentageStatusValue(0)));

            if (syringe.volume <= 1)
            {
                if (MODE == InjectionMode.CONSTANT)
                    progressPanel.Invoke(new Action(() => progressPanel.setInjectedText(string.Format("Injected: {0:0.00} ul", injectedValue * 1000))));
                else
                    progressPanel.Invoke(new Action(() => progressPanel.setPumpedText(string.Format("Pumped: {0:0.00} ul", pumpedValue * 1000))));

            }
            else
            {
                if (MODE == InjectionMode.CONSTANT)
                    progressPanel.Invoke(new Action(() => progressPanel.setInjectedText(string.Format("Injected: {0:0.00} ml", injectedValue))));
                else
                    progressPanel.Invoke(new Action(() => progressPanel.setPumpedText(string.Format("Pumped: {0:0.00} ml", pumpedValue))));
            }
        }
        #endregion

        #region COMMUNICATION AND CONNECTION

        Communication communication;

        ArduinoConnectionManager arduino;
        int connectionStatus;

        System.Timers.Timer t;
        
        private void connectionChanged(object sender, ConnectionArgs e)
        {
            connectionStatus = e.Status;
            serialConnectionStatusDisplay(e.Port);
        }

        private void serialConnectionStatusDisplay(string port)
        {
            this.Invoke(new Action(() =>
            {
                if (connectionStatus == 1)
                {
                    port_txt.Text = String.Concat("Port: ", port);
                    connection_status.Text = "Status: Connected";
                    connection_status.BackColor = Color.LimeGreen;

                    //Buttons state:
                    buttons_enabled(true);

                    rbtn_1x.Checked = true;
                    Thread.Sleep(100);

                    t.Start();
                    Thread.Sleep(100);
                    t.Stop();
                }
                //Disconnect:
                else if (connectionStatus == 2)
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
            }));
        }

        private void getData(object sender, ElapsedEventArgs e)
        {
            communication.sendCommand(Commands.READ_POS.ToString("D"));
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        #endregion

        #region PUMPING PROCESS
        Stopwatch sw = new Stopwatch();
        TimeSpan ts = new TimeSpan();

        #region BOLUS MODE
        private void validateVolumeUpDown(object sender)
        {
            NumericUpDown tb = sender as NumericUpDown;
            int value = (int)(syringe.volume * 1000) - (int)(pumpedValue * 1000);

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
                //tb.Maximum = value;
                tb.Value = value;
                return;
            }

        }

        private void bolusInj_ValueChanged(object sender, EventArgs e)
        {
            validateVolumeUpDown(sender);
        }

        private void bolus_Click(object sender, EventArgs e)
        {
            if (validateSyringe())
            {
                validateVolumeUpDown(bolusInj);
                settings_group.Visible = false;
                bolus_group.Visible = true;
                start_btn.Visible = false;
            }

        }

        private void bolus_start_Click(object sender, EventArgs e)
        {
            if (bolusSpeed.Value != 0 && bolusInj.Value != 0)
            {
                Thread.Sleep(500);

                validateVolumeUpDown(bolusInj);


                MODE = InjectionMode.BOLUS;

                lastPosition = currentPosition;

                syringe.setSpeed((double)bolusSpeed.Value);

                rbtn_1x.Checked = true;
                this.Invoke(new Action(() => this.buttons_enabled(false)));

                t.Start();
                if (ModeManager.Bolus.startInjection(syringe, (double)bolusInj.Value, lastPosition))
                    sw.Start();

            }
        }

        private void exit_bolus_Click(object sender, EventArgs e)
        {
            settings_group.Visible = true;
            bolus_group.Visible = false;
            start_btn.Visible = true;

            speedUpDown.Value = bolusSpeed.Value;
            set_speed.PerformClick();
        }
        #endregion

        #region CONSTANT MODE
        private void start_btn_Click(object sender, EventArgs e)
        {
            if (validateSyringe() && speed_val != 0)
            {
                Thread.Sleep(500);
                if (progressValue < 100)
                {
                    rbtn_1x.Checked = true;
                    this.Invoke(new Action(() => this.buttons_enabled(false)));
                    t.Start();

                    start_btn.BackColor = Color.FromArgb(150, colors.text_color.R, colors.text_color.G, colors.text_color.B);
                   
                    if (ModeManager.ConstantMode.startInjection(syringe))
                    {
                        MODE = InjectionMode.CONSTANT;
                        sw.Start();
                    }
                }
            }
            else
            {
                MessageBox.Show("Select a syringe and speed value!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region MOVE

        private void forth_btn_MouseDown(object sender, MouseEventArgs e)
        {
            if (MODE == InjectionMode.START_POS_DONE || MODE == InjectionMode.HOME_DONE)
            {
                progressPanel.Invoke(new Action(() => progressPanel.setInjectedText("")));
            }
            //if (pumped.Visible != true)
            //    pumped.Visible = true;
            if (progressValue < 100)
            {
                MODE = InjectionMode.MOVING_FORTH;
                t.Start();
                ModeManager.Move.startInjection(MODE);
            }
            else
            {
                MODE = InjectionMode.WAITING;
            }
        }

        private void forth_btn_MouseUp(object sender, MouseEventArgs e)
        {
            stopMove();
        }

        private void back_btn_MouseDown(object sender, MouseEventArgs e)
        {
            if (MODE == InjectionMode.START_POS_DONE || MODE == InjectionMode.HOME_DONE)
            {
                progressPanel.Invoke(new Action(() => progressPanel.setInjectedText("")));
            }
            MODE = InjectionMode.MOVING_BACK;
            t.Start();
            ModeManager.Move.startInjection(MODE);
        }

        private void back_btn_MouseUp(object sender, MouseEventArgs e)
        {
            stopMove();
        }

        private void stopMove()
        {
            communication.sendCommand(Commands.STOP_MOVE.ToString("D"));
            lastPosition = currentPosition;
            Thread.Sleep(250);
            t.Stop();
        }

        #region SPEED
        private void rbtn_1x_CheckedChanged(object sender, EventArgs e)
        {
            communication.sendCommand(Commands.CHANGE_STEP.ToString("D"), 1);
            Thread.Sleep(100);
        }

        private void rbtn_2x_CheckedChanged(object sender, EventArgs e)
        {
            communication.sendCommand(Commands.CHANGE_STEP.ToString("D"), 2);
            Thread.Sleep(100);
        }

        private void rbtn_4x_CheckedChanged(object sender, EventArgs e)
        {
            communication.sendCommand(Commands.CHANGE_STEP.ToString("D"), 3);
            Thread.Sleep(100);
        }
        #endregion

        #endregion

        #region START POSITION / HOMMING
        private void home_1_Click(object sender, EventArgs e)
        {
            buttons_enabled(false);
            rbtn_4x.Checked = true;

            ModeManager.Move.homming();
            MODE = InjectionMode.HOMMING;

            t.Start();

            reset(sw);
            progressPanel.Invoke(new Action(() => progressPanel.setElapsedTime(TimeSpan.FromMilliseconds(sw.ElapsedMilliseconds))));
            progressPanel.Invoke(new Action(() => progressPanel.setProgressValue(0)));
            progressPanel.Invoke(new Action(() => progressPanel.setInjectedText("Homming...")));

        }

        private void pos_start_btn_Click(object sender, EventArgs e)
        {
            if (validateSyringe())
            {
                buttons_enabled(false);
                rbtn_4x.Checked = true;

                ModeManager.Move.startPosition(syringe);
                MODE = InjectionMode.START_POS;
                
                t.Start();

                progressValue = 0;
                progressPanel.Invoke(new Action(() => progressPanel.setInjectedText("Moving to start position...")));
            }
        }
        #endregion

        #region STOP
        private void stop_btn_Click(object sender, EventArgs e)
        {
            stopMove();
            sw.Stop();

            buttons_enabled(true);
            start_btn.BackColor = colors.text_color;

            stop_btn_result();

            set_syringe.Enabled = true;
            syringeCombobox.Enabled = true;
        }

        private void stop_btn_result()
        {
            switch (MODE)
            {
                case InjectionMode.HOMMING:
                    progressPanel.Invoke(new Action(() => progressPanel.setInjectedText("Homming stopped")));
                    MODE = InjectionMode.WAITING;
                    break;

                case InjectionMode.START_POS:
                    progressPanel.Invoke(new Action(() => progressPanel.setInjectedText("Setting start position stopped")));
                    MODE = InjectionMode.WAITING;
                    break;

                case InjectionMode.BOLUS:
                    bolus_start.Enabled = true;
                    exit_bolus.Enabled = true;
                    progressPanel.Invoke(new Action(() => progressPanel.setInjectedText("Bolus stopped")));
                    MODE = InjectionMode.WAITING;
                    break;
                default:
                    MODE = InjectionMode.WAITING;
                    break;
            }
        }
        #endregion

        #endregion
    }
}
