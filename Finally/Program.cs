using System;

namespace Finally
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int age = int.Parse(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hello Exception!");
            }
            finally
            {
                Console.WriteLine("Despite exception, Hello always gets executed!");
            }
        }
    }
}
