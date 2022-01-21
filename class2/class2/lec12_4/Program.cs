using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lec12_4
{
    class A
    {
        public virtual void Print()
        {
            Console.WriteLine("A Print");
        }
    }
    class B : A
    {
        public override void Print()
        {
            Console.WriteLine("B Print");
        }
    }
    class C: B
    {
        public override void Print()
        {
            Console.WriteLine("C Print");
        }
    }
    internal class Program
    {
        
        static void Main(string[] args)
        {
            B test = new B();
            test.Print();
            C test2 = new C();
            test2.Print();
        }
    }
}
