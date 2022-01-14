using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lec5_3_2_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nArray1 = { 1, 2, 3, 4, 5 };
            Array.Clear(nArray1, 2, 3); //array, 초기화시작index, 초기화할요소개수
            foreach (int m in nArray1)
            {
                Console.Write(m);
            }
            Console.WriteLine();
            Array.Clear(nArray1, 0,nArray1.Length);
            foreach (int m in nArray1)
            {
                Console.Write(m);

            }
            Console.WriteLine();
        }
    }
}
