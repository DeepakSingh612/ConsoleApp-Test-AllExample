namespace InterviewQuestions
{
    internal class Program
    { //Swap index value 3 with index value 7
        public int[] SwapString(int[] array2)
        {
            int Temp = array2[3];
            array2[3] = array2[7];
            array2[7] = Temp;

            return array2;


        }

        static void Main(string[] args)
        {

            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8 };
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
            Program program = new Program();

            int[] array1 = program.SwapString(array);
            foreach (var item in array1)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}