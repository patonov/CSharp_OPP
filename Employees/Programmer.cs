using System;
using System.Collections.Generic;
using System.Text;

namespace Employees
{
    public class Programmer : Employee
    {
        public Programmer(string name, int salary, List<string> languages)
            : base(name, salary)
        {
            this.Languages = languages;
        }

        public List<string> Languages { get; set; }
    }
}
