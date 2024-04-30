namespace FindCommanPrefix
{
    internal class Program
    {
        static String longestCommonPrefix(String[] arr)
        {
            
            if (arr == null || arr.Length == 0)
            {
               
                return "";
            }
 
            Array.Sort(arr);

            string prefix = "";
          
            for (int i = 0; i < arr[0].Length; i++)
            {
                
                bool match = true;
                for (int j = 1; j < arr.Length; j++)
                {
                    if (arr[j].Length <= i || arr[j][i] != arr[0][i])
                    {
                        match = false;
                        break;
                    }
                }

                if (match)
                {
                    prefix += arr[0][i];
                }
                else
                {
                    break;
                }
            }

            return (prefix);
        }
        static void Main(string[] args)
        {
            String[] arr = { "geeksforgeeks", "ks", "geek",
                         "geezer" };
           
            Console.WriteLine("The longest common prefix is: "
                              + longestCommonPrefix(arr));
            Console.ReadLine();
        }
    }
    }
