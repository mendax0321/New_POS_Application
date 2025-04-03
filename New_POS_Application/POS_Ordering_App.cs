using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
    public partial class POS_Ordering_App : Form
    {
        private int total_qty;

        public double total_amount { get; private set; }
        public POS_Ordering_App()
        {
            InitializeComponent();
        }

        private void POS_Ordering_App_Load(object sender, EventArgs e)
        {
            clear();
        }

        private void Food_rdb_CheckedChanged(object sender, EventArgs e)
        {
            if (foodARdbtn.Checked == true)
            {
                double price;
                //code for changing the form background
                this.BackColor = Color.LightCyan;
                //code for food bundle B not to be selected
                foodBRdbtn.Checked = false;
                //inserting image inside the picturebox
                DisplayPictureBox.Image = Properties.Resources.combo1;
                //codes to check the checkboxes
                A_CokeCheckBox.Checked = true;
                A_ChickenCheckBox.Checked = true;
                A_FriesCheckBox.Checked = true;
                A_SideCheckBox.Checked = true;
                A_PizzaCheckBox.Checked = true;
                //codes to uncheck checkboxes
                B_CarbonaraCheckBox.Checked = false;
                B_ChickenCheckBox.Checked = false;
                B_FriesCheckBox.Checked = false;
                B_HaloCheckBox.Checked = false;
                B_PizzaCheckBox.Checked = false;
                //codes for displaying data inside the textboxes
                priceTxtBox.Text = "1,000.00";
                discountAmountTxtbox.Text = "200.00";
                price = Convert.ToDouble(priceTxtBox.Text);
                //codes for inserting data inside the listbox        
                defaultqty();
                displayListbox.Items.Add(foodARdbtn.Text + " " + priceTxtBox.Text);
                displayListbox.Items.Add(" Discount Amount: " + " " + discountAmountTxtbox.Text);
            }
            else if (foodBRdbtn.Checked == true)
            {
                double price;
                this.BackColor = Color.LightBlue;
                foodARdbtn.Checked = false;
                DisplayPictureBox.Image = Properties.Resources.combo2;
                A_CokeCheckBox.Checked = false;
                A_ChickenCheckBox.Checked = false;
                A_FriesCheckBox.Checked = false;
                A_SideCheckBox.Checked = false;
                A_PizzaCheckBox.Checked = false;
                B_CarbonaraCheckBox.Checked = true;
                B_ChickenCheckBox.Checked = true;
                B_FriesCheckBox.Checked = true;
                B_HaloCheckBox.Checked = true;
                B_PizzaCheckBox.Checked = true;
                priceTxtBox.Text = "1,299.00";
                discountAmountTxtbox.Text = "194.85";
                price = Convert.ToDouble(priceTxtBox.Text);
                displayListbox.Items.Add(foodBRdbtn.Text + " " + priceTxtBox.Text);
                displayListbox.Items.Add(" Discount Amount: " + " " + discountAmountTxtbox.Text);
                defaultqty();
            }
        }

        private void Calculate_btn_Click(object sender, EventArgs e)
        {
            double cashGiven, change, total_amountPaid;
            
            try
            {
                cashGiven = Convert.ToDouble(cashGivenTxtbox.Text);
                total_amountPaid = Convert.ToDouble(totalBillsTxtbox.Text);
                change = cashGiven - total_amountPaid;
                changeTxtbox.Text = change.ToString("n");

                if (cashGiven < total_amountPaid)
                {
                    cashGivenTxtbox.Clear();
                    changeTxtbox.Clear();
                    MessageBox.Show("Insufficient Funds", "Invalid");
                }
                else if (cashGiven >= total_amountPaid)
                {
                    displayListbox.Items.Add("Total Bills: " + "" + totalBillsTxtbox.Text);
                    displayListbox.Items.Add("Cash Given: " + "" + cashGivenTxtbox.Text);
                    displayListbox.Items.Add("Change: " + "" + changeTxtbox.Text);
                    displayListbox.Items.Add("Total No. of Items: " + " " + totalQtyTxtbox.Text);
                }
            }
            catch
            {
                MessageBox.Show("Incomplete Input / Invalid Input", "ERROR");
            }
        }
        private void Print_btn_Click(object sender, EventArgs e)
        {
            PrintFrm printForm = new PrintFrm();
            printForm.printDisplayListbox.Items.AddRange(this.displayListbox.Items);
            printForm.Show();
        }

        private void Scan_btn_Click(object sender, EventArgs e)
        {
            QRscanner scan = new QRscanner();
            scan.ShowDialog();
            cashGivenTxtbox.Text = Convert.ToString(scan.CustomerCash);
            scan.Dispose();
        }

        private void RemoveItem_btn_Click(object sender, EventArgs e)
        {
            if (displayListbox.SelectedItems.Count > 0)
            {
                displayListbox.Items.Remove(displayListbox.SelectedItems[0]);
            }
        }

        private void New_btn_Click(object sender, EventArgs e)
        {
            clear();
        }


        private void Exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void qtyTxtbox_TextChanged(object sender, EventArgs e)
        {
            double price, discounted_amount, discount_amount;
            int qty;

            if (double.TryParse(priceTxtBox.Text, out price) &&
                int.TryParse(qtyTxtbox.Text, out qty) &&
                double.TryParse(discountAmountTxtbox.Text, out discount_amount))
            {
                if (qty > 0)
                {
                    discounted_amount = (price - discount_amount ) * qty ;
                }
                else
                {
                    discounted_amount = 0;  // Prevent negative values
                }
                total_qty = total_qty + qty;
                totalQtyTxtbox.Text = total_qty.ToString();
                total_amount += discounted_amount;
                totalBillsTxtbox.Text = total_amount.ToString("n");
                discountedAmountTxtbox.Text = discounted_amount.ToString("n");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                priceTxtBox.Text = "500.99";
                chkbx_function();
                displayListbox.Items.Add(checkBox1.Text + " " + priceTxtBox.Text);
                defaultqty();
            }

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                priceTxtBox.Text = "550.00";
                chkbx_function();
                displayListbox.Items.Add(checkBox2.Text + " " + priceTxtBox.Text);
                defaultqty();
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                priceTxtBox.Text = "600.99";
                chkbx_function();
                displayListbox.Items.Add(checkBox3.Text + " " + priceTxtBox.Text);
                defaultqty();
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
                priceTxtBox.Text = "700.50";
                chkbx_function();
                displayListbox.Items.Add(checkBox4.Text + " " + priceTxtBox.Text);
                defaultqty();
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked == true)
            {
                priceTxtBox.Text = "500.00";
                chkbx_function();
                displayListbox.Items.Add(checkBox5.Text + " " + priceTxtBox.Text);
                defaultqty();
            }
        }

        private void checkBox6_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox6.Checked == true)
            {
                priceTxtBox.Text = "750.00";
                chkbx_function();
                displayListbox.Items.Add(checkBox6.Text + " " + priceTxtBox.Text);
                defaultqty();
            }
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox7.Checked == true)
            {
                priceTxtBox.Text = "700.00";
                chkbx_function();
                displayListbox.Items.Add(checkBox7.Text + " " + priceTxtBox.Text);
                defaultqty();
            }
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox8.Checked == true)
            {
                priceTxtBox.Text = "850.00";
                chkbx_function();
                displayListbox.Items.Add(checkBox8.Text + " " + priceTxtBox.Text);
                defaultqty();
            }
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox9.Checked == true)
            {
                priceTxtBox.Text = "450.00";
                chkbx_function();
                displayListbox.Items.Add(checkBox9.Text + " " + priceTxtBox.Text);
                defaultqty();
            }
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox10.Checked == true)
            {
                priceTxtBox.Text = "650.00";
                chkbx_function();
                displayListbox.Items.Add(checkBox10.Text + " " + priceTxtBox.Text);
                defaultqty();
            }
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox11.Checked == true)
            {
                priceTxtBox.Text = "575.00";
                chkbx_function();
                displayListbox.Items.Add(checkBox11.Text + " " + priceTxtBox.Text);
                defaultqty();
            }
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox12.Checked == true)
            {
                priceTxtBox.Text = "575.00";
                chkbx_function();
                displayListbox.Items.Add(checkBox12.Text + " " + priceTxtBox.Text);
                defaultqty();
            }
        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox13.Checked == true)
            {
                priceTxtBox.Text = "575.00";
                chkbx_function();
                displayListbox.Items.Add(checkBox13.Text + " " + priceTxtBox.Text);
                defaultqty();
            }
        }

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox14.Checked == true)
            {
                priceTxtBox.Text = "575.00";
                chkbx_function();
                displayListbox.Items.Add(checkBox14.Text + " " + priceTxtBox.Text);
                defaultqty();
            }
        }

        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox15.Checked == true)
            {
                priceTxtBox.Text = "575.00";
                chkbx_function();
                displayListbox.Items.Add(checkBox15.Text + " " + priceTxtBox.Text);
                defaultqty();
            }
        }

        private void checkBox16_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox16.Checked == true)
            {
                priceTxtBox.Text = "575.00";
                chkbx_function();
                displayListbox.Items.Add(checkBox16.Text + " " + priceTxtBox.Text);
                defaultqty();
            }
        }

        private void checkBox17_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox17.Checked == true)
            {
                priceTxtBox.Text = "575.00";
                chkbx_function();
                displayListbox.Items.Add(checkBox17.Text + " " + priceTxtBox.Text);
                defaultqty();
            }
        }

        private void checkBox18_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox18.Checked == true)
            {
                priceTxtBox.Text = "575.00";
                chkbx_function();
                displayListbox.Items.Add(checkBox18.Text + " " + priceTxtBox.Text);
                defaultqty();
            }
        }

        private void checkBox19_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox19.Checked == true)
            {
                priceTxtBox.Text = "575.00";
                chkbx_function();
                displayListbox.Items.Add(checkBox19.Text + " " + priceTxtBox.Text);
                defaultqty();
            }
        }

        private void checkBox20_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox20.Checked == true)
            {
                priceTxtBox.Text = "575.00";
                chkbx_function();
                displayListbox.Items.Add(checkBox20.Text + " " + priceTxtBox.Text);
                defaultqty();
            }
        }

        private void chkbx_function()
        {
            double price;
            discountAmountTxtbox.Text = "0.00";
            price = Convert.ToDouble(priceTxtBox.Text);
        }

        private void defaultqty()
        {
            qtyTxtbox.Text = "0";
            qtyTxtbox.Focus();
        }

        private void clear()
        {
                        // Uncheck all given checkboxes
            foodARdbtn.Checked = false;
            foodBRdbtn.Checked = false;

            A_CokeCheckBox.Checked = false;
            A_ChickenCheckBox.Checked = false;
            A_FriesCheckBox.Checked = false;
            A_SideCheckBox.Checked = false;
            A_PizzaCheckBox.Checked = false;
            B_CarbonaraCheckBox.Checked = false;
            B_ChickenCheckBox.Checked = false;
            B_FriesCheckBox.Checked = false;
            B_HaloCheckBox.Checked = false;
            B_PizzaCheckBox.Checked = false;

            // Uncheck all additional checkboxes
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
            checkBox7.Checked = false;
            checkBox8.Checked = false;
            checkBox9.Checked = false;
            checkBox10.Checked = false;
            checkBox11.Checked = false;
            checkBox12.Checked = false;
            checkBox13.Checked = false;
            checkBox14.Checked = false;
            checkBox15.Checked = false;
            checkBox16.Checked = false;
            checkBox17.Checked = false;
            checkBox18.Checked = false;
            checkBox19.Checked = false;
            checkBox20.Checked = false;

            // Remove the contents of the textboxes
            displayListbox.Items.Clear();
            priceTxtBox.Clear();
            qtyTxtbox.Clear();
            discountAmountTxtbox.Clear();
            discountedAmountTxtbox.Clear();
            cashGivenTxtbox.Clear();
            changeTxtbox.Clear();

            // Reset total_qty and total_amount
            total_qty = 0;
            total_amount = 0;
          

            // Update the textboxes to reflect the reset values
            totalQtyTxtbox.Text = total_qty.ToString();
            totalBillsTxtbox.Text = total_amount.ToString("n");
        }
    }
}
