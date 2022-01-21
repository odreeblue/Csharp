using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lec13_1
{
    interface IA
    {
        void PrintA();
    }

    interface IB
    {
        void PrintB();
    }

    class C : IA,IB
    {
        public void PrintA()
        {
            Console.WriteLine("InterFace A");
        }
        public void PrintB()
        {
            Console.WriteLine("InterFace B");
        }
    }
    internal class Program
    {/// <summary>
    /// 인터페이스 : 다중상속 가능
    /// 형식 
    /// interface I
    /// { ... }
    /// </summary>
    /// <param name="args"></param>
    ///
        static void Main(string[] args)
        {
            C test = new C();
            test.PrintA();
            test.PrintB();
        }
    }
}
