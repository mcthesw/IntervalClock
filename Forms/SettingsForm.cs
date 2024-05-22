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

        private float x;
        private float y;
        private void SettingsForm_Load(object sender, EventArgs e)
        {
            x = this.Width;
            y = this.Height;

            foreach (Control con in this.Controls) con.Tag = con.Width + ":" + con.Height + ":" + con.Left + ":" + con.Top + ":" + con.Font.Size;
        }

        private void SettingsForm_Resize(object sender, EventArgs e)
        {
            if (this.Width <= 334) this.Width = 334;
            if (this.Height <= 421) this.Height = 421;
            float newX = this.Width / x;
            float newY = this.Height / y;
            setControlsSize(newX, newY, this);
        }

        private void setControlsSize(float newX, float newY, Control cons)
        {
            foreach (Control con in cons.Controls)
            {
                string[] tag = con.Tag.ToString().Split(":");
                float a = Convert.ToSingle(tag[0]) * newX;
                con.Width = (int)a;
                a = Convert.ToSingle(tag[2]) * newX;
                con.Left = (int)(a);
                a = Convert.ToSingle(tag[3]) * newY;
                con.Top = (int)(a);
            }
        }
    }
}
