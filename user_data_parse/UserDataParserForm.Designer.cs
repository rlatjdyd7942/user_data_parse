namespace user_data_parse
{
    partial class UserDataParserForm
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
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.runButton = new System.Windows.Forms.Button();
            this.startDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.endDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.termsTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.femaleRadioButton = new System.Windows.Forms.RadioButton();
            this.maleRadioButton = new System.Windows.Forms.RadioButton();
            this.allRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.endAgeTextBox = new System.Windows.Forms.TextBox();
            this.startAgeTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataFolderPath = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.setFolderPathButton = new System.Windows.Forms.Button();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.resultNotepadButton = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.resultExcelButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // runButton
            // 
            this.runButton.Location = new System.Drawing.Point(443, 210);
            this.runButton.Name = "runButton";
            this.runButton.Size = new System.Drawing.Size(95, 23);
            this.runButton.TabIndex = 0;
            this.runButton.Tag = "runButton";
            this.runButton.Text = "실행";
            this.runButton.UseVisualStyleBackColor = true;
            this.runButton.Click += new System.EventHandler(this.runButton_Click);
            // 
            // startDateTimePicker
            // 
            this.startDateTimePicker.Location = new System.Drawing.Point(80, 20);
            this.startDateTimePicker.Name = "startDateTimePicker";
            this.startDateTimePicker.Size = new System.Drawing.Size(171, 21);
            this.startDateTimePicker.TabIndex = 1;
            this.startDateTimePicker.Tag = "startDateTimePicker";
            // 
            // endDateTimePicker
            // 
            this.endDateTimePicker.Location = new System.Drawing.Point(80, 47);
            this.endDateTimePicker.Name = "endDateTimePicker";
            this.endDateTimePicker.Size = new System.Drawing.Size(171, 21);
            this.endDateTimePicker.TabIndex = 2;
            this.endDateTimePicker.Tag = "endDateTimePicker";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "시작 날짜 :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "끝 날짜    :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "~";
            // 
            // termsTextBox
            // 
            this.termsTextBox.Location = new System.Drawing.Point(110, 207);
            this.termsTextBox.Name = "termsTextBox";
            this.termsTextBox.Size = new System.Drawing.Size(100, 21);
            this.termsTextBox.TabIndex = 6;
            this.termsTextBox.Tag = "termsTextBox";
            this.termsTextBox.Text = "7,30,60,90";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.startDateTimePicker);
            this.groupBox1.Controls.Add(this.endDateTimePicker);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(258, 79);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "날짜";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.femaleRadioButton);
            this.groupBox2.Controls.Add(this.maleRadioButton);
            this.groupBox2.Controls.Add(this.allRadioButton);
            this.groupBox2.Location = new System.Drawing.Point(12, 98);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(120, 92);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "성별";
            // 
            // femaleRadioButton
            // 
            this.femaleRadioButton.AutoSize = true;
            this.femaleRadioButton.Location = new System.Drawing.Point(26, 64);
            this.femaleRadioButton.Name = "femaleRadioButton";
            this.femaleRadioButton.Size = new System.Drawing.Size(47, 16);
            this.femaleRadioButton.TabIndex = 2;
            this.femaleRadioButton.Tag = "femaleRadioButton";
            this.femaleRadioButton.Text = "여자";
            this.femaleRadioButton.UseVisualStyleBackColor = true;
            // 
            // maleRadioButton
            // 
            this.maleRadioButton.AutoSize = true;
            this.maleRadioButton.Location = new System.Drawing.Point(26, 42);
            this.maleRadioButton.Name = "maleRadioButton";
            this.maleRadioButton.Size = new System.Drawing.Size(47, 16);
            this.maleRadioButton.TabIndex = 1;
            this.maleRadioButton.Tag = "maleRadioButton";
            this.maleRadioButton.Text = "남자";
            this.maleRadioButton.UseVisualStyleBackColor = true;
            // 
            // allRadioButton
            // 
            this.allRadioButton.AutoSize = true;
            this.allRadioButton.Checked = true;
            this.allRadioButton.Location = new System.Drawing.Point(26, 20);
            this.allRadioButton.Name = "allRadioButton";
            this.allRadioButton.Size = new System.Drawing.Size(47, 16);
            this.allRadioButton.TabIndex = 0;
            this.allRadioButton.TabStop = true;
            this.allRadioButton.Tag = "allRadioButton";
            this.allRadioButton.Text = "전체";
            this.allRadioButton.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.endAgeTextBox);
            this.groupBox3.Controls.Add(this.startAgeTextBox);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(138, 98);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(132, 92);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "나이";
            // 
            // endAgeTextBox
            // 
            this.endAgeTextBox.Location = new System.Drawing.Point(26, 59);
            this.endAgeTextBox.Name = "endAgeTextBox";
            this.endAgeTextBox.Size = new System.Drawing.Size(77, 21);
            this.endAgeTextBox.TabIndex = 6;
            this.endAgeTextBox.Tag = "endAgeTextBox";
            this.endAgeTextBox.Text = "2015";
            this.endAgeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // startAgeTextBox
            // 
            this.startAgeTextBox.Location = new System.Drawing.Point(26, 19);
            this.startAgeTextBox.Name = "startAgeTextBox";
            this.startAgeTextBox.Size = new System.Drawing.Size(77, 21);
            this.startAgeTextBox.TabIndex = 0;
            this.startAgeTextBox.Tag = "startAgeTextBox";
            this.startAgeTextBox.Text = "1900";
            this.startAgeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "기간들 :";
            // 
            // dataFolderPath
            // 
            this.dataFolderPath.Enabled = false;
            this.dataFolderPath.Location = new System.Drawing.Point(18, 20);
            this.dataFolderPath.Name = "dataFolderPath";
            this.dataFolderPath.Size = new System.Drawing.Size(227, 21);
            this.dataFolderPath.TabIndex = 10;
            this.dataFolderPath.Tag = "dataFolderPath";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.setFolderPathButton);
            this.groupBox4.Controls.Add(this.dataFolderPath);
            this.groupBox4.Location = new System.Drawing.Point(276, 13);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(262, 78);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "파일 폴더 경로";
            // 
            // setFolderPathButton
            // 
            this.setFolderPathButton.Location = new System.Drawing.Point(157, 46);
            this.setFolderPathButton.Name = "setFolderPathButton";
            this.setFolderPathButton.Size = new System.Drawing.Size(88, 23);
            this.setFolderPathButton.TabIndex = 11;
            this.setFolderPathButton.Tag = "setFolderPathButton";
            this.setFolderPathButton.Text = "폴더 정하기";
            this.setFolderPathButton.UseVisualStyleBackColor = true;
            this.setFolderPathButton.Click += new System.EventHandler(this.setFolderPathButton_Click);
            // 
            // resultNotepadButton
            // 
            this.resultNotepadButton.Location = new System.Drawing.Point(28, 39);
            this.resultNotepadButton.Name = "resultNotepadButton";
            this.resultNotepadButton.Size = new System.Drawing.Size(98, 23);
            this.resultNotepadButton.TabIndex = 12;
            this.resultNotepadButton.Tag = "resultNotepadButton";
            this.resultNotepadButton.Text = "메모장으로";
            this.resultNotepadButton.UseVisualStyleBackColor = true;
            this.resultNotepadButton.Click += new System.EventHandler(this.showResultButton_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.resultExcelButton);
            this.groupBox5.Controls.Add(this.resultNotepadButton);
            this.groupBox5.Location = new System.Drawing.Point(276, 98);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(262, 92);
            this.groupBox5.TabIndex = 13;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "결과 보기";
            // 
            // resultExcelButton
            // 
            this.resultExcelButton.Location = new System.Drawing.Point(132, 39);
            this.resultExcelButton.Name = "resultExcelButton";
            this.resultExcelButton.Size = new System.Drawing.Size(98, 23);
            this.resultExcelButton.TabIndex = 13;
            this.resultExcelButton.Tag = "resultExcelButton";
            this.resultExcelButton.Text = "엑셀로";
            this.resultExcelButton.UseVisualStyleBackColor = true;
            this.resultExcelButton.Click += new System.EventHandler(this.resultExcelButton_Click);
            // 
            // UserDataParserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 244);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.termsTextBox);
            this.Controls.Add(this.runButton);
            this.Name = "UserDataParserForm";
            this.Text = "UserDataParser";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button runButton;
        private System.Windows.Forms.DateTimePicker startDateTimePicker;
        private System.Windows.Forms.DateTimePicker endDateTimePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox termsTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton femaleRadioButton;
        private System.Windows.Forms.RadioButton maleRadioButton;
        private System.Windows.Forms.RadioButton allRadioButton;
        private System.Windows.Forms.TextBox endAgeTextBox;
        private System.Windows.Forms.TextBox startAgeTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox dataFolderPath;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button setFolderPathButton;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Button resultNotepadButton;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button resultExcelButton;
    }
}

