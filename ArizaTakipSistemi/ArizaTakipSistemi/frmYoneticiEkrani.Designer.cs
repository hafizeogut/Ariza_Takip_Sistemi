namespace ArizaTakipSistemi
{
    partial class frmYoneticiEkrani
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmYoneticiEkrani));
            this.msUst = new System.Windows.Forms.MenuStrip();
            this.yönetimMenüsüToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yöneticiİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kullanıcıİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bilgisayarMenüsüToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bilgisayarİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arızaMenüsüToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arızaGeçmişiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ssAlt = new System.Windows.Forms.StatusStrip();
            this.tsslBir = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslHosgeldiniz = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslIki = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslTarih = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslUc = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslSaat = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslDort = new System.Windows.Forms.ToolStripStatusLabel();
            this.tmrZaman = new System.Windows.Forms.Timer(this.components);
            this.dgvArizalar = new System.Windows.Forms.DataGridView();
            this.cmsMenuYenile = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.yenileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbArizaBilgileri = new System.Windows.Forms.GroupBox();
            this.cbDurum = new System.Windows.Forms.ComboBox();
            this.btnArizaGuncelle = new System.Windows.Forms.Button();
            this.btnArizaBitti = new System.Windows.Forms.Button();
            this.txtYetkili = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblKullaniciAd = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblKullaniciId = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTarih = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblAriza = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDemirBasNo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.msUst.SuspendLayout();
            this.ssAlt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArizalar)).BeginInit();
            this.cmsMenuYenile.SuspendLayout();
            this.gbArizaBilgileri.SuspendLayout();
            this.SuspendLayout();
            // 
            // msUst
            // 
            this.msUst.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yönetimMenüsüToolStripMenuItem,
            this.bilgisayarMenüsüToolStripMenuItem,
            this.arızaMenüsüToolStripMenuItem});
            this.msUst.Location = new System.Drawing.Point(0, 0);
            this.msUst.Name = "msUst";
            this.msUst.Size = new System.Drawing.Size(784, 24);
            this.msUst.TabIndex = 0;
            this.msUst.Text = "menuStrip1";
            // 
            // yönetimMenüsüToolStripMenuItem
            // 
            this.yönetimMenüsüToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yöneticiİşlemleriToolStripMenuItem,
            this.kullanıcıİşlemleriToolStripMenuItem});
            this.yönetimMenüsüToolStripMenuItem.Name = "yönetimMenüsüToolStripMenuItem";
            this.yönetimMenüsüToolStripMenuItem.Size = new System.Drawing.Size(110, 20);
            this.yönetimMenüsüToolStripMenuItem.Text = "Yönetim Menüsü";
            // 
            // yöneticiİşlemleriToolStripMenuItem
            // 
            this.yöneticiİşlemleriToolStripMenuItem.Name = "yöneticiİşlemleriToolStripMenuItem";
            this.yöneticiİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.yöneticiİşlemleriToolStripMenuItem.Text = "Yönetici İşlemleri";
            this.yöneticiİşlemleriToolStripMenuItem.Click += new System.EventHandler(this.yöneticiİşlemleriToolStripMenuItem_Click);
            // 
            // kullanıcıİşlemleriToolStripMenuItem
            // 
            this.kullanıcıİşlemleriToolStripMenuItem.Name = "kullanıcıİşlemleriToolStripMenuItem";
            this.kullanıcıİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.kullanıcıİşlemleriToolStripMenuItem.Text = "Kullanıcı İşlemleri";
            this.kullanıcıİşlemleriToolStripMenuItem.Click += new System.EventHandler(this.kullanıcıİşlemleriToolStripMenuItem_Click);
            // 
            // bilgisayarMenüsüToolStripMenuItem
            // 
            this.bilgisayarMenüsüToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bilgisayarİşlemleriToolStripMenuItem});
            this.bilgisayarMenüsüToolStripMenuItem.Name = "bilgisayarMenüsüToolStripMenuItem";
            this.bilgisayarMenüsüToolStripMenuItem.Size = new System.Drawing.Size(115, 20);
            this.bilgisayarMenüsüToolStripMenuItem.Text = "Bilgisayar Menüsü";
            // 
            // bilgisayarİşlemleriToolStripMenuItem
            // 
            this.bilgisayarİşlemleriToolStripMenuItem.Name = "bilgisayarİşlemleriToolStripMenuItem";
            this.bilgisayarİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.bilgisayarİşlemleriToolStripMenuItem.Text = "Bilgisayar İşlemleri";
            this.bilgisayarİşlemleriToolStripMenuItem.Click += new System.EventHandler(this.bilgisayarİşlemleriToolStripMenuItem_Click);
            // 
            // arızaMenüsüToolStripMenuItem
            // 
            this.arızaMenüsüToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arızaGeçmişiToolStripMenuItem});
            this.arızaMenüsüToolStripMenuItem.Name = "arızaMenüsüToolStripMenuItem";
            this.arızaMenüsüToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.arızaMenüsüToolStripMenuItem.Text = "Arıza Menüsü";
            // 
            // arızaGeçmişiToolStripMenuItem
            // 
            this.arızaGeçmişiToolStripMenuItem.Name = "arızaGeçmişiToolStripMenuItem";
            this.arızaGeçmişiToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.arızaGeçmişiToolStripMenuItem.Text = "Arıza Geçmişi";
            this.arızaGeçmişiToolStripMenuItem.Click += new System.EventHandler(this.arızaGeçmişiToolStripMenuItem_Click);
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
            this.ssAlt.TabIndex = 1;
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
            // tmrZaman
            // 
            this.tmrZaman.Interval = 1000;
            this.tmrZaman.Tick += new System.EventHandler(this.tmrZaman_Tick);
            // 
            // dgvArizalar
            // 
            this.dgvArizalar.AllowUserToAddRows = false;
            this.dgvArizalar.AllowUserToDeleteRows = false;
            this.dgvArizalar.BackgroundColor = System.Drawing.Color.White;
            this.dgvArizalar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArizalar.ContextMenuStrip = this.cmsMenuYenile;
            this.dgvArizalar.GridColor = System.Drawing.Color.Black;
            this.dgvArizalar.Location = new System.Drawing.Point(12, 27);
            this.dgvArizalar.Name = "dgvArizalar";
            this.dgvArizalar.ReadOnly = true;
            this.dgvArizalar.Size = new System.Drawing.Size(760, 510);
            this.dgvArizalar.TabIndex = 4;
            this.dgvArizalar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvArizalar_CellClick);
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
            // gbArizaBilgileri
            // 
            this.gbArizaBilgileri.Controls.Add(this.cbDurum);
            this.gbArizaBilgileri.Controls.Add(this.btnArizaGuncelle);
            this.gbArizaBilgileri.Controls.Add(this.btnArizaBitti);
            this.gbArizaBilgileri.Controls.Add(this.txtYetkili);
            this.gbArizaBilgileri.Controls.Add(this.label7);
            this.gbArizaBilgileri.Controls.Add(this.label6);
            this.gbArizaBilgileri.Controls.Add(this.lblKullaniciAd);
            this.gbArizaBilgileri.Controls.Add(this.label5);
            this.gbArizaBilgileri.Controls.Add(this.lblKullaniciId);
            this.gbArizaBilgileri.Controls.Add(this.label4);
            this.gbArizaBilgileri.Controls.Add(this.lblTarih);
            this.gbArizaBilgileri.Controls.Add(this.label3);
            this.gbArizaBilgileri.Controls.Add(this.lblAriza);
            this.gbArizaBilgileri.Controls.Add(this.label2);
            this.gbArizaBilgileri.Controls.Add(this.lblDemirBasNo);
            this.gbArizaBilgileri.Controls.Add(this.label1);
            this.gbArizaBilgileri.Location = new System.Drawing.Point(12, 283);
            this.gbArizaBilgileri.Name = "gbArizaBilgileri";
            this.gbArizaBilgileri.Size = new System.Drawing.Size(760, 254);
            this.gbArizaBilgileri.TabIndex = 5;
            this.gbArizaBilgileri.TabStop = false;
            this.gbArizaBilgileri.Text = "ARIZA BİLGİLERİ";
            this.gbArizaBilgileri.Visible = false;
            // 
            // cbDurum
            // 
            this.cbDurum.FormattingEnabled = true;
            this.cbDurum.Items.AddRange(new object[] {
            "ALINDI",
            "TAMİRDE",
            "HAZIR"});
            this.cbDurum.Location = new System.Drawing.Point(126, 198);
            this.cbDurum.Name = "cbDurum";
            this.cbDurum.Size = new System.Drawing.Size(200, 24);
            this.cbDurum.TabIndex = 24;
            // 
            // btnArizaGuncelle
            // 
            this.btnArizaGuncelle.BackgroundImage = global::ArizaTakipSistemi.Properties.Resources.ekle;
            this.btnArizaGuncelle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnArizaGuncelle.FlatAppearance.BorderSize = 0;
            this.btnArizaGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArizaGuncelle.Location = new System.Drawing.Point(332, 198);
            this.btnArizaGuncelle.Name = "btnArizaGuncelle";
            this.btnArizaGuncelle.Size = new System.Drawing.Size(50, 50);
            this.btnArizaGuncelle.TabIndex = 22;
            this.btnArizaGuncelle.UseVisualStyleBackColor = true;
            this.btnArizaGuncelle.Click += new System.EventHandler(this.btnArizaGuncelle_Click);
            // 
            // btnArizaBitti
            // 
            this.btnArizaBitti.BackgroundImage = global::ArizaTakipSistemi.Properties.Resources.kapat;
            this.btnArizaBitti.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnArizaBitti.FlatAppearance.BorderSize = 0;
            this.btnArizaBitti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArizaBitti.Location = new System.Drawing.Point(388, 198);
            this.btnArizaBitti.Name = "btnArizaBitti";
            this.btnArizaBitti.Size = new System.Drawing.Size(50, 50);
            this.btnArizaBitti.TabIndex = 23;
            this.btnArizaBitti.UseVisualStyleBackColor = true;
            this.btnArizaBitti.Click += new System.EventHandler(this.btnArizaBitti_Click);
            // 
            // txtYetkili
            // 
            this.txtYetkili.Location = new System.Drawing.Point(126, 226);
            this.txtYetkili.Name = "txtYetkili";
            this.txtYetkili.Size = new System.Drawing.Size(200, 22);
            this.txtYetkili.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(48, 229);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "YETKİLİ : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(51, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "DURUM : ";
            // 
            // lblKullaniciAd
            // 
            this.lblKullaniciAd.AutoSize = true;
            this.lblKullaniciAd.Location = new System.Drawing.Point(123, 181);
            this.lblKullaniciAd.Name = "lblKullaniciAd";
            this.lblKullaniciAd.Size = new System.Drawing.Size(110, 16);
            this.lblKullaniciAd.TabIndex = 4;
            this.lblKullaniciAd.Text = "KULLANICI AD : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "KULLANICI AD : ";
            // 
            // lblKullaniciId
            // 
            this.lblKullaniciId.AutoSize = true;
            this.lblKullaniciId.Location = new System.Drawing.Point(123, 161);
            this.lblKullaniciId.Name = "lblKullaniciId";
            this.lblKullaniciId.Size = new System.Drawing.Size(106, 16);
            this.lblKullaniciId.TabIndex = 3;
            this.lblKullaniciId.Text = "KULLANICI ID : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "KULLANICI ID : ";
            // 
            // lblTarih
            // 
            this.lblTarih.AutoSize = true;
            this.lblTarih.Location = new System.Drawing.Point(123, 141);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(58, 16);
            this.lblTarih.TabIndex = 2;
            this.lblTarih.Text = "TARİH : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "TARİH : ";
            // 
            // lblAriza
            // 
            this.lblAriza.Location = new System.Drawing.Point(123, 40);
            this.lblAriza.Name = "lblAriza";
            this.lblAriza.Size = new System.Drawing.Size(631, 101);
            this.lblAriza.TabIndex = 1;
            this.lblAriza.Text = "ARIZA : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "ARIZA : ";
            // 
            // lblDemirBasNo
            // 
            this.lblDemirBasNo.AutoSize = true;
            this.lblDemirBasNo.Location = new System.Drawing.Point(123, 20);
            this.lblDemirBasNo.Name = "lblDemirBasNo";
            this.lblDemirBasNo.Size = new System.Drawing.Size(111, 16);
            this.lblDemirBasNo.TabIndex = 0;
            this.lblDemirBasNo.Text = "DEMİR BAŞ NO : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "DEMİR BAŞ NO : ";
            // 
            // frmYoneticiEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.gbArizaBilgileri);
            this.Controls.Add(this.dgvArizalar);
            this.Controls.Add(this.ssAlt);
            this.Controls.Add(this.msUst);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.msUst;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "frmYoneticiEkrani";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YÖNETİCİ EKRANI";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmYoneticiEkrani_Load);
            this.msUst.ResumeLayout(false);
            this.msUst.PerformLayout();
            this.ssAlt.ResumeLayout(false);
            this.ssAlt.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArizalar)).EndInit();
            this.cmsMenuYenile.ResumeLayout(false);
            this.gbArizaBilgileri.ResumeLayout(false);
            this.gbArizaBilgileri.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msUst;
        private System.Windows.Forms.StatusStrip ssAlt;
        private System.Windows.Forms.ToolStripStatusLabel tsslBir;
        private System.Windows.Forms.ToolStripStatusLabel tsslIki;
        private System.Windows.Forms.ToolStripStatusLabel tsslTarih;
        private System.Windows.Forms.ToolStripStatusLabel tsslUc;
        private System.Windows.Forms.ToolStripStatusLabel tsslSaat;
        private System.Windows.Forms.Timer tmrZaman;
        public System.Windows.Forms.ToolStripStatusLabel tsslHosgeldiniz;
        private System.Windows.Forms.ToolStripMenuItem yönetimMenüsüToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yöneticiİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kullanıcıİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bilgisayarMenüsüToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bilgisayarİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arızaMenüsüToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arızaGeçmişiToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel tsslDort;
        private System.Windows.Forms.DataGridView dgvArizalar;
        private System.Windows.Forms.GroupBox gbArizaBilgileri;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtYetkili;
        private System.Windows.Forms.Label lblKullaniciAd;
        private System.Windows.Forms.Label lblKullaniciId;
        private System.Windows.Forms.Label lblTarih;
        private System.Windows.Forms.Label lblAriza;
        private System.Windows.Forms.Label lblDemirBasNo;
        private System.Windows.Forms.Button btnArizaGuncelle;
        private System.Windows.Forms.Button btnArizaBitti;
        private System.Windows.Forms.ComboBox cbDurum;
        private System.Windows.Forms.ContextMenuStrip cmsMenuYenile;
        private System.Windows.Forms.ToolStripMenuItem yenileToolStripMenuItem;
    }
}