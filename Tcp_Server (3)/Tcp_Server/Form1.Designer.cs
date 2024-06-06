namespace Tcp_Server
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
            this.textBox_log = new System.Windows.Forms.TextBox();
            this.textBox_IP = new System.Windows.Forms.TextBox();
            this.labelIP = new System.Windows.Forms.Label();
            this.labelPort = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox_port = new System.Windows.Forms.TextBox();
            this.button_Start = new System.Windows.Forms.Button();
            this.Server_checkBox = new System.Windows.Forms.CheckBox();
            this.textBox = new System.Windows.Forms.TextBox();
            this.infobox = new System.Windows.Forms.CheckBox();
            this.button_input = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_log
            // 
            this.textBox_log.Location = new System.Drawing.Point(12, 75);
            this.textBox_log.Multiline = true;
            this.textBox_log.Name = "textBox_log";
            this.textBox_log.ReadOnly = true;
            this.textBox_log.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_log.Size = new System.Drawing.Size(311, 131);
            this.textBox_log.TabIndex = 0;
            this.textBox_log.TextChanged += new System.EventHandler(this.textBox_log_TextChanged);
            // 
            // textBox_IP
            // 
            this.textBox_IP.Location = new System.Drawing.Point(42, 3);
            this.textBox_IP.Name = "textBox_IP";
            this.textBox_IP.Size = new System.Drawing.Size(153, 21);
            this.textBox_IP.TabIndex = 1;
            this.textBox_IP.Text = "127.0.0.1";
            this.textBox_IP.TextChanged += new System.EventHandler(this.textBox_IP_TextChanged);
            // 
            // labelIP
            // 
            this.labelIP.Location = new System.Drawing.Point(3, 0);
            this.labelIP.Name = "labelIP";
            this.labelIP.Size = new System.Drawing.Size(33, 23);
            this.labelIP.TabIndex = 2;
            this.labelIP.Text = "IP";
            this.labelIP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPort
            // 
            this.labelPort.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelPort.Location = new System.Drawing.Point(3, 28);
            this.labelPort.Name = "labelPort";
            this.labelPort.Size = new System.Drawing.Size(33, 23);
            this.labelPort.TabIndex = 3;
            this.labelPort.Text = "Port";
            this.labelPort.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.Controls.Add(this.textBox_port, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBox_IP, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelIP, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelPort, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(198, 57);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // textBox_port
            // 
            this.textBox_port.Location = new System.Drawing.Point(42, 31);
            this.textBox_port.Name = "textBox_port";
            this.textBox_port.Size = new System.Drawing.Size(153, 21);
            this.textBox_port.TabIndex = 4;
            this.textBox_port.Text = "7000";
            this.textBox_port.TextChanged += new System.EventHandler(this.textBox_port_TextChanged);
            // 
            // button_Start
            // 
            this.button_Start.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_Start.Location = new System.Drawing.Point(216, 33);
            this.button_Start.Name = "button_Start";
            this.button_Start.Size = new System.Drawing.Size(107, 36);
            this.button_Start.TabIndex = 5;
            this.button_Start.Text = "Start";
            this.button_Start.UseVisualStyleBackColor = true;
            this.button_Start.Click += new System.EventHandler(this.button_Start_Click);
            // 
            // Server_checkBox
            // 
            this.Server_checkBox.AutoSize = true;
            this.Server_checkBox.Location = new System.Drawing.Point(216, 12);
            this.Server_checkBox.Name = "Server_checkBox";
            this.Server_checkBox.Size = new System.Drawing.Size(60, 16);
            this.Server_checkBox.TabIndex = 6;
            this.Server_checkBox.Text = "Server";
            this.Server_checkBox.UseVisualStyleBackColor = true;
            this.Server_checkBox.CheckedChanged += new System.EventHandler(this.Server_checkBox_CheckedChanged);
            // 
            // textBox
            // 
            this.textBox.ImeMode = System.Windows.Forms.ImeMode.On;
            this.textBox.Location = new System.Drawing.Point(12, 213);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(264, 21);
            this.textBox.TabIndex = 7;
            this.textBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.textBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyDown);
            // 
            // infobox
            // 
            this.infobox.AutoCheck = false;
            this.infobox.AutoSize = true;
            this.infobox.Location = new System.Drawing.Point(282, 12);
            this.infobox.Name = "infobox";
            this.infobox.Size = new System.Drawing.Size(44, 16);
            this.infobox.TabIndex = 8;
            this.infobox.Text = "info";
            this.infobox.UseVisualStyleBackColor = true;
            this.infobox.CheckedChanged += new System.EventHandler(this.infobox_CheckedChanged);
            // 
            // button_input
            // 
            this.button_input.Location = new System.Drawing.Point(282, 211);
            this.button_input.Name = "button_input";
            this.button_input.Size = new System.Drawing.Size(41, 23);
            this.button_input.TabIndex = 9;
            this.button_input.Text = "input";
            this.button_input.UseVisualStyleBackColor = true;
            this.button_input.Click += new System.EventHandler(this.button_input_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 241);
            this.Controls.Add(this.button_input);
            this.Controls.Add(this.infobox);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.Server_checkBox);
            this.Controls.Add(this.button_Start);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.textBox_log);
            this.Name = "Form1";
            this.Text = "통신 테스트";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_log;
        private System.Windows.Forms.TextBox textBox_IP;
        private System.Windows.Forms.Label labelIP;
        private System.Windows.Forms.Label labelPort;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox textBox_port;
        private System.Windows.Forms.Button button_Start;
        private System.Windows.Forms.CheckBox Server_checkBox;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.CheckBox infobox;
        private System.Windows.Forms.Button button_input;
    }
}

