using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;
using ZXing.Aztec;
using System.Xml;

namespace New_POS_Application
{
    public partial class POS_Cashier_Interface : Form
    {
        string fpbev = "D:\\repos\\New_POS_Application\\images\\beverages\\";
        string fpbreakfast = "D:\\repos\\New_POS_Application\\images\\breakfast\\";
        string fpcoffee = "D:\\repos\\New_POS_Application\\images\\coffee\\";
        string fpdessert = "D:\\repos\\New_POS_Application\\images\\dessert\\";
        string fpdinner = "D:\\repos\\New_POS_Application\\images\\dinner\\";
        string fplunch = "D:\\repos\\New_POS_Application\\images\\lunch\\";
        int x = 0;

        public POS_Cashier_Interface()
        {
            InitializeComponent();

        }
        private void GetPriceItemValue()
        {

            Price_Item_Value price_item_value = new Price_Item_Value();
            POS_Class variables = new POS_Class();
            itemnametxtbox.Text = (price_item_value.GetItemName());
            pricetextbox.Text = (price_item_value.GetPrice());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ClearPics();
            this.WindowState = FormWindowState.Maximized;
            this.BackColor = Color.Thistle;
            this.Text = "Point of Sale Interface";
        }

      

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        //PicBox Click Event
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            displayTxtbox(name1lbl, price1lbl);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            displayTxtbox(name2lbl, price2lbl);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            displayTxtbox(name3lbl, price3lbl);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            displayTxtbox(name4lbl, price4lbl);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            displayTxtbox(name5lbl, price5lbl);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            displayTxtbox(name6lbl, price6lbl);
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            displayTxtbox(name7lbl, price7lbl);
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            displayTxtbox(name8lbl, price8lbl);
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            displayTxtbox(name9lbl, price9lbl);
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            displayTxtbox(name10lbl, price10lbl);
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            displayTxtbox(name11lbl, price11lbl);
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            displayTxtbox(name12lbl, price12lbl);
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            displayTxtbox(name13lbl, price13lbl);
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            displayTxtbox(name14lbl, price14lbl);
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            displayTxtbox(name15lbl, price15lbl);
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            displayTxtbox(name16lbl, price16lbl);
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            displayTxtbox(name17lbl, price17lbl);
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            displayTxtbox(name18lbl, price18lbl);
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            displayTxtbox(name19lbl, price19lbl);
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            displayTxtbox(name20lbl, price20lbl);
        }

        //Product, Picture & Price 
        private void dinnerBtn_Click(object sender, EventArgs e)
        {
            List<int> dinnerPrices = new List<int>
            {
                100, 115, 130, 145, 170, 185, 210, 225, 235, 215,
                270, 125, 135, 165, 189, 125, 137, 180, 250, 239
            };

            LoadMenu("Dinner", fpdinner, "d", "jfif", 1, dinnerPrices);
        }


        private void lunchBtn_Click(object sender, EventArgs e)
        {
            List<int> lunchPrices = new List<int>
            {
                99, 70, 80, 85, 79, 120, 110, 85, 75, 150,
                115, 95, 97, 85, 95, 87, 67, 90, 91, 119
        };

            LoadMenu("Lunch", fplunch, "l", "jfif", 1, lunchPrices);
        }


        private void dessertsBtn_Click(object sender, EventArgs e)
        {
            List<int> dessertPrices = new List<int>
            {
                125, 150, 145, 139, 200, 190, 85, 90, 95, 88,
                99, 110, 130, 155, 165, 125, 140, 160, 180, 199
            };

            LoadMenu("Dessert", fpdessert, "s", "jfif", 1, dessertPrices);
        }

        private void breakfastBrn_Click(object sender, EventArgs e)
        {
            List<int> breakfastPrices = new List<int>
            {
                65, 75, 85, 90, 70, 88, 99, 105, 115, 120,
                110, 130, 95, 100, 80, 77, 89, 94, 102, 112
            };

            LoadMenu("Breakfast", fpbreakfast, "b", "jfif", 1, breakfastPrices);
        }

        private void beveragesBtn_Click(object sender, EventArgs e)
        {
            List<int> bevPrices = new List<int>
            {
                45, 55, 60, 50, 40, 58, 65, 70, 75, 80,
                90, 100, 85, 95, 88, 73, 67, 78, 83, 92
            };

            LoadMenu("Beverages", fpbev, "b", "jfif", 1, bevPrices);
        }

        private void coffeeBtn_Click(object sender, EventArgs e)
        {
            List<int> coffeePrices = new List<int>
            {
                80, 89, 110, 100, 99, 79, 120, 89, 69, 105,
                80, 79, 76, 91, 95, 86, 99, 100, 102, 79
            };

            LoadMenu("Coffee", fpcoffee, "c", "jfif", 1, coffeePrices);
        }

        //Radio Button
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
                ApplyDiscount(0.30, radioButton1);
        }

        private void EmployeeRdbtn_CheckedChanged(object sender, EventArgs e)
        {
            if (EmployeeRdbtn.Checked)
                ApplyDiscount(0.15, EmployeeRdbtn);
        }

        private void noTaxRdbtn_CheckedChanged(object sender, EventArgs e)
        {
            if (noTaxRdbtn.Checked)
                ApplyDiscount(0.0, noTaxRdbtn);
        }

        private void regularRbtn_CheckedChanged(object sender, EventArgs e)
        {
            if (regularRbtn.Checked)
                ApplyDiscount(0.10, regularRbtn);
        }

        private void quantitytxtbox_TextChanged(object sender, EventArgs e)
        {
            
        }

        //Button Controls
        private void calcbtn_Click(object sender, EventArgs e)
        {
            int qty, qty_total = 0;
            double discount_amt, discounted_amt, cash_rendered = 0, change = 0, discount_totalgiven = 0, discounted_total = 0;

            try
            {
                qty = Convert.ToInt32(quantitytxtbox.Text);
                discount_amt = Convert.ToDouble(discounttxtbox.Text);
                discounted_amt = Convert.ToDouble(discountedtxtbox.Text);
                cash_rendered = Convert.ToDouble(cashre_renderedtxtbox.Text);

                qty_total += qty;
                discount_totalgiven += discount_amt;
                discounted_total += discounted_amt;
                if (cash_rendered < discounted_amt)
                {
                    cashre_renderedtxtbox.Clear();
                    changetxtbox.Clear();
                    MessageBox.Show("Insufficient Funds", "Invalid");
                }
                else if (cash_rendered >= discounted_amt)
                {
                    change = cash_rendered - discounted_amt;
                    qty_totaltxtbox.Text = qty_total.ToString();
                    discount_totaltxtbox.Text = discount_totalgiven.ToString();
                    disconted_totaltxtbox.Text = discounted_total.ToString();
                    changetxtbox.Text = change.ToString();
                    cashre_renderedtxtbox.Text = cash_rendered.ToString();
                }
            }
            catch
            {
                MessageBox.Show("Incomplete Input / Invalid Input", "ERROR");
            }
        }

        private void CashScan_btn_Click(object sender, EventArgs e)
        {
            QRscanner scan = new QRscanner();
            scan.ShowDialog();
            cashre_renderedtxtbox.Text = Convert.ToString(scan.CustomerCash);
            scan.Dispose();
        }

        private void newbtn_Click(object sender, EventArgs e)
        {
            ClearFrm();
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            ClearFrm();
        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        //Functions
        private void ClearPics()
        {
            name1lbl.Hide();
            name2lbl.Hide();
            name3lbl.Hide();
            name4lbl.Hide();
            name5lbl.Hide();
            name6lbl.Hide();
            name7lbl.Hide();
            name8lbl.Hide();
            name9lbl.Hide();
            name10lbl.Hide();
            name11lbl.Hide();
            name12lbl.Hide();
            name13lbl.Hide();
            name14lbl.Hide();
            name15lbl.Hide();
            name16lbl.Hide();
            name17lbl.Hide();
            name18lbl.Hide();
            name19lbl.Hide();
            name20lbl.Hide();
            price1lbl.Hide();
            price2lbl.Hide();
            price3lbl.Hide();
            price4lbl.Hide();
            price5lbl.Hide();
            price6lbl.Hide();
            price7lbl.Hide();
            price8lbl.Hide();
            price9lbl.Hide();
            price10lbl.Hide();
            price11lbl.Hide();
            price12lbl.Hide();
            price13lbl.Hide();
            price14lbl.Hide();
            price15lbl.Hide();
            price16lbl.Hide();
            price17lbl.Hide();
            price18lbl.Hide();
            price19lbl.Hide();
            price20lbl.Hide();
            pictureBox1.Image = null;
            pictureBox2.Image = null;
            pictureBox3.Image = null;
            pictureBox4.Image = null;
            pictureBox5.Image = null;
            pictureBox6.Image = null;
            pictureBox7.Image = null;
            pictureBox8.Image = null;
            pictureBox9.Image = null;
            pictureBox10.Image = null;
            pictureBox11.Image = null;
            pictureBox12.Image = null;
            pictureBox13.Image = null;
            pictureBox14.Image = null;
            pictureBox15.Image = null;
            pictureBox16.Image = null;
            pictureBox17.Image = null;
            pictureBox18.Image = null;
            pictureBox19.Image = null;
            pictureBox20.Image = null;

        }
        private void ClearFrm()
        {
            radioButton1.Checked = false;
            regularRbtn.Checked = false;
            EmployeeRdbtn.Checked = false;
            noTaxRdbtn.Checked = false;
            itemnametxtbox.Clear();
            pricetextbox.Clear();
            quantitytxtbox.Clear();
            qty_totaltxtbox.Clear();
            discounttxtbox.Clear();
            discountedtxtbox.Clear();
            discount_totaltxtbox.Clear();
            disconted_totaltxtbox.Clear();
            cashre_renderedtxtbox.Clear();
            changetxtbox.Clear();
            ClearPics();
        }

        private void count()
        {
            x++;
            quantitytxtbox.Text = Convert.ToString(x);
        }
       
        private void quantityTxtbox()
        {
            quantitytxtbox.Clear();
            quantitytxtbox.Focus();
        }

        private void ApplyDiscount(double discountRate, RadioButton selectedButton)
        {
            int qty = Convert.ToInt32(quantitytxtbox.Text);
            double price = Convert.ToDouble(pricetextbox.Text);
            double discount_amt = (qty * price) * discountRate;
            double discounted_amt = (qty * price) - discount_amt;

            discounttxtbox.Text = discount_amt.ToString("n");
            discountedtxtbox.Text = discounted_amt.ToString("n");

            // Uncheck all other buttons
            foreach (var ctrl in this.Controls)
            {
                if (ctrl is RadioButton rb && rb != selectedButton)
                    rb.Checked = false;
            }

            cashre_renderedtxtbox.Focus();
        }
        private void displayTxtbox(Label nameLabel, Label priceLabel)
        {
            itemnametxtbox.Text = nameLabel.Text;
            pricetextbox.Text = priceLabel.Text;
            count();
            quantityTxtbox();
        }
        private void LoadMenu(string category, string pathPrefix, string filePrefix, string fileExtension, int startIndex, List<int> prices)
        {
            itemnametxtbox.Clear();
            pricetextbox.Clear();

            for (int i = 0; i < prices.Count; i++)
            {
                var pictureBox = Controls.Find($"pictureBox{i + 1}", true).FirstOrDefault() as PictureBox;
                var nameLabel = Controls.Find($"name{i + 1}lbl", true).FirstOrDefault() as Label;
                var priceLabel = Controls.Find($"price{i + 1}lbl", true).FirstOrDefault() as Label;

                if (pictureBox != null && nameLabel != null && priceLabel != null)
                {
                    string fileName = $"{filePrefix}{startIndex + i}.{fileExtension}";
                    pictureBox.Image = Image.FromFile(Path.Combine(pathPrefix, fileName));
                    nameLabel.Text = $"{category} {i + 1}";
                    priceLabel.Text = prices[i].ToString();
                }
            }
        }

        private void name1lbl_Click(object sender, EventArgs e)
        {

        }
    }
}