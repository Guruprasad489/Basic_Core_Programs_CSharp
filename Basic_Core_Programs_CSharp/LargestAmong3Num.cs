using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Core_Programs_CSharp
{
    internal class LargestAmong3Num
    {
        public static void GetLargestAmong3Num()
        {
            Console.WriteLine("Enter the value of First number");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the value of Second number");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the value of Third number");
            double num3 = Convert.ToDouble(Console.ReadLine());

            //double n = Math.Max(num1, num2);
            //double max = Math.Max(n, num3);
            //Console.WriteLine("max is " + max);

            if (num1>num2)
            {
                if (num1>num3)
                {
                    Console.WriteLine(num1 + " is greatest among three numbers");
                }
                else
                {
                    Console.WriteLine(num3 + " is greatest among three numbers");
                }
            }
            else if (num2>num3)
            {
                Console.WriteLine(num2 + " is greatest among three numbers");
            }
            else
            {
                Console.WriteLine(num3 + " is greatest among three numbers");
            }
        }
    }
}
