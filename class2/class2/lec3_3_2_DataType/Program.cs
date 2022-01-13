using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lec3_3_2_DataType
{
    public struct MyStruct
    {
        public const float PI = 3.14f;//const , static 사용해야 초기화 가능함
        public static int Age = 12;
        //public int Mass = 78;
        public int Mass; //--> 이렇게 하려면 선언을 먼저해야함
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("{0}, {1}",MyStruct.PI,MyStruct.Age);

            //MyStruct ss = new MyStruct();
            //ss.Mass = 12;
            //Console.WriteLine("{0}", ss.Mass);
        }
    }
}
