using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Challange1.BL;
using Challange1.DL;

namespace Challange1.UI
{
    internal class AdminUI
    {
        public static void ShowAdminMenu()
        {
            int choice;
            do
            {
               

                Console.WriteLine("1. Add Product");
                Console.WriteLine("2. View All Products");
                Console.WriteLine("3. Find Product with Highest Unit Price");
                Console.WriteLine("4. View Sales Tax of All Products");
                Console.WriteLine("5. Products to be Ordered (Low Stock)");
                Console.WriteLine("6. View Profile (Username, Password)");
                Console.WriteLine("7. Exit");

                ProductDL pro = new ProductDL();
                Admin ad = new Admin();
                Console.WriteLine("Enter your choice: ");
                choice=int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        pro.AddProduct();
                        break;
                    case 2:
                        pro.ViewAllProducts();
                        break;
                    case 3:
                        pro.FindHighestPricedProduct();
                        break;
                    case 4:
                        pro.ViewSalesTax();
                        break;
                    case 5:
                        pro.ViewLowStockProducts();
                        break;
                    case 6:
                        Console.WriteLine("\nAdmin Profile:");
                        ad.Profile();
                        break;
                    case 7:
                        Console.WriteLine("Exiting Admin Panel...");
                        break;
                    default:
                        Console.WriteLine("Invalid choice! Please select a valid option.");
                        break;
                }

                
            } while (choice != 7);
        }
    }
}
