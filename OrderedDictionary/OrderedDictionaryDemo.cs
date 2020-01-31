using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderedDictionary
{
    class OrderedDictionaryDemo
    {
        static void Main(string[] args)
        {
            System.Collections.Specialized.OrderedDictionary orderedDictionary = new System.Collections.Specialized.OrderedDictionary();
            orderedDictionary.Add("Test1", "Test@123");
            orderedDictionary.Add("Admin", "Admin@123");
            orderedDictionary.Add("Temp", "Temp@123");
            orderedDictionary.Add("Demo", "Demo@123");
            orderedDictionary.Add("Test2", "Test2@123");
            orderedDictionary.Remove("Admin");
            if (orderedDictionary.Contains("Admin"))
            {
                Console.WriteLine("UserName already Esists");
            }
            else
            {
                orderedDictionary.Add("Admin", "Admin@123");
                Console.WriteLine("User added succesfully.");
            }
            // Insert a new key to the beginning of the OrderedDictionary
            orderedDictionary.Insert(0, "Test3", "Test3@123");
            // Modify the value of the entry with the key "Test1"
            orderedDictionary["Test1"] = "Test1@333";
            // Get a collection of the keys.
            Console.WriteLine("UserName" + ": " + "Password");
            foreach (DictionaryEntry entry in orderedDictionary)
            {
                Console.WriteLine(entry.Key + ": " + entry.Value);
            }
            String[] myKeys = new String[orderedDictionary.Count];
            String[] myValues = new String[orderedDictionary.Count];
            orderedDictionary.Keys.CopyTo(myKeys, 0);
            orderedDictionary.Values.CopyTo(myValues, 0);
            Console.WriteLine("");
            // Displays the contents of the OrderedDictionary
            Console.WriteLine(" INDEX KEY  VALUE");
            for (int i = 0; i < orderedDictionary.Count; i++)
            {
                Console.WriteLine("   {0} {1} {2}",
                    i, myKeys[i], myValues[i]);
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
