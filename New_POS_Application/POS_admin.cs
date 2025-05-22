using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static ZXing.QrCode.Internal.Mode;

namespace New_POS_Application
{
    public partial class POS_admin : Form
    {
        POS_dbconnect dbconnect = new POS_dbconnect();
        OpenFileDialog PicFile = new OpenFileDialog();
        private string picpath;
        private Image defaultpic;
        public POS_admin()
        {
            InitializeComponent();
            dbconnect.pos_connString();
            try
            {
                dbconnect.pos_select();
                dbconnect.pos_cmd();
                dbconnect.pos_sqladapterSelect();
                dbconnect.pos_sqldatasetSELECT();
                GridView.DataSource = dbconnect.pos_sql_dataset.Tables[0];
            }
            catch (Exception)
            {
                MessageBox.Show("Error occurs in this area. Please contact your administrator!");
            }
            HidePath();
        }

        // EVENTS

        private void Search_btn_Click(object sender, EventArgs e)
        {
            try
            {
                dbconnect.pos_sql = "SELECT * FROM pos_nameTbl INNER JOIN pos_picTbl ON pos_nameTbl.pos_id = pos_picTbl.pos_id " +
                    "INNER JOIN pos_priceTbl ON pos_picTbl.pos_id = pos_priceTbl.pos_id WHERE pos_nameTbl.pos_id = '"
                    + POSID_cbox.Text + "'";
                dbconnect.pos_cmd();
                dbconnect.pos_sqladapterSelect();
                dbconnect.pos_sqldatasetSELECT();
                GridView.DataSource = dbconnect.pos_sql_dataset.Tables[0];
                item1_tbox.Text = dbconnect.pos_sql_dataset.Tables[0].Rows[0][2].ToString();
                item2_tbox.Text = dbconnect.pos_sql_dataset.Tables[0].Rows[0][3].ToString();
                item3_tbox.Text = dbconnect.pos_sql_dataset.Tables[0].Rows[0][4].ToString();
                item4_tbox.Text = dbconnect.pos_sql_dataset.Tables[0].Rows[0][5].ToString();
                item5_tbox.Text = dbconnect.pos_sql_dataset.Tables[0].Rows[0][6].ToString();
                item6_tbox.Text = dbconnect.pos_sql_dataset.Tables[0].Rows[0][7].ToString();
                item7_tbox.Text = dbconnect.pos_sql_dataset.Tables[0].Rows[0][8].ToString();
                item8_tbox.Text = dbconnect.pos_sql_dataset.Tables[0].Rows[0][9].ToString();
                item9_tbox.Text = dbconnect.pos_sql_dataset.Tables[0].Rows[0][10].ToString();
                item10_tbox.Text = dbconnect.pos_sql_dataset.Tables[0].Rows[0][11].ToString();
                item11_tbox.Text = dbconnect.pos_sql_dataset.Tables[0].Rows[0][12].ToString();
                item12_tbox.Text = dbconnect.pos_sql_dataset.Tables[0].Rows[0][13].ToString();
                item13_tbox.Text = dbconnect.pos_sql_dataset.Tables[0].Rows[0][14].ToString();
                item14_tbox.Text = dbconnect.pos_sql_dataset.Tables[0].Rows[0][15].ToString();
                item15_tbox.Text = dbconnect.pos_sql_dataset.Tables[0].Rows[0][16].ToString();
                item16_tbox.Text = dbconnect.pos_sql_dataset.Tables[0].Rows[0][17].ToString();
                item17_tbox.Text = dbconnect.pos_sql_dataset.Tables[0].Rows[0][18].ToString();
                item18_tbox.Text = dbconnect.pos_sql_dataset.Tables[0].Rows[0][19].ToString();
                item19_tbox.Text = dbconnect.pos_sql_dataset.Tables[0].Rows[0][20].ToString();
                item20_tbox.Text = dbconnect.pos_sql_dataset.Tables[0].Rows[0][21].ToString();

                picpath1_tbox.Text = dbconnect.pos_sql_dataset.Tables[0].Rows[0][24].ToString();
                pic1_pbox.Image = Image.FromFile(picpath1_tbox.Text);
                picpath2_tbox.Text = dbconnect.pos_sql_dataset.Tables[0].Rows[0][25].ToString();
                pic2_pbox.Image = Image.FromFile(picpath2_tbox.Text);
                picpath3_tbox.Text = dbconnect.pos_sql_dataset.Tables[0].Rows[0][26].ToString();
                pic3_pbox.Image = Image.FromFile(picpath3_tbox.Text);
                picpath4_tbox.Text = dbconnect.pos_sql_dataset.Tables[0].Rows[0][27].ToString();
                pic4_pbox.Image = Image.FromFile(picpath4_tbox.Text);
                picpath5_tbox.Text = dbconnect.pos_sql_dataset.Tables[0].Rows[0][28].ToString();
                pic5_pbox.Image = Image.FromFile(picpath5_tbox.Text);
                picpath6_tbox.Text = dbconnect.pos_sql_dataset.Tables[0].Rows[0][29].ToString();
                pic6_pbox.Image = Image.FromFile(picpath6_tbox.Text);
                picpath7_tbox.Text = dbconnect.pos_sql_dataset.Tables[0].Rows[0][30].ToString();
                pic7_pbox.Image = Image.FromFile(picpath7_tbox.Text);
                picpath8_tbox.Text = dbconnect.pos_sql_dataset.Tables[0].Rows[0][31].ToString();
                pic8_pbox.Image = Image.FromFile(picpath8_tbox.Text);
                picpath9_tbox.Text = dbconnect.pos_sql_dataset.Tables[0].Rows[0][32].ToString();
                pic9_pbox.Image = Image.FromFile(picpath9_tbox.Text);
                picpath10_tbox.Text = dbconnect.pos_sql_dataset.Tables[0].Rows[0][33].ToString();
                pic10_pbox.Image = Image.FromFile(picpath10_tbox.Text);
                picpath11_tbox.Text = dbconnect.pos_sql_dataset.Tables[0].Rows[0][34].ToString();
                pic11_pbox.Image = Image.FromFile(picpath11_tbox.Text);
                picpath12_tbox.Text = dbconnect.pos_sql_dataset.Tables[0].Rows[0][35].ToString();
                pic12_pbox.Image = Image.FromFile(picpath12_tbox.Text);
                picpath13_tbox.Text = dbconnect.pos_sql_dataset.Tables[0].Rows[0][36].ToString();
                pic13_pbox.Image = Image.FromFile(picpath13_tbox.Text);
                picpath14_tbox.Text = dbconnect.pos_sql_dataset.Tables[0].Rows[0][37].ToString();
                pic14_pbox.Image = Image.FromFile(picpath14_tbox.Text);
                picpath15_tbox.Text = dbconnect.pos_sql_dataset.Tables[0].Rows[0][38].ToString();
                pic15_pbox.Image = Image.FromFile(picpath15_tbox.Text);
                picpath16_tbox.Text = dbconnect.pos_sql_dataset.Tables[0].Rows[0][39].ToString();
                pic16_pbox.Image = Image.FromFile(picpath16_tbox.Text);
                picpath17_tbox.Text = dbconnect.pos_sql_dataset.Tables[0].Rows[0][40].ToString();
                pic17_pbox.Image = Image.FromFile(picpath17_tbox.Text);
                picpath18_tbox.Text = dbconnect.pos_sql_dataset.Tables[0].Rows[0][41].ToString();
                pic18_pbox.Image = Image.FromFile(picpath18_tbox.Text);
                picpath19_tbox.Text = dbconnect.pos_sql_dataset.Tables[0].Rows[0][42].ToString();
                pic19_pbox.Image = Image.FromFile(picpath19_tbox.Text);
                picpath20_tbox.Text = dbconnect.pos_sql_dataset.Tables[0].Rows[0][43].ToString();
                pic20_pbox.Image = Image.FromFile(picpath20_tbox.Text);

                price1_tbox.Text = dbconnect.pos_sql_dataset.Tables[0].Rows[0][46].ToString();
                price2_tbox.Text = dbconnect.pos_sql_dataset.Tables[0].Rows[0][47].ToString();
                price3_tbox.Text = dbconnect.pos_sql_dataset.Tables[0].Rows[0][48].ToString();
                price4_tbox.Text = dbconnect.pos_sql_dataset.Tables[0].Rows[0][49].ToString();
                price5_tbox.Text = dbconnect.pos_sql_dataset.Tables[0].Rows[0][50].ToString();
                price6_tbox.Text = dbconnect.pos_sql_dataset.Tables[0].Rows[0][51].ToString();
                price7_tbox.Text = dbconnect.pos_sql_dataset.Tables[0].Rows[0][52].ToString();
                price8_tbox.Text = dbconnect.pos_sql_dataset.Tables[0].Rows[0][53].ToString();
                price9_tbox.Text = dbconnect.pos_sql_dataset.Tables[0].Rows[0][54].ToString();
                price10_tbox.Text = dbconnect.pos_sql_dataset.Tables[0].Rows[0][55].ToString();
                price11_tbox.Text = dbconnect.pos_sql_dataset.Tables[0].Rows[0][56].ToString();
                price12_tbox.Text = dbconnect.pos_sql_dataset.Tables[0].Rows[0][57].ToString();
                price13_tbox.Text = dbconnect.pos_sql_dataset.Tables[0].Rows[0][58].ToString();
                price14_tbox.Text = dbconnect.pos_sql_dataset.Tables[0].Rows[0][59].ToString();
                price15_tbox.Text = dbconnect.pos_sql_dataset.Tables[0].Rows[0][60].ToString();
                price16_tbox.Text = dbconnect.pos_sql_dataset.Tables[0].Rows[0][61].ToString();
                price17_tbox.Text = dbconnect.pos_sql_dataset.Tables[0].Rows[0][62].ToString();
                price18_tbox.Text = dbconnect.pos_sql_dataset.Tables[0].Rows[0][63].ToString();
                price19_tbox.Text = dbconnect.pos_sql_dataset.Tables[0].Rows[0][64].ToString();
                price20_tbox.Text = dbconnect.pos_sql_dataset.Tables[0].Rows[0][65].ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Error occurs in this area. Please contact your administrator!");
            }
        }
       
