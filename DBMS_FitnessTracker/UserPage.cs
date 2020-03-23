using System.Windows.Forms;
using System.Collections.Specialized;
using System;
using MySql.Data.MySqlClient;
namespace DBMS_FitnessTracker
{
   


    public partial class UserPage : Form
    {
        public static string constr = "server=localhost;user id=root;database=ft;CharSet=utf8;persistsecurityinfo=True;password=swetha2000";
        MySqlConnection con1 = new MySqlConnection(constr);

        public UserPage()
        {
            InitializeComponent();
        }

        public int findUID()
        {
            try
            {
                con1.Open();
                string Query = "select max(userid)+1 from user";
                MySqlCommand cmd = new MySqlCommand(Query, con1);
                MySqlDataReader dr = cmd.ExecuteReader();
               
                if(dr.Read())
                {
                    con1.Close();
                    return dr.GetUInt16(0);

                }
               


            }
            catch(Exception er)
            {
                con1.Close();
                return 1;
            }

            con1.Close();
            return 1;


        }
        private void Save_Click(object sender, System.EventArgs e)
        {
            string gender = string.Empty;
            if (male.Checked && female.Checked)
                MessageBox.Show("Select one gender");
            if (male.Checked)
                gender = "Male";
            else if (female.Checked)
                gender = "Female";
            else
                MessageBox.Show("Please select a gender:");
            string age = agebox.Value.ToString();
            string height = ht.Value.ToString();
            string weight = wt.Value.ToString();
           
            string Query = "insert into user (userid,name,age,gender,phoneNo,email,height,weight,category) values ("+findUID()+",'" + name.Text + "'," + age + ",'" + gender + "','" + phone.Text + "','" + email.Text + "'," + height + "," + weight +",'"+ category.SelectedItem.ToString()+"');";
            MySqlCommand cmd = new MySqlCommand(Query, con1);


            try 
            {
                
                con1.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Saved Successfully");


            }
            catch (MySqlException error)
            {
                MessageBox.Show(error.Message);
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
            con1.Close();

        }

        private void UserPage_Load(object sender, EventArgs e)
        {

        }
    }
}
