namespace ArizaTakipSistemi
{
    partial class frmKullaniciEkrani
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKullaniciEkrani));
            this.tmrZaman = new System.Windows.Forms.Timer(this.components);
            this.ssAlt = new System.Windows.Forms.StatusStrip();
            this.tsslBir = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslHosgeldiniz = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslIki = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslTarih = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslUc = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslSaat = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslDort = new System.Windows.Forms.ToolStripStatusLabel();
            this.msUst = new System.Windows.Forms.MenuStrip();
            this.menüToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yardımToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iletişimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbBilgiler = new System.Windows.Forms.GroupBox();
            this.btnArizaGonder = new System.Windows.Forms.Button();
            this.lblTur = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblKullaniciAd = new System.Windows.Forms.Label();
            this.lblIsim = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvAriza = new System.Windows.Forms.DataGridView();
            this.cmsMenuYenile = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.yenileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pArizaEkle = new System.Windows.Forms.Panel();
            this.txtAriza = new System.Windows.Forms.TextBox();
            this.txtDemirBasNo = new System.Windows.Forms.TextBox();
            this.btnArizaEkle = new System.Windows.Forms.Button();
            this.btnArizaEkleKapat = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.ssAlt.SuspendLayout();
            this.msUst.SuspendLayout();
            this.gbBilgiler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAriza)).BeginInit();
            this.cmsMenuYenile.SuspendLayout();
            this.pArizaEkle.SuspendLayout();
            this.SuspendLayout();
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
            this.tsslHosgeldiniz,
            this.tsslIki,
            this.tsslTarih,
            this.tsslUc,
            this.tsslSaat,
            this.tsslDort});
            this.ssAlt.Location = new System.Drawing.Point(0, 540);
            this.ssAlt.Name = "ssAlt";
            this.ssAlt.Size = new System.Drawing.Size(784, 22);
            this.ssAlt.TabIndex = 3;
            this.ssAlt.Text = "statusStrip1";
            // 
            // tsslBir
            // 
            this.tsslBir.Name = "tsslBir";
            this.tsslBir.Size = new System.Drawing.Size(32, 17);
            this.tsslBir.Text = "-----";
            // 
            // tsslHosgeldiniz
            // 
            this.tsslHosgeldiniz.ForeColor = System.Drawing.Color.Red;
            this.tsslHosgeldiniz.Name = "tsslHosgeldiniz";
            this.tsslHosgeldiniz.Size = new System.Drawing.Size(81, 17);
            this.tsslHosgeldiniz.Text = "HOŞGELDİNİZ";
            // 
            // tsslIki
            // 
            this.tsslIki.Name = "tsslIki";
            this.tsslIki.Size = new System.Drawing.Size(32, 17);
            this.tsslIki.Text = "-----";
            // 
            // tsslTarih
            // 
            this.tsslTarih.Name = "tsslTarih";
            this.tsslTarih.Size = new System.Drawing.Size(41, 17);
            this.tsslTarih.Text = "TARİH";
            // 
            // tsslUc
            // 
            this.tsslUc.Name = "tsslUc";
            this.tsslUc.Size = new System.Drawing.Size(32, 17);
            this.tsslUc.Text = "-----";
            // 
            // tsslSaat
            // 
            this.tsslSaat.Name = "tsslSaat";
            this.tsslSaat.Size = new System.Drawing.Size(36, 17);
            this.tsslSaat.Text = "SAAT";
            // 
            // tsslDort
            // 
            this.tsslDort.Name = "tsslDort";
            this.tsslDort.Size = new System.Drawing.Size(32, 17);
            this.tsslDort.Text = "-----";
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
            this.msUst.TabIndex = 7;
            this.msUst.Text = "menuStrip1";
            // 
            // menüToolStripMenuItem
            // 
            this.menüToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.çıkToolStripMenuItem});
            this.menüToolStripMenuItem.Name = "menüToolStripMenuItem";
            this.menüToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menüToolStripMenuItem.Text = "Menü";
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
            this.yardımToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.yardımToolStripMenuItem.Text = "Yardım";
            // 
            // iletişimToolStripMenuItem
            // 
            this.iletişimToolStripMenuItem.Name = "iletişimToolStripMenuItem";
            this.iletişimToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.iletişimToolStripMenuItem.Text = "İletişim";
            this.iletişimToolStripMenuItem.Click += new System.EventHandler(this.iletişimToolStripMenuItem_Click);
            // 
            // gbBilgiler
            // 
            this.gbBilgiler.Controls.Add(this.lblTur);
            this.gbBilgiler.Controls.Add(this.label4);
            this.gbBilgiler.Controls.Add(this.lblKullaniciAd);
            this.gbBilgiler.Controls.Add(this.lblIsim);
            this.gbBilgiler.Controls.Add(this.label3);
            this.gbBilgiler.Controls.Add(this.lblId);
            this.gbBilgiler.Controls.Add(this.label2);
            this.gbBilgiler.Controls.Add(this.label1);
            this.gbBilgiler.Location = new System.Drawing.Point(12, 81);
            this.gbBilgiler.Name = "gbBilgiler";
            this.gbBilgiler.Size = new System.Drawing.Size(760, 230);
            this.gbBilgiler.TabIndex = 8;
            this.gbBilgiler.TabStop = false;
            this.gbBilgiler.Text = "BİLGİLER";
            // 
            // btnArizaGonder
            // 
            this.btnArizaGonder.BackColor = System.Drawing.Color.Transparent;
            this.btnArizaGonder.BackgroundImage = global::ArizaTakipSistemi.Properties.Resources.buyuksimge;
            this.btnArizaGonder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnArizaGonder.FlatAppearance.BorderSize = 0;
            this.btnArizaGonder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArizaGonder.Location = new System.Drawing.Point(141, 3);
            this.btnArizaGonder.Name = "btnArizaGonder";
            this.btnArizaGonder.Size = new System.Drawing.Size(150, 150);
            this.btnArizaGonder.TabIndex = 22;
            this.btnArizaGonder.UseVisualStyleBackColor = false;
            this.btnArizaGonder.Click += new System.EventHandler(this.btnArizaGonder_Click);
            // 
            // lblTur
            // 
            this.lblTur.AutoSize = true;
            this.lblTur.Location = new System.Drawing.Point(122, 170);
            this.lblTur.Name = "lblTur";
            this.lblTur.Size = new System.Drawing.Size(44, 16);
            this.lblTur.TabIndex = 3;
            this.lblTur.Text = "TÜR : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(72, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "TÜR : ";
            // 
            // lblKullaniciAd
            // 
            this.lblKullaniciAd.AutoSize = true;
            this.lblKullaniciAd.Location = new System.Drawing.Point(122, 130);
            this.lblKullaniciAd.Name = "lblKullaniciAd";
            this.lblKullaniciAd.Size = new System.Drawing.Size(110, 16);
            this.lblKullaniciAd.TabIndex = 2;
            this.lblKullaniciAd.Text = "KULLANICI AD : ";
            // 
            // lblIsim
            // 
            this.lblIsim.AutoSize = true;
            this.lblIsim.Location = new System.Drawing.Point(122, 90);
            this.lblIsim.Name = "lblIsim";
            this.lblIsim.Size = new System.Drawing.Size(47, 16);
            this.lblIsim.TabIndex = 1;
            this.lblIsim.Text = "İSİM : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(6, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "KULLANICI AD : ";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(122, 50);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(32, 16);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "ID : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(69, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "İSİM : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(84, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID : ";
            // 
            // dgvAriza
            // 
            this.dgvAriza.AllowUserToAddRows = false;
            this.dgvAriza.AllowUserToDeleteRows = false;
            this.dgvAriza.BackgroundColor = System.Drawing.Color.White;
            this.dgvAriza.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAriza.ContextMenuStrip = this.cmsMenuYenile;
            this.dgvAriza.GridColor = System.Drawing.Color.Black;
            this.dgvAriza.Location = new System.Drawing.Point(12, 317);
            this.dgvAriza.Name = "dgvAriza";
            this.dgvAriza.ReadOnly = true;
            this.dgvAriza.Size = new System.Drawing.Size(760, 220);
            this.dgvAriza.TabIndex = 23;
            this.dgvAriza.Visible = false;
            // 
            // cmsMenuYenile
            // 
            this.cmsMenuYenile.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yenileToolStripMenuItem});
            this.cmsMenuYenile.Name = "cmsMenuYenile";
            this.cmsMenuYenile.Size = new System.Drawing.Size(107, 26);
            // 
            // yenileToolStripMenuItem
            // 
            this.yenileToolStripMenuItem.Image = global::ArizaTakipSistemi.Properties.Resources.yenile;
            this.yenileToolStripMenuItem.Name = "yenileToolStripMenuItem";
            this.yenileToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.yenileToolStripMenuItem.Text = "Yenile";
            this.yenileToolStripMenuItem.Click += new System.EventHandler(this.yenileToolStripMenuItem_Click);
            // 
            // pArizaEkle
            // 
            this.pArizaEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pArizaEkle.Controls.Add(this.btnArizaGonder);
            this.pArizaEkle.Controls.Add(this.txtAriza);
            this.pArizaEkle.Controls.Add(this.txtDemirBasNo);
            this.pArizaEkle.Controls.Add(this.btnArizaEkle);
            this.pArizaEkle.Controls.Add(this.btnArizaEkleKapat);
            this.pArizaEkle.Controls.Add(this.label8);
            this.pArizaEkle.Controls.Add(this.label9);
            this.pArizaEkle.Location = new System.Drawing.Point(163, 317);
            this.pArizaEkle.Name = "pArizaEkle";
            this.pArizaEkle.Size = new System.Drawing.Size(415, 203);
            this.pArizaEkle.TabIndex = 22;
            this.pArizaEkle.Visible = false;
            // 
            // txtAriza
            // 
            this.txtAriza.Location = new System.Drawing.Point(120, 53);
            this.txtAriza.Multiline = true;
            this.txtAriza.Name = "txtAriza";
            this.txtAriza.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtAriza.Size = new System.Drawing.Size(266, 91);
            this.txtAriza.TabIndex = 24;
            // 
            // txtDemirBasNo
            // 
            this.txtDemirBasNo.Location = new System.Drawing.Point(120, 17);
            this.txtDemirBasNo.Name = "txtDemirBasNo";
            this.txtDemirBasNo.Size = new System.Drawing.Size(266, 22);
            this.txtDemirBasNo.TabIndex = 24;
            // 
            // btnArizaEkle
            // 
            this.btnArizaEkle.BackgroundImage = global::ArizaTakipSistemi.Properties.Resources.ekle;
            this.btnArizaEkle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnArizaEkle.FlatAppearance.BorderSize = 0;
            this.btnArizaEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArizaEkle.Location = new System.Drawing.Point(120, 150);
            this.btnArizaEkle.Name = "btnArizaEkle";
            this.btnArizaEkle.Size = new System.Drawing.Size(50, 50);
            this.btnArizaEkle.TabIndex = 22;
            this.btnArizaEkle.UseVisualStyleBackColor = true;
            this.btnArizaEkle.Click += new System.EventHandler(this.btnArizaEkle_Click);
            // 
            // btnArizaEkleKapat
            // 
            this.btnArizaEkleKapat.BackgroundImage = global::ArizaTakipSistemi.Properties.Resources.kapat;
            this.btnArizaEkleKapat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnArizaEkleKapat.FlatAppearance.BorderSize = 0;
            this.btnArizaEkleKapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArizaEkleKapat.Location = new System.Drawing.Point(392, 3);
            this.btnArizaEkleKapat.Name = "btnArizaEkleKapat";
            this.btnArizaEkleKapat.Size = new System.Drawing.Size(20, 20);
            this.btnArizaEkleKapat.TabIndex = 23;
            this.btnArizaEkleKapat.UseVisualStyleBackColor = true;
            this.btnArizaEkleKapat.Click += new System.EventHandler(this.btnArizaEkleKapat_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(3, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "DEMİR BAŞ NO : ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(57, 56);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 16);
            this.label9.TabIndex = 1;
            this.label9.Text = "ARIZA : ";
            // 
            // frmKullaniciEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.pArizaEkle);
            this.Controls.Add(this.dgvAriza);
            this.Controls.Add(this.gbBilgiler);
            this.Controls.Add(this.msUst);
            this.Controls.Add(this.ssAlt);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "frmKullaniciEkrani";
            this.Text = "KULLANICI EKRANI";
            this.Load += new System.EventHandler(this.frmKullaniciEkrani_Load);
            this.ssAlt.ResumeLayout(false);
            this.ssAlt.PerformLayout();
            this.msUst.ResumeLayout(false);
            this.msUst.PerformLayout();
            this.gbBilgiler.ResumeLayout(false);
            this.gbBilgiler.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAriza)).EndInit();
            this.cmsMenuYenile.ResumeLayout(false);
            this.pArizaEkle.ResumeLayout(false);
            this.pArizaEkle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer tmrZaman;
        private System.Windows.Forms.StatusStrip ssAlt;
        private System.Windows.Forms.ToolStripStatusLabel tsslBir;
        public System.Windows.Forms.ToolStripStatusLabel tsslHosgeldiniz;
        private System.Windows.Forms.ToolStripStatusLabel tsslIki;
        private System.Windows.Forms.ToolStripStatusLabel tsslTarih;
        private System.Windows.Forms.ToolStripStatusLabel tsslUc;
        private System.Windows.Forms.ToolStripStatusLabel tsslSaat;
        private System.Windows.Forms.ToolStripStatusLabel tsslDort;
        private System.Windows.Forms.MenuStrip msUst;
        private System.Windows.Forms.ToolStripMenuItem menüToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yardımToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iletişimToolStripMenuItem;
        private System.Windows.Forms.GroupBox gbBilgiler;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lblTur;
        public System.Windows.Forms.Label lblKullaniciAd;
        public System.Windows.Forms.Label lblIsim;
        public System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Button btnArizaGonder;
        private System.Windows.Forms.DataGridView dgvAriza;
        private System.Windows.Forms.Panel pArizaEkle;
        private System.Windows.Forms.TextBox txtAriza;
        private System.Windows.Forms.TextBox txtDemirBasNo;
        private System.Windows.Forms.Button btnArizaEkle;
        private System.Windows.Forms.Button btnArizaEkleKapat;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ContextMenuStrip cmsMenuYenile;
        private System.Windows.Forms.ToolStripMenuItem yenileToolStripMenuItem;
    }
}