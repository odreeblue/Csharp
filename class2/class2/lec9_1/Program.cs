using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lec9_1
{
    class A
    {
        private int number;
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Number
        {
            get { return number; }
            set
            {
                if (value < 0 || value > 9)
                    number = 0;
                else
                    number = value;
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //속성의 의미와 역할
            A test = new A();
            test.Name = "Microsoft C#";
            test.Number = 9;
            Console.WriteLine("{0} {1}", test.Name, test.Number);
            test.Number = -7;
            Console.WriteLine(test.Number);
        }
    }
}
