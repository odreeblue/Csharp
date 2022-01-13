using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lec3_2_1_DataType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var value1 = 3.14f;
            float value2 = 10.0f;
            float sum = value1 + value2;
            Console.WriteLine("{0} {1:f1} {2}", value1, value2, sum);
        }
    }
}
