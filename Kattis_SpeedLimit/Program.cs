using System;
using System.Linq;

namespace Kattis_SpeedLimit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfInputs = 0;
            numberOfInputs = Convert.ToInt32(Console.ReadLine());

            while (numberOfInputs != -1)
            {
                int previousTimeElapsed = 0;
                int milesTravelled = 0;

                for (int i = 0; i < numberOfInputs; i++)
                {
                    string input = Console.ReadLine();
                    int[] values = input.Split(' ').Select(Int32.Parse).ToArray();
                    milesTravelled += values[0] * (values[1] - previousTimeElapsed);
                }
                Console.WriteLine($"{milesTravelled} Miles");
                numberOfInputs = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}

