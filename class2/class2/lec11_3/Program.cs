using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lec11_3
{
    /// <summary>
    /// 이벤트
    /// </summary>
    delegate void DelegateType(string Message); //delegate 반환형 delegatetype:freename (string Message)
    class A // *이벤트 핸들러는 정적(static) 클래스에 선언될 수 없음
    {       // *따라서 메인 메서드에서 A.EventHandler-> 이런식으로는 사용될 수 없음 
        public event DelegateType EventHandler;
        public void Func(string Message)
        {
            EventHandler(Message);
        }
    }
    class B
    {
        public void PrintA(string Message)
        {
            Console.WriteLine("(1) {0}",Message);
        }
        public void PrintB(string Message)
        {
            Console.WriteLine("(2) {0}", Message);
        }
    }
    class C
    {
        public void PrintC(string Message)
        {
            Console.WriteLine("(3) {0}", Message);
        }
        public void PrintD(string Message)
        {
            Console.WriteLine("(4) {0}", Message);
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            A test1 = new A();
            B test2 = new B();
            C test3 = new C();
            test1.EventHandler += new DelegateType(test2.PrintB);
            test1.EventHandler += new DelegateType(test2.PrintA); // 이거 순서에 따라서 출력 순서가 달라짐
            test1.Func("good!!!");
            test1.EventHandler -= test2.PrintB;
            test1.Func("Hi~~");
            test1.EventHandler -= test2.PrintA;

            test1.EventHandler += test2.PrintA; //처리기에 추가 
            test1.EventHandler += test2.PrintB;
            test1.Func("Hello world!!");

            // 다른 클래스의 객체(test3)에서도 함수를 호출할 수있는지?

            test1.EventHandler += test3.PrintC;
            test1.EventHandler += test3.PrintD;
            test1.Func("WOW");


        }
    }
}
