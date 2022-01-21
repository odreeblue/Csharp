using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lec22_2
{
    /// <summary>
    /// *** 텍스트 박스
    ///  ** 용도 : 문자열 입력 또는 출력
    ///  ** TextBox.Text 속성
    ///     public override string Text{get; set;}
    ///  ** 데이터변환
    ///     Convert.ToInt() 등 convert 클래스로 해결
    ///     public static class Convert
    ///  ** MaskedTextBox
    ///     휴대폰 번호 형식, 우편번호 등 입출력
    ///  ** RichTextBox
    ///     TextBox보다 업그레이드 기능 제공
    ///  ** 주요 속성
    ///     ReadOnly --> 읽기 전용
    ///     PasswordChar --> 비밀번호 입력 문자 지정
    /// *** 콤보박스
    ///  ** 용도 : 여러개의 항목중에서 하나 선택
    ///  ** 형태 : DropDown, DropDownList,Simple
    ///  ** 리스트 항목 길이 : 자동
    ///  ** 선택 항목의 문자열 입력
    ///     combobox item 속성 박스에서 입력 --> 코드보다 훨씬 쉬움
    /// *** 리스트 박스 --> 앞의 두개와 비슷함
    ///  ** 링크드 리스트와 같이 사용가능
    ///     listbox.items 사용해야함
    /// </summary>
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
    }
}
