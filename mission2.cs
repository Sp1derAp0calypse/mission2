using System;
using mission2;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("How many times do you want to roll the dice?");
        int iterations = int.Parse(Console.ReadLine());

        // Create an instance of RollProcessor and call its method
        RollProcessor processor = new RollProcessor();
        processor.ProcessRolls(iterations);
    }
}
