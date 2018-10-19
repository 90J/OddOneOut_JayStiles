using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddOneOut_JayStiles
{
    class Program
    {
        static void Main(string[] args)
        {


            //user input for number size
            Console.Write("Enter a number: ");
            int userNum = int.Parse(Console.ReadLine());
            List<int> oddNumbers = new List<int>();
            for (int i = 0; i <= userNum; i++)
            {
                if (IsOdd(i))
                {
                    oddNumbers.Add(i);
                }

            }
            int sum = oddNumbers.Sum();
            Console.WriteLine(sum);
            double avg = oddNumbers.Average();
            Console.WriteLine($"Total sum of the Odd numbers: {sum}.");
            Console.WriteLine($"Average of the Odd numbers: {avg}.");
        }

        public static bool IsOdd(int value)
        {
            return value % 2 != 0;
        }
    }
}

