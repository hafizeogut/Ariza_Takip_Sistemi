namespace ArizaTakipSistemi
{
    partial class frmArizaGecmisi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmArizaGecmisi));
            this.dgvArizaGecmisi = new System.Windows.Forms.DataGridView();
            this.cmsMenuYenile = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.yenileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tmrZaman = new System.Windows.Forms.Timer(this.components);
            this.ssAlt = new System.Windows.Forms.StatusStrip();
            this.tsslBir = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslTarih = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslIki = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslSaat = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslUc = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArizaGecmisi)).BeginInit();
            this.cmsMenuYenile.SuspendLayout();
            this.ssAlt.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvArizaGecmisi
            // 
            this.dgvArizaGecmisi.AllowUserToAddRows = false;
            this.dgvArizaGecmisi.AllowUserToDeleteRows = false;
            this.dgvArizaGecmisi.BackgroundColor = System.Drawing.Color.White;
            this.dgvArizaGecmisi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArizaGecmisi.ContextMenuStrip = this.cmsMenuYenile;
            this.dgvArizaGecmisi.GridColor = System.Drawing.Color.Black;
            this.dgvArizaGecmisi.Location = new System.Drawing.Point(12, 12);
            this.dgvArizaGecmisi.Name = "dgvArizaGecmisi";
            this.dgvArizaGecmisi.ReadOnly = true;
            this.dgvArizaGecmisi.Size = new System.Drawing.Size(710, 479);
            this.dgvArizaGecmisi.TabIndex = 5;
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
            this.ssAlt.Location = new System.Drawing.Point(0, 494);
            this.ssAlt.Name = "ssAlt";
            this.ssAlt.Size = new System.Drawing.Size(734, 22);
            this.ssAlt.TabIndex = 13;
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
            // frmArizaGecmisi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 516);
            this.Controls.Add(this.ssAlt);
            this.Controls.Add(this.dgvArizaGecmisi);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(750, 550);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(750, 550);
            this.Name = "frmArizaGecmisi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ARIZA GEÇMİŞİ";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmArizaGecmisi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArizaGecmisi)).EndInit();
            this.cmsMenuYenile.ResumeLayout(false);
            this.ssAlt.ResumeLayout(false);
            this.ssAlt.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvArizaGecmisi;
        private System.Windows.Forms.Timer tmrZaman;
        private System.Windows.Forms.StatusStrip ssAlt;
        private System.Windows.Forms.ToolStripStatusLabel tsslBir;
        private System.Windows.Forms.ToolStripStatusLabel tsslTarih;
        private System.Windows.Forms.ToolStripStatusLabel tsslIki;
        private System.Windows.Forms.ToolStripStatusLabel tsslSaat;
        private System.Windows.Forms.ToolStripStatusLabel tsslUc;
        private System.Windows.Forms.ContextMenuStrip cmsMenuYenile;
        private System.Windows.Forms.ToolStripMenuItem yenileToolStripMenuItem;
    }
}