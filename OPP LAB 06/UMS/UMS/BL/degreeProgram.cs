using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace UMS.BL
{
    class degreeProgram
    {
        public  List<subject> Subjects;
        public string name;
        public int duration;
        public int seats;
        public degreeProgram()
        {

        }
        public degreeProgram(string name, int duration, int seats)
        {
            this.name = name;
            this.duration = duration;
            this.seats = seats;
            Subjects = new List<subject>();
        }
        public bool isSubjectExists(subject sub)
        {
            foreach (subject s in Subjects)
            {
                if (s.code == sub.code)
                {
                    return true;
                }
            }
            return false;
        }
        public  int calculateCreditHour()
        {
            int count = 0;
            for (int x = 0; x < Subjects.Count; x++)
            {
                count = count + Subjects[x].creditHours;
            }
            return count;
        }
        public  bool addSubject(subject s)
        {
            int checkCR = calculateCreditHour();

            if (checkCR + s.creditHours <= 20)
            {
                Subjects.Add(s);
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
