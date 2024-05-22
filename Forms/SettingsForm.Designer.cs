namespace IntervalClock.Forms
{
    partial class SettingsForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ShowClockLabel = new Label();
            ShowClockButton = new Button();
            ShowClockTimeNumSelect = new NumericUpDown();
            ShowClockTimeLabel = new Label();
            MinuteIntervalLabel = new Label();
            MinuteIntervalNumSelect = new NumericUpDown();
            SaveButton = new Button();
            AbortChangeButton = new Button();
            EnableClockBox = new CheckBox();
            EnableClockLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)ShowClockTimeNumSelect).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MinuteIntervalNumSelect).BeginInit();
            SuspendLayout();
            // 
            // ShowClockLabel
            // 
            ShowClockLabel.AutoSize = true;
            ShowClockLabel.Location = new Point(17, 15);
            ShowClockLabel.Margin = new Padding(2, 0, 2, 0);
            ShowClockLabel.Name = "ShowClockLabel";
            ShowClockLabel.Size = new Size(56, 17);
            ShowClockLabel.TabIndex = 0;
            ShowClockLabel.Text = "显示时钟";
            // 
            // ShowClockButton
            // 
            ShowClockButton.Location = new Point(131, 12);
            ShowClockButton.Margin = new Padding(2, 3, 2, 3);
            ShowClockButton.Name = "ShowClockButton";
            ShowClockButton.Size = new Size(73, 25);
            ShowClockButton.TabIndex = 1;
            ShowClockButton.Text = "显示";
            ShowClockButton.UseVisualStyleBackColor = true;
            ShowClockButton.Click += ShowClockButton_Click;
            // 
            // ShowClockTimeNumSelect
            // 
            ShowClockTimeNumSelect.Location = new Point(131, 42);
            ShowClockTimeNumSelect.Margin = new Padding(2, 3, 2, 3);
            ShowClockTimeNumSelect.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            ShowClockTimeNumSelect.Name = "ShowClockTimeNumSelect";
            ShowClockTimeNumSelect.Size = new Size(117, 23);
            ShowClockTimeNumSelect.TabIndex = 2;
            ShowClockTimeNumSelect.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // ShowClockTimeLabel
            // 
            ShowClockTimeLabel.AutoSize = true;
            ShowClockTimeLabel.Location = new Point(17, 43);
            ShowClockTimeLabel.Margin = new Padding(2, 0, 2, 0);
            ShowClockTimeLabel.Name = "ShowClockTimeLabel";
            ShowClockTimeLabel.Size = new Size(92, 17);
            ShowClockTimeLabel.TabIndex = 3;
            ShowClockTimeLabel.Text = "弹出时间（秒）";
            // 
            // MinuteIntervalLabel
            // 
            MinuteIntervalLabel.AutoSize = true;
            MinuteIntervalLabel.Location = new Point(17, 71);
            MinuteIntervalLabel.Margin = new Padding(2, 0, 2, 0);
            MinuteIntervalLabel.Name = "MinuteIntervalLabel";
            MinuteIntervalLabel.Size = new Size(104, 17);
            MinuteIntervalLabel.TabIndex = 5;
            MinuteIntervalLabel.Text = "弹出间隔（分钟）";
            // 
            // MinuteIntervalNumSelect
            // 
            MinuteIntervalNumSelect.Location = new Point(131, 70);
            MinuteIntervalNumSelect.Margin = new Padding(2, 3, 2, 3);
            MinuteIntervalNumSelect.Maximum = new decimal(new int[] { 60, 0, 0, 0 });
            MinuteIntervalNumSelect.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            MinuteIntervalNumSelect.Name = "MinuteIntervalNumSelect";
            MinuteIntervalNumSelect.Size = new Size(117, 23);
            MinuteIntervalNumSelect.TabIndex = 4;
            MinuteIntervalNumSelect.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(17, 348);
            SaveButton.Margin = new Padding(2, 3, 2, 3);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(73, 25);
            SaveButton.TabIndex = 6;
            SaveButton.Text = "保存";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // AbortChangeButton
            // 
            AbortChangeButton.Location = new Point(95, 348);
            AbortChangeButton.Margin = new Padding(2, 3, 2, 3);
            AbortChangeButton.Name = "AbortChangeButton";
            AbortChangeButton.Size = new Size(73, 25);
            AbortChangeButton.TabIndex = 7;
            AbortChangeButton.Text = "取消修改";
            AbortChangeButton.UseVisualStyleBackColor = true;
            AbortChangeButton.Click += AbortChangeButton_Click;
            // 
            // EnableClockBox
            // 
            EnableClockBox.AutoSize = true;
            EnableClockBox.Location = new Point(131, 98);
            EnableClockBox.Margin = new Padding(2, 3, 2, 3);
            EnableClockBox.Name = "EnableClockBox";
            EnableClockBox.Size = new Size(87, 21);
            EnableClockBox.TabIndex = 8;
            EnableClockBox.Text = "勾选以启用";
            EnableClockBox.UseVisualStyleBackColor = true;
            // 
            // EnableClockLabel
            // 
            EnableClockLabel.AutoSize = true;
            EnableClockLabel.Location = new Point(17, 99);
            EnableClockLabel.Margin = new Padding(2, 0, 2, 0);
            EnableClockLabel.Name = "EnableClockLabel";
            EnableClockLabel.Size = new Size(56, 17);
            EnableClockLabel.TabIndex = 9;
            EnableClockLabel.Text = "是否启用";
            // 
            // SettingsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(318, 382);
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
            Margin = new Padding(2, 3, 2, 3);
            Name = "SettingsForm";
            Text = "SettingsForm";
            Load += SettingsForm_Load;
            Resize += SettingsForm_Resize;
            ((System.ComponentModel.ISupportInitialize)ShowClockTimeNumSelect).EndInit();
            ((System.ComponentModel.ISupportInitialize)MinuteIntervalNumSelect).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ShowClockLabel;
        private Button ShowClockButton;
        private NumericUpDown ShowClockTimeNumSelect;
        private Label ShowClockTimeLabel;
        private Label MinuteIntervalLabel;
        private NumericUpDown MinuteIntervalNumSelect;
        private Button SaveButton;
        private Button AbortChangeButton;
        private CheckBox EnableClockBox;
        private Label EnableClockLabel;
    }
}
