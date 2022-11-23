using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
    internal class CoffeeOrder
    {
        
        string clientname;
        string drink;
        string size;
        int quantity;
        
        string[] addons;
        DateTime dateTime;
        double total;
        int topInd;

        public CoffeeOrder() : this("","", DateTime.Today.ToString(), 0.0, -1, new string[3], "Regular") { }
        public CoffeeOrder(string n, string dr, string d, double t, int q, string[] a, string s)
        {
            this.clientname = n;
            this.drink = dr;
            this.dateTime = DateTime.Parse(d);
            this.total = t;
            this.quantity = q;
            this.addons= a;
            this.size = s;
            this.topInd = 0;
        }
        public string Name { get { return clientname; } set { clientname = value; } }
        public string Drink { get { return drink; } set { drink = value; } }
        public string Size { get { return size; } set { size = value; } }
        public double Total { get { return total; } set { total = value; } }
        public int Quantity { get { return quantity; } set { quantity = value; } }
        public DateTime DateTime { get { return dateTime; } set { dateTime = value; } }
        public string[] Toppings { get { return addons; } set { addons = value; } }
        public void addOns(String a)
        {
            if (topInd < 3)
            {
                addons[topInd] = a;
            }
            topInd++;
        }

        public override string ToString()
        {
            string a = "\n" + Quantity + " " + Size + " "+ Drink+("(s) ")+ "\nAdd Ons:  \n";
            for (int i = 0; i < 3; i++)
            {
                if (addons[i] != null)
                    a += addons[i] + "\n";
            }
            return a;
        }

    }
}
