using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_6._2.BL
{
    class Product
    {
        public string nameP;
        public string category;
        public float price;
        public int quantityS;
        public int quantityM;
        public float tax;

        public Product()
        {

        }
        public Product(string nameP, string category, float price, int quantityS, int quantityM)
        {
            this.nameP = nameP;
            this.category = category;
            this.price = price;
            this.quantityS = quantityS;
            this.quantityM = quantityM;
        }
    }
}
