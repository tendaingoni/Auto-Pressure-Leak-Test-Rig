namespace TesterStoryBoard
{
    partial class TankTest
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
            this.Backtestbutton = new System.Windows.Forms.Button();
            this.Filltankbutton = new System.Windows.Forms.Button();
            this.Tanktestlabel1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // Backtestbutton
            // 
            this.Backtestbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Backtestbutton.Location = new System.Drawing.Point(181, 396);
            this.Backtestbutton.Name = "Backtestbutton";
            this.Backtestbutton.Size = new System.Drawing.Size(80, 43);
            this.Backtestbutton.TabIndex = 0;
            this.Backtestbutton.Text = "BACK";
            this.Backtestbutton.UseVisualStyleBackColor = true;
            this.Backtestbutton.Click += new System.EventHandler(this.Backtestbutton_Click);
            // 
            // Filltankbutton
            // 
            this.Filltankbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Filltankbutton.Location = new System.Drawing.Point(863, 396);
            this.Filltankbutton.Name = "Filltankbutton";
            this.Filltankbutton.Size = new System.Drawing.Size(76, 43);
            this.Filltankbutton.TabIndex = 1;
            this.Filltankbutton.Text = "FILL";
            this.Filltankbutton.UseVisualStyleBackColor = true;
            this.Filltankbutton.Click += new System.EventHandler(this.Filltankbutton_Click);
            // 
            // Tanktestlabel1
            // 
            this.Tanktestlabel1.AutoSize = true;
            this.Tanktestlabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tanktestlabel1.ForeColor = System.Drawing.Color.Red;
            this.Tanktestlabel1.Location = new System.Drawing.Point(413, 104);
            this.Tanktestlabel1.Name = "Tanktestlabel1";
            this.Tanktestlabel1.Size = new System.Drawing.Size(342, 32);
            this.Tanktestlabel1.TabIndex = 2;
            this.Tanktestlabel1.Text = "Please Close all Outlets";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(467, 206);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(234, 21);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "Yes I have closed all outlets";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // TankTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 537);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.Tanktestlabel1);
            this.Controls.Add(this.Filltankbutton);
            this.Controls.Add(this.Backtestbutton);
            this.Name = "TankTest";
            this.Text = "TankTest";
            this.Load += new System.EventHandler(this.TankTest_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Backtestbutton;
        private System.Windows.Forms.Button Filltankbutton;
        private System.Windows.Forms.Label Tanktestlabel1;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}