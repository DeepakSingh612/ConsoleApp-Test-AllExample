namespace Delegates
{
    internal class Program
    {
        delegate void Printer();
        static void Main(string[] args)
        {
            List<Printer> printers = new List<Printer>();
            for (int i = 0; i < 5; i++)
            {
                printers.Add(delegate { Console.WriteLine(i); });
            }

            foreach (Printer printer in printers)
            {
                printer();
            }
            Console.ReadLine();
            //  Console.WriteLine("Hello, World!");
        }
    }
}