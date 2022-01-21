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
        public Form1()
        {
            InitializeComponent();
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
        }
        private void button2_Click(object sender, EventArgs e)
        {
            //SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\XINNOS_IAS_CYKIM\Downloads\sound_files\26.wav");
            //simpleSound.Play();
            button2.BackColor = Color.Red;
            SoundPlayer simpleSound = new SoundPlayer(Properties.Resources._26);
            simpleSound.Play();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            button3.BackColor = Color.Red;
            SoundPlayer simpleSound = new SoundPlayer(Properties.Resources._27);
            simpleSound.Play();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            button4.BackColor = Color.Red;
            SoundPlayer simpleSound = new SoundPlayer(Properties.Resources._28);
            simpleSound.Play();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            button5.BackColor = Color.Red;
            SoundPlayer simpleSound = new SoundPlayer(Properties.Resources._29);
            simpleSound.Play();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            button6.BackColor = Color.Red;
            SoundPlayer simpleSound = new SoundPlayer(Properties.Resources._30);
            simpleSound.Play();
        }
        private void button7_Click(object sender, EventArgs e)
        {
            button7.BackColor = Color.Red;
            SoundPlayer simpleSound = new SoundPlayer(Properties.Resources._31);
            simpleSound.Play();
        }
        private void button8_Click(object sender, EventArgs e)
        {
            button8.BackColor = Color.Red;
            SoundPlayer simpleSound = new SoundPlayer(Properties.Resources._32);
            simpleSound.Play();
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //도 세로 라인
            e.Graphics.DrawLine(Pens.Black, 12, 110, 12, 485);
            e.Graphics.DrawLine(Pens.Black, 80, 110, 80, 485);
            //도 가로 라인
            e.Graphics.DrawLine(Pens.Black, 12, 110, 80, 110);

            //레 세로 라인
            e.Graphics.DrawLine(Pens.Black, 12+75, 110, 12+75, 485);
            e.Graphics.DrawLine(Pens.Black, 80+75, 110, 80+75, 485);
            //레 가로 라인
            e.Graphics.DrawLine(Pens.Black, 12 + 75, 110, 80 + 75, 110);

            //미 세로 라인
            e.Graphics.DrawLine(Pens.Black, 12 + 75*2, 110, 12 + 75*2, 485);
            e.Graphics.DrawLine(Pens.Black, 80 + 75*2, 110, 80 + 75*2, 485);
            //미 가로 라인
            e.Graphics.DrawLine(Pens.Black, 12 + 75 * 2, 110, 80 + 75 * 2, 110);

            //파세로 라인
            e.Graphics.DrawLine(Pens.Black, 12 + 75 * 3, 110, 12 + 75 * 3, 485);
            e.Graphics.DrawLine(Pens.Black, 80 + 75 * 3, 110, 80 + 75 * 3, 485);
            //파 가로 라인
            e.Graphics.DrawLine(Pens.Black, 12 + 75 * 3, 110, 80 + 75 * 3, 110);

            //솔세로 라인
            e.Graphics.DrawLine(Pens.Black, 12 + 75 * 4, 110, 12 + 75 * 4, 485);
            e.Graphics.DrawLine(Pens.Black, 80 + 75 * 4, 110, 80 + 75 * 4, 485);
            //솔 가로 라인
            e.Graphics.DrawLine(Pens.Black, 12 + 75 * 4, 110, 80 + 75 * 4, 110);

            //라세로 라인
            e.Graphics.DrawLine(Pens.Black, 12 + 75 * 5, 110, 12 + 75 * 5, 485);
            e.Graphics.DrawLine(Pens.Black, 80 + 75 * 5, 110, 80 + 75 * 5, 485);
            //라 가로 라인
            e.Graphics.DrawLine(Pens.Black, 12 + 75 * 5, 110, 80 + 75 * 5, 110);

            //시세로 라인
            e.Graphics.DrawLine(Pens.Black, 12 + 75 * 6, 110, 12 + 75 * 6, 485);
            e.Graphics.DrawLine(Pens.Black, 80 + 75 * 6, 110, 80 + 75 * 6, 485);
            //시 가로 라인
            e.Graphics.DrawLine(Pens.Black, 12 + 75 * 6, 110, 80 + 75 * 6, 110);

            //도세로 라인
            e.Graphics.DrawLine(Pens.Black, 12 + 75 * 7, 110, 12 + 75 * 7, 485);
            e.Graphics.DrawLine(Pens.Black, 80 + 75 * 7, 110, 80 + 75 * 7, 485);
            //도 가로 라인
            e.Graphics.DrawLine(Pens.Black, 12 + 75 * 7, 110, 80 + 75 * 7, 110);
        }
    }
}
