namespace P01._Worker_Before
{
    using Contracts;
    using System;

    public class Human : IWorker, IEatable, ISleepable
    {
        public void Eat()
        {
            Console.WriteLine("I am eating...");
        }

        public void Sleep()
        {
            Console.WriteLine("I am sleeping...");
        }

        public void Work()
        {
            Console.WriteLine("I am working...");
        }
    }
}
