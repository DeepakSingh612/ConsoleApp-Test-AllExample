namespace CommanFunctoAddintStr
{
    internal class Program
    {
        public static int Add<T>(T val1, T val2)
        {
            dynamic a = val1;
            dynamic b = val2;
            return a + b;
        }
        static void Main(string[] args)
        {
            //   public class HelloWorld
            //{
            //    public static T Add<T>(T val1, T val2)
            //    {
            //        dynamic a = val1;
            //        dynamic b = val2;
            //        return a + b;
            //    }
            //    public static void Main(string[] args)
            //    {
            //        int result = HelloWorld.Add<int>(3, 4);
            //        string result1 = HelloWorld.Add<string>("Deepak", "Singh");

            //        Console.WriteLine(result);
            //        Console.WriteLine("-----------------\n");
            //        Console.WriteLine(result1);

            //    }
            int result = Program.Add<int>(3, 4);
            int a = 1;
            Console.WriteLine("result", +a);

            // Program<string> program1 = new Program<string>();
            // program1.Add("Deepak","Singh");
            //Console.WriteLine("Hello, World!");
            Console.ReadLine();
        }
    }
}