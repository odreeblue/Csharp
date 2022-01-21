using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lec12_3
{
    class A
    {
        int number;
        protected string name = "Hello";
        public A(int num)
        {
            number = num;
        }
        public void PrintA()
        {
            Console.WriteLine(number);
        }
    }
    class B:A
    {
        string name = "world";
        public B(int num) : base(num) // B(int num)의 값이 --> base(num)--> class A의 생성자 매개변수로 들어감
        {

        }
        public void PrintB()
        {
            Console.WriteLine("{0}  {1}", base.name, name);
        }
    }
    // 만약에 class C 가 추가되어서 상속을 두번한다면? ==> 나중에 해결
    //class C : B
    //{
    //    string n
    //}
    internal class Program
    {
        static void Main(string[] args)
        {
            B test = new B(3);
            test.PrintA();
            test.PrintB();
        }
    }
}
