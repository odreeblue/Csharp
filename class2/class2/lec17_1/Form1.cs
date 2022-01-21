using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lec17_1
{
    public partial class Form1 : Form
    {
        string strMousePos;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Click");
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Mouse Click");
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            MessageBox.Show("버튼 눌렸네");
        }

        ///마우스좌표출력
        ///

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            strMousePos = "X: " + e.X + "  Y: " + e.Y;
            Invalidate(); //--> wp_Paint 메세지 전달 --<Form1_Paint 호출
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawString(strMousePos, Font, Brushes.Black, 10, 10);
        }
    }
}
