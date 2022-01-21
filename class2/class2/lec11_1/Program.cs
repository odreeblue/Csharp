using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lec11_1
{
    /// <summary>
    /// 델리게이트 이해하기
    /// </summary>
    /// <param name="args"></param>
    delegate void ss(string str);
    class A
    {
        public void print(string str)
        {
            Console.WriteLine(str);
        }
    }
    internal class Program
    {
        
        static void Main(string[] args)
        {
                A test = new A();
                ss dd = new ss(test.print);
                dd("adfnladf");

                ss dd2 = test.print;
                dd2("hello world");
        }
    }
}
