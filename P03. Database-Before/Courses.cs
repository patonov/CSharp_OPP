namespace P03._Database_Before
{
    using P03._Database_Before.Contracts;

    public class Courses
    {
        private ICourseData coursesDatabase;

        public Courses(ICourseData courseData)
        {
            coursesDatabase = courseData;
        }

        public void PrintAll()
        {
            var courses = coursesDatabase.CourseNames();

            Console.WriteLine(string.Join(",", courses));
        }

        public void PrintIds()
        {           
            var courseIds = coursesDatabase.CourseIds();

            Console.WriteLine(string.Join(",", courseIds));
        }

        public void PrintById(int id)
        {           
            var course = coursesDatabase.GetCourseById(id);

            Console.WriteLine(course);
        }

    }
}
