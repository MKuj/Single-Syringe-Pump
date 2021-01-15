using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Syringe_app
{
    public class Communication
    {
        //Feedback messages.
        private const int CONNECTED = 1;
        private const int NULL = 0;
        private const int DISCONNECTED = 2;

        #region CLASS CONSTRUTORS
        //Instance of Communication class.
        private static Communication instance = null;

        private static ProgressDecoder decoder { get; set; }


        //Serial port object
        private static SerialPort serial = null;

        /// <summary>
        /// Communication constructor.
        /// </summary>
        private Communication()
        {
        }

        /// <summary>
        /// Get Communication instance.
        /// </summary>
        /// <returns>
        /// <see cref="Communication"/> instance.
        /// </returns>
        public static Communication getCommunicationManager()
        {
            if(instance == null)
            {
                MessageBox.Show("Communication doesn't exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return instance;
        }

        /// <summary>
        /// Create and return Communication instance.
        /// </summary>
        /// <param SerialPort="serialPort">
        /// SerialPort object used in main thread.
        /// </param>
        /// <returns>
        /// <see cref="Communication"/> instance.
        /// </returns>
        public static Communication createCommunicationManager(SerialPort serialPort, ProgressDecoder d)
        {
            if (instance == null)
            {
                instance = new Communication();
                serial = serialPort;
                serial.DataReceived += new SerialDataReceivedEventHandler(dataReceived);
                decoder = d;
            }
            return instance;
        }
        #endregion

        #region SERIAL CONNECTION
        /// <summary>
        /// Get all currently used serial ports.
        /// </summary>
        /// <returns>
        /// <see cref="string[]"/> of port names
        /// </returns>
        public string[] ports()
        {
            string[] portnames = SerialPort.GetPortNames();
            return portnames;
        }

        /// <summary>
        /// Connect to given port.
        /// </summary>
        /// <param port="PORT">
        /// COM port string name.
        /// </param>
        /// <returns>
        /// <para>State of connection:</para>
        /// <para><see cref="int"/> 1 - CONNECTED</para>
        /// <para><see cref="int"/> 2 - DISCONNECTED</para>
        /// <para><see cref="int"/> 0 - ERROR</para>
        /// </returns>
        public int connect(string PORT)
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
                    sendCommand(Commands.STOP_MOVE);
                    
                    serial.Close();
                    serial.DtrEnable = false;
                    serial.RtsEnable = false;
                    return DISCONNECTED;
                }
                catch (IOException ex)
                {
                    MessageBox.Show("Error: " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return NULL;
                }     
            }
        }
        #endregion

        #region COMMUNICATION METHODS:
        /// <summary>
        /// Get message from arduino and send it to decoder class.
        /// </summary>
        private static void dataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                SerialPort s = (SerialPort)sender;
                string message = s.ReadLine();
                decoder.decodeMessage(message);
            }
            catch { }
        }

        /// <summary>
        /// Send command to arduino
        /// </summary>
        /// <param StringArguments="args"></param>
        public void sendCommand(params object[] args)
        {
            string message = string.Concat(args);
            try
            {
                serial.WriteLine(message);
            }
            catch
            {
            }
        }

        /// <summary>
        /// Checking if the correct device is connected.
        /// </summary>
        /// <returns>
        /// <see cref="string"/> received message
        /// </returns>
        public string checkDevice()
        {
            try
            {
                serial.WriteLine("88");
                return serial.ReadTo("\n");
            }
            catch
            {
                return null;
            }
        }
        #endregion
    }
}
