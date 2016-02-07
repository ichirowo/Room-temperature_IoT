namespace room_temperature
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.butComDisconnect = new System.Windows.Forms.Button();
            this.butComConnect = new System.Windows.Forms.Button();
            this.comComPort = new System.Windows.Forms.ComboBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.labComStatus = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labDataStatus = new System.Windows.Forms.Label();
            this.texRcv = new System.Windows.Forms.TextBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.butEnd = new System.Windows.Forms.Button();
            this.butStationary = new System.Windows.Forms.Button();
            this.cheAutoRun = new System.Windows.Forms.CheckBox();
            this.labTemperature = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labHumidity = new System.Windows.Forms.Label();
            this.texMachineName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numInterval = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.texApiAddress = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numInterval)).BeginInit();
            this.SuspendLayout();
            // 
            // butComDisconnect
            // 
            this.butComDisconnect.Location = new System.Drawing.Point(318, 99);
            this.butComDisconnect.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.butComDisconnect.Name = "butComDisconnect";
            this.butComDisconnect.Size = new System.Drawing.Size(74, 31);
            this.butComDisconnect.TabIndex = 5;
            this.butComDisconnect.Text = "切断";
            this.butComDisconnect.UseVisualStyleBackColor = true;
            this.butComDisconnect.Click += new System.EventHandler(this.butComDisconnect_Click);
            // 
            // butComConnect
            // 
            this.butComConnect.Location = new System.Drawing.Point(238, 99);
            this.butComConnect.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.butComConnect.Name = "butComConnect";
            this.butComConnect.Size = new System.Drawing.Size(74, 31);
            this.butComConnect.TabIndex = 4;
            this.butComConnect.Text = "接続";
            this.butComConnect.UseVisualStyleBackColor = true;
            this.butComConnect.Click += new System.EventHandler(this.butComConnect_Click);
            // 
            // comComPort
            // 
            this.comComPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comComPort.FormattingEnabled = true;
            this.comComPort.Location = new System.Drawing.Point(16, 100);
            this.comComPort.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.comComPort.Name = "comComPort";
            this.comComPort.Size = new System.Drawing.Size(216, 31);
            this.comComPort.TabIndex = 3;
            this.comComPort.SelectedIndexChanged += new System.EventHandler(this.comComPort_SelectedIndexChanged);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // labComStatus
            // 
            this.labComStatus.Location = new System.Drawing.Point(16, 63);
            this.labComStatus.Name = "labComStatus";
            this.labComStatus.Size = new System.Drawing.Size(376, 31);
            this.labComStatus.TabIndex = 6;
            this.labComStatus.Text = "labComStatus";
            this.labComStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labDataStatus
            // 
            this.labDataStatus.Location = new System.Drawing.Point(16, 137);
            this.labDataStatus.Name = "labDataStatus";
            this.labDataStatus.Size = new System.Drawing.Size(376, 31);
            this.labDataStatus.TabIndex = 7;
            this.labDataStatus.Text = "labDataStatus";
            this.labDataStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // texRcv
            // 
            this.texRcv.Location = new System.Drawing.Point(16, 229);
            this.texRcv.Multiline = true;
            this.texRcv.Name = "texRcv";
            this.texRcv.Size = new System.Drawing.Size(448, 197);
            this.texRcv.TabIndex = 8;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "COM2http";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseClick);
            // 
            // butEnd
            // 
            this.butEnd.Location = new System.Drawing.Point(189, 518);
            this.butEnd.Name = "butEnd";
            this.butEnd.Size = new System.Drawing.Size(130, 41);
            this.butEnd.TabIndex = 9;
            this.butEnd.Text = "終了";
            this.butEnd.UseVisualStyleBackColor = true;
            this.butEnd.Click += new System.EventHandler(this.butEnd_Click);
            // 
            // butStationary
            // 
            this.butStationary.Location = new System.Drawing.Point(402, 16);
            this.butStationary.Name = "butStationary";
            this.butStationary.Size = new System.Drawing.Size(62, 78);
            this.butStationary.TabIndex = 10;
            this.butStationary.Text = "常駐";
            this.butStationary.UseVisualStyleBackColor = true;
            this.butStationary.Click += new System.EventHandler(this.butStationary_Click);
            // 
            // cheAutoRun
            // 
            this.cheAutoRun.AutoSize = true;
            this.cheAutoRun.Location = new System.Drawing.Point(16, 432);
            this.cheAutoRun.Name = "cheAutoRun";
            this.cheAutoRun.Size = new System.Drawing.Size(257, 27);
            this.cheAutoRun.TabIndex = 11;
            this.cheAutoRun.Text = "起動時にセンサーに接続して常駐";
            this.cheAutoRun.UseVisualStyleBackColor = true;
            this.cheAutoRun.CheckedChanged += new System.EventHandler(this.cheAutoRun_CheckedChanged);
            // 
            // labTemperature
            // 
            this.labTemperature.Font = new System.Drawing.Font("メイリオ", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labTemperature.Location = new System.Drawing.Point(16, 187);
            this.labTemperature.Name = "labTemperature";
            this.labTemperature.Size = new System.Drawing.Size(115, 39);
            this.labTemperature.TabIndex = 12;
            this.labTemperature.Text = "30.00";
            this.labTemperature.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("メイリオ", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(137, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 39);
            this.label1.TabIndex = 13;
            this.label1.Text = "℃";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("メイリオ", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(355, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 39);
            this.label2.TabIndex = 15;
            this.label2.Text = "％";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // labHumidity
            // 
            this.labHumidity.Font = new System.Drawing.Font("メイリオ", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labHumidity.Location = new System.Drawing.Point(234, 187);
            this.labHumidity.Name = "labHumidity";
            this.labHumidity.Size = new System.Drawing.Size(115, 39);
            this.labHumidity.TabIndex = 14;
            this.labHumidity.Text = "30.00";
            this.labHumidity.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // texMachineName
            // 
            this.texMachineName.Location = new System.Drawing.Point(103, 16);
            this.texMachineName.Name = "texMachineName";
            this.texMachineName.Size = new System.Drawing.Size(209, 30);
            this.texMachineName.TabIndex = 16;
            this.texMachineName.TextChanged += new System.EventHandler(this.texMachineName_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 23);
            this.label3.TabIndex = 17;
            this.label3.Text = "マシン番号";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(488, 500);
            this.tabControl1.TabIndex = 18;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.texMachineName);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.comComPort);
            this.tabPage1.Controls.Add(this.butComConnect);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.butComDisconnect);
            this.tabPage1.Controls.Add(this.labHumidity);
            this.tabPage1.Controls.Add(this.labComStatus);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.labDataStatus);
            this.tabPage1.Controls.Add(this.labTemperature);
            this.tabPage1.Controls.Add(this.texRcv);
            this.tabPage1.Controls.Add(this.cheAutoRun);
            this.tabPage1.Controls.Add(this.butStationary);
            this.tabPage1.Location = new System.Drawing.Point(4, 32);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(480, 464);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "メイン";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.numInterval);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.texApiAddress);
            this.tabPage2.Location = new System.Drawing.Point(4, 32);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(480, 464);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "設定";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(233, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 23);
            this.label6.TabIndex = 4;
            this.label6.Text = "秒";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(61, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 23);
            this.label5.TabIndex = 3;
            this.label5.Text = "間隔";
            // 
            // numInterval
            // 
            this.numInterval.Increment = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numInterval.Location = new System.Drawing.Point(107, 62);
            this.numInterval.Maximum = new decimal(new int[] {
            86400,
            0,
            0,
            0});
            this.numInterval.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numInterval.Name = "numInterval";
            this.numInterval.Size = new System.Drawing.Size(120, 30);
            this.numInterval.TabIndex = 2;
            this.numInterval.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numInterval.ValueChanged += new System.EventHandler(this.numInterval_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 23);
            this.label4.TabIndex = 1;
            this.label4.Text = "APIアドレス";
            // 
            // texApiAddress
            // 
            this.texApiAddress.Location = new System.Drawing.Point(107, 26);
            this.texApiAddress.Name = "texApiAddress";
            this.texApiAddress.Size = new System.Drawing.Size(354, 30);
            this.texApiAddress.TabIndex = 0;
            this.texApiAddress.TextChanged += new System.EventHandler(this.texApiAddress_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 579);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.butEnd);
            this.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "COM2HTTP";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numInterval)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button butComDisconnect;
        private System.Windows.Forms.Button butComConnect;
        private System.Windows.Forms.ComboBox comComPort;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label labComStatus;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labDataStatus;
        private System.Windows.Forms.TextBox texRcv;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Button butEnd;
        private System.Windows.Forms.Button butStationary;
        private System.Windows.Forms.CheckBox cheAutoRun;
        private System.Windows.Forms.Label labTemperature;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labHumidity;
        private System.Windows.Forms.TextBox texMachineName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox texApiAddress;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numInterval;
    }
}