        private void Save_btn_Click(object sender, EventArgs e)
        {
            try
            {
                dbconnect.pos_sql = "INSERT INTO pos_nameTbl ( pos_id, name1, name2, name3, name4, name5, name6, " +
                    "name7, name8, name9, name10, name11, name12, name13, name14, name15, name16, name17, name18, name19, " +
                    "name20) VALUES('" + POSID_cbox.Text + "', '" + item1_tbox.Text + "', '" + item2_tbox.Text + "', '" 
                    + item3_tbox.Text + "', '" + item4_tbox.Text + "','" + item5_tbox.Text + "', '" + item6_tbox.Text + "', '" 
                    + item7_tbox.Text + "', '" + item8_tbox.Text + "', '" + item9_tbox.Text + "', '" + item10_tbox.Text + "', '" 
                    + item11_tbox.Text + "', '" + item12_tbox.Text + "', '" + item13_tbox.Text + "', '" + item14_tbox.Text + "', '" 
                    + item15_tbox.Text + "', '" + item16_tbox.Text + "', '" + item17_tbox.Text + "', '" + item18_tbox.Text + "', '" 
                    + item19_tbox.Text + "', '" + item20_tbox.Text + "')";
                dbconnect.pos_cmd();
                dbconnect.pos_sqladapterInsert();
                dbconnect.pos_sql = "INSERT INTO pos_priceTbl (price1, price2, price3, price4, price5, price6, price7, price8, " +
                    "price9, price10, price11, price12, price13, price14, price15, price16, price17, price18, price19, price20, pos_id) " +
                    "VALUES('" + price1_tbox.Text + "', '" + price2_tbox.Text + "', '" + price3_tbox.Text + "', '" + price4_tbox.Text 
                    + "','" + price5_tbox.Text + "', '" + price6_tbox.Text + "', '" + price7_tbox.Text + "', '" + price8_tbox.Text 
                    + "', '" + price9_tbox.Text + "', '" + price10_tbox.Text + "', '" + price11_tbox.Text + "', '" + price12_tbox.Text 
                    + "', '" + price13_tbox.Text + "', '" + price14_tbox.Text + "', '" + price15_tbox.Text + "', '" + price16_tbox.Text 
                    + "', '" + price17_tbox.Text + "', '" + price18_tbox.Text + "', '" + price19_tbox.Text + "', '" + price20_tbox.Text 
                    + "', '" + POSID_cbox.Text + "')";
                dbconnect.pos_cmd();
                dbconnect.pos_sqladapterInsert();
                dbconnect.pos_sql = "INSERT INTO pos_picTbl (pic1, pic2, pic3, pic4, pic5, pic6, pic7, pic8, pic9, pic10, pic11, " +
                    "pic12, pic13, pic14, pic15, pic16, pic17, pic18, pic19, pic20, pos_id) VALUES('" + picpath1_tbox.Text + "', '" 
                    + picpath2_tbox.Text + "', '" + picpath3_tbox.Text + "', '" + picpath4_tbox.Text + "','" + picpath5_tbox.Text 
                    + "', '" + picpath6_tbox.Text + "', '" + picpath7_tbox.Text + "', '" + picpath8_tbox.Text + "', '" 
                    + picpath9_tbox.Text + "', '" + picpath10_tbox.Text + "', '" + picpath11_tbox.Text + "', '" + picpath12_tbox.Text 
                    + "', '" + picpath13_tbox.Text + "', '" + picpath14_tbox.Text + "', '" + picpath15_tbox.Text + "', '" 
                    + picpath16_tbox.Text + "', '" + picpath17_tbox.Text + "', '" + picpath18_tbox.Text + "', '" + picpath19_tbox.Text 
                    + "', '" + picpath20_tbox.Text + "', '" + POSID_cbox.Text + "')";
                dbconnect.pos_cmd();
                dbconnect.pos_sqladapterInsert();
                dbconnect.pos_select();
                dbconnect.pos_cmd();
                dbconnect.pos_sqladapterSelect();
                dbconnect.pos_sqldatasetSELECT();
                GridView.DataSource = dbconnect.pos_sql_dataset.Tables[0];
                DefaultForm();
            }
            catch (Exception)
            {
                MessageBox.Show("Error occurs in this area. Please contact your administrator!");
            }
        }

        private void Update_btn_Click(object sender, EventArgs e)
        {
            try
            {
                dbconnect.pos_sql = "UPDATE pos_nameTbl SET name1 = '" + item1_tbox.Text + "', name2 = '" + item2_tbox.Text 
                    + "', name3 = '" + item3_tbox.Text + "', name4 = '" + item4_tbox.Text + "', name5 = '" + item5_tbox.Text 
                    + "', name6 = '" + item6_tbox.Text + "', name7 = '" + item7_tbox.Text + "', name8 = '" + item8_tbox.Text 
                    + "', name9 = '" + item9_tbox.Text + "', name10 = '" + item10_tbox.Text + "', name11 = '" + item11_tbox.Text 
                    + "', name12 = '" + item12_tbox.Text + "', name13 = '" + item13_tbox.Text + "', name14 = '" + item14_tbox.Text 
                    + "', name15 = '" + item15_tbox.Text + "', name16 = '" + item16_tbox.Text + "', name17 = '" + item17_tbox.Text 
                    + "', name18 = '" + item18_tbox.Text + "', name19 = '" + item19_tbox.Text + "', name20 = '" + item20_tbox.Text 
                    + "' WHERE pos_id = '" + POSID_cbox.Text + "'";
                dbconnect.pos_cmd();
                dbconnect.pos_sqladapterUpdate();
                dbconnect.pos_sql = "UPDATE pos_picTbl SET pic1 = '" + picpath1_tbox.Text + "', pic2 = '" + picpath2_tbox.Text 
                    + "', pic3 = '" + picpath3_tbox.Text + "', pic4 = '" + picpath4_tbox.Text + "', pic5 = '" + picpath5_tbox.Text 
                    + "', pic6 = '" + picpath6_tbox.Text + "', pic7 = '" + picpath7_tbox.Text + "', pic8 = '" + picpath8_tbox.Text 
                    + "', pic9 = '" + picpath9_tbox.Text + "', pic10 = '" + picpath10_tbox.Text + "', pic11 = '" + picpath11_tbox.Text 
                    + "', pic12 = '" + picpath12_tbox.Text + "', pic13 = '" + picpath13_tbox.Text + "', pic14 = '" + picpath14_tbox.Text 
                    + "', pic15 = '" + picpath15_tbox.Text + "', pic16 = '" + picpath16_tbox.Text + "', pic17 = '" + picpath17_tbox.Text 
                    + "', pic18 = '" + picpath18_tbox.Text + "', pic19 = '" + picpath19_tbox.Text + "', pic20 = '" + picpath20_tbox.Text 
                    + "' WHERE pos_id = '" + POSID_cbox.Text + "'";
                dbconnect.pos_cmd();
                dbconnect.pos_sqladapterUpdate();
                dbconnect.pos_sql = "UPDATE pos_priceTbl SET price1 = '" + price1_tbox.Text + "', price2 = '" + price2_tbox.Text 
                    + "', price3 = '" + price3_tbox.Text + "', price4 = '" + price4_tbox.Text + "', price5 = '" + price5_tbox.Text 
                    + "', price6 = '" + price6_tbox.Text + "', price7 = '" + price7_tbox.Text + "', price8 = '" + price8_tbox.Text 
                    + "', price9 = '" + price9_tbox.Text + "', price10 = '" + price10_tbox.Text + "', price11 = '" + price11_tbox.Text 
                    + "', price12 = '" + price12_tbox.Text + "', price13 = '" + price13_tbox.Text + "', price14 = '" + price14_tbox.Text 
                    + "', price15 = '" + price15_tbox.Text + "', price16 = '" + price16_tbox.Text + "', price17 = '" + price17_tbox.Text 
                    + "', price18 = '" + price18_tbox.Text + "', price19 = '" + price19_tbox.Text + "', price20 = '" + price20_tbox.Text 
                    + "' WHERE pos_id = '" + POSID_cbox.Text + "'";
                dbconnect.pos_cmd();
                dbconnect.pos_sqladapterUpdate();
                dbconnect.pos_select();
                dbconnect.pos_cmd();
                dbconnect.pos_sqladapterSelect();
                dbconnect.pos_sqldatasetSELECT();
                GridView.DataSource = dbconnect.pos_sql_dataset.Tables[0];
                DefaultForm();
            }
            catch (Exception)
            {
                MessageBox.Show("Error occurs in this area. Please contact your administrator!");
            }
        }

        private void Delete_btn_Click(object sender, EventArgs e)
        {
            try
            {
                dbconnect.pos_sql = "DELETE FROM pos_priceTbl WHERE pos_priceTbl.pos_id = '" + POSID_cbox.Text + "'";
                dbconnect.pos_cmd();
                dbconnect.pos_sqladapterDelete();
                dbconnect.pos_sql = "DELETE FROM pos_picTbl WHERE pos_picTbl.pos_id = '" + POSID_cbox.Text + "'";
                dbconnect.pos_cmd();
                dbconnect.pos_sqladapterDelete();
                dbconnect.pos_sql = "DELETE FROM pos_nameTbl WHERE pos_nameTbl.pos_id = '" + POSID_cbox.Text + "'";
                dbconnect.pos_cmd();
                dbconnect.pos_sqladapterDelete();
                dbconnect.pos_select();
                dbconnect.pos_cmd();
                dbconnect.pos_sqladapterSelect();
                dbconnect.pos_sqldatasetSELECT();
                GridView.DataSource = dbconnect.pos_sql_dataset.Tables[0];
                DefaultForm();
            }
            catch (Exception)
            {
                MessageBox.Show("Error occurs in this area. Please contact your administrator!");
            }
        }

        private void New_btn_Click(object sender, EventArgs e)
        {
            DefaultForm();
        }

