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
    public partial class frmYoneticiIslemleri : Form
    {
        public frmYoneticiIslemleri()
        {
            InitializeComponent();
        }

        OleDbConnection baglanti = new OleDbConnection("Provider = Microsoft.Jet.Oledb.4.0;Data Source = vt.mdb");

        private void YoneticiCek()
        {
            baglanti.Open();
            OleDbCommand komutYoneticiCek = new OleDbCommand("SELECT * FROM Kullanicilar WHERE Yetki = '" + 1 + "'", baglanti);
            OleDbDataAdapter da = new OleDbDataAdapter(komutYoneticiCek);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvYoneticiler.DataSource = dt;
            baglanti.Close();
        }

        private void Temizle()
        {
            txtIsim.Clear();
            txtYoneticiAd.Clear();
            txtYoneticiSifre.Clear();
            txtSifreyiTekrarla.Clear();
            cbOnay.Checked = false;
        }

        private void frmYoneticiIslemleri_Load(object sender, EventArgs e)
        {
            tmrZaman.Enabled = true;
            YoneticiCek();
        }

        private void cbOnay_CheckedChanged(object sender, EventArgs e)
        {
            if (cbOnay.Checked)
            {
                btnEkle.Enabled = true;
                btnGuncelleOnay.Enabled = true;
            }
            else
            {
                btnEkle.Enabled = false;
                btnGuncelleOnay.Enabled = false;
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtIsim.Text == "")
            {
                MessageBox.Show("İSİM BOŞ BIRAKILAMAZ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txtYoneticiAd.Text == "")
            {
                MessageBox.Show("YÖNETİCİ ADI BOŞ BIRAKILAMAZ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txtYoneticiSifre.Text == "")
            {
                MessageBox.Show("YÖNETİCİ ŞİFRESİ BOŞ BIRAKILAMAZ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txtSifreyiTekrarla.Text == "")
            {
                MessageBox.Show("ŞİFREYİ TEKRARLA BOŞ BIRAKILAMAZ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (txtYoneticiSifre.Text == txtSifreyiTekrarla.Text)
                {
                    DialogResult soru = MessageBox.Show("YÖNETİCİ EKLEMEK İSTİYOR MUSUNUZ ?", "UYARI", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                    if (soru == DialogResult.Yes)
                    {
                        baglanti.Open();
                        OleDbCommand komutYoneticiEkle = new OleDbCommand("INSERT INTO Kullanicilar (Isim,KullaniciAd,KullaniciSifre,Yetki) VALUES (@Isim,@KullaniciAd,@KullaniciSifre,@Yetki)", baglanti);
                        komutYoneticiEkle.Parameters.AddWithValue("Isim", txtIsim.Text);
                        komutYoneticiEkle.Parameters.AddWithValue("KullaniciAd", txtYoneticiAd.Text);
                        komutYoneticiEkle.Parameters.AddWithValue("KullaniciSifre", txtYoneticiSifre.Text);
                        komutYoneticiEkle.Parameters.AddWithValue("Yetki", 1);
                        int sonuc = komutYoneticiEkle.ExecuteNonQuery();
                        if (sonuc > 0)
                        {
                            baglanti.Close();
                            YoneticiCek();
                            Temizle();
                        }
                        else
                        {
                            baglanti.Close();
                        }
                    }
                    else if (soru == DialogResult.No)
                    {
                        Temizle();
                    }
                    else
                    {

                    }
                }
                else
                {
                    MessageBox.Show("ŞİFRELER AYNI DEĞİL", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult soru = MessageBox.Show("YÖNETİCİ SİLMEK İSTİYOR MUSUNUZ ?", "UYARI", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (soru == DialogResult.Yes)
            {
                baglanti.Open();
                OleDbCommand komutYoneticiSil = new OleDbCommand("DELETE * FROM Kullanicilar WHERE KullaniciAd = @Id", baglanti);
                komutYoneticiSil.Parameters.AddWithValue("Id", dgvYoneticiler.CurrentRow.Cells[2].Value.ToString());
                int sonuc = komutYoneticiSil.ExecuteNonQuery();
                if (sonuc > 0)
                {
                    baglanti.Close();
                    YoneticiCek();
                    Temizle();
                }
                else
                {
                    baglanti.Close();
                }
            }
            else if (soru == DialogResult.No)
            {

            }
            else
            {

            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komutBilgiCek = new OleDbCommand("SELECT * FROM Kullanicilar WHERE KullaniciAd = '" + dgvYoneticiler.CurrentRow.Cells[2].Value.ToString() + "'", baglanti);
            OleDbDataReader dr = komutBilgiCek.ExecuteReader();
            if (dr.Read())
            {
                txtIsim.Text = dr[1].ToString();
                txtYoneticiAd.Text = dr[2].ToString();
                txtYoneticiSifre.Text = dr[3].ToString();
                txtSifreyiTekrarla.Text = dr[3].ToString();
            }
            baglanti.Close();
            txtYoneticiAd.Enabled = false;
            btnEkle.Visible = false;
            btnSil.Visible = false;
            btnGuncelle.Visible = false;
            btnYenile.Visible = false;
            btnGuncelleOnay.Visible = true;
            btnGuncelleIptal.Visible = true;
        }

        private void btnGuncelleOnay_Click(object sender, EventArgs e)
        {
            DialogResult soru = MessageBox.Show("YÖNETİCİ GÜNCELLEMEK İSTİYOR MUSUNUZ ?", "UYARI", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (soru == DialogResult.Yes)
            {
                baglanti.Open();
                OleDbCommand komutYoneticiGuncelle = new OleDbCommand("UPDATE Kullanicilar SET Isim = '" + txtIsim.Text + "', KullaniciSifre = '" + txtYoneticiSifre.Text + "' WHERE KullaniciAd = '" + txtYoneticiAd.Text + "'", baglanti);
                int sonuc = komutYoneticiGuncelle.ExecuteNonQuery();
                if (sonuc > 0)
                {
                    baglanti.Close();
                    YoneticiCek();
                    Temizle();
                    txtYoneticiAd.Enabled = true;
                    btnEkle.Visible = true;
                    btnSil.Visible = true;
                    btnGuncelle.Visible = true;
                    btnYenile.Visible = true;
                    btnGuncelleOnay.Visible = false;
                    btnGuncelleIptal.Visible = false;
                }
                else
                {
                    baglanti.Close();
                }
            }
            else if (soru == DialogResult.No)
            {
                Temizle();
                txtYoneticiAd.Enabled = true;
                btnEkle.Visible = true;
                btnSil.Visible = true;
                btnGuncelle.Visible = true;
                btnYenile.Visible = true;
                btnGuncelleOnay.Visible = false;
                btnGuncelleIptal.Visible = false;
            }
            else
            {

            }
        }

        private void btnGuncelleIptal_Click(object sender, EventArgs e)
        {
            Temizle();
            txtYoneticiAd.Enabled = true;
            btnEkle.Visible = true;
            btnSil.Visible = true;
            btnGuncelle.Visible = true;
            btnYenile.Visible = true;
            btnGuncelleOnay.Visible = false;
            btnGuncelleIptal.Visible = false;
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            YoneticiCek();
        }

        private void tmrZaman_Tick(object sender, EventArgs e)
        {
            tsslTarih.Text = DateTime.Now.ToLongDateString();
            tsslSaat.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
