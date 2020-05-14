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
    public partial class login : Form
    {
        public static string constr = System.Configuration.ConfigurationManager.ConnectionStrings["myConStr"].ConnectionString;
        MySqlConnection con1 = new MySqlConnection(constr);
        public login()
        {
            InitializeComponent();

        }

        private void login_Load(object sender, EventArgs e)
        {


        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (user.Text == "" || password.Text == "")
                    MessageBox.Show("Please enter all mandatory fields");
                else
                {
                    con1.Open();
                    string command = "select password from user where name='" + user.Text + "';";
                    MySqlCommand cmd = new MySqlCommand(command, con1);
                    MySqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        string pd = dr.GetString(0);
                        if (pd == password.Text)
                        {
                            //correct password
                            {
                                Program.userName = user.Text;
                                
                                //logout.Enabled = true;
                                this.Hide();

                                Welcome form1 = new Welcome();
                                form1.Closed += (s, args) => this.Close();

                                form1.Show();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Incorrect  password ! try again!!");
                        }

                    }
                    else
                    {
                        MessageBox.Show("Incorrect user name !", "Attention required");
                    }
                }

            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
            con1.Close();

           

        }
         
         

        

        private void button1_Click_1(object sender, EventArgs e)
        {
            NewUser form = new NewUser();
            form.Closed += (s, args) => this.Close();
            form.Show();
            this.Hide();
        }

    }
}
