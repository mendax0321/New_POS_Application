using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_POS_Application
{
    internal class TuitonClass
    {
        public string[] Program = { "BS Mechanical Engineering", "BS Aeronotical Engineering", 
            "BS Civil Engineering", "BS Electrical Engineering", "BS Industrial Engineering", 
            "BS Computer Engineering", "BS Electronics Engineering" };

        public double LabFee(double LabUnit)
        {
            return 2500 * LabUnit;
        }
         
        public double Lecfee(double LecUnit)
        {
            return 1500 * LecUnit;
        }

        public double CashDisc(double Total)
        {
            return Total - (Total * 0.10);
        }
        public double InstallmentRate(double Total)
        {
            return Total + (Total * 0.15);
        }

    }
}
