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
    public partial class home : Form
    {
        static bool isLoggedIn=false;
        public home()
        {
            InitializeComponent();
           // dataClass.instancePass = this;
        }

        private void home_title_Click(object sender, EventArgs e)
        {

        }

        private void home_username_TextChanged(object sender, EventArgs e)
        {

        }

        private void home_login_Click(object sender, EventArgs e)
        {
            isLoggedIn = false;
           string username = home_username.Text;
            string pword = home_password.Text;
            try
            {
                string connStr = "server=localhost;user=root;database=openll;port=3306;password=password";
                MySqlConnection conn = new MySqlConnection(connStr);
             //   string cmdText = "INSERT INTO (name, roll) VALUES ('Nishu', 456)";
                string loginQuery = "select * from auth where username='"+username+"' and password='"+pword+"';";
                MySqlCommand cmd = new MySqlCommand(loginQuery, conn);
                conn.Open();
               MySqlDataReader dataReader = cmd.ExecuteReader();
               
                while (dataReader.Read())
                {
                    //   ReadSingleRow((IDataRecord)dataReader);
                    home_description.Text = "Inside read";
                    //   MessageBox.Show("");
                    //  MessageBox.Show(dataReader["password"].ToString());
                    string unameauth = dataReader["username"].ToString();
                    dataClass.username = unameauth;
                    dataClass.name = dataReader["name"].ToString();
                    dataClass.password = dataReader["password"].ToString();

                    if(unameauth.Equals(username))
                    {
                        home_description.Text = "Successfull";
                        isLoggedIn = true;
                    }
                  
                }

                // Call Close when done reading.
                dataReader.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
             // = ex.ToString();
            }

           // home_description.Text = isLoggedIn == true ? "Success" : "Fail";
            if (isLoggedIn)
            {
                /*
                               dashboard dash= new dashboard();
                                dash.Parent = this;
                                dash.ShowDialog();
                                this.Hide();
                                */

                new dashboard().Show();
               
            }
            else
            {
                home_label_status.Text = "Please try again.";
            }
        }

        private void home_button_register_Click(object sender, EventArgs e)
        {
            this.Hide();
            new register().Show();
        }

        private void home_Load(object sender, EventArgs e)
        {

        }
    }
}
