using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTableExample
{
    class Program
    {
        static void Main()
        {
            // Create Dictionary.
            Dictionary<string, int> hash = new Dictionary<string, int>();

            // Add some data.
            hash.Add("diamond", 500);
            hash.Add("ruby", 200);
            hash.Add("pearl", 100);

            // Get value that exists.
            int value1 = hash["diamond"];
            Console.WriteLine("get DIAMOND: " + value1);

            // Get value that does not exist.
            hash.TryGetValue("coal", out int value2);
           Console.WriteLine("get COAL: " + value2);

            // Loop over items in collection.
            foreach (KeyValuePair<string, int> pair in hash)
            {
                Console.WriteLine("KEY: " + pair.Key);
                Console.WriteLine("VALUE: " + pair.Value);
            }
            Console.WriteLine("Press Any Key to Exit!");
            var x = Console.ReadLine();
        }
    }
}
