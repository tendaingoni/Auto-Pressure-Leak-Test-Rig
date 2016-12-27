namespace TesterStoryBoard
{
    partial class FILL
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
            this.components = new System.ComponentModel.Container();
            this.FillprogressBar = new System.Windows.Forms.ProgressBar();
            this.Filltimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // FillprogressBar
            // 
            this.FillprogressBar.Location = new System.Drawing.Point(291, 240);
            this.FillprogressBar.Name = "FillprogressBar";
            this.FillprogressBar.Size = new System.Drawing.Size(607, 23);
            this.FillprogressBar.TabIndex = 0;
            this.FillprogressBar.Click += new System.EventHandler(this.FillprogressBar_Click);
            // 
            // Filltimer
            // 
            this.Filltimer.Tick += new System.EventHandler(this.Filltimer_Tick);
            // 
            // FILL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 533);
            this.Controls.Add(this.FillprogressBar);
            this.Name = "FILL";
            this.Text = "FILL";
            this.Load += new System.EventHandler(this.FILL_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar FillprogressBar;
        private System.Windows.Forms.Timer Filltimer;
    }
}