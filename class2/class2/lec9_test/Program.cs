using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lec9_test
{
    internal class Program
    {
        class A 
        {
            private int[] number = new int[3];
            private int number2 = new int();
            //private int number2;
            private int[] number3 = new int[3];

            public int this[int index]
            {
                get => number[index];
                set => number[index] = value;
            }
            public int Number
            {
                get => number2;
                set => number2 = value;
            }
            public int Number3
            {
                get => number3[0];
                set => number3[0] = value;
            }
            //public float this[int index2] --> this를 두번쓰는 것은 안됨
            //{
            //    get { return number2[index2]; }
            //    set { number2[index2] = value; }
            //}
        }
        static void Main(string[] args)
        {
            A test = new A();
            test[0] = 1;
            test.Number = 100;
            test.Number3 = 10;

            Console.WriteLine("{0} {1}",test[0],test[1]);
            Console.WriteLine("{0}",test.Number);
            Console.WriteLine("{0}", test.Number3);
            //int[][] array = new int[][]
            //                {
            //                    new int[3]{1,2,3},
            //                    new int[2]{4,5}
            //                };
            //Console.WriteLine(array[0].Length);
            //Console.WriteLine(array[1].Length);


        }
    }
}
