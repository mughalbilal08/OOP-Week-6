using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UMS.BL;

namespace UMS.DL
{
    class studentList
    {
        public static List<student> studentlist = new List<student>();
        public static void addIntoStudentList(student s)
        {
            studentlist.Add(s);
        }
        public static student studentPresent(string name)
        {
            foreach (student s in studentlist)
            {
                if (name == s.name && s.regDegree != null)
                {
                    return s;
                }
            }
            return null;
        }
        public static List<student> sortbymerit()
        {
            List<student> sortedsrudentinlist = new List<student>();
            foreach (student s in studentlist)
            {
                s.generateMerit();
            }
            sortedsrudentinlist = studentlist.OrderByDescending(o => o.merit).ToList();
            return sortedsrudentinlist;
        }

        public static void giveadmission(List<student> sortedsrudentinlist)
        {
            foreach (student s in sortedsrudentinlist)
            {
                foreach (degreeProgram d in s.preferences)
                {
                    if (d.seats > 0 && s.regDegree == null)
                    {
                        s.regDegree = d;
                        d.seats--;
                        break;
                    }
                }
            }
        }

    }
}
