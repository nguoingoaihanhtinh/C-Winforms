namespace Circle_Game
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            timer1 = new System.Windows.Forms.Timer(components);
            gamePanel = new Panel();
            scoreLabel = new Label();
            timeLabel = new Label();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Interval = 500;
            timer1.Tick += timer1_Tick;
            // 
            // gamePanel
            // 
            gamePanel.Location = new Point(12, 53);
            gamePanel.Name = "gamePanel";
            gamePanel.Size = new Size(776, 319);
            gamePanel.TabIndex = 0;
            gamePanel.MouseClick += gamePanel_MouseClick;
            // 
            // scoreLabel
            // 
            scoreLabel.AutoSize = true;
            scoreLabel.Location = new Point(12, 21);
            scoreLabel.Name = "scoreLabel";
            scoreLabel.Size = new Size(36, 15);
            scoreLabel.TabIndex = 1;
            scoreLabel.Text = "Score";
            // 
            // timeLabel
            // 
            timeLabel.AutoSize = true;
            timeLabel.Location = new Point(641, 21);
            timeLabel.Name = "timeLabel";
            timeLabel.Size = new Size(53, 15);
            timeLabel.TabIndex = 2;
            timeLabel.Text = "TimeLeft";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(timeLabel);
            Controls.Add(scoreLabel);
            Controls.Add(gamePanel);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private Panel gamePanel;
        private Label scoreLabel;
        private Label timeLabel;
    }
}