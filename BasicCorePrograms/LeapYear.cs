using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class LeapYear
    {
        public static void TheLeapYear()
        {
            System.Console.WriteLine("Enter the Year in four digits : ");
            int year = Convert.ToInt32(Console.ReadLine());
            if (((year % 4 == 0) && (year % 100 != 0)) || (year % 400 == 0))
            {
                Console.WriteLine(" {0} is a Leap Year.", year);
            }
            else
            {
                Console.WriteLine(" {0} is  not a Leap Year.", year);
            }
            Console.ReadLine();
        }
    }
}
