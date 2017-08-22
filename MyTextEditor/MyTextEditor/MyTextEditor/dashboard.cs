using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyTextEditor
{
    public partial class dashboard : Form
    {
        public dashboard()
        {
            InitializeComponent();
            dashboard_label_name.Text = dataClass.name;

        }

        private void dashboard_Load(object sender, EventArgs e)
        {

            DirectoryInfo d = new DirectoryInfo(@"C:\Openll\" + dataClass.username);//Assuming Test is your Folder
            FileInfo[] Files = d.GetFiles("*.txt"); //Getting Text files
            string str = "";
            ListViewItem lv;
            int i = 1;
            foreach (FileInfo file in Files)
            {
                lv = new ListViewItem(Convert.ToString(i), 0);
                i++;
                lv.SubItems.Add(file.Name);

                listView1.Items.Add(lv);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {/*
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = "c:\\Openll\\"+dataClass.username;
            ofd.ShowDialog();
            */


            //  label1.Text = str;
            string name = listView1.SelectedItems[0].SubItems[1].Text;
            label1.Text=name;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
