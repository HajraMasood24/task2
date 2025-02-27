using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Challange1.DL;

namespace Challange1.UI
{
    internal class CustomerUI
    {
        public static void CustomerMenu()
        {
            int op;
            ProductDL pro = new ProductDL();
            do
            {
                Console.WriteLine("1. View all the products");
                Console.WriteLine("2. Buy the products");
                Console.WriteLine("3. Generate invoice");
                Console.WriteLine("4. View Profile (Username, Password, Email, Address and Contact Number");
                Console.WriteLine("5. Exit");

                op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        pro.ViewAllProducts();
                        break;
                    case 2:
                        DL.ProductDL.BuyProduct();
                        break;
                    case 3:
                        DL.ProductDL.Invoice();
                        break;
                    case 4:
                        DL.CustomerDL.CustomerProfile();
                        break;
                }
            }
            while (op!=5);
        }
    }
}
