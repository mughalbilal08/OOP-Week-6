using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using oop_6._2.BL;
using oop_6._2.DL;

namespace oop_6._2.UI
{
    class MUserCRUD
    {
        public static int menu()
        {
            Console.Clear();
            int choice;
            Console.WriteLine("1. Sign In");
            Console.WriteLine("2. Sign Up");
            Console.WriteLine("3. Exit");
            choice = int.Parse(Console.ReadLine());
            return choice;
        }
        public static int Amenu()
        {
            Console.Clear();
            int option = 0;
            Console.WriteLine("1. Add Products");
            Console.WriteLine("2. View All Products");
            Console.WriteLine("3. Find Products With Highest Price");
            Console.WriteLine("4. View Sales Tax of All Products");
            Console.WriteLine("5. Products to Be Ordered");
            Console.WriteLine("6. Exit");
            Console.Write(" Enter your option: ");
            option = int.Parse(Console.ReadLine());
            return option;
        }
        public static int Umenu()
        {
            Console.Clear();
            int option = 0;
            Console.WriteLine("1. View All Products");
            Console.WriteLine("2. Buy The Products");
            Console.WriteLine("3. Generate Invoice");
            Console.WriteLine("4. Exit");
            Console.Write(" Enter your option: ");
            option = int.Parse(Console.ReadLine());
            return option;
        }
        public static Muser signIN()
        {
            string name;
            string password;
            Console.WriteLine("Enter Your Name ");
            name = Console.ReadLine();
            Console.WriteLine("Enter Your Password ");
            password = Console.ReadLine();
            Muser objU = new Muser( name, password);
            return objU;
        }
        public static Muser signUP()
        {
            string name;
            string password;
            string role;
            Console.WriteLine("Enter Your Name ");
            name = Console.ReadLine();
            Console.WriteLine("Enter Your Password ");
            password = Console.ReadLine();
            Console.WriteLine("Enter Your Role ");
            role = Console.ReadLine();
            Muser objU = new Muser(name, password, role);
            return objU;
        }

        //                  ADMIN MENU

        public static Product addProduct()
        {
            Console.Write("ENter name of Product: ");
            string name = Console.ReadLine();
            Console.Write("ENter category: ");
            string category = Console.ReadLine();
            Console.Write("ENter Price: ");
            float price = float.Parse(Console.ReadLine());
            Console.Write("ENter Quantity: ");
            int quantityS = int.Parse(Console.ReadLine());
            Console.Write("ENter Minmum: ");
            int quantityM = int.Parse(Console.ReadLine());
            Product objP = new Product(name, category, price, quantityS, quantityM);
            return objP;
        }
        public static void productV(Product p)
        {
            Console.WriteLine();
            Console.WriteLine("                 All Products                 ");
            Console.WriteLine();
            Console.WriteLine("Name \tCategory\tPrice\tStock\tTHreshold value");
            Console.WriteLine(p.nameP + "\t" + p.category + "\t\t" + p.price + "\t" + p.quantityS + "\t" + p.quantityM);
            Console.WriteLine();
        }
        public static void highV()
        {
            Product objp = List.highest();
            Console.WriteLine();
            Console.WriteLine("          Product With highest Price               ");
            Console.WriteLine();
            Console.WriteLine("Name \tCategory\tPrice\tStock");
            Console.WriteLine();
            Console.WriteLine(objp.nameP + "\t" + objp.category + "\t\t" + objp.price + "\t" + objp.quantityS);
        }
        public static void taxV()
        {
            List.taxPrice();
            Console.WriteLine();
            Console.WriteLine("          Product With TAX Price               ");
            Console.WriteLine();
            Console.WriteLine("Name \tCategory\tPrice\tStock");
            Console.WriteLine();
        }
        public static void taxD(Product p)
        {
            Console.WriteLine(p.nameP + "\t" + p.category + "\t\t" + p.tax + "\t" + p.quantityS );

        }
        public static void thre()
        {
            string thre = List.ord();
            if (thre != " ")
            {
                Console.WriteLine("Product with Tax Price: " + thre);
            }
        }

        //                  USER MENU

        public static costumer buyproducts()
        {
            string pname;
            Console.WriteLine();
            Console.Write(" Enter product name you want to buy:");
            pname = Console.ReadLine();
            int quantity;
            Console.Write(" Enter quantity:");
            quantity = int.Parse(Console.ReadLine());
            costumer obj = new costumer(pname, quantity);
            return obj;
        }
        public static void quantityEmpty()
        {
            Console.WriteLine();
            Console.WriteLine(" Not Enough Stock Available. Try Again Later !!!!");
        }
        public static void productEmpty()
        {
            Console.WriteLine();
            Console.WriteLine(" Not Product Available. Enter Valid Name !!!!");
        }
        public static void productEmptyMenu()
        {
            Console.WriteLine();
            Console.WriteLine(" Not Product Available.  !!!!");
        }
        public static void productdisplayforUser()
        {
            Console.WriteLine();
            Console.WriteLine("                 All Products                 ");
            Console.WriteLine();
            Console.WriteLine("Name \tCategory\tPrice");

        }
        public static void productVforUser(Product p)
        {
            Console.WriteLine(p.nameP + "\t" + p.category + "\t\t" + p.price);
            Console.WriteLine();
        }
        public static void VoiceBill(float bill)
        {
            Console.WriteLine(" Total bill after sale tax to be applied is: " + bill);
        }

    }
}
