namespace TesterStoryBoard
{
    partial class ManualLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManualLogin));
            this.UserNameSetUplabel1 = new System.Windows.Forms.Label();
            this.PasswordSetUplabel2 = new System.Windows.Forms.Label();
            this.Exitbutton2 = new System.Windows.Forms.Button();
            this.Loginbutton = new System.Windows.Forms.Button();
            this.WelcomeLoginManuallylabel1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ToMainTestbutton1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // UserNameSetUplabel1
            // 
            this.UserNameSetUplabel1.AutoSize = true;
            this.UserNameSetUplabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameSetUplabel1.Location = new System.Drawing.Point(504, 98);
            this.UserNameSetUplabel1.Name = "UserNameSetUplabel1";
            this.UserNameSetUplabel1.Size = new System.Drawing.Size(132, 29);
            this.UserNameSetUplabel1.TabIndex = 0;
            this.UserNameSetUplabel1.Text = "Username";
            // 
            // PasswordSetUplabel2
            // 
            this.PasswordSetUplabel2.AutoSize = true;
            this.PasswordSetUplabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordSetUplabel2.Location = new System.Drawing.Point(508, 212);
            this.PasswordSetUplabel2.Name = "PasswordSetUplabel2";
            this.PasswordSetUplabel2.Size = new System.Drawing.Size(128, 29);
            this.PasswordSetUplabel2.TabIndex = 1;
            this.PasswordSetUplabel2.Text = "Password";
            // 
            // Exitbutton2
            // 
            this.Exitbutton2.BackColor = System.Drawing.Color.Red;
            this.Exitbutton2.Location = new System.Drawing.Point(751, 349);
            this.Exitbutton2.Name = "Exitbutton2";
            this.Exitbutton2.Size = new System.Drawing.Size(74, 58);
            this.Exitbutton2.TabIndex = 3;
            this.Exitbutton2.Text = "EXIT";
            this.Exitbutton2.UseVisualStyleBackColor = false;
            this.Exitbutton2.Click += new System.EventHandler(this.Exitbutton2_Click);
            // 
            // Loginbutton
            // 
            this.Loginbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Loginbutton.Location = new System.Drawing.Point(995, 349);
            this.Loginbutton.Name = "Loginbutton";
            this.Loginbutton.Size = new System.Drawing.Size(73, 58);
            this.Loginbutton.TabIndex = 4;
            this.Loginbutton.Text = "LOGIN";
            this.Loginbutton.UseVisualStyleBackColor = false;
            this.Loginbutton.Click += new System.EventHandler(this.Loginbutton_Click);
            // 
            // WelcomeLoginManuallylabel1
            // 
            this.WelcomeLoginManuallylabel1.AutoSize = true;
            this.WelcomeLoginManuallylabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeLoginManuallylabel1.Location = new System.Drawing.Point(111, 35);
            this.WelcomeLoginManuallylabel1.Name = "WelcomeLoginManuallylabel1";
            this.WelcomeLoginManuallylabel1.Size = new System.Drawing.Size(167, 32);
            this.WelcomeLoginManuallylabel1.TabIndex = 5;
            this.WelcomeLoginManuallylabel1.Text = "WELCOME";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(693, 98);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(375, 22);
            this.textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(693, 212);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(375, 22);
            this.textBox2.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Controls.Add(this.WelcomeLoginManuallylabel1);
            this.panel1.Location = new System.Drawing.Point(13, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(448, 509);
            this.panel1.TabIndex = 8;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // ToMainTestbutton1
            // 
            this.ToMainTestbutton1.Location = new System.Drawing.Point(995, 404);
            this.ToMainTestbutton1.Name = "ToMainTestbutton1";
            this.ToMainTestbutton1.Size = new System.Drawing.Size(73, 12);
            this.ToMainTestbutton1.TabIndex = 9;
            this.ToMainTestbutton1.Text = "TmainTestbutton";
            this.ToMainTestbutton1.UseVisualStyleBackColor = true;
            this.ToMainTestbutton1.Click += new System.EventHandler(this.ToMainTestbutton1_Click);
            // 
            // ManualLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 533);
            this.Controls.Add(this.ToMainTestbutton1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Loginbutton);
            this.Controls.Add(this.Exitbutton2);
            this.Controls.Add(this.PasswordSetUplabel2);
            this.Controls.Add(this.UserNameSetUplabel1);
            this.Name = "ManualLogin";
            this.Text = "ManualLogin";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UserNameSetUplabel1;
        private System.Windows.Forms.Label PasswordSetUplabel2;
        private System.Windows.Forms.Button Exitbutton2;
        private System.Windows.Forms.Button Loginbutton;
        private System.Windows.Forms.Label WelcomeLoginManuallylabel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ToMainTestbutton1;
    }
}