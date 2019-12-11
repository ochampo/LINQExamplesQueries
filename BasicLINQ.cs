using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LINQExamplesQueries
{
    class BasicLINQ
    {
        public void simpleLinq()
        {
            string[] names = { "Tom", "Dick", "Harry" };
            IEnumerable<string> filteredNames = System.Linq.Enumerable.Where(names, n => n.Length >= 4);
            foreach (string n in filteredNames)
                Console.WriteLine(n);


            int[] seq1 = { 1, 2, 3 };
            int[] seq2 = { 3, 4, 5 };
            IEnumerable<int> concat = seq1.Concat(seq2);
            //  { 1, 2, 3, 3, 4, 5 } 
            IEnumerable<int> union = seq1.Union(seq2);

        }

    }
}
