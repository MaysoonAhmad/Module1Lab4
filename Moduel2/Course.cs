using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Moduel2
{

    class Course

    {

        // Constants.

        private static int maxStudents = 3;

        private static int maxTeachers = 2;

               
        // Course variables and properties.

        public string CourseName { get; set; }

        private Student[] students;

        private Teacher[] teachers;
        public int studentsNumber { get; set; }
        public int teachersNumber { get; set; }

        
        // Constructor.

        public Course(string Course_Name)

        {

            this.CourseName = CourseName;

            

            this.students = new Student[maxStudents];
            this.teachers = new Teacher[maxTeachers];

            this.studentsNumber = 0;

            this.teachersNumber = 0;

        }



        // Method to add a student.

        public void addStudent(Student student)
       

        {

            int n = this.studentsNumber;

            if (n < maxStudents)

            {

                this.students[n] = student;

                this.studentsNumber++;

            }

            else

            {

                Console.WriteLine("Array of students is full.");

            }

        }



        // Method to add a teacher.

        public void addTeacher(Teacher teacher)

        {

            int n = this.teachersNumber;

            if (n < maxTeachers)

            {

                this.teachers[n] = teacher;

                this.teachersNumber++;

            }

            else

            {

                Console.WriteLine("Array of teachers is full.");

            }

        }

    }

}