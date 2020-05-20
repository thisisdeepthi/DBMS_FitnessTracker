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
            comboBox2.SelectedIndex = 1;
            FillDiet();
            Filldietgraph(DateTime.Now.Year.ToString(), DateTime.Now.Month.ToString());
            yrboxdiet.Text = DateTime.Now.Year.ToString();
            comboBoxdiet.SelectedIndex = DateTime.Now.Month;

        }

        private void Go_Click(object sender, EventArgs e)
        {
            FillDurGraph(yearBox.Text, comboBox1.SelectedIndex.ToString());
        }


        void FillDiet()
        {
            int timep = comboBox2.SelectedIndex;
            int Junk = 0, total = 0;
            double percent;
            string key = "";
            switch(timep)
            {
                case 1:
                    key = " and dietdate=curdate()";
                    break;

                case 2:
                    key = " and datediff(curdate(),dietdate) < 7";
                    break;
                case 3:
                    key = " and datediff(curdate(),dietdate) < 30 ";
                    break;
                case 4:
                    key = "";
                    break;
                default:
                    MessageBox.Show("Select some option ! ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
            }
            try
            {
                con1.Open();
                string q = "Select sum(NS) from cumDietChartReport where userid=" + userid + key;
                MySqlCommand cmd = new MySqlCommand(q, con1);
                MySqlDataReader dr = cmd.ExecuteReader();
                while(dr.Read())
                {
                    total = dr.GetInt32(0);
                    
                }
                dr.Close();
                q = "Select sum(NS) from CumDietChartReport c Join DietMaster d on d.dietid=c.dietid where d.isJunk ='Yes' and  userid =" + userid + key;
                cmd = new MySqlCommand(q, con1);
                dr = cmd.ExecuteReader();
                while(dr.Read())
                {
                    Junk = dr.GetInt32(0);
                }
                percent = (Junk * 1.00 / total) * 100;
                int p = Convert.ToInt32(percent);
                chart2.Series[0].Points.Clear();
                chart2.Series[0].IsVisibleInLegend = false;
                chart2.Series[0].Points.AddXY("Junk", p);
                chart2.Series[0].Points.AddXY("Healthy", 100 - p);
               


            }
            catch(Exception er)
            {
                MessageBox.Show(er.Message, "ERROR in DB", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con1.Close();


             
        }
        void Filldietgraph(string year, string month)
        {
            dietchart.Series[0].IsXValueIndexed = false;
            dietchart.Series[0].IsVisibleInLegend = false;
            dietchart.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
            dietchart.ChartAreas[0].AxisY.MajorGrid.LineWidth = 0;
            dietchart.Series[0].IsValueShownAsLabel = false;
            //Font f = new Font("Arial", 5, FontStyle.Bold);
            dietchart.ChartAreas[0].AxisX.LabelAutoFitMaxFontSize = 5;
            dietchart.ChartAreas[0].AxisY.LabelAutoFitMaxFontSize = 6;



            dietchart.Series[0].Points.Clear();
            try
            {
                int count = 1;
                con1.Open();
                string q = "select day(dietdate),sum(CI) from cumdietchartreport where userid=" + userid + " and month(dietdate)=" + month + " and year(dietdate)=" + year + " group by dietdate ;";
                MySqlCommand cmd = new MySqlCommand(q, con1);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    int date = dr.GetInt32(0);

                    double cal = dr.GetDouble(1);
                    while (date != count && count < 30)
                    {
                        dietchart.Series["Series1"].Points.AddXY(count, 0);
                        count++;
                    }
                    dietchart.Series["Series1"].Points.AddXY(date, cal);

                }
                while (count < 30)
                {
                    dietchart.Series["Series1"].Points.AddXY(count, 0);
                    count++;
                }




            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error in DB", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con1.Close();

        }

        private void Gobut_Click(object sender, EventArgs e)
        {
            Filldietgraph(yrboxdiet.Text, comboBoxdiet.SelectedIndex.ToString());
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillDiet();
        }

        private void CumulativeReport_Load(object sender, EventArgs e)
        {

        }

        void FillDurGraph(string year, string month)
        {
            chart1.Series[0].IsXValueIndexed = false;
            chart1.Series[0].IsVisibleInLegend = false;
            chart1.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
            chart1.ChartAreas[0].AxisY.MajorGrid.LineWidth = 0;
            chart1.Series[0].IsValueShownAsLabel = false;
            //Font f = new Font("Arial", 5, FontStyle.Bold);
            chart1.ChartAreas[0].AxisX.LabelAutoFitMaxFontSize = 5;
            chart1.ChartAreas[0].AxisY.LabelAutoFitMaxFontSize = 6;



            chart1.Series[0].Points.Clear();
            try
            {
                int count = 1;
                con1.Open();
                string q = "Select day(adate),dur,cal from cumdailydur where userid="+userid+" and month(adate)= "+month+" and year(adate)=  "+year;
                MySqlCommand cmd = new MySqlCommand(q, con1);
                MySqlDataReader dr = cmd.ExecuteReader();
                while(dr.Read())
                {
                    int date = dr.GetInt32(0);
                    int dur = dr.GetInt32(1);
                    double cal = dr.GetDouble(2);
                    while(date!=count && count<30)
                    {
                        chart1.Series["Series1"].Points.AddXY(count, 0);
                        count++;
                    }
                    chart1.Series["Series1"].Points.AddXY(date,dur);
                    
                }
                while(count<30)
                {
                    chart1.Series["Series1"].Points.AddXY(count, 0);
                    count++;
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
