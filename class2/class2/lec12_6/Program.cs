using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lec12_6
{
    /// <summary>
    /// 추상클래스
    /// </summary>
    /// 
    abstract class A
    {
        int number = 5;
        public abstract void Print();
        public abstract float Print(float num); // 오버로드 : 같은 메서드 매개변수 다르게 여러번
        public void PrintNumber()
        {
            Console.WriteLine(number);
        }
    }
    class B : A
    {
        public override void Print()//오버라이딩 : 재정의
        {
            Console.WriteLine("abstract class");
        }
        public override float Print(float num)
        {
            Console.WriteLine("abstract class2");
            return num;
        }
    }
     
    internal class Program
    {
        static void Main(string[] args)
        {
            B test = new B();
            test.Print();
            test.PrintNumber();
            float num = test.Print(3.14f); //오버로드
            Console.WriteLine(num);
            // A test2 = new A(); --> abstract는 이거 안됨
        }
    }
}
