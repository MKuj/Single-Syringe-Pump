using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Syringe_app.Properties;
using System.Resources;

namespace Syringe_app
{
    public partial class ProgressPanel : UserControl
    {
        private VisualProperties.Colors colors = new VisualProperties.Colors();
        private ResourceManager rm = Resources.ResourceManager;

        private int progress_bar_complete = 0;

        public ProgressPanel()
        {
            InitializeComponent();
            initProperties();
        }

        private void initProperties()
        {
            run_status.Text = "";
            time_elapsed_txt.Text = "";

            time_elapsed_txt.ForeColor = colors.fore_color;
            pumped.ForeColor = colors.fore_color;

            syringe_pict.Image = Resources.Strzykawka_0000;

            progress_bar.BackColor = colors.fore_color;
            progress_bar_complete = progress_bar.Width;
            progress_bar.Width = 0;

            run_status.ForeColor = colors.fore_color;
        }

        public void setProgressValue(double value)
        {
            progress_bar.Width = progress_bar_complete * (int)value / 100;
        }

        public void setSyringeImage(double value)
        {
            if ((int)value <= 20 && (int)value >= 0)
                syringe_pict.Image = (Bitmap)rm.GetObject(string.Format("Strzykawka_00{0}", (30 - (int)value)));
            else if ((int)value > 20)
                syringe_pict.Image = (Bitmap)rm.GetObject(string.Format("Strzykawka_000{0}", (30 - (int)value)));
            else if ((int)value < 0)
                syringe_pict.Image = (Bitmap)rm.GetObject(string.Format("Strzykawka_00{0}", 30));
        }

        public void setInjectedText(string text)
        {
            injected.Text = text;
        }

        public void setPumpedText(string text)
        {
            pumped.Text = text;
    }

        public void setPercentageStatusValue(double prc)
        {
            run_status.Text = String.Format("{0:0.00}%", prc);
        }

        public void setElapsedTime(TimeSpan ts)
        {
            time_elapsed_txt.Text = string.Format("Elapsed time: {0:D2}h:{1:D2}m:{2:D2}s:{3:D3}ms",
                                            ts.Hours,
                                            ts.Minutes,
                                            ts.Seconds,
                                            ts.Milliseconds
                                            );
        }
    }
}
