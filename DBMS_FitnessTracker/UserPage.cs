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
        public static string res ="1",dob="";
        public UserPage()
        {
            InitializeComponent();
        }

        public int findUID()
        {
            string cmds = "Select max(userid)+1 as id from user";
            MySqlCommand cmd = new MySqlCommand(cmds, con1);
            try
            {
                con1.Open();
                MySqlDataReader dr = cmd.ExecuteReader();
                
                if (dr.Read() && !dr.IsDBNull(0))
                {
                    res = dr.GetInt16(0).ToString();
                }


            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            con1.Close();
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
            
            string height = ht.Value.ToString();
            string weight = wt.Value.ToString();
            
            string Query = "insert into user (userid,name,dob,gender,phoneNo,email,height,weight,category) values ("+res+",'" + name.Text + "','" + dob + "','" + gender + "','" + phone.Text + "','" + email.Text + "'," + height + "," + weight +",'"+ category.SelectedItem.ToString()+"');";
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
            string cmds = "delete from user where name='" + name.Text + "',dob='" +agebox.Text+ "';";
            MySqlCommand cmd = new MySqlCommand(cmds, con1);
            try
            {
                con1.Open();
                cmd.ExecuteNonQuery();
                Save_Click(null,null);
                MessageBox.Show("Updated Successfully");
                con1.Close();
                this.Close();
            }
            catch(Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void agebox_ValueChanged(object sender, EventArgs e)
        {
            dob = agebox.Value.ToString("yyyy-MM-dd");
            MessageBox.Show(dob);
        }

        private void UserPage_Load(object sender, EventArgs e)
        {

        }

       
        private void category_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void wt_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ht_ValueChanged(object sender, EventArgs e)
        {

        }

        private void name_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
