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

        int[][] airplane;
        int nCount;
        List<Button> buttons = new List<Button>();
        public Form1() // 생성자
        {
            nCount = 0;
            InitializeComponent();
            
            
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
            buttons.Add(b0);
            buttons.Add(b1);
            buttons.Add(b2);
            buttons.Add(b3);
            buttons.Add(b4);
            buttons.Add(b5);
            buttons.Add(b6);
            buttons.Add(b7);
            buttons.Add(b8);
            buttons.Add(b9);
            buttons.Add(b10);
            buttons.Add(b11);
            buttons.Add(b12);
            buttons.Add(b13);
            buttons.Add(b14);
            buttons.Add(b15);
            buttons.Add(b16);
            buttons.Add(b17);
            buttons.Add(b18);
            buttons.Add(b19);
            buttons.Add(b20);
            buttons.Add(b21);
            buttons.Add(b22);
            buttons.Add(b23);
            buttons.Add(b24);
            buttons.Add(b25);
            buttons.Add(b26);
            buttons.Add(b27);
            buttons.Add(b28);
            buttons.Add(b29);
            buttons.Add(b30);
            buttons.Add(b31);
            buttons.Add(b32);
            buttons.Add(b33);
            buttons.Add(b34);
            buttons.Add(b35);
            buttons.Add(b36);
            buttons.Add(b37);
            buttons.Add(b38);
            buttons.Add(b39);

            //Button[] button = new Button[] {b0,b1,b2,b3,b4,
            //                                b5,b6,b7,b8,b9,
            //                                b10,b11,b12,b13,b14,
            //                                b15,b16,b17,b18,b19,
            //                                b20,b21,b22,b23,b24,
            //                                b25,b26,b27,b28,b29,
            //                                b30,b31,b32,b33,b34,
            //                                b35,b36,b37,b38,b39
            //                                };



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
            if (b3.BackColor == Color.Black)
            {
                int score;
                //int score2;
                score = Convert.ToInt32(textBox1.Text);
                score = score + 1;
                textBox1.Text = Convert.ToString(score);
            }
            else if(b4.BackColor == Color.Black)
            {
                int score;
                //int score2;
                score = Convert.ToInt32(textBox1.Text);
                score = score + 2;
                textBox1.Text = Convert.ToString(score);
            }
            else
            {
                int score;
                //int score2;
                score = Convert.ToInt32(textBox1.Text);
                score = score - 1;
                textBox1.Text = Convert.ToString(score);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            //SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\XINNOS_IAS_CYKIM\Downloads\sound_files\26.wav");
            //simpleSound.Play();
            button2.BackColor = Color.Red;
            SoundPlayer simpleSound = new SoundPlayer(Properties.Resources._26);
            simpleSound.Play();
            simpleSound.Dispose();
            if (b8.BackColor == Color.Black)
            {
                int score;
                //int score2;
                score = Convert.ToInt32(textBox1.Text);
                score = score + 1;
                textBox1.Text = Convert.ToString(score);
            }
            else if (b9.BackColor == Color.Black)
            {
                int score;
                //int score2;
                score = Convert.ToInt32(textBox1.Text);
                score = score + 2;
                textBox1.Text = Convert.ToString(score);
            }
            else
            {
                int score;
                //int score2;
                score = Convert.ToInt32(textBox1.Text);
                score = score - 1;
                textBox1.Text = Convert.ToString(score);
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            button3.BackColor = Color.Red;
            SoundPlayer simpleSound = new SoundPlayer(Properties.Resources._27);
            simpleSound.Play();
            simpleSound.Dispose(); 
            if (b13.BackColor == Color.Black)
            {
                int score;
                //int score2;
                score = Convert.ToInt32(textBox1.Text);
                score = score + 1;
                textBox1.Text = Convert.ToString(score);
            }
            else if (b14.BackColor == Color.Black)
            {
                int score;
                //int score2;
                score = Convert.ToInt32(textBox1.Text);
                score = score + 2;
                textBox1.Text = Convert.ToString(score);
            }
            else
            {
                int score;
                //int score2;
                score = Convert.ToInt32(textBox1.Text);
                score = score - 1;
                textBox1.Text = Convert.ToString(score);
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            button4.BackColor = Color.Red;
            SoundPlayer simpleSound = new SoundPlayer(Properties.Resources._28);
            simpleSound.Play();
            simpleSound.Dispose();
            if (b18.BackColor == Color.Black)
            {
                int score;
                //int score2;
                score = Convert.ToInt32(textBox1.Text);
                score = score + 1;
                textBox1.Text = Convert.ToString(score);
            }
            else if (b19.BackColor == Color.Black)
            {
                int score;
                //int score2;
                score = Convert.ToInt32(textBox1.Text);
                score = score + 2;
                textBox1.Text = Convert.ToString(score);
            }
            else
            {
                int score;
                //int score2;
                score = Convert.ToInt32(textBox1.Text);
                score = score - 1;
                textBox1.Text = Convert.ToString(score);
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            button5.BackColor = Color.Red;
            SoundPlayer simpleSound = new SoundPlayer(Properties.Resources._29);
            simpleSound.Play();
            simpleSound.Dispose();
            if (b23.BackColor == Color.Black)
            {
                int score;
                //int score2;
                score = Convert.ToInt32(textBox1.Text);
                score = score + 1;
                textBox1.Text = Convert.ToString(score);
            }
            else if (b24.BackColor == Color.Black)
            {
                int score;
                //int score2;
                score = Convert.ToInt32(textBox1.Text);
                score = score + 2;
                textBox1.Text = Convert.ToString(score);
            }
            else
            {
                int score;
                //int score2;
                score = Convert.ToInt32(textBox1.Text);
                score = score - 1;
                textBox1.Text = Convert.ToString(score);
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {
            button6.BackColor = Color.Red;
            SoundPlayer simpleSound = new SoundPlayer(Properties.Resources._30);
            simpleSound.Play(); 
            simpleSound.Dispose();
            if (b28.BackColor == Color.Black)
            {
                int score;
                //int score2;
                score = Convert.ToInt32(textBox1.Text);
                score = score + 1;
                textBox1.Text = Convert.ToString(score);
            }
            else if (b29.BackColor == Color.Black)
            {
                int score;
                //int score2;
                score = Convert.ToInt32(textBox1.Text);
                score = score + 2;
                textBox1.Text = Convert.ToString(score);
            }
            else
            {
                int score;
                //int score2;
                score = Convert.ToInt32(textBox1.Text);
                score = score - 1;
                textBox1.Text = Convert.ToString(score);
            }
        }
        private void button7_Click(object sender, EventArgs e)
        {
            button7.BackColor = Color.Red;
            SoundPlayer simpleSound = new SoundPlayer(Properties.Resources._31);
            simpleSound.Play();
            simpleSound.Dispose();
            if (b33.BackColor == Color.Black)
            {
                int score;
                //int score2;
                score = Convert.ToInt32(textBox1.Text);
                score = score + 1;
                textBox1.Text = Convert.ToString(score);
            }
            else if (b34.BackColor == Color.Black)
            {
                int score;
                //int score2;
                score = Convert.ToInt32(textBox1.Text);
                score = score + 2;
                textBox1.Text = Convert.ToString(score);
            }
            else
            {
                int score;
                //int score2;
                score = Convert.ToInt32(textBox1.Text);
                score = score - 1;
                textBox1.Text = Convert.ToString(score);
            }
        }
        private void button8_Click(object sender, EventArgs e)
        {
            button8.BackColor = Color.Red;
            SoundPlayer simpleSound = new SoundPlayer(Properties.Resources._32);
            simpleSound.Play();
            simpleSound.Dispose();
            if (b38.BackColor == Color.Black)
            {
                int score;
                //int score2;
                score = Convert.ToInt32(textBox1.Text);
                score = score + 1;
                textBox1.Text = Convert.ToString(score);
            }
            else if (b39.BackColor == Color.Black)
            {
                int score;
                //int score2;
                score = Convert.ToInt32(textBox1.Text);
                score = score + 2;
                textBox1.Text = Convert.ToString(score);
            }
            else
            {
                int score;
                //int score2;
                score = Convert.ToInt32(textBox1.Text);
                score = score - 1;
                textBox1.Text = Convert.ToString(score);
            }

        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            
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
            
            //SolidBrush blackBrush = new SolidBrush(Color.Black);
            //SolidBrush whiteBrush = new SolidBrush(Color.White);
            //Graphics g = CreateGraphics();
            if (nCount == 0)
            {
                //Rectangle[] rect = new Rectangle[airplane[nCount].Length];
                int[] num = new int[airplane[nCount].Length];
                for (int i = 0; i < airplane[nCount].Length; i++)
                {
                    num[i] = airplane[nCount][i];
                    //g.FillRectangle(blackBrush, rectangle[i]);
                }
                for (int i = 0; i < num.Length; i++)
                {
                    buttons[num[i]].BackColor = Color.Black;
                    //g.FillRectangle(blackBrush, rect[i]);
                }
                nCount++;
            }
            else
            {
                //Rectangle[] rect2 = new Rectangle[airplane[nCount-1].Length];
                int[] num2 = new int[airplane[nCount-1].Length];
                for (int i = 0; i < airplane[nCount - 1].Length; i++)
                {
                    num2[i] = airplane[nCount - 1][i];
                    //g.FillRectangle(blackBrush, rectangle[i]);
                }
                for (int i = 0; i < num2.Length; i++)
                {
                    buttons[num2[i]].BackColor = Color.White;
                    //g.FillRectangle(whiteBrush, rect2[i]);
                }
                //Rectangle[] rect3 = new Rectangle[airplane[nCount].Length];
                int[] num3 = new int[airplane[nCount].Length];
                for (int i = 0; i < airplane[nCount].Length; i++)
                {
                    num3[i] = airplane[nCount][i];
                    //g.FillRectangle(blackBrush, rectangle[i]);
                }
                for (int i = 0; i < num3.Length; i++)
                {
                    buttons[num3[i]].BackColor = Color.Black;
                    //g.FillRectangle(blackBrush, rect3[i]);
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
