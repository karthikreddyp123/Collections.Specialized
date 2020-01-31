using System;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCollection
{
    class StringCollectionDemo
    {
        static void Main(string[] args)
        {
            System.Collections.Specialized.StringCollection stringCollection = new System.Collections.Specialized.StringCollection();
            String[] Cities = new String[] { "Hyderabad","Delhi","Mumbai","Banglore","Chennai","Kolkatta"};
            stringCollection.AddRange(Cities);
            // Display the contents of the collection using foreach.
            Console.WriteLine("Displays the elements using foreach:");
            foreach (String obj in stringCollection)
                Console.WriteLine("   {0}", obj);
            Console.WriteLine();
            stringCollection.Add("Pune");
            stringCollection.Add("Vizag");
            stringCollection.Remove("Chennai");
            Console.WriteLine("After Updating Collection:");
            foreach (String obj in stringCollection)
                Console.WriteLine("   {0}", obj);
            Console.WriteLine();
            // Copy the collection to a new array starting at index 0.
            String[] CitiesArray = new String[stringCollection.Count];
            stringCollection.CopyTo(CitiesArray, 0);
            Console.WriteLine("The new array contains:");
            for (int i = 0; i < CitiesArray.Length; i++)
            {
                Console.WriteLine("   [{0}] {1}", i, CitiesArray[i]);
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
