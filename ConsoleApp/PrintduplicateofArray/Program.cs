namespace PrintduplicateofArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] values = new []{1,2,2,3,4,4,5 };
            int[] values2 = new[] { 1, 2, 2, 3, 4, 4, 5 };
            var groups=values.GroupBy(x => x);
            var groups2 = values2.GroupBy(x => x);
            foreach (var group in  groups)
            {
               Console.WriteLine("value {0} has {1} items",group.Key,group.Count());
            }
            Console.ReadLine(); 
        }
    }
}
