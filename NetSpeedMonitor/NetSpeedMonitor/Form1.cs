﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Runtime.InteropServices;

namespace NetSpeedMonitor
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);
        public const int WM_SYSCOMMAND = 0x0112;
        public const int SC_MOVE = 0xF010;
        public const int HTCAPTION = 0x0002;


        private void MainForm_Load(object sender, EventArgs e)
        {
            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            float netRecv = NetMonitorCore.GetNetRecv();
            float netSend = NetMonitorCore.GetNetSend();

            string netRecvText = "";
            string netSendText = "";

            if (netRecv < 1024)
            {
                netRecvText = netRecv.ToString("0.00") + "B";
            }
            else if (netRecv >= 1024 && netRecv < 1024 * 1024)
            {
                netRecvText = (netRecv / 1024).ToString("0.00") + "KB";
            }
            else if (netRecv >= 1024 * 1024)
            {
                netRecvText = (netRecv / (1024 * 1024)).ToString("0.00") + "MB";
            }

            if (netSend < 1024)
            {
                netSendText = netSend.ToString("0.00") + "B";
            }
            else if (netSend >= 1024 && netSend < 1024 * 1024)
            {
                netSendText = (netSend / 1024).ToString("0.00") + "KB";
            }
            else if (netSend >= 1024 * 1024)
            {
                netSendText = (netSend / (1024 * 1024)).ToString("0.00") + "MB";
            }

            labelUploadSpeed.Text = netSendText;
            //label2.Text = netRecvText;
        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
        }
    }
}


