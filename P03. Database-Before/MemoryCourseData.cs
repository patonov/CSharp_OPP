using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace P03._Database_Before
{
    using P03._Database_Before.Contracts;

    public class MemoryCourseData : ICourseData
    {
        private List<Course> courses;

        public MemoryCourseData()
        {
            courses = new List<Course>()
            {
                new Course(){ Id = 1, Name = "CSharp"},
                new Course(){ Id = 2, Name = "CSharp OOP"},
                new Course(){ Id = 3, Name = "CSharp Advanced"}
            };
        }

        public IEnumerable<int> CourseIds()
        {
            return courses.Select(c => c.Id);
        }

        public IEnumerable<string> CourseNames()
        {
           
            return courses.Select(c => c.Name);
            
        }

        public string GetCourseById(int id)
        {
            return courses.First(c => c.Id == id).Name;
        }


    }

    
}
