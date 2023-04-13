using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To The Basic Core Program");
            Console.WriteLine("Please Choose One From Below Option: ");
            Console.WriteLine("1.FlipCoin\n 2.LeapYear\n 3.PowerOfTwo\n 4.HarmonicSeries\n 5.EvenorOdd\n 6.Factor\n 7.LargestNumber\n 8.FindQuotientAndRemainder\n 9.Swap\n 10.VowelOrConsonant");
            int Option = Convert.ToInt32(Console.ReadLine());
            switch (Option)
            {
                case 1:
                    FlipCoin.Flip();
                    break;
                case 2:
                    LeapYear.TheLeapYear();
                    break;
                case 3:
                    PowerOfTwo.CalPow();
                    break;
                case 4:
                    Harmonic.HarmonicSeries();
                    break;
                case 5:
                    EvenorOdd.FindEvenOrOdd();
                    break;
                case 6:
                    Factor.PrimeFactor();
                    break;
                case 7:
                    LargestNumber.FindTheLargestNumber();
                    break;
                case 8:
                    QuotientandRemainder.FindQuotientAndRemainder();
                    break;
                case 9:
                    Swap.SwapNumbers();
                    break;
                case 10:
                    VowelOrConsonant.CheckCharacter();
                    break;
                default:
                    Console.WriteLine("Please Choose Program With Given Option");
                    break;
            }
        }
    }
}
