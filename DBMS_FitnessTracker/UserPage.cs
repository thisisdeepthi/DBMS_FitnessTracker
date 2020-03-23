using System.Windows.Forms;
using System.Collections.Specialized;
using System;
using MySql.Data.MySqlClient;
namespace DBMS_FitnessTracker
{
   


    public partial class UserPage : Form
    {
        public static string constr = System.Configuration.ConfigurationManager.ConnectionStrings["myConStr"].ConnectionString;
        MySqlConnection con1 = new MySqlConnection(constr);
        public static string res ;
        public UserPage()
        {
            InitializeComponent();
        }

        public int findUID()
        {
            return 0;
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
            
            string Query = "insert into user (userid,name,age,gender,phoneNo,email,height,weight,category) values ("+res+",'" + name.Text + "'," + age + ",'" + gender + "','" + phone.Text + "','" + email.Text + "'," + height + "," + weight +",'"+ category.SelectedItem.ToString()+"');";
            MySqlCommand cmd = new MySqlCommand(Query, con1);


            try 
            {
                
                con1.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Saved Successfully");
                con1.Close();
                this.Close();

            }
            catch (MySqlException error)
            {
                MessageBox.Show(error.Message);
            }
            catch (SystemException er)
            {
                MessageBox.Show(er.Message);
            }
            con1.Close();
            

        }

        private void Updatenew_Click(object sender, EventArgs e)
        {
            findUID();
        }
    }
}
