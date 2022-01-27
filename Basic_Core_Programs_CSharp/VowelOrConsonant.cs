using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Core_Programs_CSharp
{
    internal class VowelOrConsonant
    {
        public static void CheckVowelOrConsonant()
        {
            Console.WriteLine("Enter a character to check wheather it is Vowel or Consonant");
            char character = Convert.ToChar(Console.ReadLine().ToLower());

            switch (character)
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    Console.WriteLine("Entered character is a Vowel");
                    break;
                default:
                    if(character >= 'a' && character <= 'z')
                    {
                        Console.WriteLine("Entered character is a Consonant");
                    }
                    else
                        Console.WriteLine("Please Enter a Character");
                    break;
            }
        }
    }
}
