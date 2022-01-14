using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;

namespace lec6_8
{
    [Serializable]
    struct Data
    {
        public int data;
        public string str;
        public Data(int data1, string str1) // 생성자
        {
            data = data1;
            str = str1;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Data> ResultList;
            List<Data> DataList = new List<Data>();
            DataList.Add(new Data(7, "test1"));
            DataList.Add(new Data(12, "test2"));

            using (FileStream fs1 = new FileStream("test.dat", FileMode.Create))
            {
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs1, DataList);
            }

            using (FileStream fs2 = new FileStream("test.dat", FileMode.Open))
            {
                BinaryFormatter bf2 = new BinaryFormatter();
                ResultList = (List<Data>)bf2.Deserialize(fs2);

            }
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("{0} {1}", ResultList[i].data, ResultList[i].str);
            }

        }
    }
}
