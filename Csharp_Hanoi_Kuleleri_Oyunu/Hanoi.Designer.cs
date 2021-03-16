namespace Csharp_Hanoi_Kuleleri_Oyunu
{
    partial class Hanoi
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.StatusStrip statusStrip1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hanoi));
            this.StlHamleSayisi = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.cB1 = new System.Windows.Forms.ComboBox();
            this.bYeniOyun = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.p1 = new System.Windows.Forms.Panel();
            this.p3 = new System.Windows.Forms.Panel();
            this.p2 = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsmYeniOyun = new System.Windows.Forms.ToolStripLabel();
            this.tsmHizliCikis = new System.Windows.Forms.ToolStripLabel();
            this.timer_sure = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.timer_otoMod = new System.Windows.Forms.Timer(this.components);
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            statusStrip1 = new System.Windows.Forms.StatusStrip();
            statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            statusStrip1.Enabled = false;
            statusStrip1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StlHamleSayisi,
            this.toolStripStatusLabel2});
            statusStrip1.Location = new System.Drawing.Point(0, 356);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new System.Drawing.Size(684, 22);
            statusStrip1.TabIndex = 3;
            statusStrip1.Text = "statusStrip1";
            // 
            // StlHamleSayisi
            // 
            this.StlHamleSayisi.BackColor = System.Drawing.Color.Transparent;
            this.StlHamleSayisi.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StlHamleSayisi.ForeColor = System.Drawing.Color.Cornsilk;
            this.StlHamleSayisi.Margin = new System.Windows.Forms.Padding(10, 0, 325, 0);
            this.StlHamleSayisi.Name = "StlHamleSayisi";
            this.StlHamleSayisi.Size = new System.Drawing.Size(96, 22);
            this.StlHamleSayisi.Text = "StlHamleSayisi";
            this.StlHamleSayisi.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(32, 19);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(32, 19);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.toolStripStatusLabel1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(10, 17);
            this.toolStripStatusLabel1.Text = " ";
            // 
            // cB1
            // 
            this.cB1.BackColor = System.Drawing.Color.DarkGray;
            this.cB1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cB1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cB1.Items.AddRange(new object[] {
            "5"});
            this.cB1.Location = new System.Drawing.Point(551, 35);
            this.cB1.Name = "cB1";
            this.cB1.Size = new System.Drawing.Size(129, 31);
            this.cB1.TabIndex = 8;
            this.cB1.SelectedIndexChanged += new System.EventHandler(this.CB1_SelectedIndexChanged);
            // 
            // bYeniOyun
            // 
            this.bYeniOyun.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.bYeniOyun.BackgroundImage = global::Csharp_Hanoi_Kuleleri_Oyunu.Properties.Resources.images;
            this.bYeniOyun.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bYeniOyun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bYeniOyun.ForeColor = System.Drawing.Color.Cornsilk;
            this.bYeniOyun.Location = new System.Drawing.Point(12, 32);
            this.bYeniOyun.Name = "bYeniOyun";
            this.bYeniOyun.Size = new System.Drawing.Size(124, 34);
            this.bYeniOyun.TabIndex = 9;
            this.bYeniOyun.Text = "Oyna";
            this.bYeniOyun.UseVisualStyleBackColor = false;
            this.bYeniOyun.Click += new System.EventHandler(this.bYeniOyun_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Cornsilk;
            this.label1.Location = new System.Drawing.Point(440, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 23);
            this.label1.TabIndex = 10;
            this.label1.Text = "Halka Sayısı:";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // p1
            // 
            this.p1.AllowDrop = true;
            this.p1.BackColor = System.Drawing.Color.Transparent;
            this.p1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p1.BackgroundImage")));
            this.p1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.p1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.p1.Location = new System.Drawing.Point(13, 81);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(185, 285);
            this.p1.TabIndex = 11;
            this.p1.DragDrop += new System.Windows.Forms.DragEventHandler(this.p_DragDrop);
            this.p1.DragOver += new System.Windows.Forms.DragEventHandler(this.p_DragOver);
            // 
            // p3
            // 
            this.p3.AllowDrop = true;
            this.p3.BackColor = System.Drawing.Color.Transparent;
            this.p3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p3.BackgroundImage")));
            this.p3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.p3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.p3.Location = new System.Drawing.Point(382, 81);
            this.p3.Name = "p3";
            this.p3.Size = new System.Drawing.Size(185, 285);
            this.p3.TabIndex = 12;
            this.p3.DragDrop += new System.Windows.Forms.DragEventHandler(this.p_DragDrop);
            this.p3.DragOver += new System.Windows.Forms.DragEventHandler(this.p_DragOver);
            // 
            // p2
            // 
            this.p2.AllowDrop = true;
            this.p2.BackColor = System.Drawing.Color.Transparent;
            this.p2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p2.BackgroundImage")));
            this.p2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.p2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.p2.Location = new System.Drawing.Point(197, 81);
            this.p2.Name = "p2";
            this.p2.Size = new System.Drawing.Size(185, 285);
            this.p2.TabIndex = 12;
            this.p2.DragDrop += new System.Windows.Forms.DragEventHandler(this.p_DragDrop);
            this.p2.DragOver += new System.Windows.Forms.DragEventHandler(this.p_DragOver);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmYeniOyun,
            this.tsmHizliCikis});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(684, 25);
            this.toolStrip1.TabIndex = 13;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsmYeniOyun
            // 
            this.tsmYeniOyun.ActiveLinkColor = System.Drawing.Color.SteelBlue;
            this.tsmYeniOyun.BackColor = System.Drawing.SystemColors.Window;
            this.tsmYeniOyun.ForeColor = System.Drawing.Color.Wheat;
            this.tsmYeniOyun.IsLink = true;
            this.tsmYeniOyun.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.tsmYeniOyun.LinkColor = System.Drawing.Color.Cornsilk;
            this.tsmYeniOyun.Name = "tsmYeniOyun";
            this.tsmYeniOyun.Size = new System.Drawing.Size(61, 22);
            this.tsmYeniOyun.Text = "Yeni Oyun";
            this.tsmYeniOyun.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            // 
            // tsmHizliCikis
            // 
            this.tsmHizliCikis.ActiveLinkColor = System.Drawing.Color.SteelBlue;
            this.tsmHizliCikis.BackColor = System.Drawing.SystemColors.Window;
            this.tsmHizliCikis.ForeColor = System.Drawing.Color.Wheat;
            this.tsmHizliCikis.IsLink = true;
            this.tsmHizliCikis.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.tsmHizliCikis.LinkColor = System.Drawing.Color.Cornsilk;
            this.tsmHizliCikis.Name = "tsmHizliCikis";
            this.tsmHizliCikis.Size = new System.Drawing.Size(58, 22);
            this.tsmHizliCikis.Text = "Hızlı Çıkış";
            this.tsmHizliCikis.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            // 
            // timer_sure
            // 
            this.timer_sure.Interval = 1000;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 10.25F);
            this.groupBox1.ForeColor = System.Drawing.Color.Cornsilk;
            this.groupBox1.Location = new System.Drawing.Point(572, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(108, 281);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hamleleriniz";
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.Azure;
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.Font = new System.Drawing.Font("Times New Roman", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 19;
            this.listBox1.Location = new System.Drawing.Point(3, 20);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(102, 258);
            this.listBox1.TabIndex = 0;
            // 
            // timer_otoMod
            // 
            this.timer_otoMod.Interval = 500;
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(149, 17);
            this.toolStripStatusLabel2.Text = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Click += new System.EventHandler(this.toolStripStatusLabel2_Click);
            // 
            // Hanoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(684, 378);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bYeniOyun);
            this.Controls.Add(this.cB1);
            this.Controls.Add(statusStrip1);
            this.Controls.Add(this.p3);
            this.Controls.Add(this.p2);
            this.Controls.Add(this.p1);
            this.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Hanoi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hanoi Kulesi";
            this.Load += new System.EventHandler(this.Form_Uygulama_Load);
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ComboBox cB1;
        private System.Windows.Forms.Button bYeniOyun;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel p1;
        private System.Windows.Forms.Panel p3;
        private System.Windows.Forms.Panel p2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel tsmHizliCikis;
        private System.Windows.Forms.ToolStripLabel tsmYeniOyun;
        private System.Windows.Forms.ToolStripStatusLabel StlHamleSayisi;
        private System.Windows.Forms.Timer timer_sure;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Timer timer_otoMod;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
    }
}