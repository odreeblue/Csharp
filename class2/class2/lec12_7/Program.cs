 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lec12_7
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
    //class C: B
    //{
    //    public 
    //}
    internal class Program
    {
        static void Main(string[] args)
        {
            A test1 = new B();
            test1.Print();

            // -------cast 형을 이용한 참조
            B test2 = new B();
            A test3 = (A)test2;
            test3.Print();
            // 주소값 출력
            int num = 10;
            unsafe
            {
                int* p = &num;
                Console.WriteLine("number의 값: {0}, 포인터의 값:{1} ",num, *p);//잘되는건지 모르겠음
            }

        }
    }
}
