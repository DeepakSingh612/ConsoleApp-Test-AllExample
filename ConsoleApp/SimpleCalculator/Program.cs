namespace SimpleCalculator
{
    internal class Program
    {
        class Test
        {
            public int SimCalculator()
            {

                Console.Write("Enter first number:");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter second number:");
                int num2 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter symbol(/,+,-,*):");
                string symbol = Console.ReadLine();
                int res = 0;
                switch (symbol)
                {

                    case "+":
                        res = num1 + num2;
                        Console.WriteLine("Addition:" + res);
                        break;
                        case "-":
                        res = num1 - num2;
                        Console.WriteLine("Addition:" + res);
                        break;
                        case "*":

                        res = num1 * num2;
                        Console.WriteLine("Addition:" + res);
                        break;
                        case "/":
                        res = num1 / num2;
                        Console.WriteLine("Addition:" + res);
                        break;


                }

                return 0;
            }
    }


        static void Main(string[] args)
        {
           Test test = new Test();
            test.SimCalculator();
            Console.ReadLine();
        }
    }
}