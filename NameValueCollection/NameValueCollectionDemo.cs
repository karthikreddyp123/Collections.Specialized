using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nameValueCollection
{
    class NameValueCollectionDemo
    {
        static void Main(string[] args)
        {
            System.Collections.Specialized.NameValueCollection nameValueCollection = new System.Collections.Specialized.NameValueCollection();
            nameValueCollection.Add("Test1", "Test@123");
            nameValueCollection.Add("Admin", "Admin@123");
            nameValueCollection.Add("Temp", "Temp@123");
            nameValueCollection.Add("Demo", "Demo@123");
            nameValueCollection.Add("Test2", "Test2@123");
            nameValueCollection.Remove("Admin");
            // Gets a value either by index.
            Console.WriteLine("Index 1 contains the value {0}.", nameValueCollection[1]);
            // Copies the values to a string array and displays the string array.
            String[] myStrArr = new String[nameValueCollection.Count];
            nameValueCollection.CopyTo(myStrArr, 0);
            Console.WriteLine("The string array contains:");
            foreach (String s in myStrArr)
                Console.WriteLine("   {0}", s);
            Console.WriteLine();
            // Get a collection of the keys.
            Console.WriteLine("UserName" + ": " + "Password");
            Console.WriteLine("   KEY        VALUE");
            foreach (String s in nameValueCollection.AllKeys)
                Console.WriteLine("   {0} {1}", s, nameValueCollection[s]);
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
