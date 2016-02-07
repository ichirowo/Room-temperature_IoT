using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.IO.Ports;

namespace room_temperature
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //シリアル系初期化-----------------------------------------------------
            serialPort1.BaudRate = 9600;
            serialPort1.Parity = System.IO.Ports.Parity.None;
            serialPort1.DataBits = 8;
            serialPort1.StopBits = System.IO.Ports.StopBits.One;
            serialPort1.DtrEnable = false;

            //COMポート　コンボボックス
            string[] ports = SerialPort.GetPortNames();
            comComPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comComPort.Items.AddRange(ports);

            string LastCom = (string)Properties.Settings.Default["LastCom"];
            comComPort.SelectedIndex = comComPort.FindStringExact(LastCom);

            cheAutoRun.Checked = (bool)Properties.Settings.Default["AutoRun"];

            texMachineName.Text = (string)Properties.Settings.Default["MachineName"];

            texApiAddress.Text = (string)Properties.Settings.Default["ApiAddress"];

            numInterval.Value = (int)Properties.Settings.Default["Interval"];


            //表示 初期化
            this.MinimizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.texRcv.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.labTemperature.Text = "";
            this.labTemperature.BackColor = System.Drawing.Color.White;
            this.labHumidity.Text = "";
            this.labHumidity.BackColor = System.Drawing.Color.White;

            
            Serial_connect_status(false);
            labDataStatus.Text = "";
            notifyIcon1.Visible = true;

            //タイマー初期化
            timer1.Interval = (int)numInterval.Value * 1000;
            timer1.Enabled = false;

            //AutoRun実行
            if (cheAutoRun.Checked)
            {
                if (ComConnect())
                {
                    Form_View(false);
                }
            }

        }

        private void butComConnect_Click(object sender, EventArgs e)
        {
            ComConnect();
        }

        private void butComDisconnect_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            serialPort1.Close();
            Serial_connect_status(false);
        }

        private void comComPort_SelectedIndexChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default["LastCom"] = comComPort.SelectedItem;
            Properties.Settings.Default.Save();
        }

        /// 
        /// <summary>
        /// COMデータ受信６
        /// </summary>
        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            Invoke((MethodInvoker)(() => labDataStatus.BackColor = Color.Cyan));
            Invoke((MethodInvoker)(() => labDataStatus.Text = "データ受信"));
            System.Threading.Thread.Sleep(100);
            try
            {
                string data = serialPort1.ReadExisting();
                if (!string.IsNullOrEmpty(data))
                {
                    DateTime dtNow = DateTime.Now;
                    string Rcv = string.Format("{0}     {1}", dtNow.ToString(), data);
                    Invoke((MethodInvoker)(() => texRcv.AppendText(Rcv)));

                    string[] dataSplit = data.Split(',');
                    string Temperature = dataSplit[0];
                    string Humidity = dataSplit[1];

                    Invoke((MethodInvoker)(() => labTemperature.Text = Temperature));
                    Invoke((MethodInvoker)(() => labHumidity.Text = Humidity));

                    Invoke((MethodInvoker)(() => labDataStatus.BackColor = Color.LightSalmon));
                    Invoke((MethodInvoker)(() => labDataStatus.Text = "APIアクセス中"));
                    string err = WebAccess.Api(Temperature, Humidity);
                    if (err == null) {

                    }
                    else
                    {
                        Invoke((MethodInvoker)(() => labDataStatus.BackColor = Color.Red));
                        Invoke((MethodInvoker)(() => labDataStatus.Text = err));
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                Invoke((MethodInvoker)(() => labDataStatus.BackColor = Color.Red));
                Invoke((MethodInvoker)(() => labDataStatus.Text = ex.ToString()));
                return;
            }
            Invoke((MethodInvoker)(() => labDataStatus.BackColor = Color.FromKnownColor(KnownColor.Transparent)));
            Invoke((MethodInvoker)(() => labDataStatus.Text = ""));
        }

        /// <summary>
        /// コマンドリクエスト（タイマーイベント）
        /// </summary>
        private void timer1_Tick(object sender, EventArgs e)
        {
            //ログ制限
            string[] TextAreas = texRcv.Text.Split('\n');
            if (TextAreas.Count() > 50)
            {
                texRcv.Text = "";
                string tmp = "";
                for (int i = TextAreas.Count() - 50; i < TextAreas.Count(); i++)
                {
                    tmp += TextAreas[i].Replace("\r", "\r\n");
                }
                texRcv.AppendText(tmp);
            }

            //コマンド送信
            try
            {
                Byte[] dat = System.Text.Encoding.ASCII.GetBytes("d");
                serialPort1.Write(dat, 0, dat.GetLength(0));
            }
            catch
            {
                labDataStatus.BackColor = Color.Red;
                labDataStatus.Text = "リクエスト送信エラー";

                //COM再接続
                try
                {
                    if (serialPort1.IsOpen == true) serialPort1.Close();
                    serialPort1.Open();
                }
                catch { }
                return;
            }
            labDataStatus.BackColor = Color.Yellow;
            labDataStatus.Text = "リクエスト送信";
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            notifyIcon1.Visible = false;
            timer1.Enabled = false;
            serialPort1.Close();
            Serial_connect_status(false);
        }

        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            Form_View(true);
        }

        private void butEnd_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void butStationary_Click(object sender, EventArgs e)
        {
            Form_View(false);
        }

        private void cheAutoRun_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default["AutoRun"] = cheAutoRun.Checked;
            Properties.Settings.Default.Save();
        }

        private void texMachineName_TextChanged(object sender, EventArgs e)
        {
            texMachineName.Text = texMachineName.Text.Trim();
            Properties.Settings.Default["MachineName"] = texMachineName.Text;
            Properties.Settings.Default.Save();
        }

        private void texApiAddress_TextChanged(object sender, EventArgs e)
        {

            texApiAddress.Text = texApiAddress.Text.Trim();
            Properties.Settings.Default["ApiAddress"] = texApiAddress.Text;
            Properties.Settings.Default.Save();
        }

        private void numInterval_ValueChanged(object sender, EventArgs e)
        {
            timer1.Interval = (int)numInterval.Value * 1000;
            Properties.Settings.Default["Interval"] = (int)numInterval.Value;
            Properties.Settings.Default.Save();
        }
    }
}
