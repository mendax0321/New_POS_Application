using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace New_POS_Application
{
    public partial class Sales_Reports : Form
    {
        POS_dbconnect dbconnect = new POS_dbconnect();

        public Sales_Reports()
        {
            InitializeComponent();
            dbconnect.pos_connString();
            DefaultGrid();

        }
        private void Search_btn_Click(object sender, EventArgs e)
        {

        }

        private void Back_btn_Click(object sender, EventArgs e)
        {

        }

        // Functions
        internal void DefaultGrid()
        {
            dbconnect.pos_sql = "SELECT * FROM salesTbl";
            dbconnect.pos_cmd();
            dbconnect.pos_sqladapterSelect();
            dbconnect.pos_sqldatasetSELECT();
            GridView.DataSource = dbconnect.pos_sql_dataset.Tables[0];
        }
    }
}