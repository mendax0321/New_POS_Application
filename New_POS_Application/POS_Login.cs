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
    public partial class POS_Login: Form
    {
        POS_Class shortcut = new POS_Class();
        public POS_Login()
        {
            InitializeComponent();
        }

        private void POS_Login_Load(object sender, EventArgs e)
        {
            this.AcceptButton = LogIn_btn;
            Password_tbox.Focus();
        }

        private void LogIn_btn_Click(object sender, EventArgs e)
        {
            string username, password;
            password = "systemad12345";
            username = "admin";
            if (usernameTxtbox.Text == username && Password_tbox.Text == password)
            {
                MessageBox.Show("You are successfully accessing your homepage!!!");
                POS_Main adminfrm = new POS_Main();
                adminfrm.Show();
                clearbox();
                this.Hide();
            }
            else if (usernameTxtbox.Text == "cashierresto" && Password_tbox.Text == "resto123")
            {
                MessageBox.Show("Welcome Cashier Point of Sale Page");
                POS_Cashier_Interface_Class cashierfrm = new POS_Cashier_Interface_Class();
                cashierfrm.Show();
                clearbox();
            }
            else if (usernameTxtbox.Text == "cashierpizza" && Password_tbox.Text == "pizza123")
            {
                MessageBox.Show("Welcome Cashier Ordering POS Page");
                POS_Ordering_App_Class cashierfrm = new POS_Ordering_App_Class();
                cashierfrm.Show();
                clearbox();
            }
            else if (usernameTxtbox.Text == "payroll" && Password_tbox.Text == "emppayroll123")
            {
                MessageBox.Show("Welcome Payrol Page");
                POS_EmployeeSalary_Class payrolfrm = new POS_EmployeeSalary_Class();
                payrolfrm.Show();
                clearbox();
            }
            else
            {
                MessageBox.Show("Invalid user account. Please contact your administrator!!!");
                clearbox();
                usernameTxtbox.Focus();
            }

        }

        private void Cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void POS_Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            shortcut.exit();
        }

        internal void clearbox()
        {
            Password_tbox.Clear();
            usernameTxtbox.Clear();
        }
    }
}
