using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace lec9_3
{
    internal class Program
    {
        class A
        {
            ArrayList List = new ArrayList(); //private
            public string this[int index]
            {
                get
                {
                    if (index >= 0 && index < List.Count)
                        return (string)List[index];
                    else
                        return null;
                }
                set
                {
                    if (index >= 0 && index < List.Count)
                        List[index] = value;
                    else if (index == List.Count)
                        List.Add(value);
                }
            }
            public void print()
            {
                foreach (string m in List)
                    Console.WriteLine(m);
            }
        }
        static void Main(string[] args)
        {
            A test = new A();
            test[0] = "A";
            test[1] = "B";
            test[2] = "C";
            test[3] = "D";

            test.print();
            test[1] = "바보";
            test.print();


        }
    }
}
