using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Moduel2
{ 
   class UProgram

{

                   // UProgram variables

    public string Program_Name { get; set; }

    public  Degree Degree { get; set; }

 
                   // Constructor

    public UProgram(string ProgramName, Degree degree)

    {

        this.Program_Name = ProgramName;

        

        this.Degree = degree;

    }

}
    }

