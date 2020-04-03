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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {
            if (Program.userName != "")
            { login1.Enabled = false; logout.Enabled = true; }
            else
            { logout.Enabled = false; login1.Enabled = true; }

        }


        private void button1_Click(object sender, EventArgs e)
        {
            Program.userName = user.Text;
            login1.Enabled = false;
            logout.Enabled = true;
            this.Hide();
            Welcome form1 = new Welcome();
            form1.Show();
        } 

        private void logout_Click(object sender, EventArgs e)
        {
            Program.userName = "";
            logout.Enabled = false;
            login1.Enabled = true;
        }
    }
}
