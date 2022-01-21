using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lec17_2
{
    public partial class Form1 : Form
    {
        List<Point> ListPoint = new List<Point>();
        //컬렉션 --> List,  Point 구조체: xy좌표 저장,List에 대해 MSDN 볼것
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            if(ListPoint.Count ==3)
            {
                e.Graphics.DrawLine(Pens.Black, ListPoint[0], ListPoint[1]);
                e.Graphics.DrawLine(Pens.Black, ListPoint[1], ListPoint[2]);
                e.Graphics.DrawLine(Pens.Black, ListPoint[2], ListPoint[0]);
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            Point pt = new Point(e.X, e.Y);
            if (ListPoint.Count == 3)
            {
                ListPoint.Clear();
            }
            ListPoint.Add(pt);
            Invalidate();
        }
    }
}
