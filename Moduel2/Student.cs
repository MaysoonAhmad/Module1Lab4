using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Moduel2
{
    class Student

    {

              // Instances variables

        private static int Countstudents = 0;



              // Student variables

        public string firstName { get; set; }

        public string lastName { get; set; }

        public DateTime birthDate { get; set; }
        public static int studentnumber()
        {
            return Countstudents;
        }
       

            // Constructor

        public Student(string FirstName, string LastName, DateTime birthDate)

        {

            this.firstName = FirstName;

            this.lastName = lastName;

            this.birthDate = birthDate;
            Countstudents++;



        }

     }

}











