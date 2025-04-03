using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace New_POS_Application
{
    public partial class POS_Main: Form
    {
        POS_Class shortcut = new POS_Class();
        public POS_Main()
        {
            InitializeComponent();
        }

        private void cashier_btn_Click(object sender, EventArgs e)
        {
            POS_Cashier_Interface adminfrm = new POS_Cashier_Interface();
            adminfrm.Show();
        }

        private void pizza_btn_Click(object sender, EventArgs e)
        {
            POS_Ordering_App adminfrm = new POS_Ordering_App();
            adminfrm.Show();
        }

        private void payroll_btn_Click(object sender, EventArgs e)
        {
            POS_EmployeeSalary adminfrm = new POS_EmployeeSalary();
            adminfrm.Show();
        }

        private void pOSCashierToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pOSPIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            POS_Cashier_Interface adminfrm = new POS_Cashier_Interface();
            adminfrm.Show();
        }

        private void pOSOrderingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            POS_Ordering_App adminfrm = new POS_Ordering_App();
            adminfrm.Show();
        }

        private void payrollApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            POS_EmployeeSalary adminfrm = new POS_EmployeeSalary();
            adminfrm.Show();
        }

        private void pOSIncToolStripMenuItem_Click(object sender, EventArgs e)
        {
            POS_Cashier_Interface adminfrm = new POS_Cashier_Interface();
            adminfrm.Show();
        }

        private void pOSOrderingToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            POS_Ordering_App adminfrm = new POS_Ordering_App();
            adminfrm.Show();
        }

        private void tileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);

        }

        private void tileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);

        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            POS_Login loginpage = new POS_Login();
            loginpage.Show();
            this.Hide();
        }

        private void POS_Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            shortcut.exit();
        }
    }
}
