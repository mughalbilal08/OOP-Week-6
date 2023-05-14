using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_06
{
    class Program
    {
        static void Main(string[] args)
        {
            // t1();
            // Selft1();
            // Selft2();
        }
        public static void t1()
        {
            
            student s1 = new student("Bilal", 43, 175);
            student s2 = new student("ALi", 21, 211);
            student s3 = new student("Abdul", 22, 157);
            List<student> studentL = new List<student>() { s1, s2, s3 };
            List<student> sortL = studentL.OrderBy(o => o.rollN).ToList();
            Console.WriteLine("Name \t Roll No \t Ecat Marks");
            foreach(student s in sortL)
            {
                Console.WriteLine("{0} \t {1} \t\t {2} ", s.name, s.rollN, s.ecatM);
            }
            Console.Read();
        }
        public static void Selft1()
        {
            List<string> name = new List<string>() { "Ali", "Bilal","Noor","Abdullah","Maryam"};
            name.Sort();
            foreach (string s in name)
            {
                Console.WriteLine(s);
            }
            
            Console.WriteLine();

            List<float> num = new List<float>() { 1.2F, 2.5F,5F};
            num.Sort();
            foreach (float f in num)
            {
                Console.WriteLine(f);
            }
            Console.ReadKey();
        }
        public static void Selft2()
        {
            student s1 = new student("Bilal", 43, 175);
            student s2 = new student("ALi", 21, 211);
            student s3 = new student("Abdul", 22, 157);
            List<student> studentL = new List<student>() { s1, s2, s3 };
            List<student> sortL = studentL.OrderByDescending(o => o.rollN).ToList();
            Console.WriteLine("Name \t Roll No \t Ecat Marks");
            foreach (student s in sortL)
            {
                Console.WriteLine("{0} \t {1} \t\t {2} ", s.name, s.rollN, s.ecatM);
            }
            Console.Read();
        }

    }

    class student
    {
        public string name;
        public int rollN;
        public int ecatM;
   
        public student()
        {

        }
        public student(string name, int rollN, int ecatM)
        {
            this.name = name;
            this.rollN = rollN;
            this.ecatM = ecatM;
        }
    }
}
