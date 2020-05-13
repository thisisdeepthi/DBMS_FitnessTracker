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
    public partial class CumulativeReport : Form
    {
        public static string constr = System.Configuration.ConfigurationManager.ConnectionStrings["myConStr"].ConnectionString;
        MySqlConnection con1 = new MySqlConnection(constr);
        public static string userid;
        public static double today, thisWeek, thisMonth, allTime;
        public CumulativeReport()
        {
            InitializeComponent();
            findUser();
            FillACT();
            FillDurGraph(DateTime.Now.Year.ToString(), DateTime.Now.Month.ToString());
            yearBox.Text = DateTime.Now.Year.ToString();
            comboBox1.SelectedIndex = DateTime.Now.Month;
        }

        private void Go_Click(object sender, EventArgs e)
        {
            FillDurGraph(yearBox.Text, comboBox1.SelectedIndex.ToString());
        }

        void FillDurGraph(string year, string month)
        {
            chart1.Series[0].IsXValueIndexed = false;
            chart1.Series[0].IsVisibleInLegend = false;
            chart1.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
            chart1.ChartAreas[0].AxisY.MajorGrid.LineWidth = 0;
            chart1.ChartAreas[0].AxisX.LabelStyle = new System.Windows.Forms.DataVisualization.Charting.LabelStyle() {
                Font = new Font("Verdana", 5f)
             };
            chart1.Series[0].Points.Clear();
            try
            {
                con1.Open();
                string q = "Select day(adate),dur,cal from cumdailydur where userid="+userid+" and month(adate)= "+month+" and year(adate)=  "+year;
                MySqlCommand cmd = new MySqlCommand(q, con1);
                MySqlDataReader dr = cmd.ExecuteReader();
                while(dr.Read())
                {
                    int date = dr.GetInt32(0);
                    int dur = dr.GetInt32(1);
                    double cal = dr.GetDouble(2);
                    chart1.Series["Series1"].Points.AddXY(date,dur);
                    
                }

               

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error in DB", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        void FillACT()
        {
            
            try
            {
                con1.Open();
                string Query = "select dur from cumDailyDur where Adate=curdate() and userid=" + userid;
                MySqlCommand cmd = new MySqlCommand(Query, con1);
                MySqlDataReader dr = cmd.ExecuteReader();
                while(dr.Read())
                {
                    today = dr.GetDouble(0);
                }
                dr.Close();
                Query = "select avg(dur) from cumdailydur where userid=" + userid + " and datediff(curdate(),adate)<7;";
                cmd = new MySqlCommand(Query, con1);
                dr = cmd.ExecuteReader();
                while(dr.Read())
                {
                    thisWeek = dr.GetDouble(0);
                }
                dr.Close();

                Query = "select avg(dur) from cumdailydur where userid=" + userid + " and datediff(curdate(),adate)<30;";
                cmd = new MySqlCommand(Query, con1);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    thisMonth = dr.GetDouble(0);
                }
                dr.Close();

                Query = "select avg(dur) from cumdailydur where userid=" + userid + ";";
                cmd = new MySqlCommand(Query, con1);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    allTime = dr.GetDouble(0);
                }
                dr.Close();


            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR in DB", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con1.Close();
            
            
            ad.Text = allTime.ToString();
            md.Text = thisMonth.ToString();
            wd.Text = thisWeek.ToString();
            tdur.Text = today.ToString();
           
        }
    }
}
