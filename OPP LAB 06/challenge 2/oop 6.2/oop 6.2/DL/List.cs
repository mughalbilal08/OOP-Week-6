using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using oop_6._2.BL;
using oop_6._2.UI;

namespace oop_6._2.DL
{
    class List
    {
        static List<Muser> userD = new List<Muser>();
        static List<Product> products = new List<Product>();
        public static void AddInput(Muser user)
        {
            userD.Add(user);
        }
        public static string isValid(Muser user, ref int indexC)
        {
            string role = "undefined";
            for (int x=0; x<userD.Count; x++)
            {
                if (user.name == userD[x].name && user.password == userD[x].password)
                {
                    role = userD[x].role;
                    indexC = x;
                }
            }
            return role;
        }

        //                  Product
        
        public static void addintoProducts(Product P)
        {
            products.Add(P);
        }
        public static void productView()
        {
            for (int x = 0; x < products.Count;x++)
            {
                MUserCRUD.productV(products[x]);
            }
        }
        public static Product highest()
        {
            float highest = 0;
            int index = 0;
            string name = " ";
            for (int x = 0; x < products.Count; x++)
            {
                if (highest < products[x].price)
                {
                    highest = products[x].price;
                    index = x;
                }
            }
            return products[index];
        }
        public static void taxPrice()
        {
            float tax = 0;
            foreach (Product p in products)
            {

                if (p.category == "grocery")
                {
                    tax = p.price * 10 / 100;
                    p.tax = tax;
                }
                if (p.category == "fruits")
                {
                    tax = (p.price * 5) / 100;
                    p.tax = tax;
                }
                else
                {
                    tax = p.price * 15 / 100;
                    p.tax = tax;
                }
            } 
        }
        public static void taxDisplay()
        {
            for (int x=0;  x<products.Count;x++)
            {
                MUserCRUD.taxD(products[x]);
            }
        }
        public static string ord()
        {      
            string order = " ";
            foreach (Product p in products)
            {  
                if (p.quantityM < 10)
                {
                    order = p.nameP;
                }
            } 
            return order;
        }

        //                  Customer

        public static void AddbuyProductsToList(costumer user, int Curentindex)
        {
            userD[Curentindex].customerData.Add(user);
        }
        public static bool DataC(costumer p)
        {
            bool check = false;
            for (int x = 0; x < products.Count; x++)
            {
                if (p.name == products[x].nameP)
                {
                    check = true;
                }
            }
            return check;
        }
        public static bool quantityC(costumer p)
        {
            bool check = false;
            for (int x = 0; x < products.Count; x++)
            {
                if (p.quantity <= products[x].quantityS)
                {
                    check = true;
                }
            }
            return check;
        }
        public static void decreasedquantity(costumer p)
        {
            for (int x = 0; x < products.Count; x++)
            {
                if (products[x].nameP == p.name)
                {
                    products[x].quantityS = products[x].quantityS - p.quantity;
                }
            }
        }
        public static int userPView()
        {
            int count = 0;
            for (int x = 0; x < products.Count; x++)
            {
                MUserCRUD.productVforUser(products[x]);
                count++;
            }
            return count;
        }
        public static float generateinvoicebill(int currentindex)
        {
            float total = 0;
            int count = userD[currentindex].customerData.Count;
            for (int x = 0; x < products.Count; x++)
            {
                for (int y = 0; y < count; y++)
                {
                    if (products[x].nameP == userD[currentindex].customerData[y].name)
                    {
                        total = total + products[x].price * userD[currentindex].customerData[y].quantity;
                        total = total - (products[x].tax * userD[currentindex].customerData[y].quantity);
                    }
                }
            }
            return total;
        }

    }
}
