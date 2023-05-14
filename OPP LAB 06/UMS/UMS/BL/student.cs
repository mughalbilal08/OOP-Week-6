using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMS.BL
{
    class student
    {
        public string name;
        public int age;
        public float fscM;
        public float ecatM;
        public float merit;
        public  List<degreeProgram> preferences;
        public degreeProgram regDegree;
        public List<subject> regSubject;
        public student()
        {

        }
        public student(string name, int age, float fscM, float ecatM, List<degreeProgram> preferences)
        {
            this.name = name;
            this.age = age;
            this.fscM = fscM;
            this.ecatM = ecatM;
            this.preferences = preferences;
            
        }
        public  void generateMerit()
        {
            this.merit = (((fscM / 1100) * 0.4F) + ((ecatM / 400) * 0.55F)) * 100;
        }
        public bool redStudentSubject(subject s)
        {
            int subCH = getCHR();
            if (regDegree != null && regDegree.isSubjectExists(s) && subCH + s.creditHours <= 9)
            {
                regSubject.Add(s);
                return true;
            }
            else
            {
                return false;
            }
        }
        public int getCHR()
        {
            int count = 0;
            foreach (subject sub in regSubject)
            {
                count = count + sub.creditHours;
            }
            return count;
        }
        public float calfees()
        {
            float fee = 0;
            if (regDegree != null)
            {
                foreach (subject sub in regSubject)
                {
                    fee = fee + sub.subjectFee;
                }
            }
            return fee;
        }
    }
}
