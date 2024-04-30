namespace Singleton
{
    public sealed class Singleton
    {
        private static Singleton singleton = null;
        private static readonly object singletonLock = new object();

        Singleton() { }

        public static Singleton SingleInstance
        {
            get
            {
                lock (singletonLock)
                {
                    if (singleton == null)
                    {
                        singleton = new Singleton();
                    }
                    return singleton;
                }
            }
        }
        public static void StaticAddMethod()
        {
            Console.WriteLine("Add Method");
        }
        public void AddMethod1()
        {
           Console.WriteLine("Another Add Method");
        }
        public void AddMethod()
        {
            Console.WriteLine("Add Method");
        }

    }
    internal class Program
    {
    static void Main(string[] args)
    {
            Singleton.SingleInstance.AddMethod();
            Singleton.SingleInstance.AddMethod();
            Singleton.SingleInstance.AddMethod1();
            Console.ReadLine();
           //Console.WriteLine("Hello, World!");
    }
    }
}
