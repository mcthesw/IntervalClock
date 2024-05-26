namespace IntervalClock.Controls
{
    partial class TimeSettingsControl
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            SelectButton = new Button();
            SoundPathTextBox = new TextBox();
            label1 = new Label();
            EnableClockLabel = new Label();
            EnableClockBox = new CheckBox();
            AbortChangeButton = new Button();
            SaveButton = new Button();
            MinuteIntervalLabel = new Label();
            MinuteIntervalNumSelect = new NumericUpDown();
            ShowClockTimeLabel = new Label();
            ShowClockTimeNumSelect = new NumericUpDown();
            ShowClockButton = new Button();
            ShowClockLabel = new Label();
            SelectSoundOpenFileDialog = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)MinuteIntervalNumSelect).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ShowClockTimeNumSelect).BeginInit();
            SuspendLayout();
            // 
            // SelectButton
            // 
            SelectButton.Location = new Point(305, 138);
            SelectButton.Name = "SelectButton";
            SelectButton.Size = new Size(55, 29);
            SelectButton.TabIndex = 25;
            SelectButton.Text = "选择";
            SelectButton.UseVisualStyleBackColor = true;
            SelectButton.Click += SelectButton_Click;
            // 
            // SoundPathTextBox
            // 
            SoundPathTextBox.Location = new Point(149, 139);
            SoundPathTextBox.Name = "SoundPathTextBox";
            SoundPathTextBox.Size = new Size(150, 27);
            SoundPathTextBox.TabIndex = 24;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 142);
            label1.Name = "label1";
            label1.Size = new Size(99, 20);
            label1.TabIndex = 23;
            label1.Text = "提示音频路径";
            // 
            // EnableClockLabel
            // 
            EnableClockLabel.AutoSize = true;
            EnableClockLabel.Location = new Point(3, 107);
            EnableClockLabel.Name = "EnableClockLabel";
            EnableClockLabel.Size = new Size(69, 20);
            EnableClockLabel.TabIndex = 22;
            EnableClockLabel.Text = "是否启用";
            // 
            // EnableClockBox
            // 
            EnableClockBox.AutoSize = true;
            EnableClockBox.Location = new Point(149, 106);
            EnableClockBox.Name = "EnableClockBox";
            EnableClockBox.Size = new Size(106, 24);
            EnableClockBox.TabIndex = 21;
            EnableClockBox.Text = "勾选以启用";
            EnableClockBox.UseVisualStyleBackColor = true;
            // 
            // AbortChangeButton
            // 
            AbortChangeButton.Location = new Point(103, 400);
            AbortChangeButton.Name = "AbortChangeButton";
            AbortChangeButton.Size = new Size(94, 29);
            AbortChangeButton.TabIndex = 20;
            AbortChangeButton.Text = "取消修改";
            AbortChangeButton.UseVisualStyleBackColor = true;
            AbortChangeButton.Click += AbortChangeButton_Click;
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(3, 400);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(94, 29);
            SaveButton.TabIndex = 19;
            SaveButton.Text = "保存";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // MinuteIntervalLabel
            // 
            MinuteIntervalLabel.AutoSize = true;
            MinuteIntervalLabel.Location = new Point(3, 75);
            MinuteIntervalLabel.Name = "MinuteIntervalLabel";
            MinuteIntervalLabel.Size = new Size(129, 20);
            MinuteIntervalLabel.TabIndex = 18;
            MinuteIntervalLabel.Text = "弹出间隔（分钟）";
            // 
            // MinuteIntervalNumSelect
            // 
            MinuteIntervalNumSelect.Location = new Point(149, 73);
            MinuteIntervalNumSelect.Maximum = new decimal(new int[] { 60, 0, 0, 0 });
            MinuteIntervalNumSelect.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            MinuteIntervalNumSelect.Name = "MinuteIntervalNumSelect";
            MinuteIntervalNumSelect.Size = new Size(150, 27);
            MinuteIntervalNumSelect.TabIndex = 17;
            MinuteIntervalNumSelect.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // ShowClockTimeLabel
            // 
            ShowClockTimeLabel.AutoSize = true;
            ShowClockTimeLabel.Location = new Point(3, 42);
            ShowClockTimeLabel.Name = "ShowClockTimeLabel";
            ShowClockTimeLabel.Size = new Size(114, 20);
            ShowClockTimeLabel.TabIndex = 16;
            ShowClockTimeLabel.Text = "弹出时间（秒）";
            // 
            // ShowClockTimeNumSelect
            // 
            ShowClockTimeNumSelect.Location = new Point(149, 40);
            ShowClockTimeNumSelect.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            ShowClockTimeNumSelect.Name = "ShowClockTimeNumSelect";
            ShowClockTimeNumSelect.Size = new Size(150, 27);
            ShowClockTimeNumSelect.TabIndex = 15;
            ShowClockTimeNumSelect.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // ShowClockButton
            // 
            ShowClockButton.Location = new Point(149, 5);
            ShowClockButton.Name = "ShowClockButton";
            ShowClockButton.Size = new Size(94, 29);
            ShowClockButton.TabIndex = 14;
            ShowClockButton.Text = "显示";
            ShowClockButton.UseVisualStyleBackColor = true;
            ShowClockButton.Click += ShowClockButton_Click;
            // 
            // ShowClockLabel
            // 
            ShowClockLabel.AutoSize = true;
            ShowClockLabel.Location = new Point(3, 9);
            ShowClockLabel.Name = "ShowClockLabel";
            ShowClockLabel.Size = new Size(69, 20);
            ShowClockLabel.TabIndex = 13;
            ShowClockLabel.Text = "显示时钟";
            // 
            // SelectSoundOpenFileDialog
            // 
            SelectSoundOpenFileDialog.FileName = "SelectSoundOpenFileDialog";
            // 
            // TimeSettingsControl
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(SelectButton);
            Controls.Add(SoundPathTextBox);
            Controls.Add(label1);
            Controls.Add(EnableClockLabel);
            Controls.Add(EnableClockBox);
            Controls.Add(AbortChangeButton);
            Controls.Add(SaveButton);
            Controls.Add(MinuteIntervalLabel);
            Controls.Add(MinuteIntervalNumSelect);
            Controls.Add(ShowClockTimeLabel);
            Controls.Add(ShowClockTimeNumSelect);
            Controls.Add(ShowClockButton);
            Controls.Add(ShowClockLabel);
            Name = "TimeSettingsControl";
            Size = new Size(365, 432);
            ((System.ComponentModel.ISupportInitialize)MinuteIntervalNumSelect).EndInit();
            ((System.ComponentModel.ISupportInitialize)ShowClockTimeNumSelect).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button SelectButton;
        private TextBox SoundPathTextBox;
        private Label label1;
        private Label EnableClockLabel;
        private CheckBox EnableClockBox;
        private Button AbortChangeButton;
        private Button SaveButton;
        private Label MinuteIntervalLabel;
        private NumericUpDown MinuteIntervalNumSelect;
        private Label ShowClockTimeLabel;
        private NumericUpDown ShowClockTimeNumSelect;
        private Button ShowClockButton;
        private Label ShowClockLabel;
        private OpenFileDialog SelectSoundOpenFileDialog;
    }
}
