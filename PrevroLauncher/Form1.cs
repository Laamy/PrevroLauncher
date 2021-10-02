using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
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

        private void mouseEnter(object sender, EventArgs e) => ((Panel)sender).BackColor = Color.FromArgb(255, 46, 46, 46);
        private void mouseLeave(object sender, EventArgs e) => ((Panel)sender).BackColor = Color.FromArgb(255, 38, 38, 38);
        private void mousePress(object sender, EventArgs e)
        {
            var pan = (Panel)sender;
            foreach (Control ctn in pan.Controls)
            {
                switch (ctn.Tag.ToString())
                {
                    case "ClientName":
                        curClientName.Text = ctn.Text;
                        break;
                    case "ClientVersion":
                        curClientVersion.Text = ctn.Text;
                        break;
                    case "ClientIcon":

                        var url = ctn.Name.Split(',');

                        string cra = $"{url[1]}";

                        if (!File.Exists("data\\" + cra))
                            wb.DownloadFile("https://raw.githubusercontent.com/Laamy/PrevroLauncher/master/PrevroLauncher/Resources/" + cra, "data\\" + cra);

                        curClientBanner.BackgroundImage = Image.FromFile("data\\" + cra);

                        curClientBanner.Tag = url[2];

                        discordData.Tag = url[3];

                        curClientName.Name = curClientName.Text + ".exe";

                        break;
                }
            }
        }

        WebClient wb = new WebClient();
        Random ran = new Random();

        private void Form1_Load(object sender, EventArgs e)
        {
            //Directory.Delete("data", true);
            Directory.CreateDirectory("data");

            var rawCache = wb.DownloadString("https://raw.githubusercontent.com/Laamy/PrevroLauncher/master/PrevroLauncher/PrevroCache.txt");
            var cachedClients = rawCache.Split('&');

            foreach (string str in cachedClients)
            {
                var subClientCache = str.Split(',');

                var btn = CloneableClientBtn.Clone(); // Create new instance of custom button

                var lbl3 = label3.Clone();

                lbl3.Click += subMousePress;
                lbl3.MouseEnter += subMouseEnter;
                lbl3.MouseLeave += subMouseLeave;

                btn.Controls.Add(lbl3);

                var lbl4 = label4.Clone();

                lbl4.Click += subMousePress;
                lbl4.MouseEnter += subMouseEnter;
                lbl4.MouseLeave += subMouseLeave;

                btn.Controls.Add(lbl4);

                var iconCtrl = pictureBox1.Clone();

                iconCtrl.Click += subMousePress;
                iconCtrl.MouseEnter += subMouseEnter;
                iconCtrl.MouseLeave += subMouseLeave;

                iconCtrl.Name = subClientCache[2] + "," + subClientCache[3] + "," + subClientCache[4] + "," + subClientCache[5];

                btn.Controls.Add(iconCtrl);

                if (!File.Exists("data\\" + subClientCache[2]))
                    wb.DownloadFile("https://raw.githubusercontent.com/Laamy/PrevroLauncher/master/PrevroLauncher/Resources/" + subClientCache[2], "data\\" + subClientCache[2]);

                foreach (Control ctn in btn.Controls)
                {
                    switch (ctn.Tag.ToString())
                    {
                        case "ClientName":
                            ctn.Text = subClientCache[0];
                            break;
                        case "ClientVersion":
                            ctn.Text = subClientCache[1];
                            break;
                        case "ClientIcon":
                            var newCtn = (PictureBox)ctn;
                            newCtn.BackgroundImage = Image.FromFile("data\\" + subClientCache[2]);
                            break;
                    }
                }

                btn.MouseEnter += mouseEnter;
                btn.MouseLeave += mouseLeave;
                btn.Click += mousePress;

                btn.Visible = true;

                clientList.Controls.Add(btn);
            }

            CloneableClientBtn.Dispose();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (curClientBanner.Tag.ToString() == "isNull")
                MessageBox.Show("This client is currently not released/privated sorry!");

            try
            {
                wb.DownloadFile(curClientBanner.Tag.ToString(), "data\\" + curClientName.Name);
                Process.Start("data\\" + curClientName.Name);
            }
            catch { }
        }

        private void discordData_Click(object sender, EventArgs e)
        {
            var discordLink = ((Button)sender).Tag.ToString();
            Clipboard.SetText(discordLink);
            MessageBox.Show(discordLink, "Copied to clipboard!");
        }

        private void subMouseEnter(object sender, EventArgs e) => mouseEnter(((Control)sender).Parent, e);
        private void subMouseLeave(object sender, EventArgs e) => mouseLeave(((Control)sender).Parent, e);
        private void subMousePress(object sender, EventArgs e) => mousePress(((Control)sender).Parent, e);
    }
}
