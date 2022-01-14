using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;



namespace lec6_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /////// 파일 쓰기 /////////
            ///////           /////////
            

            //// 1. 첫번째 방법
            //FileStream fs = new FileStream("test.txt",FileMode.Create);
            //StreamWriter sw = new StreamWriter(fs);
            //sw.Close();

            //// 2. 두번째 방법
            // 위의 내용이랑 똑같은 것은
            //using (StreamWriter sw = new StreamWriter(new FileStream("test.txt", FileMode.Create)))
            //{
            //    //파일 입출력 처리
            //}


            int value = 12;
            float value2 = 3.14f;
            string str1 = "Hello World!";

            /// 1.1 첫번째 방법 예시
            //FileStream fs = new FileStream("test.txt", FileMode.Create);
            //StreamWriter sw = new StreamWriter(fs);
            //sw.WriteLine(value);
            //sw.WriteLine(value2);
            //sw.WriteLine(str1);
            //sw.Close();

            /// 2.1 두번째 방법 예시
            using (StreamWriter sw = new StreamWriter(new FileStream("test.txt", FileMode.Create)))
            {
                sw.WriteLine(value);
                sw.WriteLine(value2);
                sw.WriteLine(str1);
            }


        }
    }
}
