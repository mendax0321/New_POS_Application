using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;
using ZXing.Aztec;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using Image = System.Drawing.Image;

namespace New_POS_Application
{
    public partial class POS_Ordering_App_Class : Form
    {
        POS_dbconnect dbconnect = new POS_dbconnect();
        POS_Class PC = new POS_Class();
        private int total_qty;

        public double total_amount { get; private set; }
        public POS_Ordering_App_Class()
        {
            InitializeComponent();
            dbconnect.pos_connString();
            dbconnect.pos_select();
            dbconnect.pos_cmd();
            dbconnect.pos_sqladapterSelect();
            dbconnect.pos_sqldatasetSELECT();
            GridView.DataSource = dbconnect.pos_sql_dataset.Tables[0];
            EmpID_lbl.Text = dbconnect.pos_sql_dataset.Tables[0].Rows[0][22].ToString();
            dbload();
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
                clearB();
                //inserting image inside the picturebox
                DisplayPictureBox.Image = Properties.Resources.combo1;
                //codes to check the checkboxes
                selectA();
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
                clearA();
                DisplayPictureBox.Image = Properties.Resources.combo2;
                selectB();
                priceTxtBox.Text = "1,299.00";
                discountAmountTxtbox.Text = "194.85";
                price = Convert.ToDouble(priceTxtBox.Text);
                displayListbox.Items.Add(foodBRdbtn.Text + " " + priceTxtBox.Text);
                displayListbox.Items.Add(" Discount Amount: " + " " + discountAmountTxtbox.Text);
                defaultqty();
            }
        }
        private void Submit_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(changeTxtbox.Text))
                {
                    MessageBox.Show("Error occurs; Please contact your administrator!");
                }
                else
                {
                    dbconnect.pos_sql = "INSERT INTO order_salesTbl (discount_amount_per_transaction, discounted_amount_per_transaction, " +
        "summary_total_quantity, summary_total_bills, customer_cash, customer_change, time_date, emp_id) VALUES('"
        + discountAmountTxtbox.Text + "', '" + discountedAmountTxtbox.Text + "', '" + totalQtyTxtbox.Text + "', '"
        + totalBillsTxtbox.Text + "', '" + cashGivenTxtbox.Text + "', '"
        + changeTxtbox.Text + "', '" + dateTimePicker1.Text + "', '"
        + EmpID_lbl.Text + "')";
                dbconnect.pos_cmd();
                dbconnect.pos_sqladapterInsert();
                clear();
                }

            }
            catch
            {
                MessageBox.Show("Error occurs; Please contact your administrator!");
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
            double price, discount_amount, discounted_amount;
            int qty;

            if (double.TryParse(priceTxtBox.Text, out price) &&
                int.TryParse(qtyTxtbox.Text, out qty) &&
                double.TryParse(discountAmountTxtbox.Text, out discount_amount))
            {
                if (qty > 0)
                {
                    discounted_amount =  PC.OA_TotalPrice(price, discount_amount, qty);
                }
                else
                {
                    discounted_amount = 0;  // Prevent negative values
                }
                total_qty = PC.OA_TotalQty(qty, total_qty);
                total_amount += discounted_amount;
                totalQtyTxtbox.Text = total_qty.ToString();
                totalBillsTxtbox.Text = total_amount.ToString("n");
                discountedAmountTxtbox.Text = discounted_amount.ToString("n");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                priceTxtBox.Text = dbconnect.pos_sql_dataset.Tables[0].Rows[0][46].ToString(); ;
                chkbx_function();
                displayListbox.Items.Add(checkBox1.Text + " " + priceTxtBox.Text);
                defaultqty();
            }

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                priceTxtBox.Text = dbconnect.pos_sql_dataset.Tables[0].Rows[0][47].ToString();
                chkbx_function();
                displayListbox.Items.Add(checkBox2.Text + " " + priceTxtBox.Text);
                defaultqty();
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                priceTxtBox.Text = dbconnect.pos_sql_dataset.Tables[0].Rows[0][48].ToString();
                chkbx_function();
                displayListbox.Items.Add(checkBox3.Text + " " + priceTxtBox.Text);
                defaultqty();
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
                priceTxtBox.Text = dbconnect.pos_sql_dataset.Tables[0].Rows[0][49].ToString();
                chkbx_function();
                displayListbox.Items.Add(checkBox4.Text + " " + priceTxtBox.Text);
                defaultqty();
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked == true)
            {
                priceTxtBox.Text = dbconnect.pos_sql_dataset.Tables[0].Rows[0][50].ToString();
                chkbx_function();
                displayListbox.Items.Add(checkBox5.Text + " " + priceTxtBox.Text);
                defaultqty();
            }
        }

        private void checkBox6_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox6.Checked == true)
            {
                priceTxtBox.Text = dbconnect.pos_sql_dataset.Tables[0].Rows[0][51].ToString();
                chkbx_function();
                displayListbox.Items.Add(checkBox6.Text + " " + priceTxtBox.Text);
                defaultqty();
            }
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox7.Checked == true)
            {
                priceTxtBox.Text = dbconnect.pos_sql_dataset.Tables[0].Rows[0][52].ToString();
                chkbx_function();
                displayListbox.Items.Add(checkBox7.Text + " " + priceTxtBox.Text);
                defaultqty();
            }
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox8.Checked == true)
            {
                priceTxtBox.Text = dbconnect.pos_sql_dataset.Tables[0].Rows[0][53].ToString();
                chkbx_function();
                displayListbox.Items.Add(checkBox8.Text + " " + priceTxtBox.Text);
                defaultqty();
            }
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox9.Checked == true)
            {
                priceTxtBox.Text = dbconnect.pos_sql_dataset.Tables[0].Rows[0][54].ToString();
                chkbx_function();
                displayListbox.Items.Add(checkBox9.Text + " " + priceTxtBox.Text);
                defaultqty();
            }
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox10.Checked == true)
            {
                priceTxtBox.Text = dbconnect.pos_sql_dataset.Tables[0].Rows[0][55].ToString();
                chkbx_function();
                displayListbox.Items.Add(checkBox10.Text + " " + priceTxtBox.Text);
                defaultqty();
            }
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox11.Checked == true)
            {
                priceTxtBox.Text = dbconnect.pos_sql_dataset.Tables[0].Rows[0][56].ToString();
                chkbx_function();
                displayListbox.Items.Add(checkBox11.Text + " " + priceTxtBox.Text);
                defaultqty();
            }
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox12.Checked == true)
            {
                priceTxtBox.Text = dbconnect.pos_sql_dataset.Tables[0].Rows[0][57].ToString();
                chkbx_function();
                displayListbox.Items.Add(checkBox12.Text + " " + priceTxtBox.Text);
                defaultqty();
            }
        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox13.Checked == true)
            {
                priceTxtBox.Text = dbconnect.pos_sql_dataset.Tables[0].Rows[0][58].ToString();
                chkbx_function();
                displayListbox.Items.Add(checkBox13.Text + " " + priceTxtBox.Text);
                defaultqty();
            }
        }

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox14.Checked == true)
            {
                priceTxtBox.Text = dbconnect.pos_sql_dataset.Tables[0].Rows[0][59].ToString();
                chkbx_function();
                displayListbox.Items.Add(checkBox14.Text + " " + priceTxtBox.Text);
                defaultqty();
            }
        }

        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox15.Checked == true)
            {
                priceTxtBox.Text = dbconnect.pos_sql_dataset.Tables[0].Rows[0][60].ToString();
                chkbx_function();
                displayListbox.Items.Add(checkBox15.Text + " " + priceTxtBox.Text);
                defaultqty();
            }
        }

        private void checkBox16_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox16.Checked == true)
            {
                priceTxtBox.Text = dbconnect.pos_sql_dataset.Tables[0].Rows[0][61].ToString();
                chkbx_function();
                displayListbox.Items.Add(checkBox16.Text + " " + priceTxtBox.Text);
                defaultqty();
            }
        }

        private void checkBox17_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox17.Checked == true)
            {
                priceTxtBox.Text = dbconnect.pos_sql_dataset.Tables[0].Rows[0][62].ToString();
                chkbx_function();
                displayListbox.Items.Add(checkBox17.Text + " " + priceTxtBox.Text);
                defaultqty();
            }
        }

        private void checkBox18_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox18.Checked == true)
            {
                priceTxtBox.Text = dbconnect.pos_sql_dataset.Tables[0].Rows[0][63].ToString();
                chkbx_function();
                displayListbox.Items.Add(checkBox18.Text + " " + priceTxtBox.Text);
                defaultqty();
            }
        }

        private void checkBox19_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox19.Checked == true)
            {
                priceTxtBox.Text = dbconnect.pos_sql_dataset.Tables[0].Rows[0][64].ToString();
                chkbx_function();
                displayListbox.Items.Add(checkBox19.Text + " " + priceTxtBox.Text);
                defaultqty();
            }
        }

        private void checkBox20_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox20.Checked == true)
            {
                priceTxtBox.Text = dbconnect.pos_sql_dataset.Tables[0].Rows[0][65].ToString();
                chkbx_function();
                displayListbox.Items.Add(checkBox20.Text + " " + priceTxtBox.Text);
                defaultqty();
            }
        }

        // FUNCTIONS

        private void dbload()
        {
            dbconnect.pos_sql = "SELECT * FROM pos_nameTbl INNER JOIN pos_picTbl ON pos_nameTbl.pos_id = pos_picTbl.pos_id " +
    "INNER JOIN pos_priceTbl ON pos_picTbl.pos_id = pos_priceTbl.pos_id WHERE pos_nameTbl.pos_id = '"
    + 7 + "'";
            dbconnect.pos_cmd();
            dbconnect.pos_sqladapterSelect();
            dbconnect.pos_sqldatasetSELECT();
            GridView.DataSource = dbconnect.pos_sql_dataset.Tables[0];
            checkBox1.Text = dbconnect.pos_sql_dataset.Tables[0].Rows[0][2].ToString();
            checkBox2.Text = dbconnect.pos_sql_dataset.Tables[0].Rows[0][3].ToString();
            checkBox3.Text = dbconnect.pos_sql_dataset.Tables[0].Rows[0][4].ToString();
            checkBox4.Text = dbconnect.pos_sql_dataset.Tables[0].Rows[0][5].ToString();
            checkBox5.Text = dbconnect.pos_sql_dataset.Tables[0].Rows[0][6].ToString();
            checkBox6.Text = dbconnect.pos_sql_dataset.Tables[0].Rows[0][7].ToString();
            checkBox7.Text = dbconnect.pos_sql_dataset.Tables[0].Rows[0][8].ToString();
            checkBox8.Text = dbconnect.pos_sql_dataset.Tables[0].Rows[0][9].ToString();
            checkBox9.Text = dbconnect.pos_sql_dataset.Tables[0].Rows[0][10].ToString();
            checkBox10.Text = dbconnect.pos_sql_dataset.Tables[0].Rows[0][11].ToString();
            checkBox11.Text = dbconnect.pos_sql_dataset.Tables[0].Rows[0][12].ToString();
            checkBox12.Text = dbconnect.pos_sql_dataset.Tables[0].Rows[0][13].ToString();
            checkBox13.Text = dbconnect.pos_sql_dataset.Tables[0].Rows[0][14].ToString();
            checkBox14.Text = dbconnect.pos_sql_dataset.Tables[0].Rows[0][15].ToString();
            checkBox15.Text = dbconnect.pos_sql_dataset.Tables[0].Rows[0][16].ToString();
            checkBox16.Text = dbconnect.pos_sql_dataset.Tables[0].Rows[0][17].ToString();
            checkBox17.Text = dbconnect.pos_sql_dataset.Tables[0].Rows[0][18].ToString();
            checkBox18.Text = dbconnect.pos_sql_dataset.Tables[0].Rows[0][19].ToString();
            checkBox19.Text = dbconnect.pos_sql_dataset.Tables[0].Rows[0][20].ToString();
            checkBox20.Text = dbconnect.pos_sql_dataset.Tables[0].Rows[0][21].ToString();

            picpath1_tbox.Text = dbconnect.pos_sql_dataset.Tables[0].Rows[0][24].ToString();
            pictureBox1.Image = Image.FromFile(picpath1_tbox.Text);
            picpath2_tbox.Text = dbconnect.pos_sql_dataset.Tables[0].Rows[0][25].ToString();
            pictureBox2.Image = Image.FromFile(picpath2_tbox.Text);
            picpath3_tbox.Text = dbconnect.pos_sql_dataset.Tables[0].Rows[0][26].ToString();
            pictureBox3.Image = Image.FromFile(picpath3_tbox.Text);
            picpath4_tbox.Text = dbconnect.pos_sql_dataset.Tables[0].Rows[0][27].ToString();
            pictureBox4.Image = Image.FromFile(picpath4_tbox.Text);
            picpath5_tbox.Text = dbconnect.pos_sql_dataset.Tables[0].Rows[0][28].ToString();
            pictureBox5.Image = Image.FromFile(picpath5_tbox.Text);
            picpath6_tbox.Text = dbconnect.pos_sql_dataset.Tables[0].Rows[0][29].ToString();
            pictureBox6.Image = Image.FromFile(picpath6_tbox.Text);
            picpath7_tbox.Text = dbconnect.pos_sql_dataset.Tables[0].Rows[0][30].ToString();
            pictureBox7.Image = Image.FromFile(picpath7_tbox.Text);
            picpath8_tbox.Text = dbconnect.pos_sql_dataset.Tables[0].Rows[0][31].ToString();
            pictureBox8.Image = Image.FromFile(picpath8_tbox.Text);
            picpath9_tbox.Text = dbconnect.pos_sql_dataset.Tables[0].Rows[0][32].ToString();
            pictureBox9.Image = Image.FromFile(picpath9_tbox.Text);
            picpath10_tbox.Text = dbconnect.pos_sql_dataset.Tables[0].Rows[0][33].ToString();
            pictureBox10.Image = Image.FromFile(picpath10_tbox.Text);
            picpath11_tbox.Text = dbconnect.pos_sql_dataset.Tables[0].Rows[0][34].ToString();
            pictureBox11.Image = Image.FromFile(picpath11_tbox.Text);
            picpath12_tbox.Text = dbconnect.pos_sql_dataset.Tables[0].Rows[0][35].ToString();
            pictureBox12.Image = Image.FromFile(picpath12_tbox.Text);
            picpath13_tbox.Text = dbconnect.pos_sql_dataset.Tables[0].Rows[0][36].ToString();
            pictureBox13.Image = Image.FromFile(picpath13_tbox.Text);
            picpath14_tbox.Text = dbconnect.pos_sql_dataset.Tables[0].Rows[0][37].ToString();
            pictureBox14.Image = Image.FromFile(picpath14_tbox.Text);
            picpath15_tbox.Text = dbconnect.pos_sql_dataset.Tables[0].Rows[0][38].ToString();
            pictureBox15.Image = Image.FromFile(picpath15_tbox.Text);
            picpath16_tbox.Text = dbconnect.pos_sql_dataset.Tables[0].Rows[0][39].ToString();
            pictureBox16.Image = Image.FromFile(picpath16_tbox.Text);
            picpath17_tbox.Text = dbconnect.pos_sql_dataset.Tables[0].Rows[0][40].ToString();
            pictureBox17.Image = Image.FromFile(picpath17_tbox.Text);
            picpath18_tbox.Text = dbconnect.pos_sql_dataset.Tables[0].Rows[0][41].ToString();
            pictureBox18.Image = Image.FromFile(picpath18_tbox.Text);
            picpath19_tbox.Text = dbconnect.pos_sql_dataset.Tables[0].Rows[0][42].ToString();
            pictureBox19.Image = Image.FromFile(picpath19_tbox.Text);
            picpath20_tbox.Text = dbconnect.pos_sql_dataset.Tables[0].Rows[0][43].ToString();
            pictureBox20.Image = Image.FromFile(picpath20_tbox.Text);
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
        private void selectA()
        {
            A_CokeCheckBox.Checked = true;
            A_ChickenCheckBox.Checked = true;
            A_FriesCheckBox.Checked = true;
            A_SideCheckBox.Checked = true;
            A_PizzaCheckBox.Checked = true;
        }
        private void selectB()
        {
            B_CarbonaraCheckBox.Checked = true;
            B_ChickenCheckBox.Checked = true;
            B_FriesCheckBox.Checked = true;
            B_HaloCheckBox.Checked = true;
            B_PizzaCheckBox.Checked = true;
        }
        private void clearA()
        {
            foodARdbtn.Checked = false;
            A_CokeCheckBox.Checked = false;
            A_ChickenCheckBox.Checked = false;
            A_FriesCheckBox.Checked = false;
            A_SideCheckBox.Checked = false;
            A_PizzaCheckBox.Checked = false;
        }
        private void clearB()
        {
            foodBRdbtn.Checked = false;
            B_CarbonaraCheckBox.Checked = false;
            B_ChickenCheckBox.Checked = false;
            B_FriesCheckBox.Checked = false;
            B_HaloCheckBox.Checked = false;
            B_PizzaCheckBox.Checked = false;
        }
        private void clear()
        {
            GridView.Hide();

            // Hide picpath
            picpath1_tbox.Hide();
            picpath2_tbox.Hide();
            picpath3_tbox.Hide();
            picpath4_tbox.Hide();
            picpath5_tbox.Hide();
            picpath6_tbox.Hide();
            picpath7_tbox.Hide();
            picpath8_tbox.Hide();
            picpath9_tbox.Hide();
            picpath10_tbox.Hide();
            picpath11_tbox.Hide();
            picpath12_tbox.Hide();
            picpath13_tbox.Hide();
            picpath14_tbox.Hide();
            picpath15_tbox.Hide();
            picpath16_tbox.Hide();
            picpath17_tbox.Hide();
            picpath18_tbox.Hide();
            picpath19_tbox.Hide();
            picpath20_tbox.Hide();

            // Uncheck all given checkboxes
            clearA();
            clearB();

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
