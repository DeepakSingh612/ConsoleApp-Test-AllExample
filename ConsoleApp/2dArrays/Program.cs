namespace _2dArrays
{
    internal class Program
    {
        static void MaxMin(int[,] arr, int n)
        {

            int max=int.MaxValue; 
            int min=int.MinValue;
            for(int  i=0; i<n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (max > arr[i,j])
                        max = arr[i,j];
                        }
            
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (min < arr[i, j])
                        min = arr[i, j];
                }

            }
            Console.WriteLine("Minimum = {0},Maximum = {1}, ", max, min);
        }
            static void Main(string[] args)
        {
            int[,] arr = { { 5, 4, 9 }, { 2, 0, 6 }, { 3, 1, 8 } };
            MaxMin(arr, 3);
            Console.ReadLine();
           
        }
    }
}