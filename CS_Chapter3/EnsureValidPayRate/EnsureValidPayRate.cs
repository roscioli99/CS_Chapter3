using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EnsureValidPayRate
{
    class EnsureValidPayRate
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an hourly payrate");
            String payInput = Console.ReadLine();
            double pay = Convert.ToDouble(payInput);

            if (pay < 5.65 || pay > 49.99)
            {
                Console.WriteLine("Enter an hourly pay rate");
                String payInput2 = Console.ReadLine();
                double payTwo = Convert.ToDouble(payInput2);

                if (payTwo > 5.65 || payTwo > 49.99)
                {
                    Console.WriteLine("Your hourly pay rate is ${0}", payTwo);
                    double weeklyRate = payTwo * 40;
                    Console.WriteLine("Your weekly pay rate is ${0}", weeklyRate);
                }

                else
                {
                    Console.WriteLine("ERROR");
                }
            }
            else
            {
                Console.WriteLine("ERROR");
            }
        }
    }
}
