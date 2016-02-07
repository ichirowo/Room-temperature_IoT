using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;


namespace room_temperature
{
    partial class Form1
    {
        private void Serial_connect_status(bool Serial_connect)
        {
            if (Serial_connect)
            {
                //シリアル接続中
                labComStatus.BackColor = Color.YellowGreen;
                labComStatus.Text = "接続中";
                comComPort.Enabled = false;
                butComConnect.Enabled = false;
                butComDisconnect.Enabled = true;
                texMachineName.Enabled = false;
                texApiAddress.Enabled = false;
                numInterval.Enabled = false;
            }
            else
            {
                //シリアル切断中
                labComStatus.BackColor = Color.FromKnownColor(KnownColor.Transparent);
                labComStatus.Text = "";
                comComPort.Enabled = true;
                butComConnect.Enabled = true;
                butComDisconnect.Enabled = false;
                texMachineName.Enabled = true;
                texApiAddress.Enabled = true;
                numInterval.Enabled = true;
            }

            labDataStatus.BackColor = Color.FromKnownColor(KnownColor.Transparent);
            labDataStatus.Text = "";

        }

        private void Form_View(bool View)
        {
            if (View)
            {
                this.ShowInTaskbar = true;
                //this.Show();
                this.Visible = true;
            }
            else
            {
                this.ShowInTaskbar = false;
                //this.Hide();
                this.Visible = false;
            }
        }


        private bool ComConnect()
        {
            if (comComPort.Text == "")
            {
                labComStatus.Text = "ポートを選択してください";
                return false;
            }

            try
            {
                //COMオープン
                serialPort1.PortName = comComPort.Text;
                if (serialPort1.IsOpen == true) serialPort1.Close();
                serialPort1.Open();
            }
            catch (Exception ex)
            {
                labComStatus.BackColor = Color.Red;
                labComStatus.Text = ex.Message;
                return false;
            }

            Serial_connect_status(true);
            serialPort1.DtrEnable = true;
            timer1.Enabled = true;
            return true;
        }



        
    }
}
