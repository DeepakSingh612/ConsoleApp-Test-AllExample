namespace VirtualMethod
{
    internal class Program
    {
      public class BClass
        {
            public virtual void GetInfo()
            {
                Console.WriteLine("Learn C# Tutorial");
            }
        }

        // Derived Class
        public class DClass : BClass
        {
            public override void GetInfo()
            {
                Console.WriteLine("Welcome to DClass");
            }
        }

        //public static int[] ArrRank(int[] arr)
        //{
        //    int[] SortArr = Array.Sort(arr);
        //    int[] rankarr = SortArr.Rank;
        //    return rankarr;
        //}

        static void Main(string[] args)
        {
            // int[] arr = { 40, 10, 20, 30, 30 };
            //int[] result;
            //result = ArrRank(arr);
            //foreach (int x in result)
            //Console.WriteLine(x);
            BClass d = new BClass();
            d.GetInfo();
            BClass b = new DClass();
            b.GetInfo();
            //int num = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Hi");
            //Console.WriteLine("given ", +num);
            //var i1 = 2;
            //var j = 5;
            //var result = i1 + j;
            //Console.WriteLine(result);
            Console.ReadLine();
        }
    }
    }
