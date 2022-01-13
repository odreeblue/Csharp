using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lec4_1_2_basic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nValue = 10;

            if (nValue is float)
            {
                Console.WriteLine("호환됨");
            }
            else
            {
                Console.WriteLine("호환 안됨");
            }

            if (nValue is object)
            {
                Console.WriteLine("호환됨");
            }
            else
            {
                Console.WriteLine("호환 안됨");
            }

            object obj = nValue;
            //if(obj is float)// 호환안됨
            if(obj is int) // 호환됨
            {
                Console.WriteLine("호환됨");
            }
            else
            {
                Console.WriteLine("호환안됨");
            }

        }
    }
}
