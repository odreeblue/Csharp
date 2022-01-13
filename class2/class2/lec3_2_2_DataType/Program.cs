using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lec3_2_2_DataType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 123;
            object o = i;
            i = 456;
            Console.WriteLine("{0} {1}", i, (int)o);
            //int i = 123;
            //int j = i;
            //i = 933;
            //Console.WriteLine("{0} {1}", j, i);
        }
    }
}
