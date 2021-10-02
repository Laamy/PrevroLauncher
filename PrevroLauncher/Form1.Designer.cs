
namespace PrevroLauncher
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel6 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.clientList = new System.Windows.Forms.Panel();
            this.CloneableClientBtn = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.curClientBanner = new System.Windows.Forms.PictureBox();
            this.curClientName = new System.Windows.Forms.Label();
            this.curClientVersion = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6.SuspendLayout();
            this.clientList.SuspendLayout();
            this.CloneableClientBtn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.curClientBanner)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.panel6.Controls.Add(this.label8);
            this.panel6.Controls.Add(this.label7);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(700, 24);
            this.panel6.TabIndex = 4;
            this.panel6.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel6_MouseMove);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label8.Dock = System.Windows.Forms.DockStyle.Right;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(664, 0);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label8.Size = new System.Drawing.Size(18, 24);
            this.label8.TabIndex = 1;
            this.label8.Text = "_";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label8.Click += new System.EventHandler(this.label8_Click);
            this.label8.MouseEnter += new System.EventHandler(this.label8_MouseEnter);
            this.label8.MouseLeave += new System.EventHandler(this.label8_MouseLeave);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label7.Dock = System.Windows.Forms.DockStyle.Right;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(682, 0);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(18, 24);
            this.label7.TabIndex = 0;
            this.label7.Text = "X";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label7.Click += new System.EventHandler(this.label7_Click);
            this.label7.MouseEnter += new System.EventHandler(this.label8_MouseEnter);
            this.label7.MouseLeave += new System.EventHandler(this.label8_MouseLeave);
            // 
            // clientList
            // 
            this.clientList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.clientList.Controls.Add(this.CloneableClientBtn);
            this.clientList.Dock = System.Windows.Forms.DockStyle.Left;
            this.clientList.Location = new System.Drawing.Point(0, 24);
            this.clientList.Name = "clientList";
            this.clientList.Size = new System.Drawing.Size(202, 408);
            this.clientList.TabIndex = 5;
            // 
            // CloneableClientBtn
            // 
            this.CloneableClientBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.CloneableClientBtn.Controls.Add(this.label4);
            this.CloneableClientBtn.Controls.Add(this.label3);
            this.CloneableClientBtn.Controls.Add(this.pictureBox1);
            this.CloneableClientBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.CloneableClientBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.CloneableClientBtn.Location = new System.Drawing.Point(0, 0);
            this.CloneableClientBtn.Name = "CloneableClientBtn";
            this.CloneableClientBtn.Size = new System.Drawing.Size(202, 65);
            this.CloneableClientBtn.TabIndex = 1;
            this.CloneableClientBtn.Click += new System.EventHandler(this.mousePress);
            this.CloneableClientBtn.MouseEnter += new System.EventHandler(this.mouseEnter);
            this.CloneableClientBtn.MouseLeave += new System.EventHandler(this.mouseLeave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(58, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 15);
            this.label4.TabIndex = 3;
            this.label4.Tag = "ClientVersion";
            this.label4.Text = "v1.17.32.1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(58, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 2;
            this.label3.Tag = "ClientName";
            this.label3.Text = "Trero";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::PrevroLauncher.Properties.Resources.TreroBackground1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "ClientIcon";
            // 
            // panel7
            // 
            this.panel7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.panel7.Location = new System.Drawing.Point(202, 416);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(482, 16);
            this.panel7.TabIndex = 7;
            // 
            // curClientBanner
            // 
            this.curClientBanner.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.curClientBanner.BackgroundImage = global::PrevroLauncher.Properties.Resources.Polish_20210919_055658411;
            this.curClientBanner.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.curClientBanner.Location = new System.Drawing.Point(0, 67);
            this.curClientBanner.Name = "curClientBanner";
            this.curClientBanner.Size = new System.Drawing.Size(498, 254);
            this.curClientBanner.TabIndex = 4;
            this.curClientBanner.TabStop = false;
            // 
            // curClientName
            // 
            this.curClientName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.curClientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.curClientName.ForeColor = System.Drawing.SystemColors.Control;
            this.curClientName.Location = new System.Drawing.Point(147, 22);
            this.curClientName.Name = "curClientName";
            this.curClientName.Size = new System.Drawing.Size(211, 29);
            this.curClientName.TabIndex = 0;
            this.curClientName.Text = "Trero";
            this.curClientName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // curClientVersion
            // 
            this.curClientVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.curClientVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.curClientVersion.ForeColor = System.Drawing.SystemColors.Control;
            this.curClientVersion.Location = new System.Drawing.Point(149, 48);
            this.curClientVersion.Name = "curClientVersion";
            this.curClientVersion.Size = new System.Drawing.Size(209, 16);
            this.curClientVersion.TabIndex = 1;
            this.curClientVersion.Text = "v1.17.32.1";
            this.curClientVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(58)))), ((int)(((byte)(212)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Sylfaen", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(224)))), ((int)(((byte)(221)))));
            this.button1.Location = new System.Drawing.Point(157, 292);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(191, 54);
            this.button1.TabIndex = 2;
            this.button1.Text = "Launch";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.panel4.Controls.Add(this.button1);
            this.panel4.Controls.Add(this.curClientVersion);
            this.panel4.Controls.Add(this.curClientName);
            this.panel4.Controls.Add(this.curClientBanner);
            this.panel4.Location = new System.Drawing.Point(202, 24);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(498, 392);
            this.panel4.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(700, 432);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.clientList);
            this.Controls.Add(this.panel6);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(900, 532);
            this.MinimumSize = new System.Drawing.Size(700, 432);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Prevro";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel6.ResumeLayout(false);
            this.clientList.ResumeLayout(false);
            this.CloneableClientBtn.ResumeLayout(false);
            this.CloneableClientBtn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.curClientBanner)).EndInit();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel clientList;
        private System.Windows.Forms.Panel CloneableClientBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.PictureBox curClientBanner;
        private System.Windows.Forms.Label curClientName;
        private System.Windows.Forms.Label curClientVersion;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
    }
}

