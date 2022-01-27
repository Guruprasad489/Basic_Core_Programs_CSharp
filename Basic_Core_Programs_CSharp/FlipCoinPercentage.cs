using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Core_Programs_CSharp
{
    internal class FlipCoinPercentage
    {
        public static int numOf_Flips, tailCount=0, headCount=0;
        public static double flipResult, percentage_Tail, percentage_Head;
        public static Random random = new Random();

        public static void GetFlipCoinPercentage()
        {
            Console.WriteLine("Please enter the number of times to flip coin: ");
            numOf_Flips = Convert.ToInt32(Console.ReadLine());
            if (numOf_Flips > 0)
            {
                for (int i = 1; i <= numOf_Flips; i++)
                {
                    flipResult = random.NextDouble();
                    if (flipResult < 0.5)
                    {
                        Console.WriteLine("Flip number " + i + ": Tails");
                        tailCount++;
                    }
                    else
                    {
                        Console.WriteLine("Flip number " + i + ": Heads");
                        headCount++;
                    }
                }
                percentage_Tail = tailCount * (100 / numOf_Flips);
                percentage_Head = headCount * (100 / numOf_Flips);
                Console.WriteLine("Percentage of Tails : {0} \nPercentage of Heads: {1}", percentage_Tail, percentage_Head);

                double diff = percentage_Tail.CompareTo(percentage_Head);
                if (diff < 0)
                    Console.WriteLine("Percentage of Tails is less than Percentage of Heads");
                if (diff > 0)
                    Console.WriteLine("Percentage of Tails is greater than Percentage of Heads");
                if (diff == 0)
                    Console.WriteLine("Percentage of Tails is equal to Percentage of Heads ( 50 : 50 )");
            }
            else
            {
                Console.WriteLine("Please Enter positive integer");
            }
        }
    }
}
