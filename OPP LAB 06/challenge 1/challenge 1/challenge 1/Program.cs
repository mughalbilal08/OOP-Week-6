using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using challenge_1.BL;
using challenge_1.UI;


namespace challenge_1
{
    class Program
    {
       static MyLine objL = new MyLine();
        static void Main(string[] args)
        {
            
            int option = 0;
            do
            {
                Console.Clear();
                option = MuserCRUD.menu();
                if (option == 1)
                {
                    Console.Clear();
                    objL = MuserCRUD.makeLineX();
                    Console.ReadKey();
                }
                if (option == 2)
                {
                    Console.Clear();
                    MyPoint point = MuserCRUD.changeBeginPoint();
                    objL.begin.setX(point.x);
                    objL.begin.setY(point.y);
                    Console.ReadKey();
                }
                if (option == 3)
                {
                    Console.Clear();
                    MyPoint point = MuserCRUD.changeEndPoint();
                    objL.end.setX(point.x);
                    objL.end.setY(point.y);
                    Console.ReadKey();
                }
                if (option == 4)
                {
                    Console.Clear();
                    MuserCRUD.viewStartingPoints(objL);
                    Console.ReadKey();
                }
                if (option == 5)
                {
                    Console.Clear();
                    MuserCRUD.viewEndingPoints(objL);
                    Console.ReadKey();
                }
                if (option == 6)
                {
                    Console.Clear();
                    double len = objL.getLength();
                    MuserCRUD.viewLenght(len);
                    Console.ReadKey();
                }
                if (option == 7)
                {
                    Console.Clear();
                    double grad = objL.getGradient();
                    MuserCRUD.viewGradient(grad);
                    Console.ReadKey();
                }
                if (option == 8)
                {
                    Console.Clear();
                    double disB = objL.begin.distanceFromZero(); 
                    MuserCRUD.beginPointsDistance(disB);
                    Console.ReadKey();
                }
                if (option == 9)
                {
                    Console.Clear();
                    double disB = objL.end.distanceFromZero();
                    MuserCRUD.endPointsDistance(disB);
                    Console.ReadKey();
                }

            }
            while (option != 10);
        }
    }
}
