using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HybridDictionary
{
    class HybridDictionaryDemo
    {
        static void Main(string[] args)
        {
            System.Collections.Specialized.HybridDictionary hybridDictionary = new System.Collections.Specialized.HybridDictionary();
            hybridDictionary.Add("Test1", "Test@123");
            hybridDictionary.Add("Admin", "Admin@123");
            hybridDictionary.Add("Temp", "Temp@123");
            hybridDictionary.Add("Demo", "Demo@123");
            hybridDictionary.Add("Test2", "Test@123");
            hybridDictionary.Add("Test4", "Test@123");
            hybridDictionary.Add("Test3", "Test@123");
            hybridDictionary.Add("Test5", "Test@123");
            hybridDictionary.Add("Test12", "Test@123");
            hybridDictionary.Add("Test6", "Test@123");
            hybridDictionary.Add("Test7", "Test@123");
            hybridDictionary.Add("Test8", "Test@123");
            hybridDictionary.Add("Test9", "Test@123");
            hybridDictionary.Add("Test10", "Test@123");
            hybridDictionary.Add("Test11", "Test@123");

            hybridDictionary.Remove("Admin");
            if (hybridDictionary.Contains("Admin"))
            {
                Console.WriteLine("UserName already Esists");
            }
            else
            {
                hybridDictionary.Add("Admin", "Admin@123");
                Console.WriteLine("User added succesfully.");
            }
            // Copies the HybridDictionary to an array with DictionaryEntry elements.
            DictionaryEntry[] myArr = new DictionaryEntry[hybridDictionary.Count];
            hybridDictionary.CopyTo(myArr, 0);
            // Displays the values in the array.
            Console.WriteLine("Displays the elements in the array:");
            Console.WriteLine(" KEY VALUE");
            for (int i = 0; i < myArr.Length; i++)
                Console.WriteLine("   {0} {1}", myArr[i].Key, myArr[i].Value);
            Console.WriteLine();

            // Get a collection of the keys.
            Console.WriteLine("UserName" + ": " + "Password");
            foreach (DictionaryEntry entry in hybridDictionary)
            {
                Console.WriteLine(entry.Key + ": " + entry.Value);
            }
            Console.ReadKey();
        }
    }
}
