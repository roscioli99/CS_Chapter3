using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CheckLowAndHighRate
{
    class CheckLowAndHighRate
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your hourly pay rate?");
            String payRate = Console.ReadLine();
            double pay = Convert.ToDouble(payRate);

            if (5.6 > pay || 49.99 < pay)
                Console.WriteLine("ERROR: ERROR ERROR ERROR");
            else
                Console.WriteLine("Your hourly payrate is " + pay);
        }
    }
}
