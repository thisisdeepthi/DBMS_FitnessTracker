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
        }
        void fillcombo()
        {
            string Query = "select * from ft.activitymaster";
            MySqlCommand cmdDatabase = new MySqlCommand(Query, condatabase);
            MySqlDataReader myReader;
            try
            {
                condatabase.Open();
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
                
        }

        private void ActLog_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void actsub_Click(object sender, EventArgs e)
        {
            
        }

        private void FillCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
