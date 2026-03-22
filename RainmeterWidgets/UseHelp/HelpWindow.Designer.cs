namespace UseHelp
{
    partial class HelpWindow
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
            TipLabel = new Label();
            HelpListView = new TreeView();
            DecorationIcon = new PictureBox();
            CloseButton = new Button();
            OnlineHelpButton = new Button();
            ((System.ComponentModel.ISupportInitialize)DecorationIcon).BeginInit();
            SuspendLayout();
            // 
            // TipLabel
            // 
            TipLabel.AutoSize = true;
            TipLabel.Font = new Font("Microsoft YaHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            TipLabel.Location = new Point(8, 4);
            TipLabel.Name = "TipLabel";
            TipLabel.Size = new Size(330, 25);
            TipLabel.TabIndex = 3;
            TipLabel.Text = "已列出部分常见问题，希望能帮助您~";
            // 
            // HelpListView
            // 
            HelpListView.Location = new Point(8, 40);
            HelpListView.Name = "HelpListView";
            HelpListView.Size = new Size(586, 300);
            HelpListView.TabIndex = 0;
            // 
            // DecorationIcon
            // 
            DecorationIcon.Location = new Point(560, 4);
            DecorationIcon.Name = "DecorationIcon";
            DecorationIcon.Size = new Size(32, 32);
            DecorationIcon.SizeMode = PictureBoxSizeMode.Zoom;
            DecorationIcon.TabIndex = 2;
            DecorationIcon.TabStop = false;
            // 
            // CloseButton
            // 
            CloseButton.Location = new Point(512, 348);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(80, 40);
            CloseButton.TabIndex = 2;
            CloseButton.Text = "关闭";
            CloseButton.UseVisualStyleBackColor = true;
            CloseButton.Click += CloseButton_Click;
            // 
            // OnlineHelpButton
            // 
            OnlineHelpButton.Location = new Point(426, 348);
            OnlineHelpButton.Name = "OnlineHelpButton";
            OnlineHelpButton.Size = new Size(80, 40);
            OnlineHelpButton.TabIndex = 1;
            OnlineHelpButton.Text = "联机帮助";
            OnlineHelpButton.UseVisualStyleBackColor = true;
            // 
            // HelpWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 400);
            Controls.Add(OnlineHelpButton);
            Controls.Add(CloseButton);
            Controls.Add(DecorationIcon);
            Controls.Add(HelpListView);
            Controls.Add(TipLabel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "HelpWindow";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "手册";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)DecorationIcon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label TipLabel;
        private TreeView HelpListView;
        private PictureBox DecorationIcon;
        private Button CloseButton;
        private Button OnlineHelpButton;
    }
}
