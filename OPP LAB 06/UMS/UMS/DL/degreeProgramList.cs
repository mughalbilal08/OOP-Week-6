using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UMS.BL;
namespace UMS.DL
{
    class degreeProgramList
    {
        public static List<degreeProgram> program = new List<degreeProgram>();
       
        public static void addProgramsIntoList(degreeProgram s)
        {
            program.Add(s);
        }
        public static void viewDegreeProgram()
        {
            foreach (degreeProgram d in program)
            {
                Console.WriteLine(d.name);
            }
        }
      
    }
}
