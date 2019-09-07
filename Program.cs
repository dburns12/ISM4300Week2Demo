using System;

namespace Week2Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            // try-catch to catch an errors
            try
            {
                // Display instructions
                Console.WriteLine("Please enter in your desired amount of vacation days.");

                // Parse time to be integer
                int time = int.Parse(Console.ReadLine());

                // Conditional to determine if user can take vacation time or not
                if(time > 0 && time < 8)
                {
                    // Display true result
                    Console.WriteLine("Thank you. Enjoy your time off!");
                }
                else
                {
                    // Display false result
                    Console.WriteLine("Sorry, you may not go on vacation.");
                }

            }
           catch
            {
                // Display error message
                Console.WriteLine("Oops, you have an error!");
            }
        }
    }
}
