using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Core_Programs_CSharp
{
    internal class PrimeFactors
    {
        public static void GetPrimeFactors()
        {
            Console.WriteLine("Please enter a number to print its prime factors:");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Prime factors of {0} are: ", n);

            for (int i = 2; i < n ; i++)
            {
                if (n % i == 0)
                {
                    int prime = 1;
                    for (int j = 2; j <=i/2 ; j++)
                    {
                        if (i % j == 0)
                        {
                            prime = 0;
                            break;
                        }
                    }
                    if (prime == 1)
                    {
                        Console.Write(i+" ");
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
