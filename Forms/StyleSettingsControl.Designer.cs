namespace IntervalClock.Forms
{
    partial class StyleSettingsControl
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
            ClockLocationLabel = new Label();
            LocationComboBox = new ComboBox();
            AbortChangeButton = new Button();
            SaveButton = new Button();
            ShowClockButton = new Button();
            ShowClockLabel = new Label();
            BackColorLabel = new Label();
            colorDialog1 = new ColorDialog();
            BackColorTextBox = new TextBox();
            SelectBackColorButton = new Button();
            FontColorLabel = new Label();
            SelectFontColorButton = new Button();
            FontColorTextBox = new TextBox();
            SuspendLayout();
            // 
            // ClockLocationLabel
            // 
            ClockLocationLabel.AutoSize = true;
            ClockLocationLabel.Location = new Point(7, 43);
            ClockLocationLabel.Name = "ClockLocationLabel";
            ClockLocationLabel.Size = new Size(69, 20);
            ClockLocationLabel.TabIndex = 14;
            ClockLocationLabel.Text = "时钟位置";
            // 
            // LocationComboBox
            // 
            LocationComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            LocationComboBox.FormattingEnabled = true;
            LocationComboBox.Items.AddRange(new object[] { "TopLeft", "TopCenter", "TopRight", "Center" });
            LocationComboBox.Location = new Point(149, 40);
            LocationComboBox.Name = "LocationComboBox";
            LocationComboBox.Size = new Size(213, 28);
            LocationComboBox.TabIndex = 15;
            // 
            // AbortChangeButton
            // 
            AbortChangeButton.Location = new Point(103, 400);
            AbortChangeButton.Name = "AbortChangeButton";
            AbortChangeButton.Size = new Size(94, 29);
            AbortChangeButton.TabIndex = 22;
            AbortChangeButton.Text = "取消修改";
            AbortChangeButton.UseVisualStyleBackColor = true;
            AbortChangeButton.Click += AbortChangeButton_Click;
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(3, 400);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(94, 29);
            SaveButton.TabIndex = 21;
            SaveButton.Text = "保存";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // ShowClockButton
            // 
            ShowClockButton.Location = new Point(149, 5);
            ShowClockButton.Name = "ShowClockButton";
            ShowClockButton.Size = new Size(94, 29);
            ShowClockButton.TabIndex = 24;
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
            ShowClockLabel.TabIndex = 23;
            ShowClockLabel.Text = "显示时钟";
            // 
            // BackColorLabel
            // 
            BackColorLabel.AutoSize = true;
            BackColorLabel.Location = new Point(7, 83);
            BackColorLabel.Name = "BackColorLabel";
            BackColorLabel.Size = new Size(140, 20);
            BackColorLabel.TabIndex = 25;
            BackColorLabel.Text = "背景颜色（ARGB）";
            // 
            // BackColorTextBox
            // 
            BackColorTextBox.Enabled = false;
            BackColorTextBox.Location = new Point(149, 80);
            BackColorTextBox.Name = "BackColorTextBox";
            BackColorTextBox.Size = new Size(113, 27);
            BackColorTextBox.TabIndex = 26;
            // 
            // SelectBackColorButton
            // 
            SelectBackColorButton.Location = new Point(268, 79);
            SelectBackColorButton.Name = "SelectBackColorButton";
            SelectBackColorButton.Size = new Size(94, 29);
            SelectBackColorButton.TabIndex = 27;
            SelectBackColorButton.Text = "选择";
            SelectBackColorButton.UseVisualStyleBackColor = true;
            SelectBackColorButton.Click += SelectBackColorButton_Click;
            // 
            // FontColorLabel
            // 
            FontColorLabel.AutoSize = true;
            FontColorLabel.Location = new Point(7, 123);
            FontColorLabel.Name = "FontColorLabel";
            FontColorLabel.Size = new Size(140, 20);
            FontColorLabel.TabIndex = 28;
            FontColorLabel.Text = "字体颜色（ARGB）";
            // 
            // SelectFontColorButton
            // 
            SelectFontColorButton.Location = new Point(268, 119);
            SelectFontColorButton.Name = "SelectFontColorButton";
            SelectFontColorButton.Size = new Size(94, 29);
            SelectFontColorButton.TabIndex = 30;
            SelectFontColorButton.Text = "选择";
            SelectFontColorButton.UseVisualStyleBackColor = true;
            SelectFontColorButton.Click += SelectFontColorButton_Click;
            // 
            // FontColorTextBox
            // 
            FontColorTextBox.Enabled = false;
            FontColorTextBox.Location = new Point(149, 120);
            FontColorTextBox.Name = "FontColorTextBox";
            FontColorTextBox.Size = new Size(113, 27);
            FontColorTextBox.TabIndex = 29;
            // 
            // StyleSettingsControl
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(SelectFontColorButton);
            Controls.Add(FontColorTextBox);
            Controls.Add(FontColorLabel);
            Controls.Add(SelectBackColorButton);
            Controls.Add(BackColorTextBox);
            Controls.Add(BackColorLabel);
            Controls.Add(ShowClockButton);
            Controls.Add(ShowClockLabel);
            Controls.Add(AbortChangeButton);
            Controls.Add(SaveButton);
            Controls.Add(LocationComboBox);
            Controls.Add(ClockLocationLabel);
            Name = "StyleSettingsControl";
            Size = new Size(365, 432);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ClockLocationLabel;
        private ComboBox LocationComboBox;
        private Button AbortChangeButton;
        private Button SaveButton;
        private Button ShowClockButton;
        private Label ShowClockLabel;
        private Label BackColorLabel;
        private ColorDialog colorDialog1;
        private TextBox BackColorTextBox;
        private Button SelectBackColorButton;
        private Label FontColorLabel;
        private Button SelectFontColorButton;
        private TextBox FontColorTextBox;
    }
}
