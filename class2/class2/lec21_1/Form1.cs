using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lec21_1
{
    /// <summary>
    /// *** 메뉴
    ///  ** 일반 메뉴다루기
    ///   * 메뉴를 더블클릭하면 이벤트가 생성됨
    ///   * 단축키 설정 -> 메뉴 -> 속성 -> shortcut keys
    ///  ** 컨텍스트 메뉴 다루기
    ///   * 우클릭하면 메뉴 뜨게끔 하는? 그런것 
    /// </summary>
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void 열기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("열기");
        }

        private void 열기ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("컨텍스트 메뉴 열기");
        }
    }
}
