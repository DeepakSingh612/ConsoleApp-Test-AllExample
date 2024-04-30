namespace Pangram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // emp pm = new emp();
            // pm.Foo();

            string str1 = "war";
            string str2 = "raw";
            string? str3 = null;
            if (str1.Length == str2.Length)
            {

                char[] arr2 = str2.ToCharArray();

                //string aa = String.Concat(str1.OrderBy(c => c));

                for (int i = arr2.Length - 1; i >= 0; --i)
                {
                    str3 += arr2[i].ToString();

                }
                //  string bb = String.Concat(str2.OrderBy(c => c));
                // string result= new string(str3);
                if (str1 == str3)
                {
                    Console.WriteLine("YES");
                }
                else
                {
                    Console.WriteLine("NO");
                }


            }

            Console.ReadLine();
        }
    }
    
}