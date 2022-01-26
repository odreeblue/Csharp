using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace debug
{
    public partial class form_Main : Form
    {
        public form_Main()
        {
            InitializeComponent();
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            for(int i=1; i<101; i++)
            {
                txtbox_Output.Text=i.ToString();
            }

        }
    }
}
