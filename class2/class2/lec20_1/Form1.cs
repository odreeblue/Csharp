using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lec20_1
{
    /// <summary>
    /// 폼 이벤트
    /// ** 폼관련 메세지
    /// - WM_CREATE(폼이 뜨기 직전), WM_CLOSE(폼이 꺼지기 직전), WM_DESTROY(WM_CLOSE메시지 전달된 후)
    /// - win32 api 를 공부하면 이해하기 쉽다.
    /// 
    /// ** 폼관련 이벤트
    /// - Form.Load(폼이 처음으로 표시되기 전에 발생,초기화 관련 설정),
    ///   Form.Closing(폼이 닫히기 전에 발생함. 내부적으로 응용프로그램 메모리 삭제 중),
    ///   Form.Closed(내부적으로 응용프로그램 메모리 삭제 완료 뒤),
    ///   Form.Resize, Form.Layout (폼의 크기 , 레이아웃 관련)
    /// ** Foam.Load --> MSDN 확인 할 것
    /// - MSDN 이벤트 설명
    ///   폼이 처음으로 표시되기 전에 발생
    /// - 이벤트 사용 용도
    ///   폼에서 사용하는 리소스를 할당
    /// - public event EventHandler Load
    /// - Form.Load 특징
    ///   한번만 호출 --> 리소스 초기화(변수)
    ///   * 생성방법
    ///   1. 속성창 --> 이벤트 --> Load
    ///   2. 폼 더블 클릭
    /// - Foam.Load의 검증
    ///   메시지 박스 검증
    /// ** Form.Closing
    ///   * 폼 해제를 취소
    ///   Form1_FormClosing(object sender, FormClosingEventArgs e)
    ///   e.Cancel = true; 로 설정
    /// - 닫기 버튼 클릭마다 호출
    /// - FormClosing 이벤트 호출
    /// ** Form.FormClosed
    ///  * MSDN설명
    ///    - 폼이 닫힌 후(닫히면서)에 발생
    ///  * 이벤트 관련 메시지
    ///    - WM_DESTROY,WM_QUIT
    ///  * 이벤트 사용 용도
    ///    - 메모리에 관련된 해제
    ///  * 호출순서
    ///    -FormClosing --> FormClosed
    ///  * FormClosed 특징
    ///    한번만 호출된 후에 프로그램 완전 종료
    /// ** 폼크기의 임의 변경
    ///  * Layout 발생 시점
    ///    - 폼이 발생되기 직전
    ///    - 폼의 크기 변경
    ///    - 폼의 컨트롤의 배치가 바뀌는 경우
    ///  * Resize vs Layout 역할 비교
    ///    - Resize < Layout
    ///
    /// </summary>
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ///4. Resize : 폼 크기
            //4.1
            //Size = new Size(500, 500);//Form.Size = 속성으로 new 생성해서 참조하는 형태로 지정

            //4.2
            //Width = 500;
            //Height = 500;
        }

        private void Form1_Layout(object sender, LayoutEventArgs e)
        {
            MessageBox.Show("layout");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Hide();
        }

        //private void Form1_Resize(object sender, EventArgs e)
        //{
        //    ///5.1
        //    //Control control = (Control)sender;
        //    //control.Width = 500;
        //    //control.Height = 500;
        //    ///5.2
        //    //Width = 500;
        //    //Height = 500;   
        //}

        ///3. 폼 클로즈 생성



        ///2. 폼 클로싱 생성
        //private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        //{
        //    if (MessageBox.Show("종료?","종료할래?", MessageBoxButtons.YesNo) == DialogResult.No)
        //        e.Cancel = true; //폼 해제를 취소
        //}

        ///1. 폼 로드 생성
        //private void Form1_Load(object sender, EventArgs e)
        //{
        //    MessageBox.Show("Form Load event");
        //}

    }
}
