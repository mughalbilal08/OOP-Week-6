using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UMS.BL;
using UMS.DL;

namespace UMS.UI
{
    class MuserCRUD
    {
        public static void header()
        {
            Console.WriteLine("******************************************************************");
            Console.WriteLine("******        University Admission Management System        ******               ");
            Console.WriteLine("******************************************************************");

        }

        public static void clearScreen()
        {
            Console.WriteLine("Press any key to Continue..");
            Console.ReadKey();
            Console.Clear();
        }
        public static string menu()
        {
            string choice = " ";
          
            Console.WriteLine("1. Add Student ");
            Console.WriteLine("2. Add Degree Program ");
            Console.WriteLine("3. Generate Merit ");
            Console.WriteLine("4. View Registered Students ");
            Console.WriteLine("5. View Students of a specific Program ");
            Console.WriteLine("6. Registered Subjects for a specific student ");
            Console.WriteLine("7. Calculate Fee Of all Students ");
            Console.WriteLine("8. Exit ");
            Console.Write("Enter Your Choice: ");
            return choice;
        }
        public static degreeProgram addProgram()
        {
            Console.WriteLine("Enter Degree Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Degree Duration: ");
            int time = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Seats for Degree: ");
            int seat = int.Parse(Console.ReadLine());
            BL.degreeProgram objdegree = new BL.degreeProgram(name, time, seat);
            Console.WriteLine("Enter How Many Subjects You Want To Enter");
            int count = int.Parse(Console.ReadLine());
            for (int x = 0; x < count; x++)
            {
                objdegree.addSubject(SubjectInput());
            }
            return objdegree;
        }
        public static subject SubjectInput()
        {
            Console.Write("Enter Subject's Name : ");
            string SubjectCode = Console.ReadLine();
            Console.Write("Enter Subject's Type : ");
            string SubjectType = Console.ReadLine();
            Console.Write("Enter Subject's Credit Hours : ");
            int CreditHours = int.Parse(Console.ReadLine());
            Console.Write("Enter Subject's Fees : ");
            int SubjectFees = int.Parse(Console.ReadLine());
            subject objsubject = new subject(SubjectCode, SubjectType, CreditHours, SubjectFees);
            return objsubject;
        }
        public static student addStudent()
        {
            List<degreeProgram> preference = new List<degreeProgram>();
            Console.Write("Enter Student's Name : ");
            string Name = Console.ReadLine();
            Console.Write("Enter Student's Age : ");
            int Age = int.Parse(Console.ReadLine());
            Console.Write("Enter Student's FSC Marks : ");
            float FSC = int.Parse(Console.ReadLine());
            Console.Write("Enter Student's ECAT Marks : ");
            float ECAT = int.Parse(Console.ReadLine());
            Console.WriteLine("Available Degree Programs: ");
            degreeProgramList.viewDegreeProgram();
            Console.WriteLine("Enter How Many Preferences You Want To Enter: ");
            int count = int.Parse(Console.ReadLine());
            for (int x = 0; x < count; x++)
            {
                Console.WriteLine("Enter Name Of Preferences: ");
                string name = Console.ReadLine();
                bool flag = false;
                foreach (degreeProgram s in degreeProgramList.program)
                {
                    if (name == s.name)
                    {
                        preference.Add(s);
                        flag = true;
                    }
                }
                if (flag == false)
                {
                    Console.WriteLine("Enter Valid degree program Name");
                    x--;
                }
            }
            student objstu = new student(Name, Age, FSC, ECAT, preference);
            return objstu;
        }
        public static void generateMeritView()
        {
            foreach (student s in studentList.studentlist)
            {
                if (s.regDegree != null)
                {
                    Console.WriteLine(s.name + "  got admission in  " + s.regDegree.name);
                }
                else
                {
                    Console.WriteLine(s.name + " did not got admission ");
                }
            }
        }
        public static void regsiteredView()
        {
            Console.WriteLine("Name \t FSC \t ECAT \t AGE");
            foreach (student s in studentList.studentlist)
            {
                if (s.regDegree != null)
                {
                    Console.WriteLine(s.name + "\t" + s.fscM + "\t" + s.ecatM + "\t" + s.age);
                }
            }

        }
        public static void ViewSelectedStudent(string name)
        {
            Console.WriteLine("Name \t FSC \t ECAT \t AGE");
            foreach (student s in studentList.studentlist)
            {
                if (s.regDegree != null)
                {
                    if (s.regDegree.name == name)
                    {
                        Console.WriteLine(s.name + "\t" + s.fscM + "\t" + s.ecatM + "\t" + s.age);
                    }
                }
            }
        }
        public static void registerSubjects(student s)
        {
            Console.Write("Enter how many subjects you want to Register :");
            int count = int.Parse(Console.ReadLine());
            for (int x = 0; x < count; x++)
            {
                Console.Write("Enter the subject Code : ");
                string code = Console.ReadLine();
                bool flag = false;
                foreach (subject sub in s.regDegree.Subjects)
                {
                    if (code == sub.code && !(s.regSubject.Contains(sub)))
                    {

                        if (s.redStudentSubject(sub))
                        {
                            flag = true;
                            break;

                        }
                        else
                        {
                            Console.WriteLine("A student cannot have more than 9 CH");
                            flag = true;
                            break;
                        }
                    }
                }
                if (flag == false)
                {
                    Console.WriteLine("Enter  valid course.");
                    x--;
                }
            }
        }
        public static void calculateFee()
        {
            foreach (student s in studentList.studentlist)
            {
                if (s.regDegree != null)
                {
                    Console.WriteLine(s.name + "  has " + s.calfees() + "  fees");
                }
            }
        }
        public static void viewsubject(student s)
        {
            if (s.regDegree != null)
            {
                Console.WriteLine("Sub Code \t Sub Type");
                foreach (subject sub in s.regDegree.Subjects)
                {
                    Console.WriteLine(sub.code + " \t " + sub.subjectType);
                }
            }
        }
    }    
}
