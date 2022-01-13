using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// 3-1 클래스의 정적변수 bool형의 기본 값과 지역 bool 변수 값을 출력해보자
namespace lec3_1_DataType
{
    internal class Program
    {
        static bool BoolVar; // 클래스 안의 멤버 변수를 사용하려면 static으로 선언해야함
        //bool BoolVar;
        static void Main(string[] args)
        {
            bool LocalBoolVar = true;
            Console.WriteLine("{0} {1}",BoolVar, LocalBoolVar);

        } 
    }
}
