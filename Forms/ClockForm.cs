namespace IntervalClock.Forms
{
    public partial class ClockForm : Form
    {
        private const string FormatMessage = "HH:mm:ss";
        private int _secondCounter;
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

        /// <summary>
        /// 防止捕获到用户焦点，干扰目前活动
        /// </summary>
        protected override CreateParams CreateParams
        {
            get
            {
                var baseParams = base.CreateParams;

                const int WS_EX_NOACTIVATE = 0x08000000;
                const int WS_EX_TOOLWINDOW = 0x00000080;
                baseParams.ExStyle |= (int)(WS_EX_NOACTIVATE | WS_EX_TOOLWINDOW);

                return baseParams;
            }
        }
    }
}
