using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Syringe_app
{
    public class DecoderArgs : EventArgs
    {
        public InjectionMode Mode { get; set; }

        public int Position { get; set; }

        public double Progress { get; set; }

        public double Pumped { get; set; }

        public double Injected { get; set; }

    }

    public class ProgressDecoder
    {
        public EventHandler<DecoderArgs> NewPositionArrived;
        public EventHandler<DecoderArgs> HomingDoneArrived;
        public EventHandler<DecoderArgs> StartPosArrived;
        public EventHandler<DecoderArgs> BolusDoneArrived;
        public EventHandler<DecoderArgs> SyringeStoppedArrived;

        protected virtual void onNewPositionArrived()
        {
            NewPositionArrived?.Invoke(this, new DecoderArgs { Mode = mode, Position = step, Progress = progress, Pumped = pumped, Injected = injected });
        }
        protected virtual void onHomingDoneArrived()
        {
            HomingDoneArrived?.Invoke(this, new DecoderArgs { Mode = mode, Position = step, Progress = progress, Pumped = pumped, Injected = injected });
        }
        protected virtual void onStartPosArrived()
        {
            StartPosArrived?.Invoke(this, new DecoderArgs { Mode = mode, Position = step, Progress = progress, Pumped = pumped, Injected = injected });
        }
        protected virtual void onBolusDoneArrived()
        {
            BolusDoneArrived?.Invoke(this, new DecoderArgs { Mode = mode, Position = step, Progress = progress, Pumped = pumped, Injected = injected });
        }
        protected virtual void onSyringeStoppedArrived()
        {
            SyringeStoppedArrived?.Invoke(this, new DecoderArgs { Mode = mode, Position = acctualPosition, Progress = progress, Pumped = pumped, Injected = injected });
        }

        public InjectionMode mode { get; private set; } = InjectionMode.WAITING;

        int step = 0;
        int acctualPosition = 0;
        double progress = 0;
        double pumped = 0;
        double injected = 0;
        Syringe syringe;

        public ProgressDecoder(Syringe syringe)
        {
            this.syringe = syringe;
        }

        public void setSyringe(Syringe syringe)
        {
            this.syringe = syringe;
        }

        public int decodeMessage(string message)
        {
            try
            {
                if (message.Contains("1:"))
                {
                    int l = message.Length;
                    step = Int32.Parse(message.Substring(2, l - 2));
                    mode = InjectionMode.CONSTANT;
                    if (syringe.length != 0)
                    {
                        progress = (step - syringe.start_pos) * 100 / (double)syringe.length;
                        pumped = (syringe.volume * (step - syringe.start_pos)) / (double)syringe.length;
                        injected = (syringe.volume * (step - acctualPosition)) / (double)syringe.length;
                    }
                    onNewPositionArrived();
                }
                else if (message.Contains("12:"))
                {
                    mode = InjectionMode.HOME_DONE;
                    step = 0;
                    onHomingDoneArrived();
                    mode = InjectionMode.WAITING;
                }
                else if (message.Contains("14:"))
                {
                    int l = message.Length;
                    mode = InjectionMode.START_POS_DONE;
                    acctualPosition = step;
                    onStartPosArrived();
                    mode = InjectionMode.WAITING;
                }
                else if (message.Contains("16:"))
                {
                    mode = InjectionMode.BOLUS_DONE;
                    onBolusDoneArrived();
                    mode = InjectionMode.WAITING;
                }
                else if (message.Contains("18:"))
                {
                    mode = InjectionMode.WAITING;
                    onSyringeStoppedArrived();
                }
                else
                {
                    mode = InjectionMode.WAITING;
                    onSyringeStoppedArrived();
                }
                return 1;
            }
            catch
            {
                mode = InjectionMode.WAITING;
                onSyringeStoppedArrived();
                return 0;
            }
        }  
    }
}
