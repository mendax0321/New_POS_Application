using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Controls;
using System.Windows.Media;
using Image = System.Drawing.Image;
using static System.Net.Mime.MediaTypeNames;

namespace New_POS_Application
{
    public partial class StudentDB : Form
    {
        String picpath;
        String constring = null;
        SqlConnection conn;
        SqlCommand cmd;
        DataSet dset;
        SqlDataAdapter sqladptr;
        string sql = null;

        public StudentDB()
        {
            constring = "Data Source = LAPTOP-51BFEU3U\\SQLEXPRESS; Initial Catalog = POS_db; user id = admin; password = 1234";
            conn = new SqlConnection(constring);
            InitializeComponent();
        }

        private void StudentDB_Load(object sender, EventArgs e)
        {
            clearall();
            Pboxpath.Enabled = false;
            Pboxpath.Hide();
            defaulttable();
        }

        private void Save_btn_Click(object sender, EventArgs e)
        {
            conn.Open();
            sql = "INSERT INTO studentTbl (student_id, student_name, department, picpath) VALUES ('"
                + StudentNo_tbox.Text + "', '" + StudentName_tbox.Text + "', '" + Dept_tbox.Text + "', '"
                + Pboxpath.Text + "') ";
            cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;

            sqladptr = new SqlDataAdapter();
            sqladptr.InsertCommand = cmd;
            cmd.ExecuteNonQuery();

            sql = "SELECT * FROM studentTbl ";
            cmd = new SqlCommand (sql, conn);
            cmd.CommandType = CommandType.Text;

            sqladptr = new SqlDataAdapter();
            sqladptr.SelectCommand = cmd;
            cmd.ExecuteNonQuery();

            dset = new DataSet();
            sqladptr.Fill(dset, "studentTbl");

            dataGridView1.DataSource = dset.Tables[0];
            clearall();

            conn.Close();
        }

        private void Search_btn_Click(object sender, EventArgs e)
        {
            conn.Open();
            sql = "SELECT * FROM studentTbl WHERE student_id = '" + StudentNo_tbox.Text + "'";
            cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            //codes for mediating the language or world of C# and MSSQL
            sqladptr = new SqlDataAdapter();
            sqladptr.SelectCommand = cmd;
            cmd.ExecuteNonQuery();

            dset = new DataSet();
            sqladptr.Fill(dset, "studentTbl");
            dataGridView1.DataSource = dset.Tables[0];
            try
            {
                StudentName_tbox.Text = dset.Tables[0].Rows[0][1].ToString();
                Dept_tbox.Text = dset.Tables[0].Rows[0][2].ToString();
                Pboxpath.Text = dset.Tables[0].Rows[0][3].ToString();
                Pbox.Image = Image.FromFile(Pboxpath.Text);
            }
            catch
            {

            }
            conn.Close();
        }

        private void Del_btn_Click(object sender, EventArgs e)
        {
            conn.Open();
            sql = "DELETE FROM studentTbl WHERE student_id ='" + StudentNo_tbox.Text + "'";
            cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;

            sqladptr = new SqlDataAdapter();
            sqladptr.DeleteCommand = cmd;
            cmd.ExecuteNonQuery();

             sql = "SELECT * FROM studentTbl ";
            cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;

            sqladptr = new SqlDataAdapter();
            sqladptr.SelectCommand = cmd;
            cmd.ExecuteNonQuery();

            dset = new DataSet();
            sqladptr.Fill(dset, "studentTbl");

            dataGridView1.DataSource = dset.Tables[0];
            Pbox.Image = Image.FromFile("D:\\repos\\mendax0321\\New_POS_Application\\images\\grayperson.jpg");
            conn.Close();
        }

        private void Edit_btn_Click(object sender, EventArgs e)
        {
            conn.Open();

            sql = "UPDATE studentTbl SET student_name = '" + StudentName_tbox.Text 
                + "',department = '" + Dept_tbox.Text + "', picpath = '" + Pboxpath.Text 
                + "' WHERE student_id = '" + StudentNo_tbox.Text + "' ";
            cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;

            sqladptr = new SqlDataAdapter();
            sqladptr.UpdateCommand = cmd;
            cmd.ExecuteNonQuery();

            sql = "SELECT * FROM studentTbl ";
            cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            //codes for mediating the language or world of C# and MSSQL
            sqladptr = new SqlDataAdapter();
            sqladptr.SelectCommand = cmd;
            cmd.ExecuteNonQuery();

            dset = new DataSet();
            sqladptr.Fill(dset, "studentTbl");

            dataGridView1.DataSource = dset.Tables[0];
            Pbox.Image = Image.FromFile("D:\\repos\\mendax0321\\New_POS_Application\\images\\grayperson.jpg");
           
            StudentNo_tbox.Clear();
            StudentName_tbox.Clear();
            Dept_tbox.Clear();
            Pboxpath.Clear();
            conn.Close();
        }

        private void Browse_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog PicFile = new OpenFileDialog();
            PicFile.Filter = "Image File | * .gif; * .jpg; * .png; * .bmp;";
            PicFile.Title = "Select Employee Picture";
            PicFile.ShowDialog();
            picpath = PicFile.FileName;
            Pboxpath.Text = picpath;
            Pbox.Image = Image.FromFile(picpath);
        }

        private void New_btn_Click(object sender, EventArgs e)
        {
            defaulttable();
            clearall();
        }

        private void Cancel_btn_Click(object sender, EventArgs e)
        {
            defaulttable();
            clearall();
        }

        private void clearall()
        {
            Pbox.Image = Image.FromFile("D:\\repos\\mendax0321\\New_POS_Application\\images\\grayperson.jpg");
            StudentNo_tbox.Clear();
            StudentName_tbox.Clear();
            Dept_tbox.Clear();
            Pboxpath.Clear();
        }

        private void defaulttable()
        {
            conn.Open();
            sql = "SELECT * FROM studentTbl ";
            cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            sqladptr = new SqlDataAdapter();
            sqladptr.SelectCommand = cmd;
            cmd.ExecuteNonQuery();

            dset = new DataSet();
            sqladptr.Fill(dset, "studentTbl");
            dataGridView1.DataSource = dset.Tables[0];
            conn.Close();
        }
    }
}