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
    public partial class DReport : Form
    {
        public static string constr = System.Configuration.ConfigurationManager.ConnectionStrings["myConStr"].ConnectionString;
        MySqlConnection con1 = new MySqlConnection(constr);
        public string userid = "";
        public static int i = 0;
        public double calToday = 0.0,goals=0.0;
        public double c, v, p, f, o;
        public DReport()
        {
            InitializeComponent();
            findUser();
            Console.WriteLine("initialised n found userid");
            CreateControls();
            GenerateGrid1();
            GenerateGrid2();
            GeneratePie();
            FillJunkBox();
           
        }
        void FillJunkBox()
        {
            try
            {
                int i = 1;
                con1.Open();
                string query = "select distinct a.Dietid,b.dietname from dietchart a join dietmaster b on a.dietid=b.dietid where b.isjunk='Yes' and a.dietdate=curdate() and userid=" + userid + " ; ";
                MySqlCommand cmd = new MySqlCommand(query, con1);
                MySqlDataReader dr = cmd.ExecuteReader();
                while(dr.Read())
                {
                    string junk1 = dr.GetString(1);                    
                    listBox1.Items.Add(i.ToString() + ". " + junk1);
                    i++;
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error in DB", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con1.Close();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        void GeneratePie()
        {
            chart1.Titles.Add("Nutrient Proportion");
            
            try
            {
                con1.Open();
                string query = "Select * from dietcharttoday where userid=" + userid;
                MySqlCommand cmd = new MySqlCommand(query, con1);
                MySqlDataReader dr = cmd.ExecuteReader();
                while(dr.Read())
                {
                    c = dr.GetDouble("c");
                    p = dr.GetDouble("p");
                    v = dr.GetDouble("v");
                    f = dr.GetDouble("f");
                    o = (dr.IsDBNull(5)) ? 0.00: dr.GetDouble("o");
                    calToday = dr.GetDouble("cal");
                    
                }
                dr.Close();

            }catch(Exception es)
            { MessageBox.Show(es.Message, "Error in DB", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            try
            {
                string query = "select GoalCalorieIntake  from user where userid=" + userid;
                MySqlCommand cmd = new MySqlCommand(query, con1);
                MySqlDataReader dr = cmd.ExecuteReader();
                while(dr.Read())
                {
                    goals = dr.GetDouble(0);
                }

            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message, "Error in DB", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con1.Close();
            chart1.Series[0].IsValueShownAsLabel = false;
            //chart1.Series[0].IsXValueIndexed = true;
            chart1.Series[0].Points.AddXY("Carbo", c);
            chart1.Series[0].Points.AddXY("Protein", p);
            chart1.Series[0].Points.AddXY("Vit", v);
            chart1.Series[0].Points.AddXY("Fat", f);
            chart1.Series[0].Points.AddXY("Others", o);
            progressBar1.Maximum = Convert.ToInt32(goals);
           
                int calDis = Convert.ToInt32(calToday);
            DESC.Text = "Consumed " + calToday.ToString() + " out of " + goals.ToString();
            if (calDis>progressBar1.Maximum)
            {
                progressBar1.Value = progressBar1.Maximum;
                MessageBox.Show("You Have EATEN EXCESS! ", "More cal today", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DESC.Text += "You have EATEN EXCESS";
            }
            else
            {
                progressBar1.Value = calDis;
            }
            
           
        }
        void GenerateGrid1()
        {
            string cmdstr = "select activityname as Activity,duration as Duration,caloriesburnt as Calories from activitychart join activitymaster on activitychart.aid = activitymaster.activityid where type = 'Low' and userid = " + userid+" and adate = curdate()";
            MySqlCommand cmd = new MySqlCommand(cmdstr, con1);
            try
            {
                con1.Open();
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                low.DataSource = dt;
                da.Dispose();
                cmd.Dispose();
            }
            catch(MySqlException er)
            {
                MessageBox.Show(er.Message);
            }
            con1.Close();
        }
        void GenerateGrid2()
        {
            string cmdstr = "select activityname as Activity,duration as Duration ,caloriesburnt as Calories from activitychart join activitymaster on activitychart.aid = activitymaster.activityid where type = 'High' and userid = " + userid + " and adate = curdate()";
            MySqlCommand cmd = new MySqlCommand(cmdstr, con1);
            try
            {
                con1.Open();
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                high.DataSource = dt;
                da.Dispose();
                cmd.Dispose();
            }
            catch (MySqlException er)
            {
                MessageBox.Show(er.Message);
            }
            con1.Close();


        }
        void CreateControls()
        {
            Label label,l1,l2,l3;
            i = 0;
            Console.WriteLine("starting query execution");
            string query = "select activityname as ACT,actduration as goal ,dur from dailyrep natural join activitymaster where userid ="+userid;
            Console.WriteLine(query);
            MySqlCommand cmd = new MySqlCommand(query, con1);
            try
            {
                con1.Open();
                MySqlDataReader dr = cmd.ExecuteReader();
                while(dr.Read())
                {
                    Console.WriteLine("hello everyone");
                    i++;
                    label = new Label();
                    label.Name = "Act" + i.ToString();
                    label.Text = dr.GetString("ACT");
                    label.AutoSize = true;
                    label.Location = new Point(16, 75 + 25 * i);
                    
                    this.groupBox1.Controls.Add(label);

                    l1 = new Label();
                    l1.Name = "g" + i.ToString();
                    l1.Text = dr.GetString("goal");
                    l1.Location = new Point(96, 75 + 25 * i);
                     l1.AutoSize = true;
                   
                    this.groupBox1.Controls.Add(l1);

                    l2 = new Label();
                    l2.Name = "d" + i.ToString();
                    string val;
                    if (!dr.IsDBNull(2))
                        val = dr.GetString(2);
                    else
                        val = "0";
                    l2.Text = val;
                    l2.AutoSize = true;
                    l2.Location = new Point(169, 75 + 25 * i);
                   
                    this.groupBox1.Controls.Add(l2);

                    l3 = new Label();
                    l3.Name = "con" + i.ToString();
                    int diff = int.Parse(l2.Text) - int.Parse(l1.Text);
                    if(diff<0)
                    {
                        //bad n lazy
                        l3.Text = "NOT achieved";
                        l3.ForeColor = System.Drawing.Color.Red;
                    }
                    else if(diff >0)
                    {
                        //fitness freak
                        l3.Text = "Achieved more";
                        l3.ForeColor = System.Drawing.Color.Green;

                    }
                    else
                    {
                        l3.Text = "OK";
                        l3.ForeColor = System.Drawing.Color.Blue;
                        //Normal
                    }

                    l3.AutoSize = true;
                    l3.Location = new Point(243, 75 + 25 * i);
                   
                    this.groupBox1.Controls.Add(l3);
                }
                         

            }
            catch(MySqlException er)
            {
                MessageBox.Show(er.Message);
                
                con1.Close();
            }
            con1.Close();

        }

        
        void findUser()
        {
            //find userid
            if (Program.userName == "")
            { MessageBox.Show("Please Login to view the report !"); this.Close(); }

            else
            {
                string q = "select userid from user where name ='" + Program.userName + "'";
                try
                {
                    con1.Open();
                    MySqlCommand cmd = new MySqlCommand(q, con1);
                    MySqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        userid = dr.GetString(0);

                    }

                }
                catch (MySqlException er)
                {
                    con1.Close();
                }
                con1.Close();
            }

        }

        
    }
}
