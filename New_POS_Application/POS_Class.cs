using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace New_POS_Application
{
    internal class POS_Class
    {
        public POS_Class()
        {

        }

        public void exit()
        {
            Environment.Exit(0);
        }

        public double OA_TotalPrice(double price, double discount_amount, int qty)
        {
            return (price - discount_amount) * qty;
        }

        public int OA_TotalQty(int qty, int total_qty)
        {
            return total_qty + qty;
        }

        //POS_EmployeeSalary_Class
        public double[][] taxBrackets = new double[][]
        {
                new double[] { 10417, 0.0, 0.0 },
                new double[] { 16667, 10417, 0.15 },
                new double[] { 33333, 16667, 0.20, 937.50 },
                new double[] { 83333, 33333, 0.25, 4270.70 },
                new double[] { 333333, 83333, 0.30, 15170.83 },
                new double[] { double.MaxValue, 333333, 0.35, 81770.83 }
        };
        public double CalculateSSS(double salary)
        {
            double minMSC = 5000;
            double maxMSC = 35000;
            double employeeRate = 0.05;

            double MSC = Math.Min(Math.Max(salary, minMSC), maxMSC);

            return MSC * employeeRate;
        }
        public double CalculatePhilHealth(double salary)
        {
            double rate = 0.05;
            double minSalary = 10000;
            double maxSalary = 100000;

            if (salary < minSalary) salary = minSalary;
            if (salary > maxSalary) salary = maxSalary;

            return (salary * rate) / 2;
        }
        public double CalculatePagIBIG(double salary)
        {
            double maxSalary = 5000;
            double rate = 0.02;

            if (salary > maxSalary) salary = maxSalary;

            return salary * rate;
        }
        public double CalculateWithholdingTax(double semiMonthlySalary)
        {
            foreach (var bracket in taxBrackets)
            {
                if (semiMonthlySalary <= bracket[0])
                {
                    return (bracket.Length > 3 ? bracket[3] : 0) + (semiMonthlySalary - bracket[1]) * bracket[2];
                }
            }

            return 0.0; // Default case, should never reach
        }
        public double TotalContrib(double sss_contrib, double pagibig_contrib, double philhealth_contrib, double tax_contrib)
        {
            return sss_contrib + pagibig_contrib + philhealth_contrib + tax_contrib;
        }

        public double TotalLoan(double sss_loan, double pagibig_loan, double salary_loan,
            double faculty_sav_loan, double salary_savings, double other_deduction)
        {

            return sss_loan + pagibig_loan + salary_loan + faculty_sav_loan + salary_savings + other_deduction;
        }

        public double TotalDeduc(double total_contrib, double total_loan)
        {

            return total_contrib + total_loan;
        }

        public double ES_Income(double hrs, double rate)
        {
            return hrs * rate;
        }

        //POS_Cashier_Interface
        public Double amount_paid;
        public Double price;
        public Double cash_given;
        public Double change;
        public Double qty_total = 0;
        public Double discount_totalgiven = 0;
        public Double discounted_total = 0;
        public Double discount_amt;
        public Double discounted_amt;
        public Double total_amountPaid;
        public Int32 quantity;
    }
}
