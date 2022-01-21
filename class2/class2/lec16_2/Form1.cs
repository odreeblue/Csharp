using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lec16_2
{
    public partial class Form1 : Form
    {
        string strMessage;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            strMessage += e.KeyChar;//계속해서 문자열 붙임
            Invalidate();//-->이걸 호출하면 WM_Paint라는 메세지가 발생함
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawString(strMessage, Font, Brushes.Black, 10, 10);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
