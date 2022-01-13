using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lec_3_3_4_Datatype
{
    //enum Days { Sun = 1, Mon, Tue, Wed, Thu, Fri, Sat };

    internal class Program
    {
        static void Main(string[] args)
        {
            //int nValue = (int)Days.Mon;
            //Days day = Days.Tue;
            //Days day2 = Days.Wed;
            //Console.WriteLine("{0},{1},{2}", nValue, (int)day, day2);

            string[] a = { "1234567","1234"};
            string[] b = a;
            b[0] = "0";
            Console.WriteLine("{0},{1}",a[0],a[1]);
            Console.WriteLine("{0}", "김찬영바보");
        }
    }
}
