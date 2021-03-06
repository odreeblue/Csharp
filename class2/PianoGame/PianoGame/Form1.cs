using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;//추가

namespace PianoGame
{
    
    public partial class Form1 : Form
    {
        

        Rectangle[] rectangle;
        int[] X;
        int[] Y;
        int[][] airplane;
        int nCount;
        public Form1() // 생성자
        {
            nCount = 0;
            InitializeComponent();
            rectangle = new Rectangle[40];
            X = new int[] {12,12,12,12,12,
                            87,87,87,87,87,
                            162,162,162,162,162,
                            237,237,237,237,237,
                            312,312,312,312,312,
                            387,387,387,387,387,
                            462,462,462,462,462,
                            537,537,537,537,537};
            Y = new int[] {110,185,260,335,410,
                            110,185,260,335,410,
                            110,185,260,335,410,
                            110,185,260,335,410,
                            110,185,260,335,410,
                            110,185,260,335,410,
                            110,185,260,335,410,
                            110,185,260,335,410};
            for (int i=0; i<40; i++)
            {
                rectangle[i].X = X[i];
                rectangle[i].Y = Y[i];
                rectangle[i].Width = 68;
                rectangle[i].Height = 75;
            }

            airplane = new int[33][];
            airplane[0] = new int[] { 10 };
            airplane[1] = new int[] { 5, 11 };
            airplane[2] = new int[] { 0, 6, 12 };
            airplane[3] = new int[] { 1, 5, 7, 13 };
            airplane[4] = new int[] { 2, 6, 8, 10, 14 };
            airplane[5] = new int[] { 3, 7, 9, 10, 11 };
            airplane[6] = new int[] { 4, 8, 10, 11, 12 };
            airplane[7] = new int[] { 9, 11, 12, 13 };
            airplane[8] = new int[] { 5, 12, 13, 14 };
            airplane[9] = new int[] { 5, 6, 13, 14 };
            airplane[10] = new int[] { 5, 6, 7, 14 };
            airplane[11] = new int[] { 6, 7, 8 };
            airplane[12] = new int[] { 7, 8, 9, 10 };
            airplane[13] = new int[] { 8, 9, 11, 20 };
            airplane[14] = new int[] { 9, 12, 20, 21 };
            airplane[15] = new int[] { 13, 21, 22 };
            airplane[16] = new int[] { 10, 14, 22, 23 };
            airplane[17] = new int[] { 5, 11, 23, 24 };
            airplane[18] = new int[] { 0, 6, 12, 24 };
            airplane[19] = new int[] { 5, 1, 7, 13 };
            airplane[20] = new int[] { 2, 6, 8, 10, 14 };
            airplane[21] = new int[] { 3, 7, 9, 10, 11 };
            airplane[22] = new int[] { 4, 8, 10, 11, 12 };
            airplane[23] = new int[] { 5, 11, 12, 13, 9 };
            airplane[24] = new int[] { 5, 6, 12, 13, 14 };
            airplane[25] = new int[] { 6, 7, 10, 13, 14 };
            airplane[26] = new int[] { 7, 8, 11, 14 };
            airplane[27] = new int[] { 5, 8, 9, 12 };
            airplane[28] = new int[] { 0, 6, 13, 9 };
            airplane[29] = new int[] { 1, 7, 14 };
            airplane[30] = new int[] { 2, 8 };
            airplane[31] = new int[] { 3, 9 };
            airplane[32] = new int[] { 4 };


        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.A:
                    button1_Click(sender, e);
                    break;
                case Keys.S:
                    button2_Click(sender, e);
                    break;
                case Keys.D:
                    button3_Click(sender, e);
                    break;
                case Keys.F:
                    button4_Click(sender, e);
                    break;
                case Keys.G:
                    button5_Click(sender, e);
                    break;
                case Keys.H:
                    button6_Click(sender, e);
                    break;
                case Keys.J:
                    button7_Click(sender, e);
                    break;
                case Keys.K:
                    button8_Click(sender, e);
                    break;
            }
        }
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.A:
                    button1.BackColor = Color.White;
                    break;
                case Keys.S:
                    button2.BackColor = Color.White;
                    break;
                case Keys.D:
                    button3.BackColor = Color.White;
                    break;
                case Keys.F:
                    button4.BackColor = Color.White;
                    break;
                case Keys.G:
                    button5.BackColor = Color.White;
                    break;
                case Keys.H:
                    button6.BackColor = Color.White;
                    break;
                case Keys.J:
                    button7.BackColor = Color.White;
                    break;
                case Keys.K:
                    button8.BackColor = Color.White;
                    break;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.Red;
            //SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\XINNOS_IAS_CYKIM\Downloads\sound_files\25.wav");
            //simpleSound.Play();
            SoundPlayer simpleSound = new SoundPlayer(Properties.Resources._25);
            simpleSound.Play();
            simpleSound.Dispose();
            int x= 46;
            int y1 = 372, y2 = 447;
            
        }
        private void button2_Click(object sender, EventArgs e)
        {
            //SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\XINNOS_IAS_CYKIM\Downloads\sound_files\26.wav");
            //simpleSound.Play();
            button2.BackColor = Color.Red;
            SoundPlayer simpleSound = new SoundPlayer(Properties.Resources._26);
            simpleSound.Play();
            simpleSound.Dispose();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            button3.BackColor = Color.Red;
            SoundPlayer simpleSound = new SoundPlayer(Properties.Resources._27);
            simpleSound.Play();
            simpleSound.Dispose();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            button4.BackColor = Color.Red;
            SoundPlayer simpleSound = new SoundPlayer(Properties.Resources._28);
            simpleSound.Play();
            simpleSound.Dispose();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            button5.BackColor = Color.Red;
            SoundPlayer simpleSound = new SoundPlayer(Properties.Resources._29);
            simpleSound.Play();
            simpleSound.Dispose();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            button6.BackColor = Color.Red;
            SoundPlayer simpleSound = new SoundPlayer(Properties.Resources._30);
            simpleSound.Play(); 
            simpleSound.Dispose();
        }
        private void button7_Click(object sender, EventArgs e)
        {
            button7.BackColor = Color.Red;
            SoundPlayer simpleSound = new SoundPlayer(Properties.Resources._31);
            simpleSound.Play();
            simpleSound.Dispose();
        }
        private void button8_Click(object sender, EventArgs e)
        {
            button8.BackColor = Color.Red;
            SoundPlayer simpleSound = new SoundPlayer(Properties.Resources._32);
            simpleSound.Play();
            simpleSound.Dispose();

        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            ////도 세로 라인
            //e.Graphics.DrawLine(Pens.Black, 12, 110, 12, 485);
            //e.Graphics.DrawLine(Pens.Black, 80, 110, 80, 485);
            ////도 가로 라인
            //e.Graphics.DrawLine(Pens.Black, 12, 110, 80, 110);

            ////레 세로 라인
            //e.Graphics.DrawLine(Pens.Black, 12 + 75, 110, 12 + 75, 485);
            //e.Graphics.DrawLine(Pens.Black, 80 + 75, 110, 80 + 75, 485);
            ////레 가로 라인
            //e.Graphics.DrawLine(Pens.Black, 12 + 75, 110, 80 + 75, 110);

            ////미 세로 라인
            //e.Graphics.DrawLine(Pens.Black, 12 + 75 * 2, 110, 12 + 75 * 2, 485);
            //e.Graphics.DrawLine(Pens.Black, 80 + 75 * 2, 110, 80 + 75 * 2, 485);
            ////미 가로 라인
            //e.Graphics.DrawLine(Pens.Black, 12 + 75 * 2, 110, 80 + 75 * 2, 110);

            ////파세로 라인
            //e.Graphics.DrawLine(Pens.Black, 12 + 75 * 3, 110, 12 + 75 * 3, 485);
            //e.Graphics.DrawLine(Pens.Black, 80 + 75 * 3, 110, 80 + 75 * 3, 485);
            ////파 가로 라인
            //e.Graphics.DrawLine(Pens.Black, 12 + 75 * 3, 110, 80 + 75 * 3, 110);

            ////솔세로 라인
            //e.Graphics.DrawLine(Pens.Black, 12 + 75 * 4, 110, 12 + 75 * 4, 485);
            //e.Graphics.DrawLine(Pens.Black, 80 + 75 * 4, 110, 80 + 75 * 4, 485);
            ////솔 가로 라인
            //e.Graphics.DrawLine(Pens.Black, 12 + 75 * 4, 110, 80 + 75 * 4, 110);

            ////라세로 라인
            //e.Graphics.DrawLine(Pens.Black, 12 + 75 * 5, 110, 12 + 75 * 5, 485);
            //e.Graphics.DrawLine(Pens.Black, 80 + 75 * 5, 110, 80 + 75 * 5, 485);
            ////라 가로 라인
            //e.Graphics.DrawLine(Pens.Black, 12 + 75 * 5, 110, 80 + 75 * 5, 110);

            ////시세로 라인
            //e.Graphics.DrawLine(Pens.Black, 12 + 75 * 6, 110, 12 + 75 * 6, 485);
            //e.Graphics.DrawLine(Pens.Black, 80 + 75 * 6, 110, 80 + 75 * 6, 485);
            ////시 가로 라인
            //e.Graphics.DrawLine(Pens.Black, 12 + 75 * 6, 110, 80 + 75 * 6, 110);

            ////도세로 라인
            //e.Graphics.DrawLine(Pens.Black, 12 + 75 * 7, 110, 12 + 75 * 7, 485);
            //e.Graphics.DrawLine(Pens.Black, 80 + 75 * 7, 110, 80 + 75 * 7, 485);
            ////도 가로 라인
            //e.Graphics.DrawLine(Pens.Black, 12 + 75 * 7, 110, 80 + 75 * 7, 110);


            // Test
            //SolidBrush blackBrush = new SolidBrush(Color.Black);
            //e.Graphics.FillRectangle(blackBrush, 162,110,68,75);
        }

        
        // Start button
        private void button9_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        //Stop button
        private void button10_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            SolidBrush blackBrush = new SolidBrush(Color.Black);
            SolidBrush whiteBrush = new SolidBrush(Color.White);
            Graphics g = CreateGraphics();
            if (nCount == 0)
            {
                Rectangle[] rect = new Rectangle[airplane[nCount].Length];
                for (int i = 0; i < airplane[nCount].Length; i++)
                {
                    rect[i] = rectangle[airplane[nCount][i]];
                    //g.FillRectangle(blackBrush, rectangle[i]);
                }
                for (int i = 0; i < rect.Length; i++)
                {
                    g.FillRectangle(blackBrush, rect[i]);
                }
                nCount++;
            }
            else
            {
                Rectangle[] rect2 = new Rectangle[airplane[nCount-1].Length];
                for (int i = 0; i < airplane[nCount - 1].Length; i++)
                {
                    rect2[i] = rectangle[airplane[nCount - 1][i]];
                    //g.FillRectangle(blackBrush, rectangle[i]);
                }
                for (int i = 0; i < rect2.Length; i++)
                {
                    g.FillRectangle(whiteBrush, rect2[i]);
                }
                Rectangle[] rect3 = new Rectangle[airplane[nCount].Length];
                for (int i = 0; i < airplane[nCount].Length; i++)
                {
                    rect3[i] = rectangle[airplane[nCount][i]];
                    //g.FillRectangle(blackBrush, rectangle[i]);
                }
                for (int i = 0; i < rect3.Length; i++)
                {
                    g.FillRectangle(blackBrush, rect3[i]);
                }
                nCount++;
            }
            
            if (nCount > 32)
            {
                timer1.Stop();
            }

        }
            
            //SolidBrush blackBrush = new SolidBrush(Color.Black);
            //Rectangle rect = new Rectangle(12, 110, 68, 75);
            //e.Graphics.FillRectangle(blueBrush,rect);
            //Graphics g = CreateGraphics();
            //SolidBrush blackBrush = new SolidBrush(Color.Black);   
        
    }
}
