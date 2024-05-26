using IntervalClock.Controls;

namespace IntervalClock.Forms
{
    public partial class SettingsForm : Form
    {
        private readonly TimeSettingsControl _timeSettingsControl;
        private readonly StyleSettingsControl _styleSettingsControl;
        public SettingsForm(ClockTimer timer)
        {
            InitializeComponent();
            _timeSettingsControl = new TimeSettingsControl(timer);
            _styleSettingsControl = new StyleSettingsControl(timer);
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(_timeSettingsControl);
            _timeSettingsControl.Show();
        }

        private void FunctionToolStripLabel_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(_timeSettingsControl);
            _timeSettingsControl.Show();
        }

        private void StyleToolStripLabel_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(_styleSettingsControl);
            _styleSettingsControl.Show();
        }
    }
}