        private void Exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pic1_pbox_Click(object sender, EventArgs e)
        {
            PictureSelect();
            picpath = PicFile.FileName;
            picpath1_tbox.Text = picpath;
            pic1_pbox.Image = Image.FromFile(picpath);
        }

        private void pic2_pbox_Click(object sender, EventArgs e)
        {
            PictureSelect();
            picpath = PicFile.FileName;
            picpath2_tbox.Text = picpath;
            pic2_pbox.Image = Image.FromFile(picpath);
        }

        private void pic3_pbox_Click(object sender, EventArgs e)
        {
            PictureSelect();
            picpath = PicFile.FileName;
            picpath3_tbox.Text = picpath;
            pic3_pbox.Image = Image.FromFile(picpath);
        }

        private void pic4_pbox_Click(object sender, EventArgs e)
        {
            PictureSelect();
            picpath = PicFile.FileName;
            picpath4_tbox.Text = picpath;
            pic4_pbox.Image = Image.FromFile(picpath);
        }

        private void pic5_pbox_Click(object sender, EventArgs e)
        {
            PictureSelect();
            picpath = PicFile.FileName;
            picpath5_tbox.Text = picpath;
            pic5_pbox.Image = Image.FromFile(picpath);
        }

        private void pic6_pbox_Click(object sender, EventArgs e)
        {
            PictureSelect();
            picpath = PicFile.FileName;
            picpath6_tbox.Text = picpath;
            pic6_pbox.Image = Image.FromFile(picpath);
        }

