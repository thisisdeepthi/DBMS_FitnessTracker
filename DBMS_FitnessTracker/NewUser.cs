using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DBMS_FitnessTracker
{
    public partial class NewUser : Form
    {

        public static string username = "";
        public static string password = "";


        public NewUser()
        {
            InitializeComponent();
        }
       
        private void createAccnt_Click(object sender, EventArgs e)
        {
            if (userName.Text == "")
                MessageBox.Show("Please do enter user name it is mandatory!");
            else if (pwd.Text == "")
                MessageBox.Show("Password Mandatory!");
            else if (newPwd.Text != pwd.Text)
                MessageBox.Show("Re enter password carefully!");
           else
            {
                UserPage Form1 = new UserPage();
                MessageBox.Show("Please enter all essential details now !!");
                username = userName.Text;
                password = pwd.Text;
                Program.userName = username;

                Form1.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
                Form1.Show();
                this.Close();
                
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            login form1 = new login();
            form1.Show();
            this.Close();
        }
    }
}
