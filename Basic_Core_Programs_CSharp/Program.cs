using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Core_Programs_CSharp
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Choose a program to run");
            Console.WriteLine("\n 1. Flip coin \n 2. Leap year \n 3. Power of 2"+
                   "\n 4. Harmonic Number \n 5. Prime Factors \n 6. Compute Quotient and Remainder \n 7. Swap Two Numbers" +
                   "\n 8. Check Whether a Number is Even or Odd \n 9. Check Whether an Alphabet is Vowel or Consonant" +
                   "\n 10. Find the Largest Among Three Numbers");
            int program_No=Convert.ToInt32(Console.ReadLine());
            switch(program_No)
            {
                case 1:
                    FlipCoinPercentage.GetFlipCoinPercentage();
                    break;
                case 2:
                    LeapYear.CheckLeapYear();
                    break;
                case 3:
                    PowerOf2.PowerOf2_Table();
                    break;
                case 4:
                    HarmonicNumber.GetHarmonicNumber();
                    break;
                case 5:
                    PrimeFactors.GetPrimeFactors();
                    break;
                case 6:
                    QuotientAndRemainder.GetQuotientAndRemainder();
                    break;
                case 7:
                    SwapTwoNumbers.SwapingTwoNumbers();
                    break;
                case 8:
                    EvenOrOdd.CheckEvenOrOdd();
                    break;
                case 9:
                    VowelOrConsonant.CheckVowelOrConsonant();
                    break;
                case 10:
                    LargestAmong3Num.GetLargestAmong3Num();
                    break;
                default:
                    Console.WriteLine("Please Enter correct program number");
                    break;
            }
        }
    }
}
