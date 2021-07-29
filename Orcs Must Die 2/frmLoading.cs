using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Orcs_Must_Die_2
{
    public partial class frmLoading : Form
    {
        public frmLoading()
        {
            InitializeComponent();
        }

        private void frmLoading_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Process[] pname = Process.GetProcessesByName("OrcsMustDie2");
            if (pname.Length == 0)
            {
                textBox_Status.Text = "Wait Game Process";
            }else
            {
                timer1.Stop();
                frmMain fMain = new frmMain();
                fMain.Show();
                this.Hide();
            }
        }
    }
}
