using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lec3_3_3_DataType
{
    public struct MyStruct
    {
        public int Age;
        public MyStruct(int InAge) // 생성자
        {
            Age = InAge;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MyStruct testStruct1;
            testStruct1.Age = 12;
            Console.WriteLine(testStruct1.Age);

            MyStruct testStruct2 = new MyStruct(); //생성자
            Console.WriteLine(testStruct2.Age);

            MyStruct testStruct3 = new MyStruct(12);
            Console.WriteLine(testStruct3.Age);
        }
    }
}
