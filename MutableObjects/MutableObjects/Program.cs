using System;

namespace MutableObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            MutableList mutableList = new MutableList(new[] { "Mutko", "Utko", "Putko" });

            foreach (var name in mutableList.StdentNames)
            {
                Console.WriteLine(name);
            }
        }
    }
}
