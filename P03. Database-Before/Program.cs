using System;

namespace P03._Database_Before
{
    class Program
    {
        static void Main(string[] args)
        {
            Courses courses = new Courses(new MemoryCourseData());

            courses.PrintAll();
            courses.PrintIds();
            courses.PrintById(2);
        }
    }
}
