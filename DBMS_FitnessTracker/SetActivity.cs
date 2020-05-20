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
        public static string constr1 = System.Configuration.ConfigurationManager.ConnectionStrings["myConStr"].ConnectionString;
        MySqlConnection condatabase = new MySqlConnection(constr1);
        int j = 0,uid=0;
        public SetActivity()
        {
            InitializeComponent();
            FindingUser();
            goalselected(0);
            selectact();
            GoalDiet();
        }
        void goalselected(int i)
        {
            string Query;
            condatabase.Open();
            if (i == 0)
            {
                Query = "select * from ft.activitymaster where ActivityID in (select ActivityID from ft.mustdo where userid="+uid+") ;";
                
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
        void FindingUser()
        {

            condatabase.Open();
            string Query = "select * from user where name='" + Program.userName + "';";
            try
            {
                MySqlCommand cmd = new MySqlCommand(Query, condatabase);
                MySqlDataReader myReader = cmd.ExecuteReader();
                while (myReader.Read())
                {
                    uid = myReader.GetInt32("UserID");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
        void GoalDiet()
        {
            condatabase.Open();
            decimal gl=0; 
            string Query = "select * from user where Userid=" + uid + ";";
            try
            {
                MySqlCommand cmd = new MySqlCommand(Query, condatabase);
                MySqlDataReader myReader = cmd.ExecuteReader();
                while(myReader.Read())
                {
                     gl = myReader.GetDecimal("GoalCalorieIntake");
                }
                //string glS = Convert.ToString(gl);
                if(gl==0)
                {
                    AddDiet.Text = "ADD";
                }
                else
                {
                    DietGoal.Text = Convert.ToString(gl);
                    AddDiet.Text = "EDIT";
                    AddDietGoal.Text = "Calories To Be Taken-" + gl;
                    //SetUrGoal.Items.Add("Calories To Be Taken-"+gl);

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            condatabase.Close();

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            this.Controls.Clear();
            activityGoatEdit std = new activityGoatEdit();
            std.TopLevel = false;
            this.Controls.Add(std); 
            std.Show();
        }

        private void finish_Click(object sender, EventArgs e)
        {
            this.Close();
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
                    int id = 0;
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
            string Query1 = "select * from activitymaster a join mustdo m on a.activityid=m.activityid where userid="+uid+";";
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void AddDiet_Click(object sender, EventArgs e)
        {
           
            try
            {
                string goal = DietGoal.Text;
                int gl = Convert.ToInt32(goal);
                string Query = " update user set GoalCalorieIntake=" + gl + " where Userid=" + uid + ";";
                condatabase.Open();
                MySqlCommand cmd = new MySqlCommand(Query, condatabase);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Added successfully");
                AddDiet.Enabled = false;
                condatabase.Close();
                GoalDiet();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DietGoal_TextChanged(object sender, EventArgs e)
        {
            AddDiet.Enabled = true;
        }

        private void actdur_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
