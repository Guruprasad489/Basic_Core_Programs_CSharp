using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Core_Programs_CSharp
{
    internal class HarmonicNumber
    {
        public static void GetHarmonicNumber()
        {
            double nth_Harmonic_Num = 0, reciprocal;
            Console.WriteLine("Please enter a number to calculate Nth Harmonic value");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n > 0)
            {
                for (int i = 1; i <= n; i++)
                {
                    reciprocal = (double)1 / i;
                    nth_Harmonic_Num = nth_Harmonic_Num + reciprocal;
                    Console.Write("1/"+ i + " + ");
                }
                Console.WriteLine("\nNth Harmonic value is : " + nth_Harmonic_Num);
            }
            else
                Console.WriteLine("Please enter a number greater than zero");
        }
    }
}
