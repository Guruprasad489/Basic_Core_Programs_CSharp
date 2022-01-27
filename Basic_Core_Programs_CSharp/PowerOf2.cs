using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Core_Programs_CSharp
{
    internal class PowerOf2
    {
        public static void PowerOf2_Table()
        {
            int power_2;
            Console.WriteLine("Please enter value of n to print power of 2 table");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n >=0 && n <= 30)
            {
                for (int i = 0; i <= n; i++)
                {
                    power_2 = Convert.ToInt32(Math.Pow(2, i));
                    Console.WriteLine("2^" + i + " : " + power_2);
                }
            }
            else
                Console.WriteLine("Please Enter value of n from 0 to 30");
            }
        }
}
