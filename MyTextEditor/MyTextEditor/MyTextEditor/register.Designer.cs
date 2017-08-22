namespace MyTextEditor
{
    partial class register
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
            this.register_label_name = new System.Windows.Forms.Label();
            this.register_label_password = new System.Windows.Forms.Label();
            this.register_label_confirmpass = new System.Windows.Forms.Label();
            this.register_label_register = new System.Windows.Forms.Label();
            this.register_button_register = new System.Windows.Forms.Button();
            this.register_textBox_name = new System.Windows.Forms.TextBox();
            this.register_textBox_password = new System.Windows.Forms.TextBox();
            this.register_textBox_confirmpass = new System.Windows.Forms.TextBox();
            this.register_button_back = new System.Windows.Forms.Button();
            this.register_label_status = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.register_textBox_username = new System.Windows.Forms.TextBox();
            this.register_label_username = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // register_label_name
            // 
            this.register_label_name.AutoSize = true;
            this.register_label_name.Font = new System.Drawing.Font("Calibri Light", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_label_name.Location = new System.Drawing.Point(15, 101);
            this.register_label_name.Name = "register_label_name";
            this.register_label_name.Size = new System.Drawing.Size(56, 23);
            this.register_label_name.TabIndex = 1;
            this.register_label_name.Text = "Name";
            // 
            // register_label_password
            // 
            this.register_label_password.AutoSize = true;
            this.register_label_password.Font = new System.Drawing.Font("Calibri Light", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_label_password.Location = new System.Drawing.Point(15, 141);
            this.register_label_password.Name = "register_label_password";
            this.register_label_password.Size = new System.Drawing.Size(83, 23);
            this.register_label_password.TabIndex = 2;
            this.register_label_password.Text = "Password";
            // 
            // register_label_confirmpass
            // 
            this.register_label_confirmpass.AutoSize = true;
            this.register_label_confirmpass.Font = new System.Drawing.Font("Calibri Light", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_label_confirmpass.Location = new System.Drawing.Point(15, 187);
            this.register_label_confirmpass.Name = "register_label_confirmpass";
            this.register_label_confirmpass.Size = new System.Drawing.Size(148, 23);
            this.register_label_confirmpass.TabIndex = 3;
            this.register_label_confirmpass.Text = "Confirm Password";
            // 
            // register_label_register
            // 
            this.register_label_register.AutoSize = true;
            this.register_label_register.Font = new System.Drawing.Font("Calibri Light", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_label_register.Location = new System.Drawing.Point(244, 30);
            this.register_label_register.Name = "register_label_register";
            this.register_label_register.Size = new System.Drawing.Size(214, 49);
            this.register_label_register.TabIndex = 4;
            this.register_label_register.Text = "Registration";
            // 
            // register_button_register
            // 
            this.register_button_register.Font = new System.Drawing.Font("Calibri Light", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_button_register.Location = new System.Drawing.Point(160, 245);
            this.register_button_register.Name = "register_button_register";
            this.register_button_register.Size = new System.Drawing.Size(66, 32);
            this.register_button_register.TabIndex = 5;
            this.register_button_register.Text = "Register";
            this.register_button_register.UseVisualStyleBackColor = true;
            this.register_button_register.Click += new System.EventHandler(this.button1_Click);
            // 
            // register_textBox_name
            // 
            this.register_textBox_name.Location = new System.Drawing.Point(185, 99);
            this.register_textBox_name.Name = "register_textBox_name";
            this.register_textBox_name.Size = new System.Drawing.Size(232, 32);
            this.register_textBox_name.TabIndex = 7;
            // 
            // register_textBox_password
            // 
            this.register_textBox_password.Location = new System.Drawing.Point(185, 141);
            this.register_textBox_password.Name = "register_textBox_password";
            this.register_textBox_password.PasswordChar = '*';
            this.register_textBox_password.Size = new System.Drawing.Size(232, 32);
            this.register_textBox_password.TabIndex = 8;
            // 
            // register_textBox_confirmpass
            // 
            this.register_textBox_confirmpass.Location = new System.Drawing.Point(185, 185);
            this.register_textBox_confirmpass.Name = "register_textBox_confirmpass";
            this.register_textBox_confirmpass.PasswordChar = '*';
            this.register_textBox_confirmpass.Size = new System.Drawing.Size(232, 32);
            this.register_textBox_confirmpass.TabIndex = 9;
            // 
            // register_button_back
            // 
            this.register_button_back.Font = new System.Drawing.Font("Calibri Light", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_button_back.Location = new System.Drawing.Point(1, 4);
            this.register_button_back.Name = "register_button_back";
            this.register_button_back.Size = new System.Drawing.Size(75, 33);
            this.register_button_back.TabIndex = 10;
            this.register_button_back.Text = "Back";
            this.register_button_back.UseVisualStyleBackColor = true;
            this.register_button_back.Click += new System.EventHandler(this.register_button_back_Click);
            // 
            // register_label_status
            // 
            this.register_label_status.AutoSize = true;
            this.register_label_status.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_label_status.Location = new System.Drawing.Point(322, 480);
            this.register_label_status.Name = "register_label_status";
            this.register_label_status.Size = new System.Drawing.Size(0, 24);
            this.register_label_status.TabIndex = 11;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MyTextEditor.Properties.Resources.openll_register;
            this.pictureBox1.Location = new System.Drawing.Point(26, 160);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(226, 216);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.register_textBox_username);
            this.groupBox1.Controls.Add(this.register_label_username);
            this.groupBox1.Controls.Add(this.register_label_name);
            this.groupBox1.Controls.Add(this.register_label_password);
            this.groupBox1.Controls.Add(this.register_textBox_confirmpass);
            this.groupBox1.Controls.Add(this.register_label_confirmpass);
            this.groupBox1.Controls.Add(this.register_textBox_password);
            this.groupBox1.Controls.Add(this.register_button_register);
            this.groupBox1.Controls.Add(this.register_textBox_name);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(292, 127);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(437, 297);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Register";
            // 
            // register_textBox_username
            // 
            this.register_textBox_username.Location = new System.Drawing.Point(185, 61);
            this.register_textBox_username.Name = "register_textBox_username";
            this.register_textBox_username.Size = new System.Drawing.Size(232, 32);
            this.register_textBox_username.TabIndex = 6;
            // 
            // register_label_username
            // 
            this.register_label_username.AutoSize = true;
            this.register_label_username.Font = new System.Drawing.Font("Calibri Light", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_label_username.Location = new System.Drawing.Point(15, 61);
            this.register_label_username.Name = "register_label_username";
            this.register_label_username.Size = new System.Drawing.Size(88, 23);
            this.register_label_username.TabIndex = 0;
            this.register_label_username.Text = "Username";
            // 
            // register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 525);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.register_label_status);
            this.Controls.Add(this.register_button_back);
            this.Controls.Add(this.register_label_register);
            this.Name = "register";
            this.Text = "register";
            this.Load += new System.EventHandler(this.register_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label register_label_name;
        private System.Windows.Forms.Label register_label_password;
        private System.Windows.Forms.Label register_label_confirmpass;
        private System.Windows.Forms.Label register_label_register;
        private System.Windows.Forms.Button register_button_register;
        private System.Windows.Forms.TextBox register_textBox_name;
        private System.Windows.Forms.TextBox register_textBox_password;
        private System.Windows.Forms.TextBox register_textBox_confirmpass;
        private System.Windows.Forms.Button register_button_back;
        private System.Windows.Forms.Label register_label_status;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox register_textBox_username;
        private System.Windows.Forms.Label register_label_username;
    }
}