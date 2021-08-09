namespace P01._Worker_Before
{
    using Contracts;
    using System;

    public class Robot : IWorker
    {
        public void Work()
        {
            Console.WriteLine("I am working...");
        }
    }
}
