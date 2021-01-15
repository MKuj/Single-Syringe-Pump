using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Management;
using System.Threading;

namespace Syringe_app
{
    /// <summary>
    /// Event arguments of <see cref="ArduinoConnectionManager"/> <see cref=" EventHandler"/> ConnectionChanged
    /// </summary>
    class ConnectionArgs : EventArgs
    {
        public int Status { get; set; }

        public string Port { get; set; }
    }

    class ArduinoConnectionManager
    {
        private Communication communication;

        //Connected port value
        private string p = "";
        private string _port
        {
            get 
            { 
                return p; 
            }
            set
            {
                p = value;
                //Connection change event raise
                onConnectionChanged(value, _status);
            }
        }

        private int _status = 0;

        //Load VID and PID from App.config file
        string vid = ConfigurationManager.AppSettings.Get("Leonardo_VID");
        string pid = ConfigurationManager.AppSettings.Get("Leonardo_PID");

        #region CONSTRUCTOR
        /// <summary>
        /// Auto-detect Arduino device by VID and PID numbers.
        /// </summary>
        public ArduinoConnectionManager()
        {
            communication = Communication.getCommunicationManager();

            _deviceChanged = new ManagementEventWatcher(new WqlEventQuery(
                "SELECT * FROM Win32_DeviceChangeEvent WHERE EventType = 2 or EventType = 3"));

            _deviceChanged.EventArrived += _deviceChanged_Event;
            _deviceChanged.Start();
        }
        #endregion

        #region EVENTS
        private readonly ManagementEventWatcher _deviceChanged;

        /// <summary>
        /// Arduino connection change event.
        /// </summary>
        public EventHandler<ConnectionArgs> ConnectionChanged;

        /// <summary>
        /// Raising an event when connection changed
        /// </summary>
        protected virtual void onConnectionChanged(string portName, int status)
        {
            ConnectionChanged?.Invoke(this, new ConnectionArgs { Port = portName, Status = status });
        }

        /// <summary>
        /// Occurs when device is arrived or removed.
        /// </summary>
        private void _deviceChanged_Event(object sender, EventArrivedEventArgs e)
        {
            connectWithDevice();
            if (_status == 2)
                _port = "";
        }
        #endregion

        #region ARDUINO DETECT AND CONNECT
        /// <summary>
        /// Detecting and adding to list devices with valid vid and pid numbers
        /// </summary>
        /// <returns>
        /// <see cref="List{string}"/> of devices with valid vid and pid numbers
        /// </returns>
        private List<string> autodetectArduinoPort()
        {
            ManagementScope connectionScope = new ManagementScope();
            SelectQuery serialQuery = new SelectQuery("SELECT * FROM Win32_SerialPort");
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(connectionScope, serialQuery);

            try
            {
                List<string> deviceIDs = new List<string>();
                foreach (ManagementObject item in searcher.Get())
                {
                    string desc = item["PNPDeviceID"].ToString();
                    string deviceId = item["DeviceID"].ToString();

                    if (desc.Contains(vid) && desc.Contains(pid))
                    {
                        deviceIDs.Add(deviceId);
                    }
                }
                if (deviceIDs.Count > 0)
                    return deviceIDs;
                else
                    return null;
            }
            catch
            { return null; }
        }

        /// <summary>
        /// Connnection witn Syringe Pump
        /// </summary>
        public void connectWithDevice()
        {
            List<string> ports = autodetectArduinoPort();
            if (ports != null)
            {
                if (!ports.Contains(_port))
                {
                    Thread.Sleep(120);
                    foreach (string port in ports)
                    {
                        try
                        {
                            _status = communication.connect(port);
                            string outcome = communication.checkDevice();
                            if (outcome != null && outcome.Contains("<connected>"))
                            {
                                _port = port; 
                                break;
                            }
                            else
                            {
                                _status = communication.connect(port);
                            }
                        }
                        catch
                        {
                        }
                    }
                    onConnectionChanged(_port, _status);
                }
            }
            else
            {
                _port = "";
                onConnectionChanged(_port, 2); 
            }
            
        }
        #endregion
    }
}
