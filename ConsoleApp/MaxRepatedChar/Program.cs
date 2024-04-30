using System.Collections.Generic;
using System.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace MaxRepatedChar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "Welcome  to qentelli";

            char[] str1=str.ToCharArray();
            int count = 0;

            //var q = list.GroupBy(x => x)
            //   .Select(g => new { Value = g.Key, Count = g.Count() })
            //   .OrderByDescending(x => x.Count);

            var q = from x in str
                    group x by x into g
                    let count1 = g.Count()
                    orderby count1 descending
                    select new { Value = g.Key, Count = count1 };
            foreach (var x in q)
            {
                Console.WriteLine("Value: " + x.Value + " Count: " + x.Count);
            }
            Console.ReadLine();
            
        }
    }
}