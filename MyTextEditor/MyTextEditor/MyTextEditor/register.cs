using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace MyTextEditor
{
    public partial class register : Form
    {
        public register()
        {
           InitializeComponent();
        }

        private void register_button_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            new home().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = register_textBox_name.Text;
            string username = register_textBox_username.Text;
            string password = register_textBox_password.Text;
            string confirmpass = register_textBox_confirmpass.Text;

            if(password.Equals(confirmpass))
            {
                string query = "insert into auth values('" + username + "','" + name + "','" + password + "');";
                try
                {
                    string connStr = "server=localhost;user=root;database=openll;port=3306;password=password";
                    MySqlConnection conn = new MySqlConnection(connStr);
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    conn.Open();
                    int data = cmd.ExecuteNonQuery();
                    register_label_status.Text = "Registration Successful.";
                    makeDirectory(username);
                    conn.Close();
                }
                catch (Exception ex)
                {
                    register_label_status.Text ="Username already exists!";
                }
            }
            else
            {
                register_label_status.Text = "Passwords do not Match!!";
            }
        }

        private static void makeDirectory(String uname)
        {
            string path = @"c:\Openll\"+uname;
            string pathString = @"c:\Openll\" + uname +"\\Master";
            string pathString2 = @"c:\Openll\" + uname + "\\Branch";
            System.IO.Directory.CreateDirectory(path);
            System.IO.Directory.CreateDirectory(pathString);
            System.IO.Directory.CreateDirectory(pathString2);
        }

        private void register_Load(object sender, EventArgs e)
        {

        }
    }
}
