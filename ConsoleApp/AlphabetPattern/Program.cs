namespace AlphabetPattern
{
    internal class Program
    {



        static void Main(string[] args)
        {
            int i, j;
            int n = 4;

            for (i = 1; i <= n; i++)
            {
                for (j = 1; j <= i; j++)
                {
                    Console.Write((char)(j + 64));

                }

                Console.WriteLine("");
            }
            Console.ReadLine();
        }
    }
    }
