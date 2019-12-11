using System;
using System.Collections.Generic;

namespace LINQExamplesQueries
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Tom", "Dick", "Harry" }; 
            IEnumerable<string> filteredNames = System.Linq.Enumerable.Where(names, n => n.Length >= 4); 
            foreach (string n in filteredNames) 
                Console.WriteLine(n);

        }
    }
}
