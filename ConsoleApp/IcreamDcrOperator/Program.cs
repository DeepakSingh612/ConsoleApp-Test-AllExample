namespace IcreamDcrOperator
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Incremental Operator
            Console.WriteLine("------------------");
            int a = 10;
            Console.WriteLine("Incremental Operator");
            Console.WriteLine();
            Console.WriteLine(++a);//11
            Console.WriteLine(a);//11
            Console.WriteLine();
            Console.WriteLine(a++);//11
            Console.WriteLine(a);//12
            Console.WriteLine();
            a++;
            Console.WriteLine(a);//13
            ++a;
            Console.WriteLine(a);//14
            Console.WriteLine();
            // Decrement Operator    
            Console.WriteLine("Decremental Operator");
            Console.WriteLine();
            Console.WriteLine(--a);//13
            Console.WriteLine(a);//13
            Console.WriteLine();
            Console.WriteLine(a--);//13
            Console.WriteLine(a);//12
            Console.WriteLine();
            a++;
            Console.WriteLine(a);//13
            ++a;
            Console.WriteLine(a);//14
            Console.ReadLine();
        }
    }
}
