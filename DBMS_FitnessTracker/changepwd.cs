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
    public partial class changepwd : Form
    {
        public static string constr = System.Configuration.ConfigurationManager.ConnectionStrings["myConStr"].ConnectionString;
        MySqlConnection con1 = new MySqlConnection(constr);
        public changepwd()
        {
            InitializeComponent();
        }

        private void changeP_Click(object sender, EventArgs e)
        {
            if (userName.Text == "")
                MessageBox.Show("Please do enter user name it is mandatory!");
            else if (pwd.Text == "")
                MessageBox.Show("Password Mandatory!");
            else if (newPwd.Text != pwd.Text)
                MessageBox.Show("Re enter password carefully!");
            else
            {
                try
                {
                    con1.Open();
                    string cmdstr = "update user set password ='" + pwd.Text + "' where name='" + userName.Text + "';";
                    MySqlCommand cmd = new MySqlCommand(cmdstr, con1);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Password changed successfully!!", "Change Password");
                    Welcome newform = new Welcome();
                    newform.Show();
                    this.Close();

                }
                catch(Exception test)
                {
                    MessageBox.Show("Unable to change the password due to error! " + test.Message);
                }

            }
        }

        private void changepwd_Load(object sender, EventArgs e)
        {
            userName.Text = Program.userName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Welcome newformm = new Welcome();
            newformm.Show();
            this.Close();
        }
    }
}
