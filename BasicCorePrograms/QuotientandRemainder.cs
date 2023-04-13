using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class QuotientandRemainder
    {
        public static void FindQuotientAndRemainder()
        {
            int dividend = 60, divisor = 9;

            int quotient = dividend / divisor;
            int remainder = dividend % divisor;

            Console.WriteLine("Dividend : {0} Divisor: {1}", dividend, divisor);
            // Console.WriteLine("Dividend : " + dividend+" Divisor: " + divisor);

            Console.WriteLine("Quotient =  " + quotient);
            Console.WriteLine("Remainder =  " + remainder);
        }
    }
}
