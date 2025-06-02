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
    public partial class POS_EmployeeRegistration: Form
    {
        POS_dbconnect dbconnect = new POS_dbconnect();
        POS_Class PC = new POS_Class();
        string picpath;
        public POS_EmployeeRegistration()
        {
            InitializeComponent();
            dbconnect.pos_connString();
            try
            {
                dbconnect.pos_select_EmpReg();
                dbconnect.pos_cmd();
                dbconnect.pos_sqladapterSelect();
                dbconnect.pos_sqldatasetSELECT();
                GridView.DataSource = dbconnect.pos_sql_dataset.Tables[0];
            }
            catch (Exception)
            {
                MessageBox.Show("Error occurs in this area. Please contact your administrator!");
            }
        }
        private void POS_EmployeeRegistration_Load(object sender, EventArgs e)
        {

        }

        private void LoadEmployeeData()
        {
            try
            {
                dbconnect.pos_select_EmpReg();
                dbconnect.pos_cmd();
                dbconnect.pos_sqladapterSelect();
                dbconnect.pos_sqldatasetSELECT();
                GridView.DataSource = dbconnect.pos_sql_dataset.Tables[0];
            }
            catch (Exception)
            {
                MessageBox.Show("Error loading employee data. Please contact your administrator.");
            }
        }
        private void BrowseButton_Click(object sender, EventArgs e)
        {
            try
            {
                PicFile.Filter = "Image File | * .gif; * .jpg; * .png; * .bmp; * .jfif;";
                PicFile.Title = "Select Picture";
                PicFile.ShowDialog();
                picpath = PicFile.FileName;
                picpath_tbox.Text = picpath;
                employeePictureBox.Image = Image.FromFile(picpath);
            }
            catch
            {
                MessageBox.Show("No Image Selected");
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            try
            {
                dbconnect.pos_sql = "SELECT * FROM pos_empRegTbl WHERE emp_id = @emp_id";
                dbconnect.pos_cmd();
                dbconnect.pos_sql_command.Parameters.AddWithValue("@emp_id", empIdTextBox.Text);
                dbconnect.pos_sqladapterSelect();
                dbconnect.pos_sqldatasetSELECT();

                if (dbconnect.pos_sql_dataset.Tables[0].Rows.Count > 0)
                {
                    DataRow row = dbconnect.pos_sql_dataset.Tables[0].Rows[0];
                    firstnameLabel.Text = row["emp_fname"].ToString();
                    middleNameLabel.Text = row["emp_mname"].ToString();
                    lastNameLabel.Text = row["emp_surname"].ToString();
                    ageTextBox.Text = row["emp_age"].ToString();
                    genderComboBox.Text = row["emp_gender"].ToString();
                    sssTextBox.Text = row["emp_sss_no"].ToString();
                    tinTextBox.Text = row["emp_tin_no"].ToString();
                    philhealthTextBox.Text = row["emp_philhealth_no"].ToString();
                    pagibigTextBox.Text = row["emp_pagibig_no"].ToString();
                    statusComboBox.Text = row["emp_status"].ToString();
                    heightTextBox.Text = row["emp_height"].ToString();
                    weightTextBox.Text = row["emp_weight"].ToString();
                    stayTextBox.Text = row["emp_yrsstay"].ToString();
                    houseNumberTextBox.Text = row["emp_house_no"].ToString();
                    subdivisionTextBox.Text = row["emp_subdivision"].ToString();
                    phaseTextBox.Text = row["emp_phase_no"].ToString();
                    streetTextBox.Text = row["emp_street"].ToString();
                    barangayTextBox.Text = row["emp_barangay"].ToString();
                    municipalityTextBox.Text = row["emp_municipality"].ToString();
                    cityTextBox.Text = row["emp_city"].ToString();
                    countryTextBox.Text = row["emp_country"].ToString();
                    stateTextBox.Text = row["emp_state"].ToString();
                    zipTextBox.Text = row["emp_zip"].ToString();
                    elemNameTextBox.Text = row["elem_name"].ToString();
                    elemAddressTextBox.Text = row["elem_address"].ToString();
                    elemYearGradTextBox.Text = row["elem_yr_grad"].ToString();
                    elemAwardTextBox.Text = row["elem_award"].ToString();
                    juniorHighNameTextBox.Text = row["junior_high_name"].ToString();
                    juniorHighAddressTextBox.Text = row["junior_high_address"].ToString();
                    juniorHighYearGradTextBox.Text = row["junior_high_yr_grad"].ToString();
                    juniorHighAwardTextBox.Text = row["junior_high_award"].ToString();
                    seniorHighNameTextBox.Text = row["senior_high_name"].ToString();
                    seniorHighAddressTextBox.Text = row["senior_high_address"].ToString();
                    seniorHighYearGradTextBox.Text = row["senior_high_yr_grad"].ToString();
                    seniorHighTrackTextBox.Text = row["senior_high_track"].ToString();
                    seniorHighAwardTextBox.Text = row["senior_high_award"].ToString();
                    collegeNameTextBox.Text = row["college_school_name"].ToString();
                    collegeAddressTextBox.Text = row["college_address"].ToString();
                    collegeYearGradTextBox.Text = row["college_yr_grad"].ToString();
                    collegeAwardTextBox.Text = row["college_award"].ToString();
                    collegeCourseTextBox.Text = row["college_course"].ToString();
                    othersTextBox.Text = row["others"].ToString();
                    positionTextBox.Text = row["emp_position"].ToString();
                    statusTextBox.Text = row["emp_status"].ToString();
                    dateHiredTextBox.Text = row["emp_datehired"].ToString();
                    departmentTextBox.Text = row["emp_department"].ToString();
                    dependentsTextBox.Text = row["emp_dependents"].ToString();
                    picpath_tbox.Text = row["picpath"].ToString();

                    employeePictureBox.Image = Image.FromFile(picpath_tbox.Text);
                }

                else
                {
                    MessageBox.Show("Employee not found.");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                dbconnect.pos_sql = @"INSERT INTO pos_empRegTbl
                    (emp_id, emp_fname, emp_mname, emp_surname, emp_age, emp_gender, emp_sss_no, emp_tin_no, emp_philhealth_no, emp_pagibig_no, emp_status,
                     emp_height, emp_weight, emp_yrsstay, emp_house_no, emp_subdivision, emp_phase_no, emp_street, emp_barangay, emp_municipality, emp_city,
                     emp_country, emp_state, emp_zip, elem_name, elem_address, elem_yr_grad, elem_award, junior_high_name, junior_high_address,
                     junior_high_yr_grad, junior_high_award, senior_high_name, senior_high_address, senior_high_yr_grad, senior_high_track, senior_high_award,
                     college_school_name, college_address, college_yr_grad, college_award, college_course, emp_position, emp_datehired, emp_department,
                     emp_dependents, others, picpath)
                    VALUES
                    (@emp_id, @emp_fname, @emp_mname, @emp_surname, @emp_age, @emp_gender, @emp_sss_no, @emp_tin_no, @emp_philhealth_no, @emp_pagibig_no, @emp_status,
                     @emp_height, @emp_weight, @emp_yrsstay, @emp_house_no, @emp_subdivision, @emp_phase_no, @emp_street, @emp_barangay, @emp_municipality, @emp_city,
                     @emp_country, @emp_state, @emp_zip, @elem_name, @elem_address, @elem_yr_grad, @elem_award, @junior_high_name, @junior_high_address,
                     @junior_high_yr_grad, @junior_high_award, @senior_high_name, @senior_high_address, @senior_high_yr_grad, @senior_high_track, @senior_high_award,
                     @college_school_name, @college_address, @college_yr_grad, @college_award, @college_course, @emp_position, @emp_datehired, @emp_department,
                     @emp_dependents, @others, @picpath)";

                dbconnect.pos_cmd();

                dbconnect.pos_sql_command.Parameters.Clear();
                dbconnect.pos_sql_command.Parameters.AddWithValue("@emp_id", empIdTextBox.Text);
                dbconnect.pos_sql_command.Parameters.AddWithValue("@emp_fname", firstNameTextBox.Text);
                dbconnect.pos_sql_command.Parameters.AddWithValue("@emp_mname", middleNameTextBox.Text);
                dbconnect.pos_sql_command.Parameters.AddWithValue("@emp_surname", lastNameTextBox.Text);
                dbconnect.pos_sql_command.Parameters.AddWithValue("@emp_age", Convert.ToInt32(ageTextBox.Text));
                dbconnect.pos_sql_command.Parameters.AddWithValue("@emp_gender", genderComboBox.Text);
                dbconnect.pos_sql_command.Parameters.AddWithValue("@emp_sss_no", sssTextBox.Text);
                dbconnect.pos_sql_command.Parameters.AddWithValue("@emp_tin_no", tinTextBox.Text);
                dbconnect.pos_sql_command.Parameters.AddWithValue("@emp_philhealth_no", philhealthTextBox.Text);
                dbconnect.pos_sql_command.Parameters.AddWithValue("@emp_pagibig_no", pagibigTextBox.Text);
                dbconnect.pos_sql_command.Parameters.AddWithValue("@emp_status", statusComboBox.Text);
                dbconnect.pos_sql_command.Parameters.AddWithValue("@emp_height", heightTextBox.Text);
                dbconnect.pos_sql_command.Parameters.AddWithValue("@emp_weight", weightTextBox.Text);
                dbconnect.pos_sql_command.Parameters.AddWithValue("@emp_yrsstay", stayTextBox.Text);
                dbconnect.pos_sql_command.Parameters.AddWithValue("@emp_house_no", houseNumberTextBox.Text);
                dbconnect.pos_sql_command.Parameters.AddWithValue("@emp_subdivision", subdivisionTextBox.Text);
                dbconnect.pos_sql_command.Parameters.AddWithValue("@emp_phase_no", phaseTextBox.Text);
                dbconnect.pos_sql_command.Parameters.AddWithValue("@emp_street", streetTextBox.Text);
                dbconnect.pos_sql_command.Parameters.AddWithValue("@emp_barangay", barangayTextBox.Text);
                dbconnect.pos_sql_command.Parameters.AddWithValue("@emp_municipality", municipalityTextBox.Text);
                dbconnect.pos_sql_command.Parameters.AddWithValue("@emp_city", cityTextBox.Text);
                dbconnect.pos_sql_command.Parameters.AddWithValue("@emp_country", countryTextBox.Text);
                dbconnect.pos_sql_command.Parameters.AddWithValue("@emp_state", stateTextBox.Text);
                dbconnect.pos_sql_command.Parameters.AddWithValue("@emp_zip", zipTextBox.Text);
                dbconnect.pos_sql_command.Parameters.AddWithValue("@elem_name", elemNameTextBox.Text);
                dbconnect.pos_sql_command.Parameters.AddWithValue("@elem_address", elemAddressTextBox.Text);
                dbconnect.pos_sql_command.Parameters.AddWithValue("@elem_yr_grad", elemYearGradTextBox.Text);
                dbconnect.pos_sql_command.Parameters.AddWithValue("@elem_award", elemAwardTextBox.Text);
                dbconnect.pos_sql_command.Parameters.AddWithValue("@junior_high_name", juniorHighNameTextBox.Text);
                dbconnect.pos_sql_command.Parameters.AddWithValue("@junior_high_address", juniorHighAddressTextBox.Text);
                dbconnect.pos_sql_command.Parameters.AddWithValue("@junior_high_yr_grad", juniorHighYearGradTextBox.Text);
                dbconnect.pos_sql_command.Parameters.AddWithValue("@junior_high_award", juniorHighAwardTextBox.Text);
                dbconnect.pos_sql_command.Parameters.AddWithValue("@senior_high_name", seniorHighNameTextBox.Text);
                dbconnect.pos_sql_command.Parameters.AddWithValue("@senior_high_address", seniorHighAddressTextBox.Text);
                dbconnect.pos_sql_command.Parameters.AddWithValue("@senior_high_yr_grad", seniorHighYearGradTextBox.Text);
                dbconnect.pos_sql_command.Parameters.AddWithValue("@senior_high_track", seniorHighTrackTextBox.Text);
                dbconnect.pos_sql_command.Parameters.AddWithValue("@senior_high_award", seniorHighAwardTextBox.Text);
                dbconnect.pos_sql_command.Parameters.AddWithValue("@college_school_name", collegeNameTextBox.Text);
                dbconnect.pos_sql_command.Parameters.AddWithValue("@college_address", collegeAddressTextBox.Text);
                dbconnect.pos_sql_command.Parameters.AddWithValue("@college_yr_grad", collegeYearGradTextBox.Text);
                dbconnect.pos_sql_command.Parameters.AddWithValue("@college_award", collegeAwardTextBox.Text);
                dbconnect.pos_sql_command.Parameters.AddWithValue("@college_course", collegeCourseTextBox.Text);
                dbconnect.pos_sql_command.Parameters.AddWithValue("@emp_position", positionTextBox.Text);
                dbconnect.pos_sql_command.Parameters.AddWithValue("@emp_datehired", dateHiredTextBox.Text);
                dbconnect.pos_sql_command.Parameters.AddWithValue("@emp_department", departmentTextBox.Text);
                dbconnect.pos_sql_command.Parameters.AddWithValue("@emp_dependents", dependentsTextBox.Text);
                dbconnect.pos_sql_command.Parameters.AddWithValue("@others", othersTextBox.Text);
                dbconnect.pos_sql_command.Parameters.AddWithValue("@picpath", picpath_tbox.Text);

                dbconnect.pos_sqladapterInsert();
                MessageBox.Show("Employee added successfully!");
                LoadEmployeeData();
                ClearFormFields();
                SetInitialControlStates();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error adding employee: " + ex.Message);
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                var confirmResult = MessageBox.Show("Are you sure to delete this employee?", "Confirm Delete!", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    dbconnect.pos_sql = "DELETE FROM pos_empRegTbl WHERE emp_id = @emp_id";
                    dbconnect.pos_cmd();
                    dbconnect.pos_sql_command.Parameters.Clear();
                    dbconnect.pos_sql_command.Parameters.AddWithValue("@emp_id", empIdTextBox.Text);
                    dbconnect.pos_sqladapterDelete();
                    MessageBox.Show("Employee deleted successfully!");
                    LoadEmployeeData();
                    ClearFormFields();
                    SetInitialControlStates();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting employee: " + ex.Message);
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            try
            {
                dbconnect.pos_sql = @"UPDATE pos_empRegTbl SET 
                    emp_fname = @emp_fname, emp_mname = @emp_mname, emp_surname = @emp_surname, emp_age = @emp_age, emp_gender = @emp_gender,
                    emp_sss_no = @emp_sss_no, emp_tin_no = @emp_tin_no, emp_philhealth_no = @emp_philhealth_no, emp_pagibig_no = @emp_pagibig_no,
                    emp_status = @emp_status, emp_height = @emp_height, emp_weight = @emp_weight, emp_yrsstay = @emp_yrsstay, emp_house_no = @emp_house_no,
                    emp_subdivision = @emp_subdivision, emp_phase_no = @emp_phase_no, emp_street = @emp_street, emp_barangay = @emp_barangay,
                    emp_municipality = @emp_municipality, emp_city = @emp_city, emp_country = @emp_country, emp_state = @emp_state, emp_zip = @emp_zip,
                    elem_name = @elem_name, elem_address = @elem_address, elem_yr_grad = @elem_yr_grad, elem_award = @elem_award,
                    junior_high_name = @junior_high_name, junior_high_address = @junior_high_address, junior_high_yr_grad = @junior_high_yr_grad, junior_high_award = @junior_high_award,
                    senior_high_name = @senior_high_name, senior_high_address = @senior_high_address, senior_high_yr_grad = @senior_high_yr_grad, senior_high_track = @senior_high_track, senior_high_award = @senior_high_award,
                    college_school_name = @college_school_name, college_address = @college_address, college_yr_grad = @college_yr_grad, college_award = @college_award,
                    college_course = @college_course, emp_position = @emp_position, emp_datehired = @emp_datehired, emp_department = @emp_department,
                    emp_dependents = @emp_dependents, others = @others, picpath = @picpath
                    WHERE emp_id = @emp_id";

                dbconnect.pos_cmd();

                dbconnect.pos_sql_command.Parameters.Clear();
                dbconnect.pos_sql_command.Parameters.AddWithValue("@emp_fname", firstNameTextBox.Text);
                dbconnect.pos_sql_command.Parameters.AddWithValue("@emp_mname", middleNameTextBox.Text);
                dbconnect.pos_sql_command.Parameters.AddWithValue("@emp_surname", lastNameTextBox.Text);
                dbconnect.pos_sql_command.Parameters.AddWithValue("@emp_age", Convert.ToInt32(ageTextBox.Text));
                dbconnect.pos_sql_command.Parameters.AddWithValue("@emp_gender", genderComboBox.Text);
                dbconnect.pos_sql_command.Parameters.AddWithValue("@emp_sss_no", sssTextBox.Text);
                dbconnect.pos_sql_command.Parameters.AddWithValue("@emp_tin_no", tinTextBox.Text);
                dbconnect.pos_sql_command.Parameters.AddWithValue("@emp_philhealth_no", philhealthTextBox.Text);
                dbconnect.pos_sql_command.Parameters.AddWithValue("@emp_pagibig_no", pagibigTextBox.Text);
                dbconnect.pos_sql_command.Parameters.AddWithValue("@emp_status", statusComboBox.Text);
                dbconnect.pos_sql_command.Parameters.AddWithValue("@emp_height", heightTextBox.Text);
                dbconnect.pos_sql_command.Parameters.AddWithValue("@emp_weight", weightTextBox.Text);
                dbconnect.pos_sql_command.Parameters.AddWithValue("@emp_yrsstay", stayTextBox.Text);
                dbconnect.pos_sql_command.Parameters.AddWithValue("@emp_house_no", houseNumberTextBox.Text);
                dbconnect.pos_sql_command.Parameters.AddWithValue("@emp_subdivision", subdivisionTextBox.Text);
                dbconnect.pos_sql_command.Parameters.AddWithValue("@emp_phase_no", phaseTextBox.Text);
                dbconnect.pos_sql_command.Parameters.AddWithValue("@emp_street", streetTextBox.Text);
                dbconnect.pos_sql_command.Parameters.AddWithValue("@emp_barangay", barangayTextBox.Text);
                dbconnect.pos_sql_command.Parameters.AddWithValue("@emp_municipality", municipalityTextBox.Text);
                dbconnect.pos_sql_command.Parameters.AddWithValue("@emp_city", cityTextBox.Text);
                dbconnect.pos_sql_command.Parameters.AddWithValue("@emp_country", countryTextBox.Text);
                dbconnect.pos_sql_command.Parameters.AddWithValue("@emp_state", stateTextBox.Text);
                dbconnect.pos_sql_command.Parameters.AddWithValue("@emp_zip", zipTextBox.Text);
                dbconnect.pos_sql_command.Parameters.AddWithValue("@elem_name", elemNameTextBox.Text);
                dbconnect.pos_sql_command.Parameters.AddWithValue("@elem_address", elemAddressTextBox.Text);
                dbconnect.pos_sql_command.Parameters.AddWithValue("@elem_yr_grad", elemYearGradTextBox.Text);
                dbconnect.pos_sql_command.Parameters.AddWithValue("@elem_award", elemAwardTextBox.Text);
                dbconnect.pos_sql_command.Parameters.AddWithValue("@junior_high_name", juniorHighNameTextBox.Text);
                dbconnect.pos_sql_command.Parameters.AddWithValue("@junior_high_address", juniorHighAddressTextBox.Text);
                dbconnect.pos_sql_command.Parameters.AddWithValue("@junior_high_yr_grad", juniorHighYearGradTextBox.Text);
                dbconnect.pos_sql_command.Parameters.AddWithValue("@junior_high_award", juniorHighAwardTextBox.Text);
                dbconnect.pos_sql_command.Parameters.AddWithValue("@senior_high_name", seniorHighNameTextBox.Text);
                dbconnect.pos_sql_command.Parameters.AddWithValue("@senior_high_address", seniorHighAddressTextBox.Text);
                dbconnect.pos_sql_command.Parameters.AddWithValue("@senior_high_yr_grad", seniorHighYearGradTextBox.Text);
                dbconnect.pos_sql_command.Parameters.AddWithValue("@senior_high_track", seniorHighTrackTextBox.Text);
                dbconnect.pos_sql_command.Parameters.AddWithValue("@senior_high_award", seniorHighAwardTextBox.Text);
                dbconnect.pos_sql_command.Parameters.AddWithValue("@college_school_name", collegeNameTextBox.Text);
                dbconnect.pos_sql_command.Parameters.AddWithValue("@college_address", collegeAddressTextBox.Text);
                dbconnect.pos_sql_command.Parameters.AddWithValue("@college_yr_grad", collegeYearGradTextBox.Text);
                dbconnect.pos_sql_command.Parameters.AddWithValue("@college_award", collegeAwardTextBox.Text);
                dbconnect.pos_sql_command.Parameters.AddWithValue("@college_course", collegeCourseTextBox.Text);
                dbconnect.pos_sql_command.Parameters.AddWithValue("@emp_position", positionTextBox.Text);
                dbconnect.pos_sql_command.Parameters.AddWithValue("@emp_datehired", dateHiredTextBox.Text);
                dbconnect.pos_sql_command.Parameters.AddWithValue("@emp_department", departmentTextBox.Text);
                dbconnect.pos_sql_command.Parameters.AddWithValue("@emp_dependents", dependentsTextBox.Text);
                dbconnect.pos_sql_command.Parameters.AddWithValue("@others", othersTextBox.Text);
                dbconnect.pos_sql_command.Parameters.AddWithValue("@picpath", picpath_tbox.Text);
                dbconnect.pos_sql_command.Parameters.AddWithValue("@emp_id", empIdTextBox.Text);
                dbconnect.pos_sqladapterUpdate();
                MessageBox.Show("Employee updated successfully!");
                LoadEmployeeData();
                ClearFormFields();
                SetInitialControlStates();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error updating employee: " + ex.Message);
            }
        }

        private void NewButton_Click(object sender, EventArgs e)
        {
            ClearFormFields();
            SetInitialControlStates();
        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // FUNCTIONS

        private void SetInitialControlStates()
        {
            AddButton.Enabled = true;
            EditButton.Enabled = false;
            DeleteButton.Enabled = false;
            ExitButton.Enabled = false;
        }

        private void ClearFormFields()
        {
            empIdTextBox.Clear();
            firstNameTextBox.Clear();
            middleNameTextBox.Clear();
            lastNameTextBox.Clear();
            ageTextBox.Clear();
            genderComboBox.SelectedIndex = -1;
            sssTextBox.Clear();
            tinTextBox.Clear();
            philhealthTextBox.Clear();
            pagibigTextBox.Clear();
            statusComboBox.SelectedIndex = -1;
            heightTextBox.Clear();
            weightTextBox.Clear();
            stayTextBox.Clear();
            houseNumberTextBox.Clear();
            subdivisionTextBox.Clear();
            phaseTextBox.Clear();
            streetTextBox.Clear();
            barangayTextBox.Clear();
            municipalityTextBox.Clear();
            cityTextBox.Clear();
            countryTextBox.Clear();
            stateTextBox.Clear();
            zipTextBox.Clear();
            elemNameTextBox.Clear();
            elemAddressTextBox.Clear();
            elemYearGradTextBox.ResetText();
            elemAwardTextBox.Clear();
            juniorHighNameTextBox.Clear();
            juniorHighAddressTextBox.Clear();
            juniorHighYearGradTextBox.ResetText();
            juniorHighAwardTextBox.Clear();
            seniorHighNameTextBox.Clear();
            seniorHighAddressTextBox.Clear();
            seniorHighYearGradTextBox.ResetText();
            seniorHighTrackTextBox.Clear();
            seniorHighAwardTextBox.Clear();
            collegeNameTextBox.Clear();
            collegeAddressTextBox.Clear();
            collegeYearGradTextBox.ResetText();
            collegeAwardTextBox.Clear();
            collegeCourseTextBox.Clear();
            othersTextBox.Clear();
            positionTextBox.Clear();
            statusTextBox.Clear();
            dateHiredTextBox.ResetText();
            departmentTextBox.Clear();
            dependentsTextBox.Clear();
        }
    }
}
