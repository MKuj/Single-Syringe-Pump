using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Syringe_app
{
    class Syringe
    {
        /// <summary>
        /// Syringe constants and variables 
        /// </summary>
        #region CONSTANTS AND VARIABLES
        public string RUN = "";
        public string STOP = "";
        public string FORWARD = "";
        public string BACKWARD = "";
        public string HOME = "";
        public string SET_PERIOD = "";
        public string SET_START = "";
        public string STOP_MOVE = "";
        public string STOP_POS = "";
        public string BOLUS = "";
        public string HARD_STOP = "";
        public string CHANGE_STEP = "";

        private int syrML = 0;
        private double _startPosition = 0;
        private double lenght = 0;
        private int syr = 0;
        private double speed = 0;
        private long delay = 0;

        //Calibration
        private static int proportional_lenght = 10000;
        private double calibration = 15.7;
        #endregion

        /// <summary>
        /// Construtor of class
        /// Params are command to move a syringe
        /// </summary>
        /// <param run="rUN"></param>
        /// <param stop="sTOP"></param>
        /// <param forward="fORWARD"></param>
        /// <param backward="bACKWARD"></param>
        /// <param home="hOME"></param>
        /// <param set period="sET_PERIOD"></param>
        /// <param set start position="sET_START"></param>
        /// <param stop move="sTOP_MOVE"></param>
        /// <param set stop position="sTOP_POS"></param>
        /// <param bolus command="bOLUS"></param>
        /// <param set hard stop position (100%) ="hARD_STOP"></param>
        #region CONSTRUCTOR
        public Syringe(string rUN, string sTOP, string fORWARD, string bACKWARD, string hOME, string sET_PERIOD, string sET_START, string sTOP_MOVE, string sTOP_POS, string bOLUS, string hARD_STOP, string cHANGE_STEP)
        {
            RUN = rUN;
            STOP = sTOP;
            FORWARD = fORWARD;
            BACKWARD = bACKWARD;
            HOME = hOME;
            SET_PERIOD = sET_PERIOD;
            SET_START = sET_START;
            STOP_MOVE = sTOP_MOVE;
            STOP_POS = sTOP_POS;
            BOLUS = bOLUS;
            HARD_STOP = hARD_STOP;
            CHANGE_STEP = cHANGE_STEP;
        }

        public Syringe()
        {
        }
        #endregion

        /// <summary>
        /// Syringes value (length and  start position in mm)
        /// </summary>
        /// <param a syringe volume="syringe"></param>
        /// <returns></returns>
        #region USED SYRINGES
        private int syringe(int syringe)
        {
            switch (syringe)
            {
                case 5:
                    return 42;

                case 20:
                    return 63;

                case 1:
                    return 57;
            }
            return 0;
        }

        private double startPosition(int syringe)
        {
            switch (syringe)
            {
                case 5:
                    return 50;

                case 20:
                    return 27.5;

                case 1:
                    return 34.1;
            }
            return 0;
        }
        #endregion

        double start;

        /// <summary>
        /// Get and Set commands
        /// </summary>
        /// <param a syringe volume="syringe"></param>
        #region GET/SET
        public void setSyringe(int syringe)
        {
            //MessageBox.Show(calibration.ToString());
            this.syr = this.syringe(syringe);
            this.syrML = syringe;
            this._startPosition = startPosition(syringe);
            lenght = (this.syr * proportional_lenght) / calibration;
            start = (_startPosition * proportional_lenght) / calibration;
        }

        public int getSyringe()
        {
            return syr;
        }

        public void setSpeed(double speed)
        {
            this.speed = speed;
            double t_c = (syrML * 3600) / speed;
            delay = (int)(t_c * 1000000 / lenght); ;

        }

        public void setCalibration(double val)
        {
            calibration = 15.7 * val;
        }
        #endregion

        /// <summary>
        /// All functions and methods used to set, get and calculate a pumping values (speed, length)
        /// </summary>
        /// <returns></returns>
        #region FUNCTION/METHODS
        public double getLenght()
        {
            return lenght;
        }

        public double getStartPosition()
        {
            return start;
        }

        public long getDelay()
        {
            return delay;
        }

        public double get_distance(double distance)
        {
            return lenght * distance;
        }

        public double getHardStop()
        {
            return start + getLenght();
        }
        #endregion
    }
}
