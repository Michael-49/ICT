using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetalappsAutomation
{


    public class SalesDetails
    {
        private int sales;
        private string name;
        public int units;

        public int Sales()
        {
            Console.WriteLine("Enter sales id");
            sales = Convert.ToInt32(Console.ReadLine());
            return sales;
        }
        public string Name()
        {
            Console.WriteLine("Enter customer name");
            name = Console.ReadLine();
            return name;
        }
        public int Units()
        {
            Console.WriteLine("Enter the number of Units sold");
            units = Convert.ToInt32(Console.ReadLine());
            if (units >= 5)
            {
                return units;
            }
            else
            {
                Console.WriteLine("No Sales for units below 5");
                throw new ArgumentOutOfRangeException("No Sales for units below 5");
            }
           
        }

    }    

}