        private void pic7_pbox_Click(object sender, EventArgs e)
        {
            PictureSelect();
            picpath = PicFile.FileName;
            picpath7_tbox.Text = picpath;
            pic7_pbox.Image = Image.FromFile(picpath);
        }

        private void pic8_pbox_Click(object sender, EventArgs e)
        {
            PictureSelect();
            picpath = PicFile.FileName;
            picpath8_tbox.Text = picpath;
            pic8_pbox.Image = Image.FromFile(picpath);
        }

        private void pic9_pbox_Click(object sender, EventArgs e)
        {
            PictureSelect();
            picpath = PicFile.FileName;
            picpath9_tbox.Text = picpath;
            pic9_pbox.Image = Image.FromFile(picpath);
        }

        private void pic10_pbox_Click(object sender, EventArgs e)
        {
            PictureSelect();
            picpath = PicFile.FileName;
            picpath10_tbox.Text = picpath;
            pic10_pbox.Image = Image.FromFile(picpath);
        }

        private void pic11_pbox_Click(object sender, EventArgs e)
        {
            PictureSelect();
            picpath = PicFile.FileName;
            picpath11_tbox.Text = picpath;
            pic11_pbox.Image = Image.FromFile(picpath);
        }

        private void pic12_pbox_Click(object sender, EventArgs e)
        {
            PictureSelect();
            picpath = PicFile.FileName;
            picpath12_tbox.Text = picpath;
            pic12_pbox.Image = Image.FromFile(picpath);
        }

        private void pic13_pbox_Click(object sender, EventArgs e)
        {
            PictureSelect();
            picpath = PicFile.FileName;
            picpath13_tbox.Text = picpath;
            pic13_pbox.Image = Image.FromFile(picpath);
        }

        private void pic14_pbox_Click(object sender, EventArgs e)
        {
            PictureSelect();
            picpath = PicFile.FileName;
            picpath14_tbox.Text = picpath;
            pic14_pbox.Image = Image.FromFile(picpath);
        }

        private void pic15_pbox_Click(object sender, EventArgs e)
        {
            PictureSelect();
            picpath = PicFile.FileName;
            picpath15_tbox.Text = picpath;
            pic15_pbox.Image = Image.FromFile(picpath);
        }

        private void pic16_pbox_Click(object sender, EventArgs e)
        {
            PictureSelect();
            picpath = PicFile.FileName;
            picpath16_tbox.Text = picpath;
            pic16_pbox.Image = Image.FromFile(picpath);
        }

        private void pic17_pbox_Click(object sender, EventArgs e)
        {
            PictureSelect();
            picpath = PicFile.FileName;
            picpath17_tbox.Text = picpath;
            pic17_pbox.Image = Image.FromFile(picpath);
        }

