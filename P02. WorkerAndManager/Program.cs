using System;

namespace P02._WorkerAndManager_Before
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager manager = new Manager(new Worker());

            Manager managerNew = new Manager(new SeniorWorkercs()); 
        }
    }
}
