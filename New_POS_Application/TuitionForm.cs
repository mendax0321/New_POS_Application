using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace New_POS_Application
{
    public partial class TuitionForm : Form
    {
        TuitonClass TC = new TuitonClass();
        string StudentName, StudentNo, YearLevel, Scholar, CourseCode, Section, CourseDesc, Day, Room;
        string[] Course;
        double LabFee, LectureFee, MiscFee = 4970, TotalTui, CashDisc, Installment;
        int[] UnitLec = { 0,0,0,0,0};
        int[] UnitLab = { 0,0,0,0,0};

        int TotLecUnit, TotLabUnit;

        int ULcount = 0;
        public TuitionForm()
        {
            InitializeComponent();
        }

        private void TuitionForm_Load(object sender, EventArgs e)
        {
            //Program_cbox.Items.Add(TC.Program[2]);
            MOP_cbox.Items.Add("Cash");
            MOP_cbox.Items.Add("Installment");
            ProgramLoop();
        }

        //Button
        private void AddCourse_btn_Click(object sender, EventArgs e)
        {
            CourseCode = CourseCode_tbox.Text;
            CourseDesc = CourseDesc_tbox.Text;
            Section = Section_tbox.Text;
            Day = Day_tbox.Text;
            Room = Room_tbox.Text;

            UnitLec[ULcount] = Convert.ToInt32(UnitLec_tbox.Text);
            UnitLab[ULcount] = Convert.ToInt32(UnitLab_tbox.Text);
            ULcount++;
        }

        private void Calculate_btn_Click(object sender, EventArgs e)
        {
            for (int x = 0; x < 5; x++)
            {
                TotLecUnit += UnitLec[x];
                TotLabUnit += UnitLab[x];
                listBox1.Items.Add("Unit Lec " + UnitLec[x]);
                listBox1.Items.Add("Unit Lab " + UnitLab[x]);
            }
            listBox1.Items.Add("Total Lec " + TotLecUnit);
            listBox1.Items.Add("Total Lab " + TotLabUnit);

            LabFee = TC.LabFee(TotLabUnit);
            LectureFee = TC.Lecfee(TotLecUnit);
            TotalTui = LabFee + LectureFee + MiscFee;

            if (MOP_cbox.Text == "Cash")
            {
                TC.CashDisc(TotalTui);
            }
            else if (MOP_cbox.Text == "Installment")
            {
                TC.InstallmentRate(TotalTui);
            }

            listBox1.Items.Add("Total " + TotalTui);
            StudentName = StudentName_tbox.Text;
            StudentNo = StudentNo_tbox.Text;
            YearLevel = YearLev_tbox.Text;
            Scholar = Scholar_tbox.Text;
            CourseCode = CourseCode_tbox.Text;
            CourseDesc = CourseDesc_tbox.Text;
            Day = Day_tbox.Text;
            Room = Room_tbox.Text;
        }

        private void New_btn_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        //Functions
        public void ProgramLoop()
        {
            for (int x = 0; x < 7; x++)
            {
                Program_cbox.Items.Add(TC.Program[x]);
            }
        }
    }
}
