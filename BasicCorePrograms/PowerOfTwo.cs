using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class PowerOfTwo
    {
        public static void CalPow()
        {
            for (int i = 0; i < 31; i++)
            {
                double pow = Math.Pow(2, i);
                Console.WriteLine("2 ^ " + i + " = " + pow);
            }

        }

    }
}

