using System;

namespace question03
{
    class programe
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a positive integer: ");
            int number;

            while (true)
            {
                if (Int32.TryParse(Console.ReadLine(), out number) && number > 0)
                {
                    long sum = 0;

                    for (int i = 1; i <= number; i++)
                    {
                        sum += i;
                    }

                    Console.WriteLine($"The sum of all numbers from 1 to {number} is: {sum}");
                    break;
                }
                else
                {
                    Console.WriteLine("ERROR: Invalid input. Please enter a positive integer.");
                }
            }
        }
    }
}
