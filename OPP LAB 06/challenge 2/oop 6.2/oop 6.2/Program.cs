using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using oop_6._2.BL;
using oop_6._2.DL;
using oop_6._2.UI;

namespace oop_6._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int option;
            int index = 0;
            do
            {
                 option = MUserCRUD.menu();
                if (option == 1)
                {
                    Console.Clear();
                    Muser data = MUserCRUD.signIN();
                    string role = List.isValid(data,ref index);
                    if(role == "admin")
                    {
                        
                        int option1 = 0;
                        while(option1 !=6)
                        {

                            option1 = MUserCRUD.Amenu();
                            if (option1 ==1)
                            {
                                Console.Clear();
                                List.addintoProducts(MUserCRUD.addProduct());
                            }
                            if (option1 == 2)
                            {
                                Console.Clear();
                                List.productView();
                                Console.ReadKey();
                            }
                            if (option1 == 3)
                            {
                                Console.Clear();
                                MUserCRUD.highV();
                                Console.ReadKey();
                            }
                            if (option1 == 4)
                            {
                                Console.Clear();
                                MUserCRUD.taxV();
                                List.taxDisplay();
                                Console.ReadKey();
                            }
                            if (option1 == 5)
                            {
                                Console.Clear();
                                MUserCRUD.thre();
                                Console.ReadKey();
                            }
                        }
                     
                    }
                    if(role == "user")
                    {
                        Console.Clear();
                        int option1=0;
                        
                        while(option1!=4)
                        {
                            option1 = MUserCRUD.Umenu();
                            if(option1 == 1)
                            {
                                Console.Clear();
                                MUserCRUD.productdisplayforUser();
                                int count = List.userPView();
                                if (count == 0)
                                {
                                    MUserCRUD.productEmptyMenu();
                                }
                                Console.ReadKey();
                            }
                            if (option1 == 2)
                            {
                                Console.Clear();
                                costumer objC = MUserCRUD.buyproducts();
                                bool check = List.DataC(objC);
                                if (check == true)
                                {
                                    bool check1 = List.quantityC(objC);
                                    if (check1 == true)
                                    {
                                        List.AddbuyProductsToList(objC, index);
                                        List.decreasedquantity(objC);
                                    }
                                    else
                                    {
                                        MUserCRUD.quantityEmpty();
                                    }
                                }
                                else
                                {
                                    MUserCRUD.productEmpty();
                                }
                                Console.ReadKey();
                            }
                            if (option == 3)
                            {
                                Console.Clear();
                                MUserCRUD.VoiceBill(List.generateinvoicebill(index));
                                Console.ReadKey();
                            }
                        }
                        Console.ReadKey();
                    }
                    if(role == "undefined")
                    {
                        Console.Clear();
                        Console.Write(" User not find!!!");
                        Console.ReadKey();
                    }
                    Console.Clear();
                }
                if (option == 2)
                {
                    Muser data1 = MUserCRUD.signUP();
                    List.AddInput(data1);
                }

            }
            while (option != 4);

        }
    }

}
