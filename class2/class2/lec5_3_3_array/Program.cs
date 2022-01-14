using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lec5_3_3_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nArray1 = { 1, 2, 3, 4 };
            int[] nCloneArray = (int[])nArray1.Clone();//boxing -> unboxing 개념, unboxing할때 캐스팅해야함

            nCloneArray[2] = 30;
            foreach (int m in nArray1)
                Console.Write(m);
            Console.WriteLine();

            foreach (int m in nCloneArray)
                Console.Write(m);
            Console.WriteLine();

            string[] Days = { "일", "월", "화", "수", "목", "금", "토" };
            string[] DaysClone = (string[])Days.Clone();
            Days[0] = "바보";
            foreach (string str in Days)
                Console.Write(str);
            Console.WriteLine();
            foreach (string str in DaysClone)
                Console.Write(str);

        }
    }
}
