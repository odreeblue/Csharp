﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace sql
{
    public partial class Form1 : Form
    {
        SqlConnection Conn = null;
        public Form1()
        {
            InitializeComponent();
        }
        
        // 서버연결
        private void button1_Click(object sender, EventArgs e)
        {
            String ConnectionString;
            ConnectionString = "server=.\\XINNOS;" + 
                                "database=" + textBox6.Text +";"+
                                "user id=" + textBox7.Text + ";" + 
                                "pwd=" + textBox8.Text+";";
            if (Conn != null)
                Conn.Dispose();
            Conn = new SqlConnection(ConnectionString);
            if (Conn != null)
            {
                textBox5.Text = "연결";
            }
            else
            {
                textBox5.Text = "해제";
            }
        }
        // 데이터베이스 연결

        private void button2_Click(object sender, EventArgs e)
        {
            Conn.Open();
            if(Conn.State == ConnectionState.Open)
            {
                MessageBox.Show("데이터베이스 열었습니다");
            }
            else
            {
                MessageBox.Show("데이터베이스 Open 에러");
            }
        }
        // 닫기
        private void button3_Click(object sender, EventArgs e)
        {
            Conn.Close();
            if (Conn.State == ConnectionState.Closed)
            {
                MessageBox.Show("데이터베이스를 닫았습니다.");
            }
            else
            {
                MessageBox.Show("데이터베이스 Closed 에러");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Conn.Dispose();
            Conn = null;
            textBox1.Text = "해제";
            MessageBox.Show("서버 연결 해제");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox5.Text = "해제";
        }
    }
}
