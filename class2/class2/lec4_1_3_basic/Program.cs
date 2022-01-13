using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lec4_1_3_basic
{
    class A
    {
        public int x = 2;
    }
    class B
    {
        
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string str1 = "123";
            object obj = str1;
            string str2 = obj as string;
            Console.WriteLine(str2);

            A test1 = new A();
            object obj1 = test1;
            A test2 = obj1 as A;
            if (test2 == null)
            {
                Console.WriteLine("형변환 실패");
            }
            else
            {
                Console.WriteLine("형변환 가능");
            }
            test1.x = 9;
            Console.WriteLine(test2.x);
        }
    }
}
