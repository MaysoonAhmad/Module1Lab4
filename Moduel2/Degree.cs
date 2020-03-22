using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;
namespace Moduel2

{
    class Degree

    {

               // Degree variables 

        public string Degree_Name { get; set; }

      
        public Course Course { get; set; }



                  // Constructor

        public Degree(string DegreeName,  Course course)

        {

            this.Degree_Name = DegreeName;

            

            this.Course = course;

        }

    }

}