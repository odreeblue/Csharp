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

namespace sql_nonconnectiontype_4
{
    public partial class Form1 : Form
    {
        SqlConnection Conn;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlDataAdapter DataAdapter1 = new SqlDataAdapter("SELECT * FROM tblStudent", Conn);
            DataSet dataSet1 = new DataSet();
            DataAdapter1.Fill(dataSet1, "tblStudent");
            dataGridView1.DataSource = dataSet1.Tables[0];
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Conn = new SqlConnection();
            Conn.ConnectionString = "server=.\\SQLEXPRESS;" +
                                    "database=school;" +
                                    "uid=sa;" +
                                    "pwd=1234;";
        }
    }
}
