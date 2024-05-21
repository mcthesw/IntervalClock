namespace IntervalClock
{
    partial class ClockForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            NumberClock = new Label();
            TickTimer = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // NumberClock
            // 
            NumberClock.BackColor = Color.Black;
            NumberClock.Dock = DockStyle.Fill;
            NumberClock.Font = new Font("JetBrainsMonoNL NF", 30F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 161);
            NumberClock.ForeColor = Color.White;
            NumberClock.Location = new Point(0, 0);
            NumberClock.Name = "NumberClock";
            NumberClock.Size = new Size(300, 100);
            NumberClock.TabIndex = 0;
            NumberClock.Text = "00:00:00";
            NumberClock.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TickTimer
            // 
            TickTimer.Enabled = true;
            TickTimer.Interval = 1000;
            TickTimer.Tick += TickTimer_Tick;
            // 
            // ClockForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CausesValidation = false;
            ClientSize = new Size(300, 100);
            ControlBox = false;
            Controls.Add(NumberClock);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ClockForm";
            Opacity = 0.8D;
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.Manual;
            Text = "ClockForm";
            TopMost = true;
            ResumeLayout(false);
        }

        #endregion

        private Label NumberClock;
        private System.Windows.Forms.Timer TickTimer;
    }
}