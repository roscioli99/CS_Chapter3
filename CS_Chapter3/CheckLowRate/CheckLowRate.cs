using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CheckLowRate
{
    class CheckLowRate
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your hourly pay rate?");
            String payRate = Console.ReadLine();
            double pay = Convert.ToDouble(payRate);

            if (pay < 5.65)
                Console.WriteLine("ERROR: PAY RATE TOO LOW");
            else
                Console.WriteLine("Your hourly payrate is " + pay);
        }
    }
}
