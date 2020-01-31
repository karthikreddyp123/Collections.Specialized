using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListDictionary
{
    class ListDictonaryDemo
    {
        static void Main(string[] args)
        {
            // Creates and initializes a new ListDictionary.
            System.Collections.Specialized.ListDictionary listDictionary = new System.Collections.Specialized.ListDictionary();
            listDictionary.Add("Test1", "Test@123");
            listDictionary.Add("Admin", "Admin@123");
            listDictionary.Add("Temp", "Temp@123");
            listDictionary.Add("Demo", "Demo@123");
            listDictionary.Add("Test2", "Test2@123");
            listDictionary.Remove("Admin");
            if (listDictionary.Contains("Admin"))
            {
                Console.WriteLine("UserName already Esists");
            }
            else
            {
                listDictionary.Add("Admin", "Admin@123");
                Console.WriteLine("User added succesfully.");
            }

            // Get a collection of the keys.
            Console.WriteLine("UserName" + ": " + "Password");
            foreach (DictionaryEntry entry in listDictionary)
            {
                Console.WriteLine(entry.Key + ": " + entry.Value);
            }
            Console.ReadKey();
        }
    }
}
