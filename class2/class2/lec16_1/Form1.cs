using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lec16_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == (Keys.A | Keys.Shift | Keys.Control))
            {
                MessageBox.Show("a+shift+control");
            }
                
            //if (e.Modifiers == (Keys.Shift | Keys.Control))
            //    MessageBox.Show("Modifiers + shift +Control");
            //if (e.KeyCode == Keys.A && e.Modifiers == (Keys.Shift | Keys.Alt))
            //    MessageBox.Show("A + shift + alt");
            //if(e.KeyCode==Keys.A && e.Shift && e.Control)
            //{
            //    MessageBox.Show("KeyCode+Shift+Control");
            //}
            //MessageBox.Show("KeyDown");
        }
    }
}
