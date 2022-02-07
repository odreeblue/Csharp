using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @override
{
    internal class Program
    {
        static public int sum(int v1, int v2)
        {
            return v1 + v2;
        }
        static public float sum(float v1, float v2)
        {
            return v1 + v2;
        }
        static void Main(string[] args)
        {
            int num1 = 1;
            int num2 = 2;
            float num3 = 3f;
            float num4 = 4f;

            
     
            int num5 = sum(num1, num2);
            Console.WriteLine(num5.GetType().Name);
            float num6 = sum(num1, num2);
            Console.WriteLine(num6.GetType().Name);
        }
    }
}
