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
        public static string constr1 = System.Configuration.ConfigurationManager.ConnectionStrings["myConStr"].ConnectionString;
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
           // condatabase.Open();
            //string Query="insert into activitychart"
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
