using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lec11_2
{
    /// <summary>
    ///  멀티캐스트 델리게이트
    /// </summary>
    delegate void DelegateType();
    class A
    {
        public void PrintA()
        {
            Console.WriteLine("Print A");
        }
        public void PrintB()
        {
            Console.WriteLine("Print B");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            A test = new A();
            DelegateType DelFunc = test.PrintA;
            DelFunc += test.PrintB;
            DelFunc();

            DelFunc -= test.PrintA;
            DelFunc();


        }
    }
}
