using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lec22_1
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// *** 컨트롤 개요
        /// ** 컨트롤 목적 : 사용자 편의 -> 사용자 인터페이스(편의성)
        /// ** 쉬운 컨트롤 사용 --> 디자인 요구 사용자 편의성 높임
        /// ** 버튼 컨트롤의 3가지 형태
        ///  * 푸시버튼, 라디오 버튼, 체크 버튼
        ///    - 푸시버튼 : 클릭했을 때, 반응 하는 용도로 사용
        ///      WM_COMMAND 발생 --> 버튼 아이디 발급 --> C#에서는 이벤트로 처리
        ///    - 클릭 이벤트 --> 이벤트에서 생성 OR 더블클릭한다
        ///  * 체크버튼: 여러항목을 선택하는 용도
        ///    - 선택, 비선택 
        ///    - CheckState 속성
        ///      CheckState 열거형, Checked, Unchecked 설정
        ///    - 체크 상태 변경에 따른 이벤트
        ///      CheckedChanged, CheckStateChanged
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("adfadfasf");
            string strResult = "체크 1: " + checkBox1.CheckState + " 체크 2: " + checkBox2.CheckState
                                + "체크 3: " + checkBox3.CheckState;
            MessageBox.Show(strResult);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                MessageBox.Show("radio 1선택");
            }
            else if (radioButton2.Checked)
            {
                MessageBox.Show("radio 2선택");
            }
            else
            {
                MessageBox.Show("radio 3선택");
            }

        }
    }
}
