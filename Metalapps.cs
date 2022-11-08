using System;
using System.Collections.Generic;
using System.Text;

namespace MetalappsAutomation
{
    class Metalapps
    {
        public static List<int> salesId = new List<int>();
        public static List<string> customerName = new List<string>();
        public static List<int> noOfUnits = new List<int>();
        public static List<double> netAmount = new List<double>();
        public double CalculateNetAmount(int unit)
        {
            int units = unit;
            double amount = 0;


            if (units <= 5)
                amount = 75350 * units;
            else if (units > 5 && units <= 10)
                amount = 75350 * units * 0.98;
            else if (units > 10 && units <= 15)
                amount = 75350 * units * 0.95;
            else if (units > 15 && units <= 20)
                amount = 75350 * units * 0.92;
            else if (units > 20)
                amount = 75350 * units * 0.90;



            return amount;
        }
    }
}
