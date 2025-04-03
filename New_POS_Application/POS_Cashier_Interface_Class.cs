using System;
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

namespace New_POS_Application
{
    public partial class POS_Cashier_Interface_Class : Form
    {
        POS_Class PC = new POS_Class();
        int qty, qty_total = 0, x = 0; 
        double price ,discount_amt, discounted_amt, cash_rendered = 0, change = 0, discount_totalgiven = 0, discounted_total = 0;

        public POS_Cashier_Interface_Class()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            startup();
        }

        //PicBox Click Event
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = name1lbl.Text;
            pricetextbox.Text = price1lbl.Text;
            count();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = name2lbl.Text;
            pricetextbox.Text = price2lbl.Text;
            count();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = name3lbl.Text;
            pricetextbox.Text = price3lbl.Text;
            count();

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = name4lbl.Text;
            pricetextbox.Text = price4lbl.Text;
            count();

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = name5lbl.Text;
            pricetextbox.Text = price5lbl.Text;
            count();

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = name6lbl.Text;
            pricetextbox.Text = price6lbl.Text;
            count();

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = name7lbl.Text;
            pricetextbox.Text = price7lbl.Text;
            count();

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = name8lbl.Text;
            pricetextbox.Text = price8lbl.Text;
            count();

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = name9lbl.Text;
            pricetextbox.Text = price9lbl.Text;
            count();

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = name10lbl.Text;
            pricetextbox.Text = price10lbl.Text;
            count();

        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = name11lbl.Text;
            pricetextbox.Text = price11lbl.Text;
            count();

        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = name12lbl.Text;
            pricetextbox.Text = price12lbl.Text;
            count();

        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = name13lbl.Text;
            pricetextbox.Text = price13lbl.Text;
            count();

        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = name14lbl.Text;
            pricetextbox.Text = price14lbl.Text;
            count();

        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = name15lbl.Text;
            pricetextbox.Text = price15lbl.Text;
            count();

        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = name16lbl.Text;
            pricetextbox.Text = price16lbl.Text;
            count();

        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = name17lbl.Text;
            pricetextbox.Text = price17lbl.Text;
            count();

        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = name18lbl.Text;
            pricetextbox.Text = price18lbl.Text;
            count();

        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = name19lbl.Text;
            pricetextbox.Text = price19lbl.Text;
            count();

        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Text = name20lbl.Text;
            pricetextbox.Text = price20lbl.Text;
            count();
        }


        //Product, Picture & Price 
        private void dinnerBtn_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Clear();
            pricetextbox.Clear();
            PB(PC.filepath + "dinner\\", "d", "Dinner ", PC.DinnerPrice);
            /*
            pictureBox1.Image = Image.FromFile(fpdinner + "d1.jfif"); name1lbl.Text = "Dinner 1"; price1lbl.Text = "100";
            pictureBox2.Image = Image.FromFile(fpdinner + "d2.jfif"); name2lbl.Text = "Dinner 2"; price2lbl.Text = "115";
            pictureBox3.Image = Image.FromFile(fpdinner + "d3.jfif"); name3lbl.Text = "Dinner 3"; price3lbl.Text = "130";
            pictureBox4.Image = Image.FromFile(fpdinner + "d4.jfif"); name4lbl.Text = "Dinner 4"; price4lbl.Text = "145";
            pictureBox5.Image = Image.FromFile(fpdinner + "d5.jfif"); name5lbl.Text = "Dinner 5"; price5lbl.Text = "170";
            pictureBox6.Image = Image.FromFile(fpdinner + "d6.jfif"); name6lbl.Text = "Dinner 6"; price6lbl.Text = "185";
            pictureBox7.Image = Image.FromFile(fpdinner + "d7.jfif"); name7lbl.Text = "Dinner 7"; price7lbl.Text = "210";
            pictureBox8.Image = Image.FromFile(fpdinner + "d8.jfif"); name8lbl.Text = "Dinner 8"; price8lbl.Text = "225";
            pictureBox9.Image = Image.FromFile(fpdinner + "d9.jfif"); name9lbl.Text = "Dinner 9"; price9lbl.Text = "235";
            pictureBox10.Image = Image.FromFile(fpdinner + "d10.jfif"); name10lbl.Text = "Dinner 10"; price10lbl.Text = "215";
            pictureBox11.Image = Image.FromFile(fpdinner + "d11.jfif"); name11lbl.Text = "Dinner 11"; price11lbl.Text = "270";
            pictureBox12.Image = Image.FromFile(fpdinner + "d12.jfif"); name12lbl.Text = "Dinner 12"; price12lbl.Text = "125";
            pictureBox13.Image = Image.FromFile(fpdinner + "d13.jfif"); name13lbl.Text = "Dinner 13"; price13lbl.Text = "135";
            pictureBox14.Image = Image.FromFile(fpdinner + "d14.jfif"); name14lbl.Text = "Dinner 14"; price14lbl.Text = "165";
            pictureBox15.Image = Image.FromFile(fpdinner + "d15.jfif"); name15lbl.Text = "Dinner 15"; price15lbl.Text = "189";
            pictureBox16.Image = Image.FromFile(fpdinner + "d16.jfif"); name16lbl.Text = "Dinner 16"; price16lbl.Text = "125";
            pictureBox17.Image = Image.FromFile(fpdinner + "d17.jfif"); name17lbl.Text = "Dinner 17"; price17lbl.Text = "137";
            pictureBox18.Image = Image.FromFile(fpdinner + "d18.jfif"); name18lbl.Text = "Dinner 18"; price18lbl.Text = "180";
            pictureBox19.Image = Image.FromFile(fpdinner + "d19.jfif"); name19lbl.Text = "Dinner 19"; price19lbl.Text = "250";
            pictureBox20.Image = Image.FromFile(fpdinner + "d20.jfif"); name20lbl.Text = "Dinner 20"; price20lbl.Text = "239";*/
        }

        private void lunchBtn_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Clear();
            pricetextbox.Clear();
            PB(PC.filepath + "lunch\\", "l", "Lunch ", PC.LunchPrice);
        }

        private void dessertsBtn_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Clear();
            pricetextbox.Clear();
            PB(PC.filepath + "dessert\\", "s", "Desserts ", PC.DessertsPrice);
        }

        private void breakfastBrn_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Clear();
            pricetextbox.Clear();
            PB(PC.filepath + "breakfast\\", "b", "Breakfast ", PC.BreakfastPrice);
        }

        private void beveragesBtn_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Clear();
            pricetextbox.Clear();
            PB(PC.filepath + "beverages\\", "l", "Beverage ", PC.BeveragesPrice);
        }

        private void coffeeBtn_Click(object sender, EventArgs e)
        {
            itemnametxtbox.Clear();
            pricetextbox.Clear();
            PB(PC.filepath + "coffee\\", "c", "Coffee ", PC.CoffeePrice);
        }

        //Radio Button
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            regularRbtn.Checked = false;
            EmployeeRdbtn.Checked = false;
            noTaxRdbtn.Checked = false;
            qrt_prc_tbox();
            discount_amt = PC.discount(qty, price, 0.30);
            discounted_amt = PC.totalprice(qty, price, discount_amt);
            discnt_tbox();
        }

        private void EmployeeRdbtn_CheckedChanged(object sender, EventArgs e)
        {
            regularRbtn.Checked = false;
            radioButton1.Checked = false;
            noTaxRdbtn.Checked = false;
            qrt_prc_tbox();
            discount_amt = PC.discount(qty, price, 0.15);
            discounted_amt = PC.totalprice(qty, price, discount_amt);
            discnt_tbox();
        }

        private void noTaxRdbtn_CheckedChanged(object sender, EventArgs e)
        {
            regularRbtn.Checked = false;
            EmployeeRdbtn.Checked = false;
            radioButton1.Checked = false;
            qrt_prc_tbox();
            discount_amt = PC.discount(qty, price, 0);
            discounted_amt = PC.totalprice(qty, price, discount_amt);
            discnt_tbox();
        }

        private void regularRbtn_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1.Checked = false;
            EmployeeRdbtn.Checked = false;
            noTaxRdbtn.Checked = false;
            qrt_prc_tbox();
            discount_amt = PC.discount(qty, price, 0.10);
            discounted_amt = PC.totalprice(qty, price, discount_amt);
            discnt_tbox();
        }

        //Button Controls
        private void calcbtn_Click(object sender, EventArgs e)
        {
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
                    change = PC.calc(cash_rendered, discounted_amt);
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
        }
        private void PB(string filepth, string filenm, string foodname, string[] tite)
        {
            PictureBox[] PB = {pictureBox1 ,pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6, pictureBox7,
            pictureBox8, pictureBox9, pictureBox10, pictureBox11, pictureBox12, pictureBox13, pictureBox14, pictureBox15,
            pictureBox16, pictureBox17, pictureBox18, pictureBox19, pictureBox20 };

            var namelbl = new List<Label> { name1lbl ,name1lbl, name2lbl, name3lbl, name4lbl, name5lbl, name6lbl, name7lbl, name8lbl, name9lbl, name10lbl,
                name11lbl, name12lbl, name13lbl, name14lbl, name15lbl,   name16lbl, name17lbl, name18lbl, name19lbl, name20lbl };

            var pricelbl = new List<Label> { price1lbl, price2lbl, price3lbl, price4lbl, price5lbl, price6lbl, price7lbl, price8lbl, price9lbl,
             price10lbl, price11lbl, price12lbl, price13lbl, price14lbl, price15lbl, price16lbl, price17lbl, price18lbl, price19lbl, price20lbl};

            int contlbl = 0, prclbl = 0;

            int z = 1;
            for (int y = 1; y < 21; y++)
            {
                PB[z].Image = Image.FromFile(filepth + filenm + y + ".jfif");
                z++;
            }

            foreach (var label in namelbl)
            {
                label.Text = foodname + contlbl;
                contlbl++;
            }

            foreach (var label in pricelbl)
            {
                label.Text = tite[prclbl];
                prclbl++;
            }
        }

        private void qrt_prc_tbox()
        {
            qty = Convert.ToInt32(quantitytxtbox.Text);
            price = Convert.ToDouble(pricetextbox.Text);
        }

        private void discnt_tbox()
        {
            discounttxtbox.Text = discount_amt.ToString("n");
            discountedtxtbox.Text = discounted_amt.ToString("n");
        }

        private void startup()
        {
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
            this.BackColor = Color.Thistle;
            this.Text = "Point of Sale Interface";
        }

        private void count()
        {
            x++;
            quantitytxtbox.Text = Convert.ToString(x);
        }
    }
}