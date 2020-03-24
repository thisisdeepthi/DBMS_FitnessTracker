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
        void check()
        {
            CheckBox box;
            for (int i = 0; i < 3; i++)
            {
                box = new CheckBox();
                box.Tag = i.ToString();
                box.Text = "a";
                box.AutoSize = true;
                box.Location = new Point(50, i * 25);//vertical
                box.Padding = new Padding(3); //box.Location = new Point(i * 50, 10); //horizontal
                this.Controls.Add(box);
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

        private void mustdo_Click(object sender, EventArgs e)
        {

        }

        private void dolist_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
