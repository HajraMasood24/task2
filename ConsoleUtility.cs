using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Challange1.BL;

namespace Challange1.UI
{
    internal class ConsoleUtility
    {
        static void Main(string[] args)
        {


            menu();


        }



        public static int menu()
        {
            string path = "C:\\2nd semester\\OOP\\Lab Manual 5\\Challange1\\sign.txt";
            Console.Clear();
            Console.WriteLine("######################################################");
            Console.WriteLine("#                   MENU                             #");
            Console.WriteLine("######################################################");
            String str;
            Console.WriteLine("     1.Sign Up");
            Console.WriteLine("     2.Sign In");
            Console.WriteLine("     3.Exit");
            Console.WriteLine("Enter an option");
            str = Console.ReadLine();
            int option = int.Parse(str);
            string[] name = new string[100];
            string[] password = new string[100];
            Console.Clear();
            if (option == 1)
            {
                Console.WriteLine("Enter username:  ");
                string username = Console.ReadLine();
                Console.WriteLine("Enter password: ");
                int userpassword = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter your email:");
                string email= Console.ReadLine();
                Console.WriteLine("Enter your address:");
                string address= Console.ReadLine();
                Console.WriteLine("Enter your contact Number");
                double cell=double.Parse(Console.ReadLine());


               
                SignUp(path, username, userpassword,email,address,cell);
                Console.WriteLine("Enter 1 to return to menu");
                int op = int.Parse(Console.ReadLine());
                if (op == 1)
                {
                    menu();
                }
                else
                {
                    Console.WriteLine("Invalid option");
                }
            }
            if (option == 2)
            {
                Console.WriteLine("Enter username:");
                string username = Console.ReadLine();
                Console.WriteLine("Enter password:");
                string userpassword = Console.ReadLine();

               
                SignIn(path, name, password, username, userpassword);
               
            }
            if (option == 3)
            {
                return 0;
            }
            return option;
        }
        static void SignUp(string path, string username, int userpassword,string email,string address,double cell)
        {
            bool isValid = true;
            StreamWriter file = new StreamWriter(path, true);
            for (int i = 0; i < username.Length; i++)
            {
                if (!((username[i] >= 'A' && username[i] <= 'Z') || (username[i] >= 'a' && username[i] <= 'z') || (username[i] >= '0' && username[i] <= '9')))
                {
                    isValid = false;
                    Console.WriteLine("InValid username");
                }
            }

            if (!(userpassword > 99 && userpassword < 1000))
            {
                isValid = false;
                Console.WriteLine("InValid userpassword");

            }
            if (isValid)
            {
                file.WriteLine(username + "," + userpassword + "," + email + "," + address +","+cell);
                file.Flush();
                file.Close();
                Console.WriteLine("You have successfully signed up!");
            }



        }
        static string getData(string record, int field)
        {
            int commaCount = 1;
            string item = "";

            for (int x = 0; x < record.Length; x++)
            {
                if (record[x] == ',')
                {
                    commaCount++;
                }
                else if (commaCount == field)
                {
                    item += record[x];
                }
            }
            return item;
        }
        static void SignIn(string path, string[] name, string[] password, string username, string userpassword)
        {
            int x = 0;
            bool valid = false;
            if (File.Exists(path))
            {
                StreamReader fileVariable = new StreamReader(path);
                string record;
                while ((record = fileVariable.ReadLine()) != null)
                {
                    name[x] = getData(record, 1);
                    password[x] = getData(record, 2);

                    if (username == name[x] && userpassword == password[x])
                    {
                        valid = true;
                        Console.WriteLine("You have successfully logged in!");
                        UI.CustomerUI.CustomerMenu();

                    }
                    x++;

                }
                if (!valid)
                {
                    Console.WriteLine("Invalid username or pin!");

                }
                fileVariable.Close();

            }
        }
        public static void userMenu()
        { 
            int op = 0;
            Console.WriteLine("1.Customer");
            Console.WriteLine("2.Admin");
            Console.WriteLine("3.Product");
            op = int.Parse(Console.ReadLine());
            if (op == 1)
            {
                menu();
            }
            if (op == 2) {
                Console.WriteLine("Enter username:");
                string username=Console.ReadLine();
                Console.WriteLine("Enter password:");
                int password=int.Parse(Console.ReadLine());
                if (username == "AAA" && password == 111)
                {
                    UI.AdminUI.ShowAdminMenu();
                }
                else
                {
                    Console.WriteLine("Invalid input");
                }
            }
        }
    }
}
