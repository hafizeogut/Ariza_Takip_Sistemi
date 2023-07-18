namespace ArizaTakipSistemi
{
    partial class frmKullaniciIslemleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKullaniciIslemleri));
            this.btnGuncelleOnay = new System.Windows.Forms.Button();
            this.ssAlt = new System.Windows.Forms.StatusStrip();
            this.tsslBir = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslTarih = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslIki = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslSaat = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslUc = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnYenile = new System.Windows.Forms.Button();
            this.btnGuncelleIptal = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.cbOnay = new System.Windows.Forms.CheckBox();
            this.txtSifreyiTekrarla = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvKullanicilar = new System.Windows.Forms.DataGridView();
            this.txtKullaniciSifre = new System.Windows.Forms.TextBox();
            this.txtKullaniciAd = new System.Windows.Forms.TextBox();
            this.tmrZaman = new System.Windows.Forms.Timer(this.components);
            this.txtIsim = new System.Windows.Forms.TextBox();
            this.ssAlt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKullanicilar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuncelleOnay
            // 
            this.btnGuncelleOnay.BackgroundImage = global::ArizaTakipSistemi.Properties.Resources.ekle;
            this.btnGuncelleOnay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuncelleOnay.Enabled = false;
            this.btnGuncelleOnay.FlatAppearance.BorderSize = 0;
            this.btnGuncelleOnay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuncelleOnay.Location = new System.Drawing.Point(286, 94);
            this.btnGuncelleOnay.Name = "btnGuncelleOnay";
            this.btnGuncelleOnay.Size = new System.Drawing.Size(50, 50);
            this.btnGuncelleOnay.TabIndex = 26;
            this.btnGuncelleOnay.UseVisualStyleBackColor = true;
            this.btnGuncelleOnay.Visible = false;
            this.btnGuncelleOnay.Click += new System.EventHandler(this.btnGuncelleOnay_Click);
            // 
            // ssAlt
            // 
            this.ssAlt.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslBir,
            this.tsslTarih,
            this.tsslIki,
            this.tsslSaat,
            this.tsslUc});
            this.ssAlt.Location = new System.Drawing.Point(0, 494);
            this.ssAlt.Name = "ssAlt";
            this.ssAlt.Size = new System.Drawing.Size(734, 22);
            this.ssAlt.TabIndex = 29;
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
            this.tsslTarih.Size = new System.Drawing.Size(41, 17);
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
            this.tsslSaat.Size = new System.Drawing.Size(36, 17);
            this.tsslSaat.Text = "SAAT";
            // 
            // tsslUc
            // 
            this.tsslUc.Name = "tsslUc";
            this.tsslUc.Size = new System.Drawing.Size(32, 17);
            this.tsslUc.Text = "-----";
            // 
            // btnYenile
            // 
            this.btnYenile.BackgroundImage = global::ArizaTakipSistemi.Properties.Resources.yenile;
            this.btnYenile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnYenile.FlatAppearance.BorderSize = 0;
            this.btnYenile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYenile.Location = new System.Drawing.Point(454, 94);
            this.btnYenile.Name = "btnYenile";
            this.btnYenile.Size = new System.Drawing.Size(50, 50);
            this.btnYenile.TabIndex = 25;
            this.btnYenile.UseVisualStyleBackColor = true;
            this.btnYenile.Click += new System.EventHandler(this.btnYenile_Click);
            // 
            // btnGuncelleIptal
            // 
            this.btnGuncelleIptal.BackgroundImage = global::ArizaTakipSistemi.Properties.Resources.kapat;
            this.btnGuncelleIptal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuncelleIptal.FlatAppearance.BorderSize = 0;
            this.btnGuncelleIptal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuncelleIptal.Location = new System.Drawing.Point(342, 94);
            this.btnGuncelleIptal.Name = "btnGuncelleIptal";
            this.btnGuncelleIptal.Size = new System.Drawing.Size(50, 50);
            this.btnGuncelleIptal.TabIndex = 28;
            this.btnGuncelleIptal.UseVisualStyleBackColor = true;
            this.btnGuncelleIptal.Visible = false;
            this.btnGuncelleIptal.Click += new System.EventHandler(this.btnGuncelleIptal_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackgroundImage = global::ArizaTakipSistemi.Properties.Resources.sil;
            this.btnSil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSil.FlatAppearance.BorderSize = 0;
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSil.Location = new System.Drawing.Point(342, 94);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(50, 50);
            this.btnSil.TabIndex = 20;
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackgroundImage = global::ArizaTakipSistemi.Properties.Resources.guncelle;
            this.btnGuncelle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuncelle.FlatAppearance.BorderSize = 0;
            this.btnGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuncelle.Location = new System.Drawing.Point(398, 94);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(50, 50);
            this.btnGuncelle.TabIndex = 23;
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.BackgroundImage = global::ArizaTakipSistemi.Properties.Resources.ekle;
            this.btnEkle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEkle.Enabled = false;
            this.btnEkle.FlatAppearance.BorderSize = 0;
            this.btnEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEkle.Location = new System.Drawing.Point(286, 94);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(50, 50);
            this.btnEkle.TabIndex = 18;
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // cbOnay
            // 
            this.cbOnay.AutoSize = true;
            this.cbOnay.Location = new System.Drawing.Point(161, 124);
            this.cbOnay.Name = "cbOnay";
            this.cbOnay.Size = new System.Drawing.Size(119, 20);
            this.cbOnay.TabIndex = 27;
            this.cbOnay.Text = "ONAYLIYORUM";
            this.cbOnay.UseVisualStyleBackColor = true;
            this.cbOnay.CheckedChanged += new System.EventHandler(this.cbOnay_CheckedChanged);
            // 
            // txtSifreyiTekrarla
            // 
            this.txtSifreyiTekrarla.Location = new System.Drawing.Point(161, 96);
            this.txtSifreyiTekrarla.Name = "txtSifreyiTekrarla";
            this.txtSifreyiTekrarla.PasswordChar = '*';
            this.txtSifreyiTekrarla.Size = new System.Drawing.Size(119, 22);
            this.txtSifreyiTekrarla.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 16);
            this.label4.TabIndex = 24;
            this.label4.Text = "ŞİFREYİ TEKRARLA : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 16);
            this.label3.TabIndex = 22;
            this.label3.Text = "KULLANICI ŞİFRESİ : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "KULLANICI ADI : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 19;
            this.label1.Text = "İSİM : ";
            // 
            // dgvKullanicilar
            // 
            this.dgvKullanicilar.AllowUserToAddRows = false;
            this.dgvKullanicilar.AllowUserToDeleteRows = false;
            this.dgvKullanicilar.BackgroundColor = System.Drawing.Color.White;
            this.dgvKullanicilar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKullanicilar.GridColor = System.Drawing.Color.Black;
            this.dgvKullanicilar.Location = new System.Drawing.Point(12, 150);
            this.dgvKullanicilar.Name = "dgvKullanicilar";
            this.dgvKullanicilar.ReadOnly = true;
            this.dgvKullanicilar.Size = new System.Drawing.Size(710, 341);
            this.dgvKullanicilar.TabIndex = 16;
            // 
            // txtKullaniciSifre
            // 
            this.txtKullaniciSifre.Location = new System.Drawing.Point(161, 68);
            this.txtKullaniciSifre.Name = "txtKullaniciSifre";
            this.txtKullaniciSifre.PasswordChar = '*';
            this.txtKullaniciSifre.Size = new System.Drawing.Size(119, 22);
            this.txtKullaniciSifre.TabIndex = 15;
            // 
            // txtKullaniciAd
            // 
            this.txtKullaniciAd.Location = new System.Drawing.Point(161, 40);
            this.txtKullaniciAd.Name = "txtKullaniciAd";
            this.txtKullaniciAd.Size = new System.Drawing.Size(119, 22);
            this.txtKullaniciAd.TabIndex = 14;
            // 
            // tmrZaman
            // 
            this.tmrZaman.Interval = 1000;
            this.tmrZaman.Tick += new System.EventHandler(this.tmrZaman_Tick);
            // 
            // txtIsim
            // 
            this.txtIsim.Location = new System.Drawing.Point(161, 12);
            this.txtIsim.Name = "txtIsim";
            this.txtIsim.Size = new System.Drawing.Size(119, 22);
            this.txtIsim.TabIndex = 13;
            // 
            // frmKullaniciIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 516);
            this.Controls.Add(this.btnGuncelleOnay);
            this.Controls.Add(this.ssAlt);
            this.Controls.Add(this.btnYenile);
            this.Controls.Add(this.btnGuncelleIptal);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.cbOnay);
            this.Controls.Add(this.txtSifreyiTekrarla);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvKullanicilar);
            this.Controls.Add(this.txtKullaniciSifre);
            this.Controls.Add(this.txtKullaniciAd);
            this.Controls.Add(this.txtIsim);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(750, 550);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(750, 550);
            this.Name = "frmKullaniciIslemleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KULLANICI İŞLEMLERİ";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmKullaniciIslemleri_Load);
            this.ssAlt.ResumeLayout(false);
            this.ssAlt.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKullanicilar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuncelleOnay;
        private System.Windows.Forms.StatusStrip ssAlt;
        private System.Windows.Forms.ToolStripStatusLabel tsslBir;
        private System.Windows.Forms.ToolStripStatusLabel tsslTarih;
        private System.Windows.Forms.ToolStripStatusLabel tsslIki;
        private System.Windows.Forms.ToolStripStatusLabel tsslSaat;
        private System.Windows.Forms.ToolStripStatusLabel tsslUc;
        private System.Windows.Forms.Button btnYenile;
        private System.Windows.Forms.Button btnGuncelleIptal;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.CheckBox cbOnay;
        private System.Windows.Forms.TextBox txtSifreyiTekrarla;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvKullanicilar;
        private System.Windows.Forms.TextBox txtKullaniciSifre;
        private System.Windows.Forms.TextBox txtKullaniciAd;
        private System.Windows.Forms.Timer tmrZaman;
        private System.Windows.Forms.TextBox txtIsim;
    }
}