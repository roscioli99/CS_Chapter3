using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Furniture
{
    class Furniture
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What kind of table would you like: Oak, Pine, or Mahogany?");
            String woodInput = Console.ReadLine();
            int pine = 100;
            int oak = 225;
            int mahogany = 310;

            if (woodInput.Equals("P"))
            {
                Console.WriteLine("The price of your Pine Table will be ${0}", pine);
            }
            else if (woodInput.Equals("O"))
            {
                Console.WriteLine("The price of your Oak Table will be ${0}",oak);
            }
            else if (woodInput.Equals("M"))
            {
                Console.WriteLine("The price of your Mahogany Table will be ${0}", mahogany);
            }
            else
            {
                Console.WriteLine("$0");
            }
        }
    }
}
