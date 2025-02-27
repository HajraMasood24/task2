using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Challange1.BL;

namespace Challange1.DL
{
    internal class ProductDL
    {

      
        public static List<Product> products = new List<Product>()
        {
            new Product("Sugar", "Grocery", 220F, 23, 3),
            new Product("Milk", "Dairy", 150F, 10, 5),
            new Product("Apple", "Fruit", 100F, 15, 4)
        };

        public bool AddProduct()
        {
            Console.Clear();
            Console.WriteLine("Enter Product Name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter Product Category (e.g., grocery, fruit, other):");
            string category = Console.ReadLine();

            Console.WriteLine("Enter Price of Product:");
            float price = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter Quantity in Stock:");
            int quantity = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Threshold (minimum stock to reorder):");
            int threshold = int.Parse(Console.ReadLine());

         
            Product newProduct = new Product(name, category, price, quantity, threshold);

           
            products.Add(newProduct);

            Console.WriteLine("\nProduct added successfully!");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            return true;
        }
        public void ViewAllProducts()
        {
            Console.Clear();
            Console.WriteLine("\nProduct List:");
            foreach (Product p in products)
            {
                Console.WriteLine(p.name + "         -           Rs." + p.price);
            }
         
        }
        public void FindHighestPricedProduct()
        {
            int maxValue=0;
            Console.Clear();
            Console.WriteLine("\nHighest Priced Product:");
            if (products.Count > 1)
            {
                for (int i = 0; i < products.Count; i++)
                {
                    if (products[i].price > products[maxValue].price)
                    {
                        maxValue = i;
                    }
                }
            }
            else
            {
                Console.WriteLine("Highest Priced Product:");
                maxValue = 1;
            }
            Product highestPriced=products[maxValue] ;
            Console.WriteLine(highestPriced.name+"  _  "+ highestPriced.price);
        }
        public void ViewSalesTax()
        {
            
            foreach (Product p in products) 
            {
                Console.WriteLine(p.name + " Tax: " + p.CalTax());
            }
        

        }
        public void ViewLowStockProducts()
        {
            Console.Clear();
            Console.WriteLine("\nLow threshold Product:");
            for (int i = 0; i < products.Count; i++)
            {
                if (products[i].threshold >= products[i].quantity)
                {
                    Console.WriteLine(products[i]);
                }
            }
            
        }
        private static float total;
        public static void BuyProduct()
        {

            string item = "";
            int quantity = 0;

            while (true)
            {
                Console.WriteLine("Enter the name of product you want to buy:");
                item = Console.ReadLine();
                if (item == "No")
                {
                    break;
                }
                Console.WriteLine("Enter the quantity of product:");
                quantity = int.Parse(Console.ReadLine());
                
                for (int i = 0; i < products.Count; i++)
                {
                    if (products[i].name == item)
                    {
                        if (products[i].quantity <= products[i].threshold)
                        {
                            Console.WriteLine("Product can't be ordered");
                            continue;
                        }
                          
                        float pric = products[i].price * quantity;
                        total += pric;
                        products[i].quantity -= quantity;
                        Console.WriteLine("Your curreny total is"+total);

                    }
                }
            }

        }
        public static void Invoice()
        {
            Console.Write("Your total bill is:" + total);

        }
    }
}
