namespace TesterStoryBoard
{
    partial class Login
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
            this.LoginLabel = new System.Windows.Forms.LinkLabel();
            this.SelfTestDuelinkLabel2 = new System.Windows.Forms.LinkLabel();
            this.MatchedSwipeToMainTestModelinkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginLabel.Location = new System.Drawing.Point(441, 237);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(239, 25);
            this.LoginLabel.TabIndex = 0;
            this.LoginLabel.TabStop = true;
            this.LoginLabel.Text = "Please Swipe your card";
            this.LoginLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LoginLabel_LinkClicked);
            // 
            // SelfTestDuelinkLabel2
            // 
            this.SelfTestDuelinkLabel2.AutoSize = true;
            this.SelfTestDuelinkLabel2.Location = new System.Drawing.Point(459, 297);
            this.SelfTestDuelinkLabel2.Name = "SelfTestDuelinkLabel2";
            this.SelfTestDuelinkLabel2.Size = new System.Drawing.Size(197, 17);
            this.SelfTestDuelinkLabel2.TabIndex = 3;
            this.SelfTestDuelinkLabel2.TabStop = true;
            this.SelfTestDuelinkLabel2.Text = "Matched Swipe Self Test  Due";
            this.SelfTestDuelinkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SelfTestDuelinkLabel2_LinkClicked);
            // 
            // MatchedSwipeToMainTestModelinkLabel1
            // 
            this.MatchedSwipeToMainTestModelinkLabel1.AutoSize = true;
            this.MatchedSwipeToMainTestModelinkLabel1.Location = new System.Drawing.Point(510, 199);
            this.MatchedSwipeToMainTestModelinkLabel1.Name = "MatchedSwipeToMainTestModelinkLabel1";
            this.MatchedSwipeToMainTestModelinkLabel1.Size = new System.Drawing.Size(107, 17);
            this.MatchedSwipeToMainTestModelinkLabel1.TabIndex = 4;
            this.MatchedSwipeToMainTestModelinkLabel1.TabStop = true;
            this.MatchedSwipeToMainTestModelinkLabel1.Text = "Matched Swipe ";
            this.MatchedSwipeToMainTestModelinkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.MatchedSwipeToMainTestModelinkLabel1_LinkClicked);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 531);
            this.Controls.Add(this.MatchedSwipeToMainTestModelinkLabel1);
            this.Controls.Add(this.SelfTestDuelinkLabel2);
            this.Controls.Add(this.LoginLabel);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel LoginLabel;
        private System.Windows.Forms.LinkLabel SelfTestDuelinkLabel2;
        private System.Windows.Forms.LinkLabel MatchedSwipeToMainTestModelinkLabel1;
    }
}