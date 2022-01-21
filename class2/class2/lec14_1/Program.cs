using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lec14_1
{
    /// <summary>
    /// Application class
    /// 상속구조
    /// System.Object
    ///     System.Windows.Threading.DispatcherObject
    ///         System.Windows.Application
    /// </summary>
    internal static class Program
    {
        /// <summary>
        /// 해당 애플리케이션의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {//Application --> 상속불가능(sealed 처리되어있음) --> 응용프로그램을 관리하는 속성 및 정보를 얻기 위한 클래스
            // MSDN 참조
            Application.EnableVisualStyles(); // --> 폼의 스타일 설정(색, 글꼴, 테마 등의 허가) !!폼이 생성되기 전에 반드시 호출되어야함!!
            Application.SetCompatibleTextRenderingDefault(false); // --> 폼에 출력할 글자의 렌더링을 GDI vs GDI+결정
                                                                  // false -> GDI, true -> GDI+ !!폼이 생성되기 전에 반드시 호출되어야함!!
            Application.Run(new Form1()); // 메시지 루프를 실행과 출력할 폼 설정
        }
    }
}
