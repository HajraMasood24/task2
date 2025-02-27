using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Challange1.BL;

namespace Challange1.DL
{
    internal class CustomerDL
    {
        public static void CustomerProfile()
        {
            Console.WriteLine("Admin name \t\t Password");

            string line;
            string path = "C:\\2nd semester\\OOP\\Lab Manual 5\\Challange1\\sign.txt";
            StreamReader fileVariable = new StreamReader(path);

            while ((line = fileVariable.ReadLine()) != null)

            {
                string name = getinfo(line, 1);
                string pin = getinfo(line, 2);
                string email = getinfo(line, 3);
                string address = getinfo(line, 4);
                string cell = getinfo(line, 5);

                Console.WriteLine(name + "\t\t\t" + pin);
            }
            Console.WriteLine("Enter 1 to go back");
            fileVariable.Close();
        }
        public static string getinfo(string record, int info)
        {
            int commaCount = 1;
            string item = "";

            for (int x = 0; x < record.Length; x++)
            {
                if (record[x] == ',')
                {
                    commaCount++;
                }
                else if (commaCount == info)
                {
                    item += record[x];
                }
            }
            return item;
        }
    }
}
