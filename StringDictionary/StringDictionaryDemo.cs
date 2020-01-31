using System;
using System.Collections.Specialized;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringDictionary
{
    class StringDictionaryDemo
    {
        static void Main(string[] args)
        {
            System.Collections.Specialized.StringDictionary stringDictionary = new System.Collections.Specialized.StringDictionary();
            stringDictionary.Add("Test1", "Test@123");
            stringDictionary.Add("Admin", "Admin@123");
            stringDictionary.Add("Temp", "Temp@123");
            stringDictionary.Add("Demo", "Demo@123");
            stringDictionary.Add("Test2", "Test2@123");
            stringDictionary.Remove("Admin");
            if (stringDictionary.ContainsKey("Admin"))
            {
                Console.WriteLine("UserName already Esists");
            }
            else
            {
                stringDictionary.Add("Admin", "Admin@123");
                Console.WriteLine("User added succesfully.");
            }

            // Get a collection of the keys.
            Console.WriteLine("UserName" + ": " + "Password");
            foreach (DictionaryEntry entry in stringDictionary )
            {
                Console.WriteLine(entry.Key + ": " + entry.Value);
            }
            Console.ReadKey();
        }
    }
}
