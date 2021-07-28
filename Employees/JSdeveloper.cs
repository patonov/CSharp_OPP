using System;
using System.Collections.Generic;
using System.Text;

namespace Employees
{
    public class JSdeveloper : Programmer
    {
        public JSdeveloper(string name, int salary, List<string> languages)
            : base(name, salary, new List<string> { "JavaScript", "React" })
        {
            Console.WriteLine("I am a great JS developer");
        }


    }
}
