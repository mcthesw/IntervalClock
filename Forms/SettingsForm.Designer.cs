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
            menu = new ToolStrip();
            FunctionToolStripLabel = new ToolStripLabel();
            StyleToolStripLabel = new ToolStripLabel();
            panel1 = new Panel();
            menu.SuspendLayout();
            SuspendLayout();
            // 
            // menu
            // 
            menu.ImageScalingSize = new Size(20, 20);
            menu.Items.AddRange(new ToolStripItem[] { FunctionToolStripLabel, StyleToolStripLabel });
            menu.Location = new Point(0, 0);
            menu.Name = "menu";
            menu.Size = new Size(409, 25);
            menu.TabIndex = 0;
            // 
            // FunctionToolStripLabel
            // 
            FunctionToolStripLabel.Name = "FunctionToolStripLabel";
            FunctionToolStripLabel.Size = new Size(39, 22);
            FunctionToolStripLabel.Text = "常规";
            FunctionToolStripLabel.Click += FunctionToolStripLabel_Click;
            // 
            // StyleToolStripLabel
            // 
            StyleToolStripLabel.Name = "StyleToolStripLabel";
            StyleToolStripLabel.RightToLeft = RightToLeft.No;
            StyleToolStripLabel.Size = new Size(39, 22);
            StyleToolStripLabel.Text = "样式";
            StyleToolStripLabel.Click += StyleToolStripLabel_Click;
            // 
            // panel1
            // 
            panel1.Location = new Point(0, 28);
            panel1.Name = "panel1";
            panel1.Size = new Size(409, 432);
            panel1.TabIndex = 1;
            // 
            // SettingsForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(409, 463);
            Controls.Add(panel1);
            Controls.Add(menu);
            Name = "SettingsForm";
            Text = "SettingsForm";
            Load += SettingsForm_Load;
            menu.ResumeLayout(false);
            menu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip menu;
        private ToolStripLabel FunctionToolStripLabel;
        private ToolStripLabel StyleToolStripLabel;
        private Panel panel1;
    }
}
