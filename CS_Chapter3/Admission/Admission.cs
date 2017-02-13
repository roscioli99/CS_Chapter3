using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Admission
{
    class Admission
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your High School GPA?");
            String gpaInput = Console.ReadLine();
            double gpa = Convert.ToDouble(gpaInput);
            Console.WriteLine("What is your admissions test score?");
            String testInput = Console.ReadLine();
            double test = Convert.ToDouble(testInput);

            if (gpa >= 3.0 && test >= 60 || gpa <= 3.0 && test >= 80)
            {
                    Console.WriteLine("ACCEPT");
            }
            else
            { 
                Console.WriteLine("REJECT");
            }

        }
    }
}
