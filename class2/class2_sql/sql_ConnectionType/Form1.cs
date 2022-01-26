using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace sql_ConnectionType
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Run_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "server=.\\SQLEXPRESS;database=school;uid=sa;password=1234;";
            conn.Open();
            SqlCommand Comm = new SqlCommand(txtbox_SqlInput.Text, conn);
            Comm.ExecuteNonQuery();
            Comm.CommandText = "SELECT * FROM tblStudent";
            SqlDataReader Reader = Comm.ExecuteReader();
            listview_SqlOutput.Clear();
            string strRecord;
            while(Reader.Read())
            {
                strRecord = string.Format("이름: {0} 나이: {1} 성별: {2}", Reader["Name"], Reader["Age"], Reader["Male"]);
                listview_SqlOutput.Items.Add(strRecord);
            }
            Reader.Close();
            conn.Close();
        }

        private void listview_SqlOutput_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
