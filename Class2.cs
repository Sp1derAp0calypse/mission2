using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mission2
{
    public class RollProcessor
    {
        public void ProcessRolls(int iterations)
        {
            int[] numbers = new int[11];

            for (int i = 0; i < iterations; i++)
            {
                Random random = new Random();

                int Dice1 = random.Next(1, 7);
                int Dice2 = random.Next(1, 7);

                int Roll = Dice1 + Dice2;

                numbers[Roll - 2]++;
            }

            int totalSum = 0;

            foreach (int value in numbers)
            {
                totalSum += value;
            }

            for (int j = 0; j < numbers.Length; j++)
            {
                int percent = (int)((double)numbers[j] / totalSum * 100);

                Console.Write($"{j + 2}: ");

                for (int k = 0; k < percent; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}

