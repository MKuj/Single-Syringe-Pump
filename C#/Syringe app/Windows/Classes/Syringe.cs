using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Syringe_app
{
    public class Syringe
    {
        #region SYRINGE PROPERTIES
        public double start_pos { get; set; }
        public string name { get; set; }
        public double length { get; set; }
        public double volume { get; set; }
        public int ID { get; set; }
        #endregion

        /// <summary>
        /// Parse data from csv file row to Syringe object.
        /// </summary>
        /// <param Row="row">
        /// Row readed from csv file. 'ID;Syringe name;Syringe volume [ml];Suringe length [step];Syringe start position [step]'
        /// </param>
        /// <returns>
        /// new <see cref="Syringe"/> with values read from row.
        /// </returns>
        internal static Syringe parseRow(string row)
        {
            var column = row.Split(';');
            return new Syringe()
            {
                ID = int.Parse(column[0]),
                name = column[1],
                volume = double.Parse(column[2]),
                length = double.Parse(column[3]),
                start_pos = double.Parse(column[4])
            };
        }

        #region METHODS
        private long delay = 0;

        /// <summary>
        /// Compute stepper motor delay.
        /// </summary>
        /// <param Speed="speed"></param>
        public void setSpeed(double speed)
        {
            double t_c = (volume * 3600) / speed;
            delay = (int)(t_c * 1000000 / length); ;
        }

        public long getDelay()
        {
            return delay;
        }

        public double getStop()
        {
            return start_pos + length;
        }
        #endregion
    }
}