        private void pic18_pbox_Click(object sender, EventArgs e)
        {
            PictureSelect();
            picpath = PicFile.FileName;
            picpath18_tbox.Text = picpath;
            pic18_pbox.Image = Image.FromFile(picpath);
        }

        private void pic19_pbox_Click(object sender, EventArgs e)
        {
            PictureSelect();
            picpath = PicFile.FileName;
            picpath19_tbox.Text = picpath;
            pic19_pbox.Image = Image.FromFile(picpath);
        }

        private void pic20_pbox_Click(object sender, EventArgs e)
        {
            PictureSelect();
            picpath = PicFile.FileName;
            picpath20_tbox.Text = picpath;
            pic20_pbox.Image = Image.FromFile(picpath);
        }

        // FUNCTIONS

        public void HidePath()
        {
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
        }

        private void PictureSelect()
        {
            PicFile.Filter = "Image File | * .gif; * .jpg; * .png; * .bmp; * .jfif;";
            PicFile.Title = "Select Picture";
            PicFile.ShowDialog();
        }

        private void DefaultForm()
        {
            try
            {
                defaultpic = Image.FromFile("D:\\repos\\mendax0321\\New_POS_Application\\images\\noimage.jpg");
               
                picpath1_tbox.Clear(); picpath2_tbox.Clear(); picpath3_tbox.Clear();
                picpath4_tbox.Clear(); picpath5_tbox.Clear(); picpath6_tbox.Clear();
                picpath7_tbox.Clear(); picpath8_tbox.Clear(); picpath9_tbox.Clear();
                picpath10_tbox.Clear(); picpath11_tbox.Clear(); picpath12_tbox.Clear();
                picpath13_tbox.Clear(); picpath14_tbox.Clear(); picpath15_tbox.Clear();
                picpath16_tbox.Clear(); picpath17_tbox.Clear(); picpath18_tbox.Clear();
                picpath19_tbox.Clear(); picpath20_tbox.Clear(); 
                pic1_pbox.Image = defaultpic; pic8_pbox.Image = defaultpic; pic15_pbox.Image = defaultpic;
                pic2_pbox.Image = defaultpic; pic9_pbox.Image = defaultpic; pic16_pbox.Image = defaultpic;
                pic3_pbox.Image = defaultpic; pic10_pbox.Image = defaultpic; pic17_pbox.Image = defaultpic;
                pic4_pbox.Image = defaultpic; pic11_pbox.Image = defaultpic; pic18_pbox.Image = defaultpic;
                pic5_pbox.Image = defaultpic; pic12_pbox.Image = defaultpic; pic19_pbox.Image = defaultpic;
                pic6_pbox.Image = defaultpic; pic13_pbox.Image = defaultpic; pic20_pbox.Image = defaultpic;
                pic7_pbox.Image = defaultpic; pic14_pbox.Image = defaultpic;
                price1_tbox.Clear(); price8_tbox.Clear(); price15_tbox.Clear();
                price2_tbox.Clear(); price9_tbox.Clear(); price16_tbox.Clear();
                price3_tbox.Clear(); price10_tbox.Clear(); price17_tbox.Clear();
                price4_tbox.Clear(); price11_tbox.Clear(); price18_tbox.Clear();
                price5_tbox.Clear(); price12_tbox.Clear(); price19_tbox.Clear();
                price6_tbox.Clear(); price13_tbox.Clear(); price20_tbox.Clear();
                price7_tbox.Clear(); price14_tbox.Clear();
                item1_tbox.Clear(); item8_tbox.Clear(); item15_tbox.Clear();
                item2_tbox.Clear(); item9_tbox.Clear(); item16_tbox.Clear();
                item3_tbox.Clear(); item10_tbox.Clear(); item17_tbox.Clear();
                item4_tbox.Clear(); item11_tbox.Clear(); item18_tbox.Clear();
                item5_tbox.Clear(); item12_tbox.Clear(); item19_tbox.Clear();
                item6_tbox.Clear(); item13_tbox.Clear(); item20_tbox.Clear();
                item7_tbox.Clear(); item14_tbox.Clear();
            }
            catch (Exception)
            {
                MessageBox.Show("Error occurs in this area. Please contact your administrator!");
            }
        }
    }
}
