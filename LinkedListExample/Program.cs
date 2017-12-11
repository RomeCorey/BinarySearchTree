using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListExample
{
    class Program
    {

        static void Main(string[] args)
        {
            Dictionary<string, bool> foo = new Dictionary<string, bool>();
            foo.Add("name", true);
            bool fee = foo["name"];
            foreach(KeyValuePair<string, bool> entry in foo)
            {
                Console.WriteLine(entry.Key, entry.Value);
            }
        }

    }
}
