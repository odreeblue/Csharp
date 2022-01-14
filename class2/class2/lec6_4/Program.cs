using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace lec6_4
{
    internal class Program
    {
        /// <summary>
        /// 1. 화면으로부터 학생 수를 입력받고 3과목에 대한 점수를 입력 받은 후에
        ///    test.txt 파일로 저장하는 프로그램을 작성
        /// 2. 작성된 test.txt 파일을 읽어서 화면에 풀력하는 프로그램 작성
        /// </summary>
        
        struct GRADE
        {
            public int kor, eng, math, total;
            public float average;
        }
        static void Main(string[] args)
        {
            //// 1번 문제
            ///
            //string str;
            //Console.Write("성적 처리를 위한 학생 수를 입력해 주세요 :");
            //int nCount = int.Parse(Console.ReadLine());
            //Console.WriteLine("국어 영어 수학 순서로 입력해주세요");

            //GRADE[] Grade = new GRADE[nCount];
            ////GRADE[][] Grade = new GRADE[nCount][]; --> 이것도 가능
            //StreamWriter sw = new StreamWriter("test.txt");
            //sw.WriteLine("학생수: {0}", nCount);
            //for (int i = 0; i < nCount; i++)
            //{
            //    str = Console.ReadLine();
            //    string[] DataString = str.Split(new char[] { ' ' });
            //    Grade[i].kor = int.Parse(DataString[0]);
            //    Grade[i].eng = int.Parse(DataString[1]);
            //    Grade[i].math = int.Parse(DataString[2]);
            //    Grade[i].total = Grade[i].kor + Grade[i].eng + Grade[i].math;
            //    Grade[i].average = Grade[i].total / 3.0f;
            //    Grade[i].average = (float)Math.Round(Grade[i].average);
            //}

            //for (int i = 0; i < nCount; i++)
            //{
            //    sw.WriteLine("{0}, {1}, {2}, {3}, {4:f1}", Grade[i].kor, Grade[i].eng,
            //        Grade[i].math, Grade[i].total, Grade[i].average);
            //}
            //sw.Close();
            ////////////////////

            /// 2번 문제
            /// 

            string str;
            Console.WriteLine("파일 명을 입력해주세요! ");
            string filename = Console.ReadLine();
            StreamReader sr = new StreamReader(filename);
            str = sr.ReadLine(); // 학생수: 5;

            string[] strData1 = str.Split(new char[] { ':' });
            int nCount = int.Parse(strData1[1]);
            Console.WriteLine("------------------------------");
            for (int i = 0; i < nCount; i++)
            {
                str = sr.ReadLine();
                string[] strData2 = str.Split(new char[] { ',' });
                Console.WriteLine("{0} {1} {2} {3} {4}", strData2[0], strData2[1],
                                    strData2[2], strData2[3], strData2[4]);
            }
            Console.WriteLine("------------------------------");
            sr.Close();


            ////시험용
            //string str = "     5";
            //int i = int.Parse(str);
            //Console.WriteLine(i);
        }

    }
}
