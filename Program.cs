using System;

namespace FizzBuzz.App
{
    class Program
    {
        static void Main(string[] args)
        {
            for (var i = 1; i <= 100; i++)
            {
                string message = i.ToString();

                if (i % 3 == 0)
                    message = "Fizz";

                if (i % 5 == 0)
                    message = "Buzz";

                if (i % 3 == 0 && i % 5 == 0)
                    message = "FizzBuzz";

                Console.WriteLine(message);
            }
        }
    }
}
