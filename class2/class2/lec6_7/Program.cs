﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;


namespace lec6_7
{
    [Serializable] //직렬화
    struct DATA
    {
        public int var1;
        public float var2;
        [NonSerialized] //역직렬화
        public string str1;
    }

    internal class Program
    {
        /// <summary>
        /// 직렬화, 비직렬화
        /// </summary>
        /// <param name="args"></param>
        ///

        static void Main(string[] args)
        {
            DATA[] Data = new DATA[2];
            Data[0].var1 = 1;
            Data[0].var2 = 0.5f;
            Data[0].str1 = "Test1";
            Data[1].var1 = 2;
            Data[1].var2 = 1.5f;
            Data[1].str1 = "Test2";
            //Serialize 직렬화
            using (FileStream fs1 = new FileStream("test.dat", FileMode.Create))
            {
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs1, Data);
            }
            //Deserialize 비직렬화
            DATA[] ResultData;
            using (FileStream fs2 = new FileStream("test.dat", FileMode.Open))
            {
                BinaryFormatter bf2 = new BinaryFormatter();
                ResultData = (DATA[])bf2.Deserialize(fs2);
            }
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("{0} {1} {2}",ResultData[i].var1,
                        ResultData[i].var2, ResultData[i].str1);
            }
        }
    }
}
