namespace TesterStoryBoard
{
    partial class SelfCheckFillTimeCheck
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
            this.LeakWarninglabel1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LeakWarninglabel1
            // 
            this.LeakWarninglabel1.AutoSize = true;
            this.LeakWarninglabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LeakWarninglabel1.Location = new System.Drawing.Point(107, 183);
            this.LeakWarninglabel1.Name = "LeakWarninglabel1";
            this.LeakWarninglabel1.Size = new System.Drawing.Size(913, 29);
            this.LeakWarninglabel1.TabIndex = 0;
            this.LeakWarninglabel1.Text = "Test piece taking too long to fill. Please check blanks are in position and tight" +
    "";
            this.LeakWarninglabel1.Click += new System.EventHandler(this.LeakWarninglabel1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(547, 289);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SelfCheckFillTimeCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 503);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LeakWarninglabel1);
            this.Name = "SelfCheckFillTimeCheck";
            this.Text = "SelfCheckFillTimeCheck";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LeakWarninglabel1;
        private System.Windows.Forms.Button button1;
    }
}