using System;

namespace ExceptionHandlingExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 0;

            try
            {
                Console.WriteLine("How old are you?");
                age = int.Parse(Console.ReadLine());
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Just enter a number");
                age = int.Parse(Console.ReadLine());
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("Too long number");
                age = int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"{age} are not little");
        }
    }
}
