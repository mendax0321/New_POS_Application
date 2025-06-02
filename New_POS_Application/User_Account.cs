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
using Image = System.Drawing.Image;

namespace New_POS_Application
{
    public partial class User_Account : Form
    {
        POS_dbconnect dbconnect = new POS_dbconnect();

        public User_Account()
        {
            InitializeComponent();
            try
            {
                dbconnect.pos_connString();
                DefaultGrid();
            }
            catch (Exception)
            {
                MessageBox.Show("Error Occurred: Please contact your administrator!");
            }
        }

        private void Search_btn_Click(object sender, EventArgs e)
        {
            try
            {
                dbconnect.pos_sql = "SELECT emp_id, emp_fname, emp_mname, emp_surname, position, picpath FROM " +
                    "useraccountTbl WHERE user_id = @user_id";
                dbconnect.pos_cmd();
                dbconnect.pos_sql_command.Parameters.AddWithValue("@emp_id", EmployeeID_tbox.Text);
                dbconnect.pos_sqladapterSelect();
                dbconnect.pos_sqldatasetSELECT();

                if (dbconnect.pos_sql_dataset.Tables[0].Rows.Count > 0)
                {
                    DataRow row = dbconnect.pos_sql_dataset.Tables[0].Rows[0];
                    Fname_tbox.Text = row["emp_fname"].ToString();
                    Mname_tbox.Text = row["emp_mname"].ToString();
                    Sname_tbox.Text = row["emp_surname"].ToString();
                    Designation_tbox.Text = row["emp_position"].ToString();
                    Picpath_tbox.Text = row["picpath"].ToString();

                    pictureBox1.Image = Image.FromFile(Picpath_tbox.Text);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error Occurred: Please contact your administrator!");
            }
        }

        private void SFU_btn_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception)
            {
                MessageBox.Show("Error Occurred: Please contact your administrator!");
            }
        }

        private void Update_btn_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception)
            {
                MessageBox.Show("Error Occurred: Please contact your administrator!");
            }
        }

        private void Delete_btn_Click(object sender, EventArgs e)
        {
            try
            {
                var confirmResult = MessageBox.Show("Are you sure to delete this employee?", "Confirmation", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    dbconnect.pos_sql = "DELETE FROM useraccountTbl WHERE user_id = @user_id";
                    dbconnect.pos_cmd();
                    dbconnect.pos_sql_command.Parameters.Clear();
                    dbconnect.pos_sql_command.Parameters.AddWithValue("@user_id", UserID_tbox.Text);
                    dbconnect.pos_sqladapterDelete();
                    MessageBox.Show("Account Deleted successfully!");
                    DefaultGrid();
                    Clear();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error Occurred: Please contact your administrator!");
            }
        }

        private void Submit_btn_Click(object sender, EventArgs e)
        {
            try
            {
                dbconnect.pos_sql = @"INSERT INTO useraccountTbl
                    (user_id, account_type, username, password, confirm_password, user_status, emp_id)
                    VALUES
                    (@user_id, @account_type, @username, @password, @confirm_password, @user_status, @emp_id)";
                dbconnect.pos_cmd();

                dbconnect.pos_sql_command.Parameters.Clear();
                dbconnect.pos_sql_command.Parameters.AddWithValue("@user_id", UserID_tbox.Text);
                dbconnect.pos_sql_command.Parameters.AddWithValue("@account_type", AccType_cbox.Text);
                dbconnect.pos_sql_command.Parameters.AddWithValue("@username", Username_tbox.Text);
                dbconnect.pos_sql_command.Parameters.AddWithValue("@password", Password_tbox.Text);
                dbconnect.pos_sql_command.Parameters.AddWithValue("@confirm_password", ConfirmPass_tbox.Text);
                dbconnect.pos_sql_command.Parameters.AddWithValue("@user_status", Status_cbox.Text);
                dbconnect.pos_sql_command.Parameters.AddWithValue("@emp_id", EmployeeID_tbox.Text);
                dbconnect.pos_sqladapterInsert();

                DefaultGrid();
                Clear();
            }
            catch (Exception)
            {
                MessageBox.Show("Error Occurred: Please contact your administrator!");
            }
        }

        private void New_btn_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void Exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Password_tbox_Click(object sender, EventArgs e)
        {
            Password_tbox.Clear();
        }

        private void ConfirmPass_tbox_Click(object sender, EventArgs e)
        {
            ConfirmPass_tbox.Clear();
        }

        // FUNCTIONS

        internal void Clear()
        {
            EmployeeID_tbox.Clear();
            UserID_tbox.Clear();

            Fname_tbox.Text = "Firstname";
            Mname_tbox.Text = "Middlename";
            Sname_tbox.Text = "Surname";
            Password_tbox.Text = "Password";
            ConfirmPass_tbox.Text = "Confirm Password";

            Status_cbox.SelectedIndex = -1;
            AccType_cbox.SelectedIndex = -1;
        }

        internal void DefaultGrid()
        {
            dbconnect.pos_sql = "SELECT pos_empRegTbl.emp_id, emp_fname, emp_mname, emp_surname, " +
                "position, user_id, username, password, user_status, account_type FROM pos_empRegTbl " +
                "INNER JOIN useraccountTbl ON pos_empRegTbl.emp_id = useraccountTbl.emp_id";
            dbconnect.pos_cmd();
            dbconnect.pos_sqladapterSelect();
            dbconnect.pos_sqldatasetSELECT();
            GridView.DataSource = dbconnect.pos_sql_dataset.Tables[0];
        }
    }
}