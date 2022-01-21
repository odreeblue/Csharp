using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lec12_5
{
    /// <summary>
    /// 오버로드
    /// </summary>
    /// 
    class A
    {
        public void Print() { Console.WriteLine("Hi!!"); }
        //public void Print() { Console.WriteLine("Hi~@#"); } --> 매개변수가 같으면 안됨
        public void Print(int num)
        {
            Console.WriteLine(num);
        }
        public float Print(int num, float pi)
        {
            Console.WriteLine("{0} {1}", num, pi);
            return pi;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            A test = new A();
            test.Print();
            test.Print(100);

            float pi = test.Print(3, 3.14f);
            Console.WriteLine(pi);
        }
    }
}
