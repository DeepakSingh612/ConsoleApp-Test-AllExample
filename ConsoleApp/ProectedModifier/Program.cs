using System.Security.Cryptography;

namespace AllOOPSConcept
{
   

        class A
        {
            private int c;
            public int z=0;
            protected int x; 
            protected int y;
            protected void Show() { }
            public void Show1() {
                Console.WriteLine("Base class");
            }

        }
        class B :A
        {

            public new void Show1() {
                Console.WriteLine("Drive class");
           
            }


        }
    class C:B
    {
        public  void Show2()
        {
           Console.WriteLine("C class");

        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            A a = new B();
            a.Show1 ();
            A a1 = new A();
        
            B b = new B();
          //  b.Show1();
            Console.ReadLine();
        }
    }
}