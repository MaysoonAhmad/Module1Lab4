using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

namespace Moduel2
{
    class Program

    {

        static void Main(string[] args)

        {

            // 1- Instantiate three Student objects.

            Student student1 = new Student("Sarah", "Ahmad", new DateTime(2000, 01, 11));

            Student student2 = new Student("Layan", "James", new DateTime(2001, 02, 20));

            Student student3 = new Student("Lamees", "Thomas", new DateTime(2002, 03, 29));



            // 2- Instantiate a Course object called Programming with C#.

            Course course = new Course("Programming with C#");



            // 3- Add your three students to this Course object.

            course.addStudent(student1);

            course.addStudent(student2);

            course.addStudent(student3);



            // 4- Instantiate at least one Teacher object.

            Teacher teacher = new Teacher("Maysoon", "Ahmad", new DateTime(1977, 01, 06));



            // 5- Add that Teacher object to your Course object.

            course.addTeacher(teacher);



            // 6- Instantiate a Degree object, such as Bachelor.

            Degree degree = new Degree("Bachelor of Art", null);



            // 7- Add your Course object to the Degree object.

            degree.Course = course;



            // 8- Instantiate a UProgram object called Information Technology.

            UProgram uProgram = new UProgram("Information Technology",  null);



            // 9- Add the Degree object to the UProgram object.

            uProgram.Degree = degree;



            // 10- Output the information.

            Console.WriteLine("The {0} program contains the {1} degree\n", uProgram.Program_Name, degree.Degree_Name);

            Console.WriteLine("The {0} degree contains the course {1}\n", degree.Degree_Name, course.CourseName);

            Console.WriteLine("The {0} course contains {1} student(s)\n", course.CourseName, course.studentsNumber);

        }
    }
}




