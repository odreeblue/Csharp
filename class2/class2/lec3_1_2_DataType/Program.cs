using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lec3_1_2_DataType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char Mun = '7'; // 문자상수값 =55
            int Num = Mun; // 암시적 형변환 char --> int
            Num += 1;
            Console.WriteLine("Mun = {0}, 문자상수값 = {1}, 유니코드문자={2}",
                (int)Mun, Num, (char)Num); // 명시적 형변환
            Mun = (char)Num; // 명시적 형변환
            Console.WriteLine(Mun);

        }
    }
}
