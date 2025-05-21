using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace New_POS_Application
{
    public partial class POS_admin : Form
    {
        OpenFileDialog PicFile = new OpenFileDialog();
        private string picpath;
        private Image defaultpic;
        public POS_admin()
        {
            InitializeComponent();
            HidePath();
        }

        // EVENTS

        private void Search_btn_Click(object sender, EventArgs e)
        {

        }

        private void Save_btn_Click(object sender, EventArgs e)
        {

        }

        private void Update_btn_Click(object sender, EventArgs e)
        {

        }

        private void Delete_btn_Click(object sender, EventArgs e)
        {

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
            PicFile.Filter = "Image File | * .gif; * .jpg; * .png; * .bmp;";
            PicFile.Title = "Select Picture";
            PicFile.ShowDialog();
        }

        private void DefaultForm()
        {
            try
            {
                defaultpic = Image.FromFile("C:\\Users\\rizal\\source\\repos\\mendax0321\\New_POS_Application\\images\\noimage.jpg");
               
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
