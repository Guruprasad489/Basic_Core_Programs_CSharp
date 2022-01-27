using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Core_Programs_CSharp
{
    internal class QuotientAndRemainder
    {
        public static void GetQuotientAndRemainder()
        {
            int quotient, remainder;
            Console.WriteLine("Enter the value of dividend: ");
            int dividend = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of divisor: ");
            int divisor = Convert.ToInt32(Console.ReadLine());

            quotient = dividend / divisor;
            remainder = dividend % divisor;

            Console.WriteLine("dividend {0}: , divisor {1}", dividend, divisor);
            Console.WriteLine("Quotient: " +quotient);
            Console.WriteLine("Remainder: " + remainder);
        }
    }
}
