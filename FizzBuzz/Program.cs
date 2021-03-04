using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 101; i++)
            {
                bool word = false;

                if (i % 3 == 0)
                {
                    Console.Write("Fizz");
                    word = true;
                }

                if (i % 5 == 0)
                {
                    Console.Write("Buzz");
                    word = true;
                }

                if (word)
                    Console.WriteLine();
                else
                    Console.WriteLine(i);
            }
        }
    }
}
