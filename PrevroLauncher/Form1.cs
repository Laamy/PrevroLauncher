﻿using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace PrevroLauncher
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll")] static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")] static extern bool ReleaseCapture();

        public Form1() => InitializeComponent();
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x84:
                    base.WndProc(ref m);
                    Point pos = new Point(m.LParam.ToInt32());
                    pos = this.PointToClient(pos);
                    if (pos.Y < 32)
                    {
                        m.Result = (IntPtr)2;
                        return;
                    }
                    if (pos.X >= this.ClientSize.Width - 16 && pos.Y >= this.ClientSize.Height - 16)
                    {
                        m.Result = (IntPtr)17;
                        return;
                    }
                    return;
                default:
                    base.WndProc(ref m);
                    return;
            }
        }

        private void panel6_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, 0xA1, 0x2, 0);
            }
        }

        private void label8_MouseEnter(object sender, EventArgs e) => ((Label)sender).ForeColor = Color.FromArgb(255, 40, 40, 40);
        private void label8_MouseLeave(object sender, EventArgs e) => ((Label)sender).ForeColor = Color.FromArgb(255, 255, 255, 255);

        private void label7_Click(object sender, EventArgs e) => Application.Exit();
        private void label8_Click(object sender, EventArgs e) => WindowState = FormWindowState.Minimized;
    }
}