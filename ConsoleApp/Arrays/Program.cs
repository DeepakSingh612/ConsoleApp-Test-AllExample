namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[]  arrA = { 5, 3 };
            int[] arrB = { 1, 3,6,9,12 };
            for (int i = 0; i < arrA.Length; i++) 
            {
                for (int j = 0; j < arrB.Length; j++)
                {
                    if ( arrB[j] % arrA[i] == 0)
                    {
                        Console.WriteLine(arrB[j]);
                    }
                
                }



            }

            Console.ReadLine();

        }
    }
}