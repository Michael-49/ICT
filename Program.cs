using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetalappsAutomation
{
    class Program
    {
       
        public static List<int> salesId = new List<int>();
        public static List<string> customerName = new List<string>();
        public static List<int> noOfUnits = new List<int>();
        public static List<double> netAmount = new List<double>();
      
        static void Main(string[] args)
        {
            salesId.Add(1000);
            salesId.Add(1001);
            salesId.Add(1002);
            customerName.Add("DOOM Traders");
            customerName.Add("JK Traders");
            customerName.Add("Shanker Traders");
            noOfUnits.Add(15);
            noOfUnits.Add(5);
            noOfUnits.Add(10);
            netAmount.Add(1073737.5);
            netAmount.Add(376750);
            netAmount.Add(738430);
            Console.WriteLine("The DataBase");
            Console.WriteLine($"*************************");
            Console.WriteLine($"");
            for (int i = 0; i < salesId.Count; i++)
            {
                Console.WriteLine($"Sales ID:{salesId[i]}");
                Console.WriteLine($"Customer Name:{customerName[i]}");
                Console.WriteLine($"No of Units:{noOfUnits[i]}");
                Console.WriteLine($"Net Amount:{netAmount[i]}");
                
                Console.WriteLine($"");
                Console.WriteLine($"");
            }
            SalesDetails obj = new SalesDetails();
            int id = obj.Sales();
            string name = obj.Name();
            int units = obj.Units();

            Metalapps o = new Metalapps();
            double amt = o.CalculateNetAmount(units);


            Console.WriteLine($"");
            Console.WriteLine($"");
            Console.WriteLine("Sales Bill ");
            Console.WriteLine("***********");
            Console.WriteLine("Sales Id : " + id);
            Console.WriteLine("Customer Name : " + name);
            Console.WriteLine("Number of Units Sold : " + units);
            Console.WriteLine("Net Amount : " + amt);
            salesId.Add(id);
            customerName.Add(name);
            noOfUnits.Add(units);
            netAmount.Add(amt);
            Console.WriteLine($"");
            Console.WriteLine($"");
            Console.WriteLine("The DataBase");
            Console.WriteLine($"*************************");
            Console.WriteLine($"");
            for (int i = 0; i < salesId.Count; i++)
            {
                Console.WriteLine($"Sales ID:{salesId[i]}");
                Console.WriteLine($"Customer Name:{customerName[i]}");
                Console.WriteLine($"No of Units:{noOfUnits[i]}");
                Console.WriteLine($"Net Amount:{netAmount[i]}");
               

                Console.WriteLine($"");
                Console.WriteLine($"");
            }











        }
    }
}
