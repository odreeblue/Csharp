using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lec14_1
{
    public partial class Form1 : Form
    {
        // partial --> 클래스나 구조체, 인터페이스, 메서드의 정의를 
        //              둘이상의 소스파일로 분할
        //         --> 규모가 큰 프로젝트일 때, 하나의 파일에 다수가 접근할 때 사용
        // Form 속성
        // handle : 윈도우 핸들 -> 우리가 사용하는 윈도우 프로그램에 대한 고유 값
                // 동일한 메모장을 여러개 띄우면, 같은 프로그램이지만 각각의 값이 다르다
        // text : 컨트롤 또는 윈도우 타이틀 바에 텍스트 출력 or 입력
        // visible : 폼 또는 컨트롤의 출력 여부 결정
        // Enable : 비활성 또는 활성
        // ClientRectangle : 클라이언트 크기 영역을 가져오는 역할

        // 메서드
        // invalidate() : 특정영역 또는 무효화 영역을 다시 출력하는 역할
        // update() : 현재 무효화 영역만 다시 출력
        // activate() : 폼을 활성화
        // close() : 폼을 닫는다 -내부적으로는 WM_Close --> WM_Destroy
        // showdialog(): 폼을 모달 대화상자로 출력 --> 화면에 띄움

        public Form1()
        {
            InitializeComponent();
        }
    }
}
