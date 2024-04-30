namespace CountLastWordChar
{
    internal class Program
    {
        public static int LengthOfLastWord(string s)
        {
            int wcount = 0;
            string[] str = s.Split(' ');

            int count = str.Length;
            for (int i = 0; i <= count; i++)

            {

                if (i == count - 1)
                {

                    for (int j = 0; j < str[i].Length; j++)

                    {

                        wcount++;

                    }

                }

            }
            return wcount;
        }
        static void Main(string[] args)
        {
            // string s = "fly me   to   the moon";
            //string s = "Hello World";
            string s = "luffy is still joyboy";
            int count=LengthOfLastWord(s);
            Console.WriteLine(count);
            Console.ReadLine();
           // Console.WriteLine("Hello, World!");
        }
    }
}