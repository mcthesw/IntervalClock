namespace IntervalClock.Forms
{
    public partial class SettingsForm : Form
    {
        TimeSettingsControl timeSettingsControl;
        StyleSettingsControl styleSettingsControl;
        public SettingsForm(ClockTimer timer)
        {
            InitializeComponent();
            this.timeSettingsControl = new TimeSettingsControl(timer);
            this.styleSettingsControl = new StyleSettingsControl(timer);
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();
            this.panel1.Controls.Add(timeSettingsControl);
            timeSettingsControl.Show();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();
            this.panel1.Controls.Add(timeSettingsControl);
            timeSettingsControl.Show();
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();
            this.panel1.Controls.Add(styleSettingsControl);
            styleSettingsControl.Show();
        }
    }
}
