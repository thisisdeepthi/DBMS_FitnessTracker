using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBMS_FitnessTracker
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
            testToolStripMenuItem.Text = "Welcome " + Program.userName;
           
        }

        

        private void profileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            UserPage Form1 = new UserPage();
            Form1.TopLevel = false;
            panel1.Controls.Add(Form1);
            Form1.Show();
        }

        private void dailyReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            DReport form1 = new DReport();
            form1.TopLevel = false;
            panel1.Controls.Add(form1);
            form1.Show();
            
        }

       
        private void dietChartToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            DietLog dietlog = new DietLog();
            dietlog.TopLevel = false;
            panel1.Controls.Add(dietlog);
            dietlog.Show();
        }

        private void activityGoalsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            SetActivity set1 = new SetActivity();
            set1.TopLevel = false;
            panel1.Controls.Add(set1);
            set1.Show();
        }

        private void activityToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            ActivityMaster master = new ActivityMaster();
            master.TopLevel = false;
            panel1.Controls.Add(master);
            master.Show();
        }

        
        private void Welcome_Load(object sender, EventArgs e)
        {
            
        }
       

        
        private void dietToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

            panel1.Controls.Clear();
            DietMaster master = new DietMaster();
            master.TopLevel = false;
            panel1.Controls.Add(master);
            master.Show();
        }

        private void activityChartToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            ActLog form1 = new ActLog();
            form1.TopLevel = false;
            panel1.Controls.Add(form1);
            form1.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void editProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            UserPage Form1 = new UserPage();
            Form1.TopLevel = false;
            panel1.Controls.Add(Form1);
            Form1.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.userName = "";
            login newform = new login();
            newform.Show();
            this.Close();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            changepwd Form1 = new changepwd ();
            Form1.Show();
            this.Close();
        }

        private void cumulativeReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            CumulativeReport form1 = new CumulativeReport();
            form1.TopLevel = false;
            panel1.Controls.Add(form1);
            form1.Show();
        }
    }
}
