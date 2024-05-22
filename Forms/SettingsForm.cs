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
        }

        private void SaveConfig()
        {
            var config = ClockConfig.Instance;
            config.MinuteInterval = (int)MinuteIntervalNumSelect.Value;
            config.ShowClockTime = (int)ShowClockTimeNumSelect.Value;
            config.EnableClock = EnableClockBox.Checked;
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
    }
}
