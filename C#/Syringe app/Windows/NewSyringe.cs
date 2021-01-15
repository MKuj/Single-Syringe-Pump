using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace Syringe_app
{
    public partial class NewSyringe : Form
    {
        #region FORM PROPERTIES AND METHODS
        VisualProperties.Colors colors = new VisualProperties.Colors();

        /// <summary>
        /// Create New Syringe Form.
        /// </summary>
        /// <param ID="id">
        /// Id of new syringe to create
        /// </param>
        /// <param Decoder="d"></param>
        public NewSyringe(int id, ProgressDecoder d)
        {
            InitializeComponent();
            initColors();

            decoder = d;
            connector = SyringesBaseConnector.getInstance();
            newSyringe = new Syringe() { ID = id };

            this.ok_btn.DialogResult = DialogResult.OK;

            t = new System.Timers.Timer();
            t.Interval = 25;
            t.Elapsed += new ElapsedEventHandler(getData);
            t.AutoReset = true;

            communication = Communication.getCommunicationManager();

            speed_cmb.SelectedIndex = 0;

            decoder.NewPositionArrived += new EventHandler<DecoderArgs>(newPositionEvent);
            decoder.HomingDoneArrived += new EventHandler<DecoderArgs>(homeDoneEvent);
        }

        /// <summary>
        /// Init colors of every control in form.
        /// </summary>
        private void initColors()
        {
            this.ForeColor = colors.fore_color;
            home_btn.ForeColor = colors.fore_color;
            forth_btn.BackColor = colors.fore_color;
            back_btn.BackColor = colors.fore_color;
            forth_btn.ForeColor = Color.White;
            back_btn.ForeColor = Color.White;
            ok_btn.ForeColor = colors.fore_color;
            stop_btn.BackColor = colors.stop_color;
            set_start_btn.ForeColor = colors.fore_color;

            s_name_txt.ForeColor = colors.fore_color;
            s_length_txt.ForeColor = colors.fore_color;

            speed_cmb.ForeColor = colors.fore_color;
        }


        /// <summary>
        /// Override method. Used only to assign an ESCAPE to a Form close invocation.
        /// </summary>
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
                exit_button.PerformClick();
            return base.ProcessCmdKey(ref msg, keyData);
        }

        /// <summary>
        /// Closing form and stops <see cref="Timer"/> t.
        /// </summary>
        private void exit_button_Click(object sender, EventArgs e)
        {
            t.Stop();
            decoder.NewPositionArrived -= newPositionEvent;
            decoder.HomingDoneArrived -= homeDoneEvent;
            this.Close();
        }

        /// <summary>
        /// Closing form if <see cref="DialogResult"/> is not <see cref="None"/>
        /// </summary>
        private void NewSyringe_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.DialogResult == DialogResult.None)
            {
                e.Cancel = true;
            }
        }
        #endregion

        #region VARIABLES
        int curr_pos = -1;
        double start_pos = -1;

        private static int proportional_lenght = int.Parse(ConfigurationManager.AppSettings.Get("Proportional_Lenght"));
        private static double calibration = double.Parse(ConfigurationManager.AppSettings.Get("Calibration"));

        Syringe newSyringe = null;
        #endregion

        #region DATA RECAIVE
        System.Timers.Timer t = null;
        SyringesBaseConnector connector = null;
        Communication communication;
        ProgressDecoder decoder;

        /// <summary>
        /// Get message from Arduino.
        /// </summary>
        private void getData(object sender, ElapsedEventArgs e)
        {
            communication.sendCommand(Commands.READ_POS.ToString("D"));
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }           

        private void newPositionEvent(object sender, DecoderArgs e)
        {
            curr_pos = e.Position;
            pos_lb.Invoke(new Action(() => pos_lb.Text = "Current position: " + curr_pos));
        }

        private void homeDoneEvent(object sender, DecoderArgs e)
        {
            pos_lb.Invoke(new Action(() => pos_lb.Text = "Homming done!"));
            this.Invoke(new Action(() => stop_btn.PerformClick()));
            t.Stop();
        }
        #endregion

        #region CONTROLS:
        #region MOVE
        private void forth_btn_MouseDown(object sender, MouseEventArgs e)
        {
            communication.sendCommand(Commands.FORWARD.ToString("D"));
            t.Start();
        }

        private void forth_btn_MouseUp(object sender, MouseEventArgs e)
        {
            communication.sendCommand(Commands.STOP_MOVE.ToString("D"));
            t.Stop();
        }

        private void back_btn_MouseDown(object sender, MouseEventArgs e)
        {
            communication.sendCommand(Commands.BACKWARD.ToString("D"));
            t.Start();
        }

        private void back_btn_MouseUp(object sender, MouseEventArgs e)
        {
            communication.sendCommand(Commands.STOP_MOVE.ToString("D"));
            t.Stop();
        }

        private void speed_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            communication.sendCommand(Commands.CHANGE_STEP.ToString("D"), speed_cmb.SelectedIndex + 1);
        }
        #endregion

        #region START POSITION / HOMMING
        private void home_btn_Click(object sender, EventArgs e)
        {
            communication.sendCommand(Commands.HOME.ToString("D"));
            buttons_state(false);
            t.Start();
        }

        private void set_start_btn_Click(object sender, EventArgs e)
        {
            if(curr_pos >= 0)
            {
                start_pos = curr_pos;
                newSyringe.start_pos = curr_pos;
            }
        }
        #endregion

        private void stop_btn_Click(object sender, EventArgs e)
        {
            buttons_state(true);
            communication.sendCommand(Commands.STOP_MOVE.ToString("D"));
            t.Stop();
        }

        /// <summary>
        /// Change state of buttons and controls in form.
        /// </summary>
        /// <param State="state"></param>
        private void buttons_state(bool state)
        {
            forth_btn.Enabled = state;
            back_btn.Enabled = state;
            stop_btn.Enabled = !state;
            home_btn.Enabled = state;
            set_start_btn.Enabled = state;
            speed_cmb.Enabled = state;
        }
        #endregion

        #region OK AND VALIDATION
        private void ok_btn_Click(object sender, EventArgs e)
        {
            if (ValidateControlls())
            {

                if (connector.addSyringe(newSyringe))
                {
                    decoder.NewPositionArrived -= newPositionEvent;
                    decoder.HomingDoneArrived -= homeDoneEvent;
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show(this, "Unexpected error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.DialogResult = DialogResult.None;
                }
            }
            else
            {
                MessageBox.Show(this, "Please, fill the fields correctly", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = DialogResult.None;
            }
        }

        /// <summary>
        /// Checking if the form controls have been correctly completed
        /// </summary>
        /// <returns>
        /// <see cref="bool"/>
        /// <para><see cref="true"/> - if controls were filled correctly</para>
        /// <para><see cref="false"/> - if controls were filled incorrectly</para>
        /// </returns>
        private bool ValidateControlls()
        {
            try
            {
                newSyringe.name = s_name_txt.Text;
                double len = Convert.ToDouble(s_length_txt.Text);
                newSyringe.length = len * proportional_lenght / calibration;
                newSyringe.volume = Convert.ToDouble(s_vol_txt.Text);
                if (start_pos <= 0)
                {
                    return false;
                }
                return true;
            }
            catch { return false; }
            
        }

        private void s_length_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            validate_key(sender, e);
        }

        private void validate_key(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            validate_key(sender, e);
        }
        #endregion

    }
}
