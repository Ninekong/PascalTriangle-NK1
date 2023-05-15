using System;

namespace PascalTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of rows: ");
            int numRows = int.Parse(Console.ReadLine());

            if (numRows < 0)
            {
                Console.WriteLine("Invalid Pascal's triangle row number.");
            }
            else
            {
                for (int i = 0; i <= numRows; i++)
                {
                    int value = 1;
                    for (int j = 0; j <= i; j++)
                    {
                        Console.Write(value + " ");
                        value = value * (i - j) / (j + 1);
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
