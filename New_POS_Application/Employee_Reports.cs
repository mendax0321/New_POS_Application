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
    public partial class Employee_Reports : Form
    {
        public Employee_Reports()
        {
            InitializeComponent();
        }

        private void Employee_Reports_Load(object sender, EventArgs e)
        {

        }

        private void Search_btn_Click(object sender, EventArgs e)
        {/*
            try
            {
                if (Option_cbox.Text == "EMPLOYEE_NUMBER")
                {
                    payrol_db_connect.payrol_sql = "SELECT * FROM pos_empRegTbl WHERE emp_id
                   = '" + optionInputTxtbox.Text + "'";
     payrol_select();
                    InputBox();
                }
                else if (Option_cbox.Text == "SURNAME")
                {
                    payrol_db_connect.payrol_sql = "SELECT * FROM pos_empRegTbl WHERE
               emp_surname = '" + optionInputTxtbox.Text + "'";
                payrol_select();
                    InputBox();
                }
                else if (Option_cbox.Text == "FIRSTNAME")
                {
                    payrol_db_connect.payrol_sql = "SELECT * FROM pos_empRegTbl WHERE
               emp_fname = '" + optionInputTxtbox.Text + "'";
                payrol_select();
                    InputBox();
                }
                else if (Option_cbox.Text == "DEPARTMENT")
                {
                    payrol_db_connect.payrol_sql = "SELECT * FROM pos_empRegTbl WHERE
               emp_department = '" + optionInputTxtbox.Text + "'";
                payrol_select();
                    InputBox();
                }
                else if (Option_cbox.Text == "DESIGNATION")
                {
                    payrol_db_connect.payrol_sql = "SELECT * FROM pos_empRegTbl WHERE
               position = '" + optionInputTxtbox.Text + "'";
                payrol_select();
                    InputBox();
                }
                else if (Option_cbox.Text == "ZIPCODE")
                {
                    payrol_db_connect.payrol_sql = "SELECT * FROM pos_empRegTbl WHERE
               add_zipcode = '" + optionInputTxtbox.Text + "'";
                payrol_select();
                    InputBox();
                }
                else if (Option_cbox.Text == "PROVINCE")
                {
                    payrol_db_connect.payrol_sql = "SELECT * FROM pos_empRegTbl WHERE
               add_state_province = '" + optionInputTxtbox.Text + "'";
                payrol_select();
                    InputBox();
                }
                else if (Option_cbox.Text == "CITY")
                {
                    payrol_db_connect.payrol_sql = "SELECT * FROM pos_empRegTbl WHERE
               add_city = '" + optionInputTxtbox.Text + "'";
                payrol_select();
                    InputBox();
                }
                else
                {
                    MessageBox.Show("No Record Found!");
                }
            }
            catch
            {

            }*/
        }

        private void Back_btn_Click(object sender, EventArgs e)
        {
            try
            {
                clear();
            }
            catch
            {
                MessageBox.Show("Error Occured: Please contact your administrator!", "Error");
            }
        }

        // FUNCTIONS
        internal void clear()
        {
            Option_cbox.SelectedIndex = -1;
            Option_tbox.Clear();
            Option_cbox.Focus();
        }

        internal void InputBox()
        {
            Option_tbox.Clear();
            Option_tbox.Focus();
        }
    }
}
