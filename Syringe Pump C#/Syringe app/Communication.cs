using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Syringe_app
{
    class Communication
    {
        /// <summary>
        /// Feedback messages
        /// </summary>
        private const int CONNECTED = 1;
        private const int NULL = 0;
        private const int DISCONNECTED = 2;
        
        /// <summary>
        /// Read syringes position
        /// </summary>
        #region BOTH SYRINGES MESSAGES:
        private const string READ_POS = "35";
        #endregion

        /// <summary>
        /// Initialize serial port, and open/close a port
        /// There are a constructors of this class
        /// </summary>
        #region SERIAL CONNECTION
        public SerialPort serial;

        public Communication(SerialPort serial)
        {
            this.serial = serial;
        }

        public string readPosition()
        {
            try
            {
                serial.WriteLine(READ_POS);
                return serial.ReadExisting();
            }
            catch (Exception ex)
            {
                return "stop";
            }
            
        }

        public void setSerialPort(SerialPort serial)
        {
            this.serial = serial;
        }

        public Communication()
        {
            this.serial = new SerialPort();
        }


        //Connection methods:
        public string[] ports()
        {
            string[] portnames = SerialPort.GetPortNames();
            return portnames;
        }

        public int connect(string PORT, Syringe[] syringes)
        {

            if (!serial.IsOpen)
            {
                serial.PortName = PORT;
                try
                {
                    serial.Open();
                    serial.DtrEnable = true;
                    serial.RtsEnable = true;
                    return CONNECTED;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return NULL;
                }
            }
            else
            {
                try
                {
                    foreach (Syringe syr in syringes){
                        stop(syr);
                        stopMoving(syr);
                    }
                    
                    serial.Close();
                    serial.DtrEnable = false;
                    serial.RtsEnable = false;
                    return DISCONNECTED;
                }
                catch (IOException ex)
                {
                    MessageBox.Show("Error: " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return NULL;
            }
        }
        #endregion

        /// <summary>
        /// Communication with arduino
        /// Write a command to move, stop
        /// </summary>
        /// <param Syringe currently used="syringe"></param>
        #region MOVE METHODS:
        public void run(Syringe syringe)
        {
            try
            {
                serial.WriteLine(syringe.RUN);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void stop(Syringe syringe)
        {
            try
            {
                serial.WriteLine(syringe.STOP);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void forward(Syringe syringe)
        {
            try
            {
                serial.WriteLine(syringe.FORWARD);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void backward(Syringe syringe)
        {
            try
            {
                serial.WriteLine(syringe.BACKWARD);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void stopMoving(Syringe syringe)
        {
            try
            {
                serial.WriteLine(syringe.STOP_MOVE);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void home(Syringe syringe)
        {
            try
            {
                serial.WriteLine(syringe.HOME);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void setPeriod(Syringe syringe)
        {
            try
            {
                serial.WriteLine(string.Format(syringe.SET_PERIOD, syringe.getDelay()));
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void setStartPosition(Syringe syringe, int cal)
        {
            try
            {
                serial.WriteLine(String.Format(syringe.SET_START, syringe.getStartPosition()));
            }catch(Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void setStopPos(Syringe syringe, int stop_pos)
        {
            try
            {
                serial.WriteLine(String.Concat(syringe.STOP_POS, stop_pos.ToString()));
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void runBolus(Syringe syringe)
        {
            try 
            {
                serial.WriteLine("13");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void setHardStop(Syringe syringe)
        {
            try
            {
                serial.WriteLine(String.Concat(syringe.HARD_STOP, (int)syringe.getHardStop()));
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void changeStep(Syringe syringe, int val, int change)
        {
            try
            {
                serial.WriteLine(String.Concat(syringe.CHANGE_STEP, val, change));
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
    }
}
