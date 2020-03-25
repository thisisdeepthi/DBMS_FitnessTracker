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
    public partial class ActLog : Form
    {
        public static string constr1= "server=localhost;user id=root;database=ft;CharSet=utf8;persistsecurityinfo=True;password=harshini_27";
        MySqlConnection condatabase = new MySqlConnection(constr1);
        public ActLog()
        {
            InitializeComponent();
            fillcombo();
            check();
            ActDone();
        }
        void fillcombo()
        {
            condatabase.Open();
            string Query = "select * from ft.activitymaster";
            MySqlCommand cmdDatabase = new MySqlCommand(Query, condatabase);
            MySqlDataReader myReader;
            try
            {
                myReader = cmdDatabase.ExecuteReader();
                while(myReader.Read())
                {
                    string sName = myReader.GetString("ActivityName");
                    actiname.Items.Add(sName);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            condatabase.Close();  
        }
        void check()
        {
            int i = 0;
            condatabase.Open();
            string Query = "select * from ft.mustdo;";
            MySqlCommand cmddb = new MySqlCommand(Query, condatabase);
            MySqlDataReader myReader;
            try
            {
                CheckBox box;
                myReader = cmddb.ExecuteReader();
                while (myReader.Read())
                {
                    string sId = myReader.GetString("ActivityID");
                    box = new CheckBox();
                    box.Tag = i.ToString();
                    box.Text = "a";
                    box.AutoSize = true;
                    box.Location = new Point(75, i * 25);
                    box.Padding = new Padding(3); //box.Location = new Point(i * 50, 10); //horizontal
                    this.Controls.Add(box);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            condatabase.Close();               
        }
       
        private void ActLog_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void actsub_Click(object sender, EventArgs e)
        {
            int logno=0,id=0,CaloriesBurnt=0;
            string intensity=" ";
            //To insert the logno into the activitychart table
            condatabase.Open();
            string Query = "select max(LogNo)+1 as Log from activitychart;";
            MySqlCommand cmd = new MySqlCommand(Query, condatabase);
            MySqlDataReader myReader;
            try
            {
                //condatabase.Open();
                myReader = cmd.ExecuteReader();
                while (myReader.Read())
                {
                    logno = myReader.GetInt32("Log");
                }
                
            }
            catch(Exception er)
            { 
                MessageBox.Show(er.Message);
            }
            condatabase.Close();
            condatabase.Open();
            //To get activity id from master table using activity name
            Query ="select * from activitymaster where activityname='"+actiname.Text +"' ;";
           cmd = new MySqlCommand(Query, condatabase);
            try
            {
                // 
                // 
                myReader = cmd.ExecuteReader();
                while (myReader.Read())
                {
                    id = myReader.GetInt32("ActivityID");
                }
               // condatabase.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            condatabase.Close();
            //To get type of activity(high or low)
            if (workhigh.Checked && worklow.Checked)
                MessageBox.Show("Select Anyone type");
            else if (workhigh.Checked)
                intensity = workhigh.Text;
            else if (worklow.Checked)
                intensity = worklow.Text;
            else
                MessageBox.Show("Please Enter the Woerkout Intensity");
            //To calculate the Calories burnt
            string duration = "";
            duration=actdur1.Text;
            int x = Convert.ToInt32(duration);
            
            condatabase.Open();
            Query = "select CaloriesPerMin from activitymaster where activityname='"+actname.Text+"';";
            try
            {
                //condatabase.Open();
                cmd = new MySqlCommand(Query, condatabase);
                myReader = cmd.ExecuteReader();
                while (myReader.Read())
                {
                    CaloriesBurnt =  myReader.GetInt32("CaloriesPerMin");
                }
                int temp = x * CaloriesBurnt;
              // MessageBox.Show("Result is" + temp +" "+x +" "+CaloriesBurnt);
                //condatabase.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            condatabase.Close();
            condatabase.Open();
            Query ="insert into activitychart(LogNo,Adate,AID,Duration,Type,CaloriesBurnt,UserID,Remark) values("+ logno + ",CURDATE(),"+id+","+x+",'"+intensity+"',"+CaloriesBurnt+",1,'"+actrem1.Text+"');";
            try
            {
               // condatabase.Open();
                cmd = new MySqlCommand(Query,condatabase);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Saved Successfully");
                //condatabase.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            condatabase.Close();
        }

        private void FillCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void mustdo_Click(object sender, EventArgs e)
        {

        }

        private void dolist_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void history_Click(object sender, EventArgs e)
        {

        }
        void ActDone()
        {
            condatabase.Open();
            string Query = "select * from activitymaster natural join mustdo where userID=2;";
            MySqlCommand cmd = new MySqlCommand(Query,condatabase);
            MySqlDataReader myReader;
            myReader = cmd.ExecuteReader();
            while(myReader.Read())
            {
                string sName = myReader.GetString("ActivityName");
                acthis.Items.Add(sName);
            }
            condatabase.Close();
        }
    }
}
