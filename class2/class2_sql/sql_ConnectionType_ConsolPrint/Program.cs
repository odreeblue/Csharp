using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace sql_ConnectionType_ConsolPrint
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SqlConnection Conn = new SqlConnection();
            Conn.ConnectionString = "server=.\\SQLEXPRESS;database=school;" +
                                    "uid=sa; pwd=1234;";
            Conn.Open();

            String strSQL1 = "INSERT INTO tblStudent VALUES('이민우',25,1)";
            String strSQL2 = "INSERT INTO tblStudent VALUES('김지우',41,0)";

            SqlCommand Command = new SqlCommand(strSQL1, Conn);
            Command.CommandText = strSQL2;
            int LN = Command.ExecuteNonQuery();
            Console.WriteLine(LN);

            //int LN2 = Command.ExecuteNonQuery();
            //Console.WriteLine(LN2);
            Command.CommandText = "SELECT * FROM tblStudent";

            SqlDataReader Reader = Command.ExecuteReader();
            while(Reader.Read())
            {
                Console.WriteLine("{0} {1} {2}", Reader["Name"], Reader[1], Reader["Male"]);
            }
            Reader.Close();
            Conn.Close();   
        }
    }
}
