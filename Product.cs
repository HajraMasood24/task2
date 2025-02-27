using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challange1.BL
{
    
    internal class Product
    {
        public string name;
        public string category;
        public float price;
        public int quantity;
        public int threshold;
        public Product() 
        { }

        public Product(string name,string category,float price,int quantity,int threshold)
        {
            this.name = name;
            this.category = category;
            this.price = price;
            this.quantity = quantity;
            this.threshold = threshold;
        }

        public double CalTax()
        {
            if (category == "grocery")
                return price * 0.10;
            else if (category == "fruit")
                return price * 0.05;
            else
                return price * 0.15;
        }

    }
}
