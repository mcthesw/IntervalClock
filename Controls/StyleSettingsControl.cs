using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IntervalClock.Forms;

namespace IntervalClock.Controls
{
    public partial class StyleSettingsControl : UserControl
    {
        private readonly ClockTimer _timer;
        public StyleSettingsControl(ClockTimer timer)
        {
            InitializeComponent();
            LoadStyle();
            this._timer = timer;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            SaveStyle();
            MessageBox.Show("修改成功");
        }

        private void AbortChangeButton_Click(object sender, EventArgs e)
        {
            LoadStyle();
            MessageBox.Show("重置成功");
        }

        private void SaveStyle()
        {
            var style = ClockStyle.Instance;
            style.Location = LocationComboBox.Text;
            style.BackColor = Convert.ToInt32(BackColorTextBox.Text);
            style.FontColor = Convert.ToInt32(FontColorTextBox.Text);
            style.Save();
            _timer.UpdateInterval();
        }

        private void LoadStyle()
        {
            var style = ClockStyle.Instance;
            LocationComboBox.Text = style.Location;
            BackColorTextBox.Text = style.BackColor.ToString();
            FontColorTextBox.Text = style.FontColor.ToString();
        }

        private void ShowClockButton_Click(object sender, EventArgs e)
        {
            new ClockForm().Show();
        }

        private void SelectBackColorButton_Click(object sender, EventArgs e)
        {
            colorDialog1 = new ColorDialog();
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                BackColorTextBox.Text = colorDialog1.Color.ToArgb().ToString();
            }
        }

        private void SelectFontColorButton_Click(object sender, EventArgs e)
        {
            colorDialog1 = new ColorDialog();
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                FontColorTextBox.Text = colorDialog1.Color.ToArgb().ToString();
            }
        }
    }
}
