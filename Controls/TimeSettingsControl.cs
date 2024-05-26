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
    public partial class TimeSettingsControl : UserControl
    {
        private readonly ClockTimer _timer;
        public TimeSettingsControl(ClockTimer timer)
        {
            InitializeComponent();
            LoadConfig();
            _timer = timer;
        }

        private void LoadConfig()
        {
            var config = ClockConfig.Instance;
            MinuteIntervalNumSelect.Value = config.MinuteInterval;
            ShowClockTimeNumSelect.Value = config.ShowClockTime;
            EnableClockBox.Checked = config.EnableClock;
            SoundPathTextBox.Text = config.SoundPath;
        }

        private void SaveConfig()
        {
            var config = ClockConfig.Instance;
            config.MinuteInterval = (int)MinuteIntervalNumSelect.Value;
            config.ShowClockTime = (int)ShowClockTimeNumSelect.Value;
            config.EnableClock = EnableClockBox.Checked;
            config.SoundPath = SelectSoundOpenFileDialog.FileName;
            config.Save();
            _timer.UpdateInterval();
        }

        private void ShowClockButton_Click(object sender, EventArgs e)
        {
            new ClockForm().Show();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            SaveConfig();
            MessageBox.Show("修改成功");
        }

        private void AbortChangeButton_Click(object sender, EventArgs e)
        {
            LoadConfig();
            MessageBox.Show("重置成功");
        }

        private void SelectButton_Click(object sender, EventArgs e)
        {
            SelectSoundOpenFileDialog.CheckFileExists = true;
            SelectSoundOpenFileDialog.CheckPathExists = true;
            SelectSoundOpenFileDialog.FileName = "时钟提示音";
            SelectSoundOpenFileDialog.Filter = "MP3文件（*.mp3）|*.mp3|OGG文件（*.ogg）|*.ogg";
            if (SelectSoundOpenFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                SoundPathTextBox.Text = SelectSoundOpenFileDialog.FileName;
                SaveConfig();
            }
        }
    }
}
