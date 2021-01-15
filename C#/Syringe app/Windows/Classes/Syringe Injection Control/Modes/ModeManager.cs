using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Syringe_app
{
    public class ModeManager
    {
        static Communication communication = Communication.getCommunicationManager();
        const bool SUCCESS = true;
        const bool ERROR = false;

        public static class Bolus
        {
            public static bool startInjection(Syringe syringe, double injectionVolume, int currentPosition)
            {
                long stop = calculateProperties(syringe, injectionVolume, currentPosition);
                try
                {
                    communication.sendCommand(Commands.SET_PERIOD.ToString("D"), syringe.getDelay());
                    communication.sendCommand(Commands.STOP_POS.ToString("D"), stop);
                    communication.sendCommand(Commands.BOLUS.ToString("D"));
                    return SUCCESS;
                }
                catch
                {
                    return ERROR;
                }
            }

            private static long calculateProperties(Syringe syringe, double injectionVolume, int currentPosition)
            {
                double param = injectionVolume / (syringe.volume * 1000);
                long stop = (long)(currentPosition + getDistance(syringe, param));
                return stop;
            }

            private static double getDistance(Syringe syringe, double param)
            {
                return syringe.length * param;
            }

            public static int stopInjection()
            {
                throw new NotImplementedException();
            }
        }

        public static class Move
        {
            public static bool startInjection(InjectionMode mode)
            {
                string message = "";
                if (mode == InjectionMode.MOVING_FORTH)
                {
                    message = Commands.FORWARD.ToString("D");
                }
                else if (mode == InjectionMode.MOVING_BACK)
                {
                    message = Commands.BACKWARD.ToString("D");
                }

                try
                {
                    communication.sendCommand(message);
                    return SUCCESS;
                }
                catch
                {
                    return ERROR;
                }
            }

            public static bool startPosition(Syringe syringe)
            {
                try
                {
                    long startPos = Convert.ToInt32(syringe.start_pos);
                    communication.sendCommand(Commands.SET_START.ToString("D"), startPos);
                    return true;
                }
                catch
                {
                    return false;
                }
            }

            public static bool homming()
            {
                try
                {
                    communication.sendCommand(Commands.HOME.ToString("D"));
                    return true;
                }
                catch { return false; }

            }
        }

        public static class ConstantMode
        {
            public static bool startInjection(Syringe syringe)
            {
                try
                {
                    communication.sendCommand(Commands.SET_PERIOD.ToString("D"), syringe.getDelay());
                    communication.sendCommand(Commands.RUN.ToString("D"));
                    return SUCCESS;
                }
                catch
                {
                    return ERROR;
                }
            }

        }
    }
}
