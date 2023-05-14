using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UMS.BL;
using UMS.DL;
using UMS.UI;

namespace UMS
{
    class Program
    {
        static void Main(string[] args)
        {
            MuserCRUD.clearScreen();
            while (true)
            {
                string op = MuserCRUD.menu();
                if (op == "1")
                {
                    if (degreeProgramList.program.Count > 0)
                    {
                        student s = MuserCRUD.addStudent();
                        studentList.addIntoStudentList(s);
                    }
                }
                else if (op == "2")
                {
                    degreeProgram d = MuserCRUD.addProgram();
                    degreeProgramList.addProgramsIntoList(d);
                }
                else if (op == "3")
                {
                    List<student> sortedstudentlsit = new List<student>();
                    sortedstudentlsit = studentList.sortbymerit();
                    studentList.giveadmission(sortedstudentlsit);
                    MuserCRUD.generateMeritView();
                }
                else if (op == "4")
                {
                    MuserCRUD.regsiteredView();
                }
                else if (op == "5")
                {
                    string degreename;
                    Console.Write("Enter Degree Name :");
                    degreename = Console.ReadLine();
                    MuserCRUD.ViewSelectedStudent(degreename);
                }
                else if (op == "6")
                {
                    Console.Write("Enter the Student Name : ");
                    string name = Console.ReadLine();
                    student s = studentList.studentPresent(name);
                    if (s != null)
                    {
                        MuserCRUD.viewsubject(s);
                        MuserCRUD.registerSubjects(s);
                    }
                }
                else if (op == "7")
                {
                    MuserCRUD.calculateFee();
                }
                else if (op == "8")
                {
                    Environment.Exit(0);
                }
            }
            MuserCRUD.clearScreen();
            Console.ReadLine();
        }
    }
}
