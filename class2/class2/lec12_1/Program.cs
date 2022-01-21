using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lec12_1
{
    class A
    {
        private int num = new int();
        public int Num
        {
            get => num;
            set => num = value;
        }
        private void PrintPrivate()
        {
            Console.WriteLine("Private");
        }
        protected void PrintProtected()
        {
            Console.WriteLine("Protected");
        }
        public void PrintPublic()
        {
            Console.WriteLine("Public");
        }
    }
    class B:A
    {
        public void Print()
        {
            // PrintPrivate();
            PrintProtected();
            PrintPublic();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            B Test = new B();
            Test.Print();
            Test.Num = 1;
            Console.WriteLine(Test.Num);

            Test.PrintPublic();//--> 이건 되는데,
            //Test.PrintProtected(); --> 이건 안됨
        }
    }
}
