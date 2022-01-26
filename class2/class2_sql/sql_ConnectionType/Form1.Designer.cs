namespace sql_ConnectionType
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtbox_SqlName = new System.Windows.Forms.TextBox();
            this.txtbox_SqlInput = new System.Windows.Forms.TextBox();
            this.btn_Run = new System.Windows.Forms.Button();
            this.txtbox_ResultName = new System.Windows.Forms.TextBox();
            this.listview_SqlOutput = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // txtbox_SqlName
            // 
            this.txtbox_SqlName.BackColor = System.Drawing.SystemColors.Control;
            this.txtbox_SqlName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbox_SqlName.Location = new System.Drawing.Point(27, 27);
            this.txtbox_SqlName.Name = "txtbox_SqlName";
            this.txtbox_SqlName.Size = new System.Drawing.Size(100, 14);
            this.txtbox_SqlName.TabIndex = 0;
            this.txtbox_SqlName.Text = "SQL문";
            // 
            // txtbox_SqlInput
            // 
            this.txtbox_SqlInput.Location = new System.Drawing.Point(27, 47);
            this.txtbox_SqlInput.Name = "txtbox_SqlInput";
            this.txtbox_SqlInput.Size = new System.Drawing.Size(333, 21);
            this.txtbox_SqlInput.TabIndex = 1;
            // 
            // btn_Run
            // 
            this.btn_Run.Location = new System.Drawing.Point(285, 74);
            this.btn_Run.Name = "btn_Run";
            this.btn_Run.Size = new System.Drawing.Size(75, 23);
            this.btn_Run.TabIndex = 2;
            this.btn_Run.Text = "실행";
            this.btn_Run.UseVisualStyleBackColor = true;
            this.btn_Run.Click += new System.EventHandler(this.btn_Run_Click);
            // 
            // txtbox_ResultName
            // 
            this.txtbox_ResultName.BackColor = System.Drawing.SystemColors.Control;
            this.txtbox_ResultName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbox_ResultName.Location = new System.Drawing.Point(27, 111);
            this.txtbox_ResultName.Name = "txtbox_ResultName";
            this.txtbox_ResultName.Size = new System.Drawing.Size(100, 14);
            this.txtbox_ResultName.TabIndex = 3;
            this.txtbox_ResultName.Text = "결과보기";
            // 
            // listview_SqlOutput
            // 
            this.listview_SqlOutput.HideSelection = false;
            this.listview_SqlOutput.Location = new System.Drawing.Point(27, 142);
            this.listview_SqlOutput.Name = "listview_SqlOutput";
            this.listview_SqlOutput.Size = new System.Drawing.Size(333, 149);
            this.listview_SqlOutput.TabIndex = 4;
            this.listview_SqlOutput.UseCompatibleStateImageBehavior = false;
            this.listview_SqlOutput.View = System.Windows.Forms.View.List;
            this.listview_SqlOutput.SelectedIndexChanged += new System.EventHandler(this.listview_SqlOutput_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 336);
            this.Controls.Add(this.listview_SqlOutput);
            this.Controls.Add(this.txtbox_ResultName);
            this.Controls.Add(this.btn_Run);
            this.Controls.Add(this.txtbox_SqlInput);
            this.Controls.Add(this.txtbox_SqlName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbox_SqlName;
        private System.Windows.Forms.TextBox txtbox_SqlInput;
        private System.Windows.Forms.Button btn_Run;
        private System.Windows.Forms.TextBox txtbox_ResultName;
        private System.Windows.Forms.ListView listview_SqlOutput;
    }
}

