using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopsLab1
{
    public class university
    {

        public class Course
        {
            public string CourseName { get; set; }
            public string CourseCode { get; set; }
            public int Credits { get; set; }

            public Course(string courseName, string courseCode, int credits)
            {
                CourseName = courseName;
                CourseCode = courseCode;
                Credits = credits;
            }


        }

        public class Department
        {
            public string Name { get; set; }
            public List<Course> Courses= new List<Course>();

            public Department(string name)
            {
                Name = name;
                
            }

        }
        public List<Department> Departments= new List<Department>();
        public void AddDepartment(string name)
        {
            Department department = new Department(name);
            Departments.Add(department);
        }
        public void AddCourse(string departmentName, string courseName, string courseCode, int credits)
        {
            foreach (Department department in Departments)
            {
                if (department.Name == departmentName)
                {
                    Course course = new Course(courseName, courseCode, credits);
                    department.Courses.Add(course);
                    
                }
               

            }
            
        }
        public void DisplayDetails()
        {
            foreach (Department department in Departments)
            {
                Console.WriteLine("Dept: " + department.Name);
                foreach (Course course in department.Courses)
                {
                    Console.WriteLine($"  Course Name: {course.CourseName}, Course Code: {course.CourseCode}, Credits: {course.Credits}");
                }
            }
        }







    }
}
