using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;

namespace FirstAndReserveTeams
{
    class Program
    {
        static void Main(string[] args)
        {
           
            List<Person> persons = new List<Person>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var line = Console.ReadLine().Split().ToArray();
                string name = line[0];
                string surname = line[1];
                int age = int.Parse(line[2]);
                double salary = double.Parse(line[3]);
                Person person = new Person(name, surname, age, salary);
                persons.Add(person);

            }
            
            Team team = new Team("SoftUni");

            foreach (Person person in persons)
            {
                team.AddPlayer(person);
            }
            Console.WriteLine(team.ToString());
        }
    }
}
