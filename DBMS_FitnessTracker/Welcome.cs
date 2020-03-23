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
            MessageBox.Show("Hiii"); 
        }

        

        private void profileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserPage Form1 = new UserPage();
            Form1.Show();
        }

        private void activityChartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActLog actlog = new ActLog();
            actlog.TopLevel = false;
            this.Controls.Clear();
            this.Controls.Add(actlog);
            actlog.Show();

        }
    }
}
