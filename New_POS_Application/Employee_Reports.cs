using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace New_POS_Application
{
    public partial class Employee_Reports : Form
    {
        POS_dbconnect dbconnect = new POS_dbconnect();

        public Employee_Reports()
        {
            InitializeComponent();
        }

        private void Employee_Reports_Load(object sender, EventArgs e)
        {
            dbconnect.pos_connString();
            DefaultGrid();
        }

        private void Search_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (Option_cbox.Text == "EMPLOYEE_NUMBER")
                {
                    SearchFunction("emp_id");
                    InputBox();
                }
                else if (Option_cbox.Text == "SURNAME")
                {
                    SearchFunction("emp_surname");
                    InputBox();
                }
                else if (Option_cbox.Text == "FIRSTNAME")
                {
                    SearchFunction("emp_fname");
                    InputBox();
                }
                else if (Option_cbox.Text == "DEPARTMENT")
                {
                    SearchFunction("emp_department");
                    InputBox();
                }
                else if (Option_cbox.Text == "DESIGNATION")
                {
                    SearchFunction("emp_position");
                    InputBox();
                }
                else if (Option_cbox.Text == "ZIPCODE")
                {
                    SearchFunction("emp_zip");
                    InputBox();
                }
                else if (Option_cbox.Text == "PROVINCE")
                {
                    SearchFunction("emp_state");
                    InputBox();
                }
                else if (Option_cbox.Text == "CITY")
                {
                    SearchFunction("emp_city");
                    InputBox();
                }
                else
                {
                    MessageBox.Show("No Record Found!");
                }
            }
            catch
            {
                MessageBox.Show("Error Occured: Contact Your Administrator!");
            }
        }

        private void Back_btn_Click(object sender, EventArgs e)
        {
            try
            {
                DefaultGrid();
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

        internal void SearchFunction(string a)
        {
            dbconnect.pos_sql = "SELECT * FROM pos_empRegTbl WHERE " + a + " = @" + a;
            dbconnect.pos_cmd();
            dbconnect.pos_sql_command.Parameters.AddWithValue("@"+ a, Option_tbox.Text);
            dbconnect.pos_sqladapterSelect();
            dbconnect.pos_sqldatasetSELECT();
            GridView.DataSource = dbconnect.pos_sql_dataset.Tables[0];
        }

        internal void DefaultGrid()
        {
            dbconnect.pos_select_EmpReg();
            dbconnect.pos_cmd();
            dbconnect.pos_sqladapterSelect();
            dbconnect.pos_sqldatasetSELECT();
            GridView.DataSource = dbconnect.pos_sql_dataset.Tables[0];
        }
    }
}
