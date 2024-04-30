//sing Newtonsoft.Json;
using System.Text.Json;
namespace CountAge
{
    internal class Program
    {
        public class cls
        {
            public string? key { get; set; }
            public int? age { get; set; }
        }
        static void Main(string[] args)
        {

           string str = "{'data':'key=IAfpK, age=58, key=WNVdi, age=64'}";

           //cls cl= JsonSerializer.Deserialize<cls>(str);
           var data1=new Dictionary<string, string>() { 
              
           };

            //string[] st=str.Split(',').ToString();
            Console.WriteLine("Hello, World!");

        }
    }
}