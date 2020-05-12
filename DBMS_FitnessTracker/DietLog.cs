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
    public partial class DietLog : Form
    {
        public static string constr = System.Configuration.ConfigurationManager.ConnectionStrings["myConStr"].ConnectionString;
        //private readonly object dietname;
        MySqlConnection con1 = new MySqlConnection(constr);
        int logno1 = 0, check = 0;
        int uid = 0;

        public DietLog()
        {
            InitializeComponent();
            fillcombo();
            FindingUser();
            dietintake();

        }


        void FindingUser()
        {

            con1.Open();
            string Query = "select * from user where name='" + Program.userName + "';";
            try
            {
                MySqlCommand cmd = new MySqlCommand(Query, con1);
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
            con1.Close();
        }

        void fillcombo()
        {
            con1.Open();
            string Query = "select * from ft.dietmaster";
            MySqlCommand cmdDatabase = new MySqlCommand(Query, con1);
            MySqlDataReader myReader;
            try
            {
                myReader = cmdDatabase.ExecuteReader();
                while (myReader.Read())
                {
                    string sName = myReader.GetString("DietName");
                    diet.Items.Add(sName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con1.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int logno = 0, id = 0, carbo = 0, protein = 0, vitamin = 0, fat = 0, calories = 0;
            con1.Open();
            string Query = "select max(LogNo)+1 as Log from dietchart;";
            MySqlCommand cmd = new MySqlCommand(Query, con1);
            MySqlDataReader myReader;
            try
            {

                myReader = cmd.ExecuteReader();
                while (myReader.Read())
                {
                    logno = myReader.GetInt32("Log");
                }

            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
            con1.Close();
            con1.Open();
            //To get activity id from master table using activity name
            Query = "select * from dietmaster where dietname='" + diet.Text + "' ;";
            cmd = new MySqlCommand(Query, con1);
            try
            {
                // 
                // 
                myReader = cmd.ExecuteReader();
                while (myReader.Read())
                {
                    id = myReader.GetInt32("DietID");
                }
                // con1.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con1.Close();
            


            con1.Open();
            Query = "select carbo,protein,vitamin,fat,caloriesperS from dietmaster where dietname='" + diet.Text + "';";


            try
            {
                //condatabase.Open();
                cmd = new MySqlCommand(Query, con1);
                myReader = cmd.ExecuteReader();
                while (myReader.Read())
                {
                    carbo = myReader.GetInt32("Carbo");
                    protein = myReader.GetInt32("Protein");
                    vitamin = myReader.GetInt32("Vitamin");
                    fat = myReader.GetInt32("Fat");
                   // junk = myReader.GetInt32("Junk tilll now");
                    calories = myReader.GetInt32("CaloriesperS");
                }

               
                // MessageBox.Show("Result is" + temp +" "+x +" "+CaloriesBurnt);
                //condatabase.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con1.Close();
            con1.Open();
            string serve = serving_no.Value.ToString();
            int x = Convert.ToInt32(serve);
            int c = x * carbo;
            int p = x * protein;
            int v = x * vitamin;
            int f = x * fat;
           // int j = x * junk;
            int ca = x * calories;
            carbo_in.Text = c.ToString();
            protein_in.Text = p.ToString();
            vitamin_in.Text = v.ToString();
            fat_in.Text = f.ToString();
            //junks.Text = j.ToString();
            cal_in.Text = ca.ToString();
            Query = "insert into dietchart(LogNo,Dietdate,DietID,noofservings,carbo,protein,vitamin,fat,calories,userID,Remark) values(" + logno + ",CURDATE()," + id + "," + x + ",'" + c + "'," + p + "," + v + "," + f + "," + ca + "," + uid + ",'" + remarks.Text + "');";
            try
            {

                cmd = new MySqlCommand(Query, con1);
                cmd.ExecuteNonQuery();
                con1.Close();
                //dietintake();
                MessageBox.Show("Saved Successfully");
                //condatabase.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void serving_no_ValueChanged(object sender, EventArgs e)
        {

        }

        private void carbo_in_TextChanged(object sender, EventArgs e)
        {

        }

       
        void dietintake()
        {
            con1.Open();
            string Query = "";
            if (logno1 == 0)
            {
                Query = "select * from dietmaster natural join dietchart where dietdate=CURDATE() and userid=" + uid + " and logno=" + logno1 + ";";

            }
            else
            {
                Query = "select * from dietmaster natural join dietchart  where dietdate=CURDATE() and userid=" + uid + " and logno=" + logno1 + ";";

            }
            MySqlCommand cmd = new MySqlCommand(Query, con1);
            MySqlDataReader myReader = cmd.ExecuteReader();
            while (myReader.Read())
            {
                string sName = myReader.GetString("DietName");
                //diettoday.Items.Add(sName);


                //diettoday.Items.Add("Carbohydrates" + " - " + carbo + " mins ");
                //diettoday.SetItemChecked(check, true);
                logno1++;
                check++;
            }
            con1.Close();
        }
    }



}


