using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challange1.BL
{
    internal class Admin
    {
        public string username;
        public string password;

        public Admin() { }
        public Admin(string username, string password)
        {
            username = this.username;
            password = this.password;
        }
        public void Profile()
        {
            Console.WriteLine("Admin name \t\t Password");

            string line;
            string path = "C:\\2nd semester\\OOP\\Lab Manual 5\\Challange1\\sign.txt";
            StreamReader fileVariable = new StreamReader(path);

            while ((line = fileVariable.ReadLine()) != null)

            {
                string name = getinfo(line, 1);
                string pin = getinfo(line, 2);
                Console.WriteLine(name + "\t\t\t" + pin);
            }
            Console.WriteLine("Enter 1 to go back");
            fileVariable.Close();
        }
        string getinfo(string record, int info)
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
