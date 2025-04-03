using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace New_POS_Application
{
    public partial class POS_EmployeeSalary_Class : Form
    {
        POS_Class PC = new POS_Class();
        private string picpath;
        private Double basic_netincome = 0.00,
        basic_numhrs = 0.00,
       basic_rate = 0.00,
        hono_netincome = 0.00,
        hono_numhrs = 0.00,
       hono_rate = 0.00,
       other_netincome = 0.00,
       other_numhrs = 0.00,
       other_rate = 0.00;

        private Double netincome = 0.00,
        grossincome = 0.00,
       sss_contrib = 0.00,
       pagibig_contrib = 0.00,
       philhealth_contrib = 0.00,
       tax_contrib = 0.00;

        private Double sss_loan = 0.00,
        pagibig_loan = 0.00,
       salary_loan = 0.00,
       salary_savings = 0.00,
       faculty_sav_loan = 0.00,
       other_deduction = 0.00,
       total_deduction = 0.00,
       total_contrib = 0.00,
        total_loan = 0.00;

        private void Others_cbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (Others_cbox.SelectedItem)
            {
                case "Other 1":
                    {
                        others_loanTxtbox.Text = "500.00";
                        break;
                    }
                case "Other 2":
                    {
                        others_loanTxtbox.Text = "550.00";
                        break;
                    }
                case "Other 3":
                    {
                        others_loanTxtbox.Text = "1550.00";
                        break;
                    }
                case "Other 4":
                    {
                        others_loanTxtbox.Text = "1250.00";
                        break;
                    }
                case "None":
                    {
                        others_loanTxtbox.Text = "0";
                        break;
                    }
                default:
                    {
                        MessageBox.Show("No other loan option selected!");
                        break;
                    }
            }
            form_calculate();
        }

        private void SSSLoan_tbox_TextChanged(object sender, EventArgs e)
        {
            form_calculate();
        }

        private void PagibigLoan_tbox_TextChanged(object sender, EventArgs e)
        {
            form_calculate();
        }

        private void FacSavDep_tbox_TextChanged(object sender, EventArgs e)
        {
            form_calculate();
        }

        private void FacSavLoan_tbox_TextChanged(object sender, EventArgs e)
        {
            form_calculate();
        }

        private void SalaryLoan_tbox_TextChanged(object sender, EventArgs e)
        {
            form_calculate();
        }

        private double CalculateWithholdingTax(double semiMonthlySalary)
        {
            foreach (var bracket in PC.taxBrackets)
            {
                if (semiMonthlySalary <= bracket[0])
                {
                    return (bracket.Length > 3 ? bracket[3] : 0) + (semiMonthlySalary - bracket[1]) * bracket[2];
                }
            }

            return 0.0; // Default case, should never reach
        }

        public POS_EmployeeSalary_Class()
        {
            InitializeComponent();
        }

        private void POS_EmployeeSalary_Load(object sender, EventArgs e)
        {
            form_default();
        }
       

        //Button Click Event
        private void Calculate_btn_Click(object sender, EventArgs e)
        {
            form_calculate();
        }

        private void Browse_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog PicFile = new OpenFileDialog();
            PicFile.Filter = "Image File | * .gif; * .jpg; * .png; * .bmp;";
            PicFile.Title = "Select Employee Picture";
            PicFile.ShowDialog();
            picpath = PicFile.FileName;
            picpath_tbox.Text = picpath;
            picbox.Image = Image.FromFile(picpath);
        }     
        
        private void Print_btn_Click(object sender, EventArgs e)
        {
            POS_PrintEmpSal PrntFrm = new POS_PrintEmpSal();
            PrntFrm.PrintDisplay_listbox.Items.AddRange(this.payslip_listbox.Items);
            PrntFrm.ShowDialog();
        }

        private void Preview_btn_Click(object sender, EventArgs e)
        {
            preview();
        }

        private void New_btn_Click(object sender, EventArgs e)
        {
            form_default();
        }

        private void Cancel_btn_Click(object sender, EventArgs e)
        {
            form_default();
        }

        private void Exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Textbox Change
        private void BP_NumOfHours_tbox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                basic_numhrs = Double.Parse(BP_NumOfHours_tbox.Text);
                basic_rate = Convert.ToDouble(BP_Rate_tbox.Text);
                basic_netincome = PC.ES_Income(basic_numhrs, basic_rate);
                BP_Income_tbox.Text = basic_netincome.ToString("n");
                form_calculate();
            }
            catch 
            {
                BP_Rate_tbox.Clear();
                BP_NumOfHours_tbox.Clear();
                BP_Income_tbox.Clear();
            }

        }

        private void H_NumOfHours_tbox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                hono_numhrs = Convert.ToDouble(H_NumOfHours_tbox.Text);
                hono_rate = Convert.ToDouble(H_Rate_tbox.Text);
                hono_netincome = PC.ES_Income(hono_numhrs, hono_rate);
                H_TotalHonPay_tbox.Text = hono_netincome.ToString("n");
                form_calculate();
            }
            catch
            {
                H_NumOfHours_tbox.Clear();
                H_Rate_tbox.Clear();
                H_TotalHonPay_tbox.Clear();
            }
        }

        private void OI_NumOfHours_tbox_TextChanged(object sender, EventArgs e)
        {
            form_calculate();
        }

        //Functions
        private void form_calculate()
        {
            try
            {
                
                other_numhrs = Convert.ToDouble(OI_NumOfHours_tbox.Text);
                other_rate = Convert.ToDouble(OI_rate_tbox.Text);
                other_netincome = PC.ES_Income(other_numhrs, other_rate);
                OI_TotalIncPay_tbox.Text = other_netincome.ToString("n");
                grossincome = basic_netincome + hono_netincome + other_netincome;
                Gross_tbox.Text = grossincome.ToString("n");
                if (!double.TryParse(Gross_tbox.Text, out grossincome))
                {
                    grossincome = 0.00;
                }
                sss_contrib = grossincome > 0 ? PC.CalculateSSS(grossincome) : 0.00;
                philhealth_contrib = grossincome > 0 ? PC.CalculatePhilHealth(grossincome) : 0.00;
                pagibig_contrib = grossincome > 0 ? PC.CalculatePagIBIG(grossincome) : 0.00;
                tax_contrib = grossincome > 0 ? PC.CalculateWithholdingTax(grossincome) : 0.00;

                SSSContr_tbox.Text = sss_contrib.ToString("n");
                PhilCont_tbox.Text = philhealth_contrib.ToString("n");
                PagibigCont_tbox.Text = pagibig_contrib.ToString("n");
                Tax_tbox.Text = tax_contrib.ToString("n");

                sss_loan = Convert.ToDouble(SSSLoan_tbox.Text);
                pagibig_loan = Convert.ToDouble(PagibigLoan_tbox.Text);
                salary_loan = Convert.ToDouble(SalaryLoan_tbox.Text);
                faculty_sav_loan = Convert.ToDouble(FacSavLoan_tbox.Text);
                salary_savings = Convert.ToDouble(FacSavDep_tbox.Text);
                other_deduction = Convert.ToDouble(others_loanTxtbox.Text);
                //formula to compute the desired data to be computed
                total_contrib = PC.TotalContrib(sss_contrib, pagibig_contrib, philhealth_contrib, tax_contrib);
                total_loan = PC.TotalLoan(sss_loan, pagibig_loan, salary_loan, faculty_sav_loan, salary_savings, other_deduction);
                total_deduction = PC.TotalDeduc(total_contrib, total_loan);
                //codes for converting numeric data to string and displayed it inside the textboxes
                TotalDeduc_tbox.Text = total_deduction.ToString("n");
                netincome = grossincome - total_deduction;
                NetIncome_tbox.Text = netincome.ToString("n");
            }
            catch
            {
                OI_NumOfHours_tbox.Clear();
                OI_rate_tbox.Clear();
                OI_TotalIncPay_tbox.Clear();
                Gross_tbox.Clear();
            }
        }
        private void preview()
        {
            payslip_listbox.Items.Clear();
            payslip_listbox.Items.Add("Employee Number : " + " " + EmpNum_tbox.Text);
            payslip_listbox.Items.Add("Firstname : " + " " + FN_tbox.Text);
            payslip_listbox.Items.Add("Middlename : " + "" + MN_tbox.Text);
            payslip_listbox.Items.Add("Surname : " + "" + LN_tbox.Text);
            payslip_listbox.Items.Add("Designation : " + "" + Desig_tbox.Text);
            payslip_listbox.Items.Add("Employee Status : " + "" + EmpStat_tbox.Text);
            payslip_listbox.Items.Add("Department : " + "" + Department_tbox.Text);
            payslip_listbox.Items.Add("Pay Date : " + "" + datepick.Text);
            payslip_listbox.Items.Add("---------------------------------------------------------------------------------------");
            payslip_listbox.Items.Add("BP Num. of Hrs : " + "               ₱" + BP_NumOfHours_tbox.Text);
            payslip_listbox.Items.Add("BP Rate / Hr : " + "                     ₱" + BP_Rate_tbox.Text);
            payslip_listbox.Items.Add("Baisc Pay Income :" + "             ₱" + BP_Income_tbox.Text);
            payslip_listbox.Items.Add("");
            payslip_listbox.Items.Add("HI Num. of Hrs : " + "                ₱" + H_NumOfHours_tbox.Text);
            payslip_listbox.Items.Add("HI Rate / Hr : " + "                      ₱" + H_Rate_tbox.Text);
            payslip_listbox.Items.Add("Honorarium Income : " + "       ₱" + H_TotalHonPay_tbox.Text);
            payslip_listbox.Items.Add("");
            payslip_listbox.Items.Add("OTI Num. of Hrs : " + "              ₱" + OI_NumOfHours_tbox.Text);
            payslip_listbox.Items.Add("OTI Rate / Hr : " + "                    ₱" + OI_rate_tbox.Text);
            payslip_listbox.Items.Add("Other Income : " + "                   ₱" + OI_TotalIncPay_tbox.Text);
            payslip_listbox.Items.Add("---------------------------------------------------------------------------------------");
            payslip_listbox.Items.Add("SSS Contribution : " + "                      ₱" + SSSContr_tbox.Text);
            payslip_listbox.Items.Add("PhilHealth Contribution : " + "          ₱" + PhilCont_tbox.Text);
            payslip_listbox.Items.Add("Pagibig Contribution : " + "                ₱" + PagibigCont_tbox.Text);
            payslip_listbox.Items.Add("Tax Contribution : " + "                       ₱" + Tax_tbox.Text);
            payslip_listbox.Items.Add("SSS Loan : " + "                                    ₱" + SSSLoan_tbox.Text);
            payslip_listbox.Items.Add("Pagibig Loan : " + "                              ₱" + PagibigLoan_tbox.Text);
            payslip_listbox.Items.Add("Faculty Savings Deposit : " + "            ₱" + FacSavDep_tbox.Text);
            payslip_listbox.Items.Add("Faculty Savings Loan : " + "                 ₱" + FacSavLoan_tbox.Text);
            payslip_listbox.Items.Add("Salary Loan : " + "                                 ₱" + SalaryLoan_tbox.Text);
            payslip_listbox.Items.Add("Other Loan : " + "                                  ₱" + others_loanTxtbox.Text);
            payslip_listbox.Items.Add("---------------------------------------------------------------------------------------");
            payslip_listbox.Items.Add("Total Deduction : " + "  ₱" + TotalDeduc_tbox.Text);
            payslip_listbox.Items.Add("Gross Income : " + "      ₱" + Gross_tbox.Text);
            payslip_listbox.Items.Add("Net Income : " + "         ₱" + NetIncome_tbox.Text);

        }
        private void form_default()
        {
            EmpNum_tbox.Clear();
            FN_tbox.Clear();
            MN_tbox.Clear();
            LN_tbox.Clear();
            CivStat_tbox.Clear();
            Desig_tbox.Clear();
            NumDep_tbox.Clear();
            EmpStat_tbox.Clear();
            Department_tbox.Clear();
            BP_Income_tbox.Clear();
            BP_NumOfHours_tbox.Clear();
            BP_Rate_tbox.Clear();
            H_TotalHonPay_tbox.Clear();
            H_NumOfHours_tbox.Clear();
            H_Rate_tbox.Clear();
            OI_TotalIncPay_tbox.Clear();
            OI_NumOfHours_tbox.Clear();
            OI_rate_tbox.Clear();
            NetIncome_tbox.Clear();
            Gross_tbox.Clear();
            payslip_listbox.Items.Clear();
            TotalDeduc_tbox.Clear();
            BP_Income_tbox.Enabled = false;
            H_TotalHonPay_tbox.Enabled = false;
            OI_TotalIncPay_tbox.Enabled = false;
            NetIncome_tbox.Enabled = false;
            Gross_tbox.Enabled = false;
            TotalDeduc_tbox.Enabled = false;
            SSSContr_tbox.Text = "0.00";
            PagibigCont_tbox.Text = "0.00";
            PhilCont_tbox.Text = "0.00";
            Tax_tbox.Text = "0.00";
            SSSLoan_tbox.Text = "0.00";
            PagibigLoan_tbox.Text = "0.00";
            FacSavDep_tbox.Text = "0.00";
            FacSavLoan_tbox.Text = "0.00";
            SalaryLoan_tbox.Text = "0.00";
            others_loanTxtbox.Text = "0.00";
            Others_cbox.Text = "Select other deduction";
            Others_cbox.Items.Add("Other 1");
            Others_cbox.Items.Add("Other 2");
            Others_cbox.Items.Add("Other 3");
            Others_cbox.Items.Add("Other 4");
            picpath_tbox.Hide();
        }
    }
}
