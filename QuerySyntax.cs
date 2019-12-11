using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LINQExamplesQueries
{
    public class QuerySyntax
    {

        public void querySyntax()
        {
            string[] names = { "Tom", "Dick", "Harry", "Mary", "Jay" };
            IEnumerable<string> query = from n in names
                                        where n.Contains("a")
                                        orderby n.Length
                                        select n.ToUpper();
            foreach (string name in query)
            {
                Console.WriteLine(name);
            }

        }


    }
}
