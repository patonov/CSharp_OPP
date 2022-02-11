using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MutableObjects
{
    public class MutableList
    {
        private List<string> studentNames;

        public MutableList(string[] initialNames)
        {
            this.studentNames = initialNames.ToList();
        }

        public IReadOnlyCollection<string> StdentNames
        {
            get => this.studentNames.AsReadOnly();
        }
            
    }
}
