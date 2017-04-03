using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview_Tests.Collections
{
    public class Iterator
    {

        public static IEnumerable LeroyStringList()
        {
            yield return "First string";
            yield return "Second string";
            yield return "Third String";
            yield return "Fourth String";
        }
        public static string TestStringListIteration()
        {
            var builder = new StringBuilder(150);

            foreach (string str in LeroyStringList())
            {
                builder.AppendLine(str);
            }
            return builder.ToString();
        }
    }
}
