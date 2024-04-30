namespace PropWithInterface
{    
  public  interface Iproduct
    {
        string Name { get; set; }
        void GetValue(string name);
    }
   public class Product : Iproduct
    {
        //private string name;
        //public string Name
        //{
        //    get { return name; }
        //    set { name = value; OnPropertyChanged("Name"); }
        //}
        string _Name;
        string Iproduct.Name { get => _Name; set =>_Name=value; }
        
        public Product(string Name) { 
        _Name = Name;
        
        }

        public void GetValue(string name)
        {
            throw new NotImplementedException();
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            string Name = "Deep";
            // Product product =

            Iproduct iproduct = new Product(Name);
            Console.WriteLine(iproduct.Name);
            Console.ReadLine();
        }
    }
}
