using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ArizaTakipSistemi
{
    public partial class frmGirisEkrani : Form
    {
        public frmGirisEkrani()
        {
            InitializeComponent();
        }

        OleDbConnection baglanti = new OleDbConnection("Provider = Microsoft.Jet.Oledb.4.0;Data Source = vt.mdb");

        frmYoneticiEkrani frmYe = new frmYoneticiEkrani();

        frmKullaniciEkrani frmKe = new frmKullaniciEkrani();

        private void frmGirisEkrani_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.arkaplan;
            pbResim.BackgroundImage = Properties.Resources.pc;
            btnGirisYap.BackgroundImage = Properties.Resources.kilit;
            tmrZaman.Enabled = true;
        }

        private void btnGirisYap_MouseEnter(object sender, EventArgs e)
        {
            btnGirisYap.BackgroundImage = Properties.Resources.anahtar;
        }

        private void btnGirisYap_MouseLeave(object sender, EventArgs e)
        {
            btnGirisYap.BackgroundImage = Properties.Resources.kilit;
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            if (txtKullaniciAd.Text == "")
            {
                MessageBox.Show("KULLANICI ADI BOŞ BIRAKILAMAZ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txtKullaniciEmail.Text == "")
            {
                MessageBox.Show("KULLANICI ŞİFRESİ BOŞ BIRAKILAMAZ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                baglanti.Open();
                OleDbCommand komutGirisYap = new OleDbCommand("SELECT * FROM Kullanicilar WHERE KullaniciAd = '" + txtKullaniciAd.Text + "' AND KullaniciSifre = '" + txtKullaniciEmail.Text + "'", baglanti);
                OleDbDataReader dr = komutGirisYap.ExecuteReader();
                if (dr.Read())
                {
                    if (dr[4].ToString() == "1")
                    {
                        frmYe.tsslHosgeldiniz.Text = "HOŞGELDİNİZ " + dr[1].ToString();
                        baglanti.Close();
                        frmYe.Show();
                        this.Hide();
                    }
                    else if (dr[4].ToString() == "2")
                    {
                        frmKe.tsslHosgeldiniz.Text = "HOŞGELDİNİZ " + dr[1].ToString();
                        frmKe.lblId.Text = dr[0].ToString();
                        frmKe.lblIsim.Text = dr[1].ToString();
                        frmKe.lblKullaniciAd.Text = dr[2].ToString();
                        frmKe.lblTur.Text = "NORMAL KULLANICI";
                        baglanti.Close();
                        frmKe.Show();
                        this.Hide();
                    }
                }
                else
                {
                    baglanti.Close();
                    MessageBox.Show("KULLANICI ADI VEYA ŞİFRE YANLIŞ YADA YETKİNİZ YOK", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void tmrZaman_Tick(object sender, EventArgs e)
        {
            tsslTarih.Text = DateTime.Now.ToLongDateString();
            tsslSaat.Text = DateTime.Now.ToLongTimeString();
        }

        private void çıkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iletişimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("HAFİZE ÖĞÜT" + "\n" + "hafize.ogt@gmail.com", "İLETİŞİM", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void çıkToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iletişimToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("HAFİZE ÖĞÜT" + "\n" + "hafize.ogt@gmail.com", "İLETİŞİM", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txtKullaniciAd_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtKullaniciSifre_TextChanged(object sender, EventArgs e)
        {

        }

        private void menüToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void msUst_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
