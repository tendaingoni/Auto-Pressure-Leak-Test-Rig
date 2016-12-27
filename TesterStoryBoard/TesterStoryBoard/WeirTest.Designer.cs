namespace TesterStoryBoard
{
    partial class WeirTest
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
            this.label1 = new System.Windows.Forms.Label();
            this.Backbutton = new System.Windows.Forms.Button();
            this.Fillweirbutton = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(415, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please close all outlets";
            // 
            // Backbutton
            // 
            this.Backbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Backbutton.Location = new System.Drawing.Point(310, 377);
            this.Backbutton.Name = "Backbutton";
            this.Backbutton.Size = new System.Drawing.Size(90, 45);
            this.Backbutton.TabIndex = 1;
            this.Backbutton.Text = "BACK";
            this.Backbutton.UseVisualStyleBackColor = true;
            this.Backbutton.Click += new System.EventHandler(this.Backbutton_Click);
            // 
            // Fillweirbutton
            // 
            this.Fillweirbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fillweirbutton.Location = new System.Drawing.Point(750, 390);
            this.Fillweirbutton.Name = "Fillweirbutton";
            this.Fillweirbutton.Size = new System.Drawing.Size(94, 32);
            this.Fillweirbutton.TabIndex = 2;
            this.Fillweirbutton.Text = "Fill Weir";
            this.Fillweirbutton.UseVisualStyleBackColor = true;
            this.Fillweirbutton.Click += new System.EventHandler(this.Fillweirbutton_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(491, 207);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(234, 21);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "Yes I have closed all outlets";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // WeirTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 532);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.Fillweirbutton);
            this.Controls.Add(this.Backbutton);
            this.Controls.Add(this.label1);
            this.Name = "WeirTest";
            this.Text = "WeirTest";
            this.Load += new System.EventHandler(this.WeirTest_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Backbutton;
        private System.Windows.Forms.Button Fillweirbutton;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}