using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Core_Programs_CSharp
{
    internal class EvenOrOdd
    {
        public static void CheckEvenOrOdd()
        {
            Console.WriteLine("Enter a number to check it is Even or Odd");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num % 2 == 0)
                Console.WriteLine("Number {0} is Even", num);
            else
                Console.WriteLine("Number {0} is Odd", num);
        }
    }
}
