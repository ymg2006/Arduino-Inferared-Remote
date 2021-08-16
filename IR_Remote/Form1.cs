using System;
using System.Windows.Forms;
using System.IO.Ports;
using System.Collections.Generic;
using MyExtentions.HWInfo;

namespace IR_Remote
{
    public partial class Form1 : Form
    {
        SerialPort _serial = new SerialPort();
        private static List<int> _rec = new List<int>();
        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (COMPortInfo comPort in COMPortInfo.GetCOMPortsInfo())
            {
                cmb_sPort.Items.Add(string.Format("{0}", comPort.Description));
                if (comPort.Description.Contains("Arduino"))
                {
                    cmb_sPort.SelectedItem = comPort.Description;
                }
            }
        }

        private void cmb_sPort_DropDown(object sender, EventArgs e)
        {
            cmb_sPort.Items.Clear();
            foreach (COMPortInfo comPort in COMPortInfo.GetCOMPortsInfo())
            {
                cmb_sPort.Items.Add(string.Format("{0}", comPort.Description));
                if (comPort.Description.Contains("Arduino"))
                {
                    cmb_sPort.SelectedItem = comPort.Description;
                }
            }
        }
        private void btn_startLearn_Click(object sender, EventArgs e)
        {
            if (btn_startLearn.Text == "Fetch IR")
            {
                _serial.Write("Learn.");
                btn_send.Enabled = false;
                btn_startLearn.Text = "Stop";
            }
            else if (btn_startLearn.Text == "Stop") {
                btn_send.Enabled = true;
                btn_startLearn.Text = "Fetch IR";
            }
        }
        private void connection_events(bool connected)
        {
            if (connected == true)
            {
                cmb_sPort.Enabled = false;
                btn_startLearn.Enabled = true;
                btn_send.Enabled = true;
                btn_connect.Text = "Disconnect";
            }
            else if (connected == false)
            {
                cmb_sPort.Enabled = true;
                btn_startLearn.Enabled = false;
                btn_send.Enabled = false;
                btn_connect.Text = "Connect";
            }
        }
        private void btn_connect_Click(object sender, EventArgs e)
        {
            if (btn_connect.Text == "Connect")
            {
                try
                {
                    _serial.PortName = cmb_sPort.SelectedItem.ToString().Split('(', ')')[1];
                    _serial.BaudRate = 9600;
                    _serial.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
                    _serial.Open();
                    lbl_toolStrip.Text = cmb_sPort.SelectedItem.ToString() + " connected successfully";
                    connection_events(true);
                }
                catch (Exception)
                {
                    throw;
                }
            }
            else if (btn_connect.Text == "Disconnect")
            {
                try
                {
                    _serial.Close();
                    lbl_toolStrip.Text = "Disconnected successfully";
                    connection_events(false);
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            string recieved = sp.ReadLine().ToString();
            int tryget;
            if (int.TryParse(recieved, out tryget)){
                _rec.Add(tryget);
            }
            textBox.AppendText(recieved);
            if (recieved.Contains("Fin")){
                btn_send.Enabled = true;
                btn_startLearn.Text = "Fetch IR";
                sp.Write("#");
            }
        }
        private void btn_cls_Click(object sender, EventArgs e)
        {
            _rec.Clear();
            textBox.Clear();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                _serial.Close();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            if (btn_send.Text == "Send IR")
            {
                //if (_rec.Count != 0)
                //{
                    _serial.Write("Send.");
                //}
                btn_startLearn.Enabled = false;
                btn_send.Text = "Stop";
            }
            else if (btn_send.Text == "Stop")
            {
                btn_startLearn.Enabled = true;
                btn_send.Text = "Send IR";
            }
        }
    }
}
