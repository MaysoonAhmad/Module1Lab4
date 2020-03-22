using System;
using System.Collections.Generic;
using System.Text;

namespace Moduel2
{
    class Teacher

    {

                  // Teacher variables

        public string firstName { get; set; }

        public string lastName { get; set; }

        public DateTime birthDate { get; set; }

       



                  // Constructor

        public Teacher(string fName, string lName, DateTime birthDate)

        {

            this.firstName = fName;

            this.lastName = lName;

            this.birthDate = birthDate;

            

        }



       

        }

    }






