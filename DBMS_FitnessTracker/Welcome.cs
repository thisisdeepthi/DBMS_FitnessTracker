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
        }

        

        private void profileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserPage Form1 = new UserPage();
            Form1.Show();
        }

        private void dailyReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DReport form1 = new DReport();
            form1.Show();
            //testttt
        }

        private void cumulativeReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CumulativeReport form1 = new CumulativeReport();
            form1.Show();
        }

        private void dietChartToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

       /* private void activityChartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActLog form1 = new ActLog();
            form1.Show();
        }
        */
        private void dietToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DietMaster form1 = new DietMaster();
            form1.Show();
        }

        private void activityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActivityMaster form2 = new ActivityMaster();
            form2.Show();
        }

        private void Welcome_Load(object sender, EventArgs e)
        {

        }

        private void dietChartToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            DietLog form1 = new DietLog();
            form1.Show();
        }
    }
}
