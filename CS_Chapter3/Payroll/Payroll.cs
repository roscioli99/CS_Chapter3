using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Payroll
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your hourly pay rate?");
            String input = Console.ReadLine();
            double payRate = Convert.ToDouble(input);

            Console.WriteLine("How many hours have you worked?");
            String input2 = Console.ReadLine();
            int hours = Convert.ToInt32(input2);

            double gross = payRate * hours;
            double withholdingTax = gross * 0.12, netPay = 0;

            if (gross <= 300.00)
            {
                withholdingTax = 0.10;
            }

            netPay = gross - withholdingTax;

            Console.WriteLine("Your net pay is ${0}", netPay);

        }
    }
}
