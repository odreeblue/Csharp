using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lec15_1
{
    internal static class Program
    {
        /// <summary>
        /// 해당 애플리케이션의 주 진입점입니다.
        /// </summary>
        /// 이벤트 개념
        /// delegate-> 외부에서, event -> 객체의 메서드 안에서.
        /// 윈도우 메시지에 따라 호출되는 이벤트는 결정 --> 자동생성 & 호출
        /// WM_PAINT
        ///     --> event PaintEventHandler Paint
        ///         --> this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint) ==> 자동화 돼있음
        ///         
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
