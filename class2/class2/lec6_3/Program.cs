using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lec6_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //// 3과목을 문자열로 저장하고 공백을 기준으로 
            ///해당 값을 읽어 총점과 평균을 계산하는 프로그램

            string str = "국어: 90 영어: 100 수학: 70";
            string[] str_Element = str.Split(new char[] {' '});
            // str_Element == {"국어:", "90", "영어:", "100", "수학:", "70"}
            int kor = int.Parse(str_Element[1]);
            int eng = int.Parse(str_Element[3]);
            int math = int.Parse(str_Element[5]);
            int total = kor + eng + math;
            float average = total / 3.0f;
            Console.WriteLine("{1} {2} {3} {4:f1}",kor,eng,math,total,Math.Round(average));

        }
    }
}
