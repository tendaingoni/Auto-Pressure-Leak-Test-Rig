namespace TesterStoryBoard
{
    partial class FirstCardSwipeFail
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
            this.SwipeCardFailLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // SwipeCardFailLabel1
            // 
            this.SwipeCardFailLabel1.AutoSize = true;
            this.SwipeCardFailLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SwipeCardFailLabel1.Location = new System.Drawing.Point(438, 226);
            this.SwipeCardFailLabel1.Name = "SwipeCardFailLabel1";
            this.SwipeCardFailLabel1.Size = new System.Drawing.Size(210, 29);
            this.SwipeCardFailLabel1.TabIndex = 0;
            this.SwipeCardFailLabel1.TabStop = true;
            this.SwipeCardFailLabel1.Text = "Please Try again";
            this.SwipeCardFailLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SwipeCardFailLabel1_LinkClicked);
            // 
            // FirstCardSwipeFail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 538);
            this.Controls.Add(this.SwipeCardFailLabel1);
            this.Name = "FirstCardSwipeFail";
            this.Text = "FirstCardSwipeFail";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel SwipeCardFailLabel1;
    }
}