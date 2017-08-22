namespace MyTextEditor
{
    partial class dashboard
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
            this.dashboard_label_welcome = new System.Windows.Forms.Label();
            this.dashboard_label_name = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.select = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fileName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dashboard_label_welcome
            // 
            this.dashboard_label_welcome.AutoSize = true;
            this.dashboard_label_welcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.dashboard_label_welcome.Location = new System.Drawing.Point(25, 34);
            this.dashboard_label_welcome.Name = "dashboard_label_welcome";
            this.dashboard_label_welcome.Size = new System.Drawing.Size(120, 29);
            this.dashboard_label_welcome.TabIndex = 0;
            this.dashboard_label_welcome.Text = "Welcome";
            // 
            // dashboard_label_name
            // 
            this.dashboard_label_name.AutoSize = true;
            this.dashboard_label_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.dashboard_label_name.Location = new System.Drawing.Point(22, 73);
            this.dashboard_label_name.Name = "dashboard_label_name";
            this.dashboard_label_name.Size = new System.Drawing.Size(0, 48);
            this.dashboard_label_name.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(382, 409);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.select,
            this.fileName});
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(318, 200);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(202, 178);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // select
            // 
            this.select.Text = "Sr. No.";
            // 
            // fileName
            // 
            this.fileName.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(337, 461);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 548);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dashboard_label_name);
            this.Controls.Add(this.dashboard_label_welcome);
            this.Name = "dashboard";
            this.Text = "dashboard";
            this.Load += new System.EventHandler(this.dashboard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label dashboard_label_welcome;
        private System.Windows.Forms.Label dashboard_label_name;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader select;
        private System.Windows.Forms.ColumnHeader fileName;
        private System.Windows.Forms.Label label1;
    }
}