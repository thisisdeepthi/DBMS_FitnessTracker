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
       
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        } 

        private void Save_Click(object sender, EventArgs e)
        {
            string JUNK = string.Empty;
            if (YES.Checked && NO.Checked)
                MessageBox.Show("Select whether the food is junk or not");
            if (YES.Checked)
                JUNK = "YES";
            else if (NO.Checked)
                JUNK = "NO";
            else
                MessageBox.Show("Select yes or no");
            string label3 = textBox2.ToString();
            string carbo = textBox3.ToString();
            string pro = textBox4.ToString();
            string vit = textBox5.ToString();
            string fat = textBox6.ToString();
            string others = textBox7.ToString();

            string Query = "insert into DietMaster(name,carbo,pro,vit,fat,caloriesperserving,others,junk)values(" + res + ",'" + Name + "'," + carbo + "," + pro + "," + vit + "," + fat + "," + label3 + "," + others + ",'" + JUNK + "');";
            MySqlCommand cmd = new MySqlCommand(Query, con1);

            try
            {
                con1.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Details saved successfully");
                con1.Close();
                this.Close();
            }
            catch(MySqlException er)
            {
                MessageBox.Show(er.Message);
            }
            catch(SystemException err)
            {
                MessageBox.Show(err.Message);
            }
            con1.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

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
                    textBox1.AppendText(name);
                }
            }
            catch (MySqlException er)
            {
                MessageBox.Show(er.Message);
            }
            con1.Close();
        }

        private void ADDNEW_Enter(object sender, EventArgs e)
        {

        }
    }
}
