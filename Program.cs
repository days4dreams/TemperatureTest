using System;
using System.Collections.Generic;

namespace TemperatureTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("It looks warm outside today, I wonder if I need to take a coat with me to work.");
            Console.WriteLine("Could you check the Weather App, and let me know the average temperature for this afternoon?");
            string temperature = Console.ReadLine(); // Ask the user for the temp
            double value;
            if (double.TryParse(temperature, out value)) // Check they've just given me a number
            {
                Console.WriteLine("Thanks, is that in Celsuis?");
                string answer = Console.ReadLine(); // Check the format
                if (answer.Equals("Yes") || answer.Equals("Y") || answer.Equals("yes") || answer.Equals("y"))
                    {
                    Console.WriteLine("I'm old school. Let me work that into Fahrenheit");
                    Console.Write("Hmmm, works out at ");
                    Console.Write(value * 9 / 5 + 32); // Multiply the double and display it
                    Console.WriteLine(" °F in old numbers.");
                    Console.WriteLine("Guess I better pack a coat after all!");
                }
                else

                {
                    Console.WriteLine("So you're old school. You're talking Farenheit");
                    Console.WriteLine("I like your style. Guess I better pack a coat after all!");
                }
            }

            else
            {
                Console.WriteLine("I just like numbers. Can we start over?");
            }
            Console.ReadLine();
        }
    }
}
