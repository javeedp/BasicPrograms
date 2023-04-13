using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
        public class FlipCoin
        {
            public static void Flip()
            {

                {
                    double Heads = 0;
                    double Tails = 0;
                    Console.WriteLine("Enter the numbers of times to Flip Coin");
                    double times = Convert.ToDouble(Console.ReadLine());
                    for (int i = 0; i < times; i++)
                    {
                        Random random = new Random();
                        int FlipCoin = random.Next(0, 2);
                        if (FlipCoin == 1)
                        {
                            Console.WriteLine("Tails");
                            Tails++;
                        }
                        else
                        {
                            Heads++;
                            Console.WriteLine("Heads");
                        }

                    }
                    double result1 = (Heads / times) * 100;
                    Console.WriteLine("Percentage of Heads: {0}%", result1);
                    double result2 = (Tails / times) * 100;
                    Console.WriteLine("Percentage of Tails: {0}%", result2);
                    Console.ReadLine();

                }

            }

        }
    }




