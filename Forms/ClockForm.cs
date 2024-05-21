using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IntervalClock
{
    public partial class ClockForm : Form
    {
        private static readonly string FormatMessage = "HH:mm:ss";
        private int _secondCounter = 0;
        public ClockForm()
        {
            InitializeComponent();
            NumberClock.Text = DateTime.Now.ToString(FormatMessage);
        }

        private void TickTimer_Tick(object sender, EventArgs e)
        {
            if (!ClockConfig.Instance.NeverHideClock)
            {
                _secondCounter++;
                if (_secondCounter >= ClockConfig.Instance.ShowClockTime)
                {
                    Close();
                }
            }
            NumberClock.Text = DateTime.Now.ToString(FormatMessage);
        }
    }
}
