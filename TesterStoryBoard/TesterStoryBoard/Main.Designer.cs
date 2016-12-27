namespace TesterStoryBoard
{
    partial class Main
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
            this.GreetingsLabel = new System.Windows.Forms.Label();
            this.ContinueButton = new System.Windows.Forms.Button();
            this.OffButton = new System.Windows.Forms.Button();
            this.SelectInstructionLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // GreetingsLabel
            // 
            this.GreetingsLabel.AutoSize = true;
            this.GreetingsLabel.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GreetingsLabel.Location = new System.Drawing.Point(289, 190);
            this.GreetingsLabel.Name = "GreetingsLabel";
            this.GreetingsLabel.Size = new System.Drawing.Size(632, 34);
            this.GreetingsLabel.TabIndex = 0;
            this.GreetingsLabel.Text = "WELCOME TO AUTO TESTING TECHNOLOGY";
            // 
            // ContinueButton
            // 
            this.ContinueButton.BackColor = System.Drawing.Color.Green;
            this.ContinueButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContinueButton.Location = new System.Drawing.Point(205, 386);
            this.ContinueButton.Name = "ContinueButton";
            this.ContinueButton.Size = new System.Drawing.Size(103, 58);
            this.ContinueButton.TabIndex = 1;
            this.ContinueButton.Text = "Continue";
            this.ContinueButton.UseVisualStyleBackColor = false;
            this.ContinueButton.Click += new System.EventHandler(this.ContinueButton_Click);
            // 
            // OffButton
            // 
            this.OffButton.BackColor = System.Drawing.Color.Red;
            this.OffButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OffButton.Location = new System.Drawing.Point(836, 394);
            this.OffButton.Name = "OffButton";
            this.OffButton.Size = new System.Drawing.Size(85, 50);
            this.OffButton.TabIndex = 2;
            this.OffButton.Text = "OFF";
            this.OffButton.UseVisualStyleBackColor = false;
            this.OffButton.Click += new System.EventHandler(this.OffButton_Click);
            // 
            // SelectInstructionLabel
            // 
            this.SelectInstructionLabel.AutoSize = true;
            this.SelectInstructionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectInstructionLabel.Location = new System.Drawing.Point(379, 296);
            this.SelectInstructionLabel.Name = "SelectInstructionLabel";
            this.SelectInstructionLabel.Size = new System.Drawing.Size(416, 32);
            this.SelectInstructionLabel.TabIndex = 3;
            this.SelectInstructionLabel.Text = "Please select a Button and click";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1160, 538);
            this.Controls.Add(this.SelectInstructionLabel);
            this.Controls.Add(this.OffButton);
            this.Controls.Add(this.ContinueButton);
            this.Controls.Add(this.GreetingsLabel);
            this.Name = "Main";
            this.Text = "Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label GreetingsLabel;
        private System.Windows.Forms.Button ContinueButton;
        private System.Windows.Forms.Button OffButton;
        private System.Windows.Forms.Label SelectInstructionLabel;
    }
}

