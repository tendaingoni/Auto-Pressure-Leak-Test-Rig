namespace TesterStoryBoard
{
    partial class SelfTest
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
            this.SelfCheckReminderlabel1 = new System.Windows.Forms.Label();
            this.INSTRUCTIONS = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.instructionSelfTestlabel3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FillButtonSelfTestbutton1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SelfCheckReminderlabel1
            // 
            this.SelfCheckReminderlabel1.AutoSize = true;
            this.SelfCheckReminderlabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelfCheckReminderlabel1.ForeColor = System.Drawing.Color.Red;
            this.SelfCheckReminderlabel1.Location = new System.Drawing.Point(121, 102);
            this.SelfCheckReminderlabel1.Name = "SelfCheckReminderlabel1";
            this.SelfCheckReminderlabel1.Size = new System.Drawing.Size(870, 36);
            this.SelfCheckReminderlabel1.TabIndex = 0;
            this.SelfCheckReminderlabel1.Text = "Its 15 minutes before my self check test please do self check";
            // 
            // INSTRUCTIONS
            // 
            this.INSTRUCTIONS.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.INSTRUCTIONS.FormattingEnabled = true;
            this.INSTRUCTIONS.ItemHeight = 31;
            this.INSTRUCTIONS.Location = new System.Drawing.Point(186, 198);
            this.INSTRUCTIONS.Name = "INSTRUCTIONS";
            this.INSTRUCTIONS.Size = new System.Drawing.Size(762, 221);
            this.INSTRUCTIONS.TabIndex = 1;
            this.INSTRUCTIONS.SelectedIndexChanged += new System.EventHandler(this.Instructions_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(263, 238);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(657, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "WARNING: Dont turn on the air supply if this is not done";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // instructionSelfTestlabel3
            // 
            this.instructionSelfTestlabel3.AutoSize = true;
            this.instructionSelfTestlabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionSelfTestlabel3.Location = new System.Drawing.Point(314, 290);
            this.instructionSelfTestlabel3.Name = "instructionSelfTestlabel3";
            this.instructionSelfTestlabel3.Size = new System.Drawing.Size(506, 25);
            this.instructionSelfTestlabel3.TabIndex = 4;
            this.instructionSelfTestlabel3.Text = "Close the air outlet which connects to the test piece";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(397, 336);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(316, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Connect the air line from supply";
            // 
            // FillButtonSelfTestbutton1
            // 
            this.FillButtonSelfTestbutton1.Location = new System.Drawing.Point(445, 425);
            this.FillButtonSelfTestbutton1.Name = "FillButtonSelfTestbutton1";
            this.FillButtonSelfTestbutton1.Size = new System.Drawing.Size(154, 70);
            this.FillButtonSelfTestbutton1.TabIndex = 6;
            this.FillButtonSelfTestbutton1.Text = "FILL";
            this.FillButtonSelfTestbutton1.UseVisualStyleBackColor = true;
            this.FillButtonSelfTestbutton1.Click += new System.EventHandler(this.FillButtonSelfTestbutton1_Click);
            // 
            // SelfTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 534);
            this.Controls.Add(this.FillButtonSelfTestbutton1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.instructionSelfTestlabel3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.INSTRUCTIONS);
            this.Controls.Add(this.SelfCheckReminderlabel1);
            this.Name = "SelfTest";
            this.Text = "Self_Test Window";
            this.Load += new System.EventHandler(this.SelfTest_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SelfCheckReminderlabel1;
        private System.Windows.Forms.ListBox INSTRUCTIONS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label instructionSelfTestlabel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button FillButtonSelfTestbutton1;
    }
}