using System.Diagnostics;

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
            LoadStyle();
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
                baseParams.ExStyle |= WS_EX_NOACTIVATE | WS_EX_TOOLWINDOW;

                return baseParams;
            }
        }

        /// <summary>
        /// 加载时钟样式
        /// </summary>
        private void LoadStyle()
        {
            //时钟位置
            if (Screen.PrimaryScreen is null)
            {
                MessageBox.Show("无法获取屏幕信息");
                return;
            }
            var workingArea = Screen.PrimaryScreen.WorkingArea;
            Location = ClockStyle.Instance.Location switch
            {
                "TopLeft" => new Point(0, 0),
                "TopRight" => new Point((workingArea.Width - Width), 0),
                "TopCenter" => new Point((workingArea.Width / 2) - (Width / 2), 0),
                "Center" => new Point((workingArea.Width / 2) - (Width / 2), (workingArea.Height / 2) - (Height / 2)),
                _ => new Point(0, 0),
            };
            //背景颜色
            NumberClock.BackColor = Color.FromArgb(ClockStyle.Instance.BackColor);
            //字体颜色
            NumberClock.ForeColor = Color.FromArgb(ClockStyle.Instance.FontColor);
        }
    }
}
