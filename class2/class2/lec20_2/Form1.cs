using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lec20_2
{
    /// <summary>
    /// *** 타이머 이벤트
    ///  ** 타이머 이벤트 제한 사항
    ///     - 1초에 100회 이하 발생
    ///     - 보장성 없음
    ///  ** 타이머 이벤트 설정 순서
    ///     - 타이머 컨트롤 폼에 설정
    ///       도구상자 --> Timer 폼에 놓기
    ///     - 타이머 컨트롤 속성 변경
    ///       Enable --> true 설정 // 폼이 실행하자마자 타이머 자동 시작
    ///       interval --> 1초에 발생할 수 설정 //100번 이하로 설정
    ///     - Timer event에서 tick 설정
    ///   ** 타이머 기본 메서드
    ///     - Start(): Enabled 을 true로 설정 OR 속성 Enable true로 직접 설정
    ///     - Stop() : Enable을 false로 설정
    ///     - Dispose() : 리소스 해제
    ///   ** 타이머를 사용하여 화면에 100개의 사각형을 출력하는 소스
    ///                   
    /// </summary>
    public partial class Form1 : Form
    {
        Rectangle[] rectangle;
        public Form1()
        {
            InitializeComponent();
            rectangle = new Rectangle[100];

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random random = new Random();
            for (int i=0; i<100; i++)
            {
                rectangle[i].X = random.Next(200);
                rectangle[i].Y = random.Next(200);
                rectangle[i].Width = 60;
                rectangle[i].Height = 60;
            }
            Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            for (int i = 0; i < 100; i++)
                e.Graphics.DrawRectangle(Pens.Black, rectangle[i]);
        }
    }
}
