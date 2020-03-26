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
    public partial class SetActivity : Form
    {
        public static string constr1 = "server=localhost;user id=root;database=ft;CharSet=utf8;persistsecurityinfo=True;password=harshini_27";
        MySqlConnection condatabase = new MySqlConnection(constr1);
        int j = 0;
        public SetActivity()
        {
            InitializeComponent();
            
            goalselected(0);
            selectact();
        }
        void goalselected(int i)
        {
            string Query;
            condatabase.Open();
            if (i == 0)
            {
                Query = "select * from ft.activitymaster where ActivityID in (select ActivityID from ft.mustdo where userid=3) ;";
                
            }
            else
            {
                 Query = "select * from ft.activitymaster where ActivityID=" + i + "; ";

            }
            MySqlCommand cmd = new MySqlCommand(Query, condatabase);
            MySqlDataReader myReader;
            myReader = cmd.ExecuteReader();
            
            while (myReader.Read())
            {
                string sName = myReader.GetString("ActivityName");
                SetUrGoal.Items.Add(sName);
                SetUrGoal.SetItemChecked(j, true);
                j++;
            }
            condatabase.Close();
        }

        private void SetActivity_Load(object sender, EventArgs e)
        {

        }
        void selectact()
        {
            condatabase.Open();
            string Query = "select * from activitymaster;";
            MySqlCommand cmd = new MySqlCommand(Query,condatabase);
            MySqlDataReader myReader;
            myReader = cmd.ExecuteReader();
            while(myReader.Read())
            {
                string sName = myReader.GetString("ActivityName");
                actname.Items.Add(sName);
            }
            condatabase.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            standard_diet_log std = new standard_diet_log();
            std.Show();
        }

        private void finish_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Finished successfully");
        }

     
      

        private void SetUrGoal_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void addact_Click(object sender, EventArgs e)
        {
            condatabase.Open();           
              string sName = actname.Text;
                string Query = "select * from ft.activitymaster where ActivityName='" + sName + "';";
                MySqlCommand cmddb = new MySqlCommand(Query, condatabase);
                MySqlDataReader myReader;
                try
                {
                    int id = 0, uid = 3;
                    myReader = cmddb.ExecuteReader();
                    while (myReader.Read())
                    {
                        id = myReader.GetInt32("ActivityID");
                        condatabase.Close();
                        goalselected(id);
                        break;

                    }
                    condatabase.Open();
                    if (id != 0)
                    {
                        string Query3 = "insert into ft.mustdo values(" + uid + "," + id + "," + actdur.Text + ")";
                        MySqlCommand cmd = new MySqlCommand(Query3, condatabase);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Saved Successfully");
                    }
                    condatabase.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            

            // string Query1 = "insert into user(;";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Saved successfully");
                    
        }

        private void actname_SelectedIndexChanged(object sender, EventArgs e)
        {
            int flag = 0;
            condatabase.Open(); 
            string Query1 = "select * from activitymaster a join mustdo m on a.activityid=m.activityid where userid=3;";
            MySqlCommand cmd = new MySqlCommand(Query1, condatabase);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string actname1 = reader.GetString("Activityname");
                if (actname.Text == actname1)
                {
                    flag = 1;
                    addact.Enabled = false;
                    MessageBox.Show("" + actname.Text + " is already there");
                    break;
                }
                else
                    addact.Enabled = true;
            }
            condatabase.Close();
        }

        private void actdur_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
