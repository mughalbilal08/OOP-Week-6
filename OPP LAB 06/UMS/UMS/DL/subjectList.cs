using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMS.DL
{
    class subjectList
    {
        static List<subjectList> subjects = new List<subjectList>();

        public static void setSubjectIntoList(subjectList s)
        {
            subjects.Add(s);
        }
    }
}
