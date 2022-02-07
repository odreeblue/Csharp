using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace sql_nonconnectiontype_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1단계 DataTable과 DataColumn 만들기
            DataTable table1 = new DataTable("table1");
            DataColumn col1 = new DataColumn("Name",typeof(string));
            table1.Columns.Add(col1);
            col1 = new DataColumn("Age", typeof(int));
            table1.Columns.Add(col1);
            col1 = new DataColumn("Male", typeof(bool));
            table1.Columns.Add(col1);

            //2단계 행 생성 및 입력
            DataRow row = table1.NewRow();
            row["Name"] = "철수";
            row["Age"] = 12;
            row["Male"] = true;
            table1.Rows.Add(row);

            row = table1.NewRow();
            row["Name"] = "수지";
            row["Age"] = 11;
            row["Male"] = false;
            table1.Rows.Add(row);

            row = table1.NewRow();
            row["Name"] = "태성";
            row["Age"] = 9;
            row["Male"] = true;
            table1.Rows.Add(row);

            table1.AcceptChanges(); //해도되고 안해도됨

            DataRow[] SelectedRow = table1.Select("Age>=10");
            if (SelectedRow.Length > 0)//Age가 10보다 큰 행이 있다
            {
                foreach(DataRow PrintRow in SelectedRow)
                {
                    string str;
                    if (PrintRow["Male"].ToString() == "True")
                    {
                        str = "남자";
                    }
                    else
                    {
                        str = "여자";
                    }
                    Console.WriteLine("이름: {0}, 나이: {1:d2}, 성별:{2}", PrintRow["Name"], PrintRow["Age"], str);
                }
                
            }
            // DataTable.Row.Find()라는 것이 있는데 이건 나중에 실습해보자

        }
    }
}
