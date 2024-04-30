namespace ScalerTest
{
    internal class Program
    {

        public static List<int> FindIntersection(int[] arr1, int[] arr2)
        {
            // Just write your code below to complete the function. Required input is available to you as the function arguments.
            // Do not print the result or any output. Just return the result via this function.
           // int[] arr1 = A.ToArray();
           // int[] arr2 = B.ToArray();
            List<int> CommElement = new List<int>();

            for (int i = 0; i < arr1.Length; i++)
            {
                for (int j = 0; j < arr2.Length; j++)
                {
                    if (arr1[i] == arr2[j])
                        CommElement.Add(arr1[i]);
                   
                }
            }
            return CommElement;
        }
        //static int[] FindIntersection(int[] array1, int[] array2)
        //{
        //    HashSet<int> set1 = new HashSet<int>(array1);
        //    HashSet<int> intersection = new HashSet<int>();

        //    foreach (int num2 in array2)
        //    {
        //        if (set1.Contains(num2))
        //        {
        //            intersection.Add(num2);
        //        }
        //    }

        //    return intersection.ToArray();
        //}
        static void Main(string[] args)
        {
            int[] array1 = { 1, 2, 4, 4, 5,5 };
            int[] array2 = { 4, 5, 4, 7, 8,5 };

            List<int> intersection = FindIntersection(array1, array2);

            Console.WriteLine("Intersection of the arrays:");
            foreach (int num in intersection)
            {
                Console.Write(num + " ");
            }
            Console.ReadLine();
        }
    }
}