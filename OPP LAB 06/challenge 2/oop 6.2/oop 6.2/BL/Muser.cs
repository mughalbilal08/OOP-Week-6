using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_6._2.BL
{
    class Muser
    {
        public string name;
        public string password;
        public string role;
        public List<costumer> customerData;

        public Muser()
        {

        }
        public Muser(string name, string password, string role)
        {
            this.name = name;
            this.password = password;
            this.role = role;
            if (role == "customer")
            {
                customerData = new List<costumer>();
            }
        }
        public Muser(string name, string password)
        {
            this.name = name;
            this.password = password;
        }
    }
   
}
