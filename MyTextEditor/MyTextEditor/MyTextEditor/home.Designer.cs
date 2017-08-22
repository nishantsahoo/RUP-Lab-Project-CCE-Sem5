namespace MyTextEditor
{
    partial class home
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
            this.home_login = new System.Windows.Forms.Button();
            this.home_username = new System.Windows.Forms.TextBox();
            this.home_password = new System.Windows.Forms.TextBox();
            this.home_title = new System.Windows.Forms.Label();
            this.home_description = new System.Windows.Forms.Label();
            this.home_label_username = new System.Windows.Forms.Label();
            this.home_label_password = new System.Windows.Forms.Label();
            this.home_label_register = new System.Windows.Forms.Label();
            this.home_button_register = new System.Windows.Forms.Button();
            this.home_label_status = new System.Windows.Forms.Label();
            this.home_groupBox = new System.Windows.Forms.GroupBox();
            this.home_pictureBox = new System.Windows.Forms.PictureBox();
            this.home_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.home_pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // home_login
            // 
            this.home_login.Font = new System.Drawing.Font("Calibri Light", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.home_login.Location = new System.Drawing.Point(195, 224);
            this.home_login.Name = "home_login";
            this.home_login.Size = new System.Drawing.Size(73, 35);
            this.home_login.TabIndex = 0;
            this.home_login.Text = "Login";
            this.home_login.UseVisualStyleBackColor = true;
            this.home_login.Click += new System.EventHandler(this.home_login_Click);
            // 
            // home_username
            // 
            this.home_username.Location = new System.Drawing.Point(145, 119);
            this.home_username.Name = "home_username";
            this.home_username.Size = new System.Drawing.Size(245, 36);
            this.home_username.TabIndex = 1;
            this.home_username.TextChanged += new System.EventHandler(this.home_username_TextChanged);
            // 
            // home_password
            // 
            this.home_password.Location = new System.Drawing.Point(145, 167);
            this.home_password.Name = "home_password";
            this.home_password.PasswordChar = '*';
            this.home_password.Size = new System.Drawing.Size(245, 36);
            this.home_password.TabIndex = 2;
            // 
            // home_title
            // 
            this.home_title.AutoSize = true;
            this.home_title.Font = new System.Drawing.Font("Calibri", 22.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.home_title.Location = new System.Drawing.Point(272, 25);
            this.home_title.Name = "home_title";
            this.home_title.Size = new System.Drawing.Size(135, 46);
            this.home_title.TabIndex = 3;
            this.home_title.Text = "OpenLL";
            this.home_title.Click += new System.EventHandler(this.home_title_Click);
            // 
            // home_description
            // 
            this.home_description.AutoSize = true;
            this.home_description.Font = new System.Drawing.Font("Calibri Light", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.home_description.Location = new System.Drawing.Point(383, 61);
            this.home_description.Name = "home_description";
            this.home_description.Size = new System.Drawing.Size(90, 21);
            this.home_description.TabIndex = 4;
            this.home_description.Text = "Local Life ...";
            // 
            // home_label_username
            // 
            this.home_label_username.AutoSize = true;
            this.home_label_username.Font = new System.Drawing.Font("Calibri Light", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.home_label_username.Location = new System.Drawing.Point(21, 123);
            this.home_label_username.Name = "home_label_username";
            this.home_label_username.Size = new System.Drawing.Size(81, 21);
            this.home_label_username.TabIndex = 5;
            this.home_label_username.Text = "Username";
            // 
            // home_label_password
            // 
            this.home_label_password.AutoSize = true;
            this.home_label_password.Font = new System.Drawing.Font("Calibri Light", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.home_label_password.Location = new System.Drawing.Point(22, 167);
            this.home_label_password.Name = "home_label_password";
            this.home_label_password.Size = new System.Drawing.Size(78, 21);
            this.home_label_password.TabIndex = 6;
            this.home_label_password.Text = "Password";
            // 
            // home_label_register
            // 
            this.home_label_register.AutoSize = true;
            this.home_label_register.Font = new System.Drawing.Font("Calibri Light", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.home_label_register.Location = new System.Drawing.Point(591, 446);
            this.home_label_register.Name = "home_label_register";
            this.home_label_register.Size = new System.Drawing.Size(120, 21);
            this.home_label_register.TabIndex = 7;
            this.home_label_register.Text = "Not a user yet ?";
            // 
            // home_button_register
            // 
            this.home_button_register.Font = new System.Drawing.Font("Calibri Light", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.home_button_register.Location = new System.Drawing.Point(592, 466);
            this.home_button_register.Name = "home_button_register";
            this.home_button_register.Size = new System.Drawing.Size(106, 30);
            this.home_button_register.TabIndex = 8;
            this.home_button_register.Text = "Register here";
            this.home_button_register.UseVisualStyleBackColor = true;
            this.home_button_register.Click += new System.EventHandler(this.home_button_register_Click);
            // 
            // home_label_status
            // 
            this.home_label_status.AutoSize = true;
            this.home_label_status.Location = new System.Drawing.Point(512, 378);
            this.home_label_status.Name = "home_label_status";
            this.home_label_status.Size = new System.Drawing.Size(0, 17);
            this.home_label_status.TabIndex = 9;
            // 
            // home_groupBox
            // 
            this.home_groupBox.Controls.Add(this.home_username);
            this.home_groupBox.Controls.Add(this.home_login);
            this.home_groupBox.Controls.Add(this.home_password);
            this.home_groupBox.Controls.Add(this.home_label_username);
            this.home_groupBox.Controls.Add(this.home_label_password);
            this.home_groupBox.Font = new System.Drawing.Font("Calibri Light", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.home_groupBox.Location = new System.Drawing.Point(305, 104);
            this.home_groupBox.Name = "home_groupBox";
            this.home_groupBox.Size = new System.Drawing.Size(424, 310);
            this.home_groupBox.TabIndex = 10;
            this.home_groupBox.TabStop = false;
            this.home_groupBox.Text = "Sign In";
            // 
            // home_pictureBox
            // 
            this.home_pictureBox.Image = global::MyTextEditor.Properties.Resources.openll_icon;
            this.home_pictureBox.Location = new System.Drawing.Point(19, 155);
            this.home_pictureBox.Name = "home_pictureBox";
            this.home_pictureBox.Size = new System.Drawing.Size(259, 240);
            this.home_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.home_pictureBox.TabIndex = 11;
            this.home_pictureBox.TabStop = false;
            // 
            // home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 525);
            this.Controls.Add(this.home_pictureBox);
            this.Controls.Add(this.home_groupBox);
            this.Controls.Add(this.home_label_status);
            this.Controls.Add(this.home_button_register);
            this.Controls.Add(this.home_label_register);
            this.Controls.Add(this.home_description);
            this.Controls.Add(this.home_title);
            this.Name = "home";
            this.Load += new System.EventHandler(this.home_Load);
            this.home_groupBox.ResumeLayout(false);
            this.home_groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.home_pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button home_login;
        private System.Windows.Forms.TextBox home_username;
        private System.Windows.Forms.TextBox home_password;
        private System.Windows.Forms.Label home_title;
        private System.Windows.Forms.Label home_description;
        private System.Windows.Forms.Label home_label_username;
        private System.Windows.Forms.Label home_label_password;
        private System.Windows.Forms.Label home_label_register;
        private System.Windows.Forms.Button home_button_register;
        private System.Windows.Forms.Label home_label_status;
        private System.Windows.Forms.GroupBox home_groupBox;
        private System.Windows.Forms.PictureBox home_pictureBox;
    }
}