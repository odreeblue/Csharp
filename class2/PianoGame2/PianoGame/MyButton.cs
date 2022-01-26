using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PianoGame
{
    public partial class MyButton : UserControl
    {
        bool mClicked = false;

        public MyButton()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mClicked = !mClicked;
            //Button btn = sender as Button;
            if(mClicked)
            {
                panel1.BackColor = Color.Red;
            }
            else
            {
                panel1.BackColor = Color.Blue;
            }
        }
    }
}
