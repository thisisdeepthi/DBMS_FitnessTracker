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
    public partial class DietMaster : Form
    {
        public static string constr = System.Configuration.ConfigurationManager.ConnectionStrings["myConStr"].ConnectionString;
        MySqlConnection con1 = new MySqlConnection(constr);
        public static string res;
        public DietMaster()
        {
            InitializeComponent();

        }
       
       
       

        private void DietMaster_Load(object sender, EventArgs e)
        {

        }

        private void EXISTING_Enter(object sender, EventArgs e)
        {

            string cmds = "select * from ft.DietMaster";
            MySqlCommand cmd = new MySqlCommand(cmds, con1);
            MySqlDataReader reader;
            try
            {
                con1.Open();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string name = reader.GetString("DietName");
                    DietName.AppendText(name);
                }
            }
            catch (MySqlException er)
            {
                MessageBox.Show(er.Message);
            }
            con1.Close();
        }

        private void Save_Click_1(object sender, EventArgs e)
        {
            string JUNK = string.Empty;
            if (Yes.Checked && No.Checked)
                MessageBox.Show("Select whether the food is junk or not! Enter one value please!");
            if (Yes.Checked)
                JUNK = "YES";
            else if (No.Checked)
                JUNK = "NO";
            else
                MessageBox.Show("Select yes or no");
            string calories = cal.ToString();
            string car = carbo.ToString();
            string pro = prot.ToString();
            string vitamin = vit.ToString();
            string fats = fat.ToString();
            //string others = textBox7.ToString();

            string Query = "insert into DietMaster(name,carbo,pro,vit,fat,caloriesperserving,junk)values(" + res + ",'" + Name + "'," + car + "," + pro + "," + vitamin + "," + fats + "," + calories +  ",'" + JUNK + "');";
            MySqlCommand cmd = new MySqlCommand(Query, con1);

            try
            {
                con1.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Details saved successfully");
                con1.Close();
                this.Close();
            }
            catch (MySqlException er)
            {
                MessageBox.Show(er.Message);
            }
            catch (SystemException err)
            {
                MessageBox.Show(err.Message);
            }
            con1.Close();

        }

       
    }
}
