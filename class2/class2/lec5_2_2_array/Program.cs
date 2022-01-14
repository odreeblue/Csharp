using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lec5_2_2_array
{
    internal class Program
    {
        static void TransArray(string[] arr)
        {
            string[] HangulDays = { "일", "월", "화", "수", "목", "금", "토" };
            for (int i=0; i<arr.Length;i++)
            {
                arr[i] = HangulDays[i];
            }
        }
        static void Main(string[] args)
        {
            string[] Days = { "sun", "mon", "tue", "wed","thu","fri","sat"};
            TransArray(Days);
            foreach (string str in Days)
            {
                Console.WriteLine(str);
            }
        }
    }
}
