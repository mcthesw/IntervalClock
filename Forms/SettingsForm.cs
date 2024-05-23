namespace IntervalClock.Forms
{
    public partial class SettingsForm : Form
    {
        private readonly ClockTimer _timer;
        public SettingsForm(ClockTimer timer)
        {
            InitializeComponent();
            LoadConfig();
            this._timer = timer;
        }

        private void LoadConfig()
        {
            var config = ClockConfig.Instance;
            MinuteIntervalNumSelect.Value = config.MinuteInterval;
            ShowClockTimeNumSelect.Value = config.ShowClockTime;
            EnableClockBox.Checked = config.EnableClock;
            SoundPathTextBox.Text=config.SoundPath;
        }

        private void SaveConfig()
        {
            var config = ClockConfig.Instance;
            config.MinuteInterval = (int)MinuteIntervalNumSelect.Value;
            config.ShowClockTime = (int)ShowClockTimeNumSelect.Value;
            config.EnableClock = EnableClockBox.Checked;
            config.SoundPath = openFileDialog1.FileName;
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
            openFileDialog1.CheckFileExists = true;
            openFileDialog1.CheckPathExists = true;
            //openFileDialog1.Filter = "音频文件(.mp3)|.mp3";
            if (openFileDialog1.ShowDialog(this) == DialogResult.OK)
            {
                SoundPathTextBox.Text= openFileDialog1.FileName;
                SaveConfig();
            }
        }
    }
}
