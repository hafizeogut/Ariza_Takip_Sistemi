namespace ArizaTakipSistemi
{
    partial class frmGirisEkrani
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGirisEkrani));
            this.btnGirisYap = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKullaniciAd = new System.Windows.Forms.TextBox();
            this.txtKullaniciEmail = new System.Windows.Forms.TextBox();
            this.tmrZaman = new System.Windows.Forms.Timer(this.components);
            this.ssAlt = new System.Windows.Forms.StatusStrip();
            this.tsslBir = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslTarih = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslIki = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslSaat = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslUc = new System.Windows.Forms.ToolStripStatusLabel();
            this.msUst = new System.Windows.Forms.MenuStrip();
            this.menüToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yardımToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iletişimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.niSimge = new System.Windows.Forms.NotifyIcon(this.components);
            this.cmsMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.çıkToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.iletişimToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pbResim = new System.Windows.Forms.PictureBox();
            this.ssAlt.SuspendLayout();
            this.msUst.SuspendLayout();
            this.cmsMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbResim)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGirisYap
            // 
            this.btnGirisYap.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnGirisYap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGirisYap.FlatAppearance.BorderSize = 0;
            this.btnGirisYap.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnGirisYap.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnGirisYap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGirisYap.Location = new System.Drawing.Point(375, 365);
            this.btnGirisYap.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGirisYap.Name = "btnGirisYap";
            this.btnGirisYap.Size = new System.Drawing.Size(90, 95);
            this.btnGirisYap.TabIndex = 2;
            this.btnGirisYap.UseVisualStyleBackColor = false;
            this.btnGirisYap.Click += new System.EventHandler(this.btnGirisYap_Click);
            this.btnGirisYap.MouseEnter += new System.EventHandler(this.btnGirisYap_MouseEnter);
            this.btnGirisYap.MouseLeave += new System.EventHandler(this.btnGirisYap_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(293, 308);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "KULLANICI ADI : ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(265, 338);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "KULLANICI ŞİFRESİ : ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtKullaniciAd
            // 
            this.txtKullaniciAd.Location = new System.Drawing.Point(414, 305);
            this.txtKullaniciAd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtKullaniciAd.Name = "txtKullaniciAd";
            this.txtKullaniciAd.Size = new System.Drawing.Size(116, 22);
            this.txtKullaniciAd.TabIndex = 0;
            this.txtKullaniciAd.Text = "emily_davis";
            this.txtKullaniciAd.TextChanged += new System.EventHandler(this.txtKullaniciAd_TextChanged);
            // 
            // txtKullaniciEmail
            // 
            this.txtKullaniciEmail.Location = new System.Drawing.Point(414, 335);
            this.txtKullaniciEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtKullaniciEmail.Name = "txtKullaniciEmail";
            this.txtKullaniciEmail.Size = new System.Drawing.Size(116, 22);
            this.txtKullaniciEmail.TabIndex = 1;
            this.txtKullaniciEmail.Text = "1234emily.davis@example.com";
            this.txtKullaniciEmail.TextChanged += new System.EventHandler(this.txtKullaniciSifre_TextChanged);
            // 
            // tmrZaman
            // 
            this.tmrZaman.Interval = 1000;
            this.tmrZaman.Tick += new System.EventHandler(this.tmrZaman_Tick);
            // 
            // ssAlt
            // 
            this.ssAlt.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslBir,
            this.tsslTarih,
            this.tsslIki,
            this.tsslSaat,
            this.tsslUc});
            this.ssAlt.Location = new System.Drawing.Point(0, 539);
            this.ssAlt.Name = "ssAlt";
            this.ssAlt.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.ssAlt.Size = new System.Drawing.Size(784, 22);
            this.ssAlt.TabIndex = 5;
            this.ssAlt.Text = "statusStrip1";
            // 
            // tsslBir
            // 
            this.tsslBir.Name = "tsslBir";
            this.tsslBir.Size = new System.Drawing.Size(32, 17);
            this.tsslBir.Text = "-----";
            // 
            // tsslTarih
            // 
            this.tsslTarih.Name = "tsslTarih";
            this.tsslTarih.Size = new System.Drawing.Size(39, 17);
            this.tsslTarih.Text = "TARİH";
            // 
            // tsslIki
            // 
            this.tsslIki.Name = "tsslIki";
            this.tsslIki.Size = new System.Drawing.Size(32, 17);
            this.tsslIki.Text = "-----";
            // 
            // tsslSaat
            // 
            this.tsslSaat.Name = "tsslSaat";
            this.tsslSaat.Size = new System.Drawing.Size(34, 17);
            this.tsslSaat.Text = "SAAT";
            // 
            // tsslUc
            // 
            this.tsslUc.Name = "tsslUc";
            this.tsslUc.Size = new System.Drawing.Size(32, 17);
            this.tsslUc.Text = "-----";
            // 
            // msUst
            // 
            this.msUst.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menüToolStripMenuItem,
            this.yardımToolStripMenuItem});
            this.msUst.Location = new System.Drawing.Point(0, 0);
            this.msUst.Name = "msUst";
            this.msUst.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.msUst.Size = new System.Drawing.Size(784, 24);
            this.msUst.TabIndex = 6;
            this.msUst.Text = "menuStrip1";
            this.msUst.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.msUst_ItemClicked);
            // 
            // menüToolStripMenuItem
            // 
            this.menüToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.çıkToolStripMenuItem});
            this.menüToolStripMenuItem.Name = "menüToolStripMenuItem";
            this.menüToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menüToolStripMenuItem.Text = "Menü";
            this.menüToolStripMenuItem.Click += new System.EventHandler(this.menüToolStripMenuItem_Click);
            // 
            // çıkToolStripMenuItem
            // 
            this.çıkToolStripMenuItem.Name = "çıkToolStripMenuItem";
            this.çıkToolStripMenuItem.Size = new System.Drawing.Size(91, 22);
            this.çıkToolStripMenuItem.Text = "Çık";
            this.çıkToolStripMenuItem.Click += new System.EventHandler(this.çıkToolStripMenuItem_Click);
            // 
            // yardımToolStripMenuItem
            // 
            this.yardımToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iletişimToolStripMenuItem});
            this.yardımToolStripMenuItem.Name = "yardımToolStripMenuItem";
            this.yardımToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.yardımToolStripMenuItem.Text = "Yardım";
            // 
            // iletişimToolStripMenuItem
            // 
            this.iletişimToolStripMenuItem.Name = "iletişimToolStripMenuItem";
            this.iletişimToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.iletişimToolStripMenuItem.Text = "İletişim";
            this.iletişimToolStripMenuItem.Click += new System.EventHandler(this.iletişimToolStripMenuItem_Click);
            // 
            // niSimge
            // 
            this.niSimge.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.niSimge.BalloonTipText = "Uyarı";
            this.niSimge.BalloonTipTitle = "Uyarı";
            this.niSimge.ContextMenuStrip = this.cmsMenu;
            this.niSimge.Icon = ((System.Drawing.Icon)(resources.GetObject("niSimge.Icon")));
            this.niSimge.Text = "Arıza Takip Sistemi";
            this.niSimge.Visible = true;
            // 
            // cmsMenu
            // 
            this.cmsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.çıkToolStripMenuItem2,
            this.iletişimToolStripMenuItem1});
            this.cmsMenu.Name = "cmsMenu";
            this.cmsMenu.Size = new System.Drawing.Size(113, 48);
            // 
            // çıkToolStripMenuItem2
            // 
            this.çıkToolStripMenuItem2.Name = "çıkToolStripMenuItem2";
            this.çıkToolStripMenuItem2.Size = new System.Drawing.Size(112, 22);
            this.çıkToolStripMenuItem2.Text = "Çık";
            this.çıkToolStripMenuItem2.Click += new System.EventHandler(this.çıkToolStripMenuItem2_Click);
            // 
            // iletişimToolStripMenuItem1
            // 
            this.iletişimToolStripMenuItem1.Name = "iletişimToolStripMenuItem1";
            this.iletişimToolStripMenuItem1.Size = new System.Drawing.Size(112, 22);
            this.iletişimToolStripMenuItem1.Text = "İletişim";
            this.iletişimToolStripMenuItem1.Click += new System.EventHandler(this.iletişimToolStripMenuItem1_Click);
            // 
            // pbResim
            // 
            this.pbResim.BackColor = System.Drawing.Color.Transparent;
            this.pbResim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbResim.Cursor = System.Windows.Forms.Cursors.PanWest;
            this.pbResim.Location = new System.Drawing.Point(280, 47);
            this.pbResim.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbResim.Name = "pbResim";
            this.pbResim.Size = new System.Drawing.Size(250, 250);
            this.pbResim.TabIndex = 7;
            this.pbResim.TabStop = false;
            // 
            // frmGirisEkrani
            // 
            this.AcceptButton = this.btnGirisYap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.pbResim);
            this.Controls.Add(this.ssAlt);
            this.Controls.Add(this.msUst);
            this.Controls.Add(this.txtKullaniciEmail);
            this.Controls.Add(this.txtKullaniciAd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGirisYap);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "frmGirisEkrani";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GİRİŞ EKRANI";
            this.Load += new System.EventHandler(this.frmGirisEkrani_Load);
            this.ssAlt.ResumeLayout(false);
            this.ssAlt.PerformLayout();
            this.msUst.ResumeLayout(false);
            this.msUst.PerformLayout();
            this.cmsMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbResim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGirisYap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKullaniciAd;
        private System.Windows.Forms.TextBox txtKullaniciEmail;
        private System.Windows.Forms.Timer tmrZaman;
        private System.Windows.Forms.StatusStrip ssAlt;
        private System.Windows.Forms.MenuStrip msUst;
        private System.Windows.Forms.PictureBox pbResim;
        private System.Windows.Forms.ToolStripStatusLabel tsslBir;
        private System.Windows.Forms.ToolStripStatusLabel tsslTarih;
        private System.Windows.Forms.ToolStripStatusLabel tsslIki;
        private System.Windows.Forms.ToolStripStatusLabel tsslSaat;
        private System.Windows.Forms.ToolStripStatusLabel tsslUc;
        private System.Windows.Forms.ToolStripMenuItem menüToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yardımToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iletişimToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon niSimge;
        private System.Windows.Forms.ContextMenuStrip cmsMenu;
        private System.Windows.Forms.ToolStripMenuItem çıkToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem iletişimToolStripMenuItem1;
    }
}

