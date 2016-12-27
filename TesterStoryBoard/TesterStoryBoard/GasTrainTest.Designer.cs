namespace TesterStoryBoard
{
    partial class GasTrainTest
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
            this.Fillbutton = new System.Windows.Forms.Button();
            this.OutletsclosedcheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(450, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = " Please Close all outlets";
            // 
            // Backbutton
            // 
            this.Backbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Backbutton.Location = new System.Drawing.Point(241, 376);
            this.Backbutton.Name = "Backbutton";
            this.Backbutton.Size = new System.Drawing.Size(87, 38);
            this.Backbutton.TabIndex = 1;
            this.Backbutton.Text = "BACK";
            this.Backbutton.UseVisualStyleBackColor = true;
            this.Backbutton.Click += new System.EventHandler(this.Backbutton_Click);
            // 
            // Fillbutton
            // 
            this.Fillbutton.Enabled = false;
            this.Fillbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fillbutton.Location = new System.Drawing.Point(764, 376);
            this.Fillbutton.Name = "Fillbutton";
            this.Fillbutton.Size = new System.Drawing.Size(79, 38);
            this.Fillbutton.TabIndex = 2;
            this.Fillbutton.Text = "FILL";
            this.Fillbutton.UseVisualStyleBackColor = true;
            this.Fillbutton.Click += new System.EventHandler(this.Fillbutton_Click);
            // 
            // OutletsclosedcheckBox
            // 
            this.OutletsclosedcheckBox.AutoSize = true;
            this.OutletsclosedcheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutletsclosedcheckBox.Location = new System.Drawing.Point(487, 175);
            this.OutletsclosedcheckBox.Name = "OutletsclosedcheckBox";
            this.OutletsclosedcheckBox.Size = new System.Drawing.Size(284, 22);
            this.OutletsclosedcheckBox.TabIndex = 3;
            this.OutletsclosedcheckBox.Text = "Tick if you have closed all Outlets";
            this.OutletsclosedcheckBox.UseVisualStyleBackColor = true;
            this.OutletsclosedcheckBox.CheckedChanged += new System.EventHandler(this.OutletsclosedcheckBox_CheckedChanged);
            // 
            // GasTrainTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 534);
            this.Controls.Add(this.OutletsclosedcheckBox);
            this.Controls.Add(this.Fillbutton);
            this.Controls.Add(this.Backbutton);
            this.Controls.Add(this.label1);
            this.Name = "GasTrainTest";
            this.Text = "Gas Train Test";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Backbutton;
        private System.Windows.Forms.Button Fillbutton;
        private System.Windows.Forms.CheckBox OutletsclosedcheckBox;
    }
}