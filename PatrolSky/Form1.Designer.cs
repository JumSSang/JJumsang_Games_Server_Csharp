namespace PatrolSky
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
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.button4 = new System.Windows.Forms.Button();
            this.linkLabel8 = new System.Windows.Forms.LinkLabel();
            this.접속자 = new System.Windows.Forms.LinkLabel();
            this.접속자리스트 = new System.Windows.Forms.ListView();
            this.listView4 = new System.Windows.Forms.ListView();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel6 = new System.Windows.Forms.LinkLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.linkLabel5 = new System.Windows.Forms.LinkLabel();
            this.ServerStat = new System.Windows.Forms.LinkLabel();
            this.WordCharList = new System.Windows.Forms.ListView();
            this.listView2 = new System.Windows.Forms.ListView();
            this.서버상태 = new System.Windows.Forms.TextBox();
            this.계정블럭 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.대기유저리스트 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.ForestGreen;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("굴림", 10F);
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.Location = new System.Drawing.Point(856, 441);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(90, 31);
            this.button4.TabIndex = 63;
            this.button4.Text = "전송";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // linkLabel8
            // 
            this.linkLabel8.AutoSize = true;
            this.linkLabel8.BackColor = System.Drawing.Color.White;
            this.linkLabel8.Font = new System.Drawing.Font("봄의왈츠", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.linkLabel8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.linkLabel8.LinkColor = System.Drawing.Color.Black;
            this.linkLabel8.Location = new System.Drawing.Point(139, 441);
            this.linkLabel8.Margin = new System.Windows.Forms.Padding(0);
            this.linkLabel8.Name = "linkLabel8";
            this.linkLabel8.Size = new System.Drawing.Size(63, 27);
            this.linkLabel8.TabIndex = 62;
            this.linkLabel8.TabStop = true;
            this.linkLabel8.Text = "공지:";
            // 
            // 접속자
            // 
            this.접속자.AutoSize = true;
            this.접속자.BackColor = System.Drawing.Color.White;
            this.접속자.Font = new System.Drawing.Font("봄의왈츠", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.접속자.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.접속자.LinkColor = System.Drawing.Color.Black;
            this.접속자.Location = new System.Drawing.Point(64, 221);
            this.접속자.Margin = new System.Windows.Forms.Padding(0);
            this.접속자.Name = "접속자";
            this.접속자.Size = new System.Drawing.Size(121, 27);
            this.접속자.TabIndex = 61;
            this.접속자.TabStop = true;
            this.접속자.Text = "접속자:0명";
            // 
            // 접속자리스트
            // 
            this.접속자리스트.Location = new System.Drawing.Point(58, 251);
            this.접속자리스트.Name = "접속자리스트";
            this.접속자리스트.Size = new System.Drawing.Size(159, 187);
            this.접속자리스트.TabIndex = 60;
            this.접속자리스트.UseCompatibleStateImageBehavior = false;
            // 
            // listView4
            // 
            this.listView4.Location = new System.Drawing.Point(949, 48);
            this.listView4.Name = "listView4";
            this.listView4.Size = new System.Drawing.Size(234, 153);
            this.listView4.TabIndex = 58;
            this.listView4.UseCompatibleStateImageBehavior = false;
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.BackColor = System.Drawing.Color.White;
            this.linkLabel2.Font = new System.Drawing.Font("a피오피네모OL", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.linkLabel2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.linkLabel2.LinkColor = System.Drawing.Color.Black;
            this.linkLabel2.Location = new System.Drawing.Point(64, 16);
            this.linkLabel2.Margin = new System.Windows.Forms.Padding(0);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(124, 27);
            this.linkLabel2.TabIndex = 57;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "대기 유저";
            // 
            // linkLabel6
            // 
            this.linkLabel6.AutoSize = true;
            this.linkLabel6.BackColor = System.Drawing.Color.White;
            this.linkLabel6.Font = new System.Drawing.Font("a피오피네모OL", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.linkLabel6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.linkLabel6.LinkColor = System.Drawing.Color.Black;
            this.linkLabel6.Location = new System.Drawing.Point(321, 15);
            this.linkLabel6.Margin = new System.Windows.Forms.Padding(0);
            this.linkLabel6.Name = "linkLabel6";
            this.linkLabel6.Size = new System.Drawing.Size(194, 27);
            this.linkLabel6.TabIndex = 56;
            this.linkLabel6.TabStop = true;
            this.linkLabel6.Text = "활성화 된 게임";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.ForestGreen;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("굴림", 10F);
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(1055, 350);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 34);
            this.button1.TabIndex = 55;
            this.button1.Text = "차단 해제";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // linkLabel5
            // 
            this.linkLabel5.AutoSize = true;
            this.linkLabel5.BackColor = System.Drawing.Color.Red;
            this.linkLabel5.Font = new System.Drawing.Font("휴먼모음T", 20F, System.Drawing.FontStyle.Bold);
            this.linkLabel5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.linkLabel5.LinkColor = System.Drawing.Color.White;
            this.linkLabel5.Location = new System.Drawing.Point(981, 16);
            this.linkLabel5.Name = "linkLabel5";
            this.linkLabel5.Size = new System.Drawing.Size(144, 30);
            this.linkLabel5.TabIndex = 54;
            this.linkLabel5.TabStop = true;
            this.linkLabel5.Text = "차단된 유저";
            // 
            // ServerStat
            // 
            this.ServerStat.AutoSize = true;
            this.ServerStat.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ServerStat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ServerStat.DisabledLinkColor = System.Drawing.Color.White;
            this.ServerStat.Font = new System.Drawing.Font("굵은안상수체", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ServerStat.Location = new System.Drawing.Point(223, 221);
            this.ServerStat.Name = "ServerStat";
            this.ServerStat.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ServerStat.Size = new System.Drawing.Size(108, 22);
            this.ServerStat.TabIndex = 53;
            this.ServerStat.TabStop = true;
            this.ServerStat.Text = "서버상태 및 채팅";
            this.ServerStat.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
            // 
            // WordCharList
            // 
            this.WordCharList.Location = new System.Drawing.Point(223, 252);
            this.WordCharList.Name = "WordCharList";
            this.WordCharList.Size = new System.Drawing.Size(627, 186);
            this.WordCharList.TabIndex = 52;
            this.WordCharList.UseCompatibleStateImageBehavior = false;
            // 
            // listView2
            // 
            this.listView2.Location = new System.Drawing.Point(298, 51);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(234, 153);
            this.listView2.TabIndex = 51;
            this.listView2.UseCompatibleStateImageBehavior = false;
            // 
            // 서버상태
            // 
            this.서버상태.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.서버상태.Location = new System.Drawing.Point(223, 444);
            this.서버상태.Name = "서버상태";
            this.서버상태.Size = new System.Drawing.Size(627, 21);
            this.서버상태.TabIndex = 50;
            this.서버상태.Text = "...";
            // 
            // 계정블럭
            // 
            this.계정블럭.BackColor = System.Drawing.Color.Red;
            this.계정블럭.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.계정블럭.Font = new System.Drawing.Font("굴림", 10F);
            this.계정블럭.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.계정블럭.Location = new System.Drawing.Point(1055, 404);
            this.계정블럭.Name = "계정블럭";
            this.계정블럭.Size = new System.Drawing.Size(128, 34);
            this.계정블럭.TabIndex = 49;
            this.계정블럭.Text = "계정 블럭";
            this.계정블럭.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1055, 593);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(128, 34);
            this.button3.TabIndex = 48;
            this.button3.Text = "종료";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1055, 459);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 38);
            this.button2.TabIndex = 47;
            this.button2.Text = "클라이언트 제거";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // 대기유저리스트
            // 
            this.대기유저리스트.Location = new System.Drawing.Point(58, 51);
            this.대기유저리스트.Name = "대기유저리스트";
            this.대기유저리스트.Size = new System.Drawing.Size(234, 153);
            this.대기유저리스트.TabIndex = 46;
            this.대기유저리스트.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 642);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.linkLabel8);
            this.Controls.Add(this.접속자);
            this.Controls.Add(this.접속자리스트);
            this.Controls.Add(this.listView4);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.linkLabel5);
            this.Controls.Add(this.ServerStat);
            this.Controls.Add(this.WordCharList);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.서버상태);
            this.Controls.Add(this.계정블럭);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.대기유저리스트);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.LinkLabel linkLabel8;
        private System.Windows.Forms.LinkLabel 접속자;
        private System.Windows.Forms.ListView 접속자리스트;
        private System.Windows.Forms.ListView listView4;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.LinkLabel linkLabel5;
        private System.Windows.Forms.LinkLabel ServerStat;
        private System.Windows.Forms.ListView WordCharList;
        private System.Windows.Forms.ListView listView2;
        public System.Windows.Forms.TextBox 서버상태;
        private System.Windows.Forms.Button 계정블럭;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListView 대기유저리스트;
    }
}

