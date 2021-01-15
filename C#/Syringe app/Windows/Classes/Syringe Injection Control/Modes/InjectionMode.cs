using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syringe_app
{
    public enum InjectionMode
    {
        CONSTANT = 0,
        HOMMING = 1,
        HOME_DONE = 2,
        START_POS = 3,
        START_POS_DONE = 4,
        WAITING = 5,
        MOVING_FORTH = 6,
        MOVING_BACK = 7,
        BOLUS = 8,
        BOLUS_DONE = 9,
        STOPPED = 10
    }
}
