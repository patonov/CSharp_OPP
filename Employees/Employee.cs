using System;
using System.Collections.Generic;
using System.Text;

namespace Employees
{
    public class Employee
    {
        public Employee(string name, int salary)
        {
            this.Name = name;
            this.Salary = salary;
        }

        public string Name { get; set; }

        public int Salary { get; set; }

    }
}
