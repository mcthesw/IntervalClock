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
                baseParams.ExStyle |= (int)(WS_EX_NOACTIVATE | WS_EX_TOOLWINDOW);

                return baseParams;
            }
        }

        /// <summary>
        /// 加载时钟样式
        /// </summary>
        private void LoadStyle()
        {
            //时钟位置
            Rectangle workingArea = Screen.PrimaryScreen.WorkingArea;
            switch (ClockStyle.Instance.Location)
            {
                case "TopLeft":
                    this.Location = new Point(0, 0);
                    break;
                case "TopRight":
                    this.Location = new Point((workingArea.Width - this.Width), 0);
                    break;
                case "TopCenter":
                    this.Location = new Point((workingArea.Width / 2) - (this.Width / 2),0);
                    break;
                case "Center":
                    this.Location = new Point((workingArea.Width/2)-(this.Width/2), (workingArea.Height/2)-(this.Height/2));
                    break;
                default:
                    this.Location = new Point(0, 0);
                    break;
            }
            //背景颜色
            NumberClock.BackColor = Color.FromArgb(ClockStyle.Instance.BackColor);
            //字体颜色
            NumberClock.ForeColor = Color.FromArgb(ClockStyle.Instance.FontColor);
        }
    }
}
