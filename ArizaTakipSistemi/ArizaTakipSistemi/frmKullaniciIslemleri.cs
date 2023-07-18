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
    public partial class frmKullaniciIslemleri : Form
    {
        public frmKullaniciIslemleri()
        {
            InitializeComponent();
        }

        OleDbConnection baglanti = new OleDbConnection("Provider = Microsoft.Jet.Oledb.4.0;Data Source = vt.mdb");

        private void KullaniciCek()
        {
            baglanti.Open();
            OleDbCommand komutKullaniciCek = new OleDbCommand("SELECT * FROM Kullanicilar WHERE Yetki = '" + 2 + "'", baglanti);
            OleDbDataAdapter da = new OleDbDataAdapter(komutKullaniciCek);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvKullanicilar.DataSource = dt;
            baglanti.Close();
        }

        private void Temizle()
        {
            txtIsim.Clear();
            txtKullaniciAd.Clear();
            txtKullaniciSifre.Clear();
            txtSifreyiTekrarla.Clear();
            cbOnay.Checked = false;
        }

        private void frmKullaniciIslemleri_Load(object sender, EventArgs e)
        {
            tmrZaman.Enabled = true;
            KullaniciCek();
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
            else if (txtKullaniciAd.Text == "")
            {
                MessageBox.Show("KULLANICI ADI BOŞ BIRAKILAMAZ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txtKullaniciSifre.Text == "")
            {
                MessageBox.Show("KULLANICI ŞİFRESİ BOŞ BIRAKILAMAZ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txtSifreyiTekrarla.Text == "")
            {
                MessageBox.Show("ŞİFREYİ TEKRARLA BOŞ BIRAKILAMAZ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (txtKullaniciSifre.Text == txtSifreyiTekrarla.Text)
                {
                    DialogResult soru = MessageBox.Show("KULLANICI EKLEMEK İSTİYOR MUSUNUZ ?", "UYARI", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                    if (soru == DialogResult.Yes)
                    {
                        baglanti.Open();
                        OleDbCommand komutKullaniciEkle = new OleDbCommand("INSERT INTO Kullanicilar (Isim,KullaniciAd,KullaniciSifre,Yetki) VALUES (@Isim,@KullaniciAd,@KullaniciSifre,@Yetki)", baglanti);
                        komutKullaniciEkle.Parameters.AddWithValue("Isim", txtIsim.Text);
                        komutKullaniciEkle.Parameters.AddWithValue("KullaniciAd", txtKullaniciAd.Text);
                        komutKullaniciEkle.Parameters.AddWithValue("KullaniciSifre", txtKullaniciSifre.Text);
                        komutKullaniciEkle.Parameters.AddWithValue("Yetki", 2);
                        int sonuc = komutKullaniciEkle.ExecuteNonQuery();
                        if (sonuc > 0)
                        {
                            baglanti.Close();
                            KullaniciCek();
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
            DialogResult soru = MessageBox.Show("KULLANICI SİLMEK İSTİYOR MUSUNUZ ?", "UYARI", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (soru == DialogResult.Yes)
            {
                baglanti.Open();
                OleDbCommand komutKullaniciSil = new OleDbCommand("DELETE * FROM Kullanicilar WHERE KullaniciAd = @Id", baglanti);
                komutKullaniciSil.Parameters.AddWithValue("Id", dgvKullanicilar.CurrentRow.Cells[2].Value.ToString());
                int sonuc = komutKullaniciSil.ExecuteNonQuery();
                if (sonuc > 0)
                {
                    baglanti.Close();
                    KullaniciCek();
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
            OleDbCommand komutBilgiCek = new OleDbCommand("SELECT * FROM Kullanicilar WHERE KullaniciAd = '" + dgvKullanicilar.CurrentRow.Cells[2].Value.ToString() + "'", baglanti);
            OleDbDataReader dr = komutBilgiCek.ExecuteReader();
            if (dr.Read())
            {
                txtIsim.Text = dr[1].ToString();
                txtKullaniciAd.Text = dr[2].ToString();
                txtKullaniciSifre.Text = dr[3].ToString();
                txtSifreyiTekrarla.Text = dr[3].ToString();
            }
            baglanti.Close();
            txtKullaniciAd.Enabled = false;
            btnEkle.Visible = false;
            btnSil.Visible = false;
            btnGuncelle.Visible = false;
            btnYenile.Visible = false;
            btnGuncelleOnay.Visible = true;
            btnGuncelleIptal.Visible = true;
        }

        private void btnGuncelleOnay_Click(object sender, EventArgs e)
        {
            DialogResult soru = MessageBox.Show("KULLANICI GÜNCELLEMEK İSTİYOR MUSUNUZ ?", "UYARI", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (soru == DialogResult.Yes)
            {
                baglanti.Open();
                OleDbCommand komutKullaniciGuncelle = new OleDbCommand("UPDATE Kullanicilar SET Isim = '" + txtIsim.Text + "', KullaniciSifre = '" + txtKullaniciSifre.Text + "' WHERE KullaniciAd = '" + txtKullaniciAd.Text + "'", baglanti);
                int sonuc = komutKullaniciGuncelle.ExecuteNonQuery();
                if (sonuc > 0)
                {
                    baglanti.Close();
                    KullaniciCek();
                    Temizle();
                    txtKullaniciAd.Enabled = true;
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
                txtKullaniciAd.Enabled = true;
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
            txtKullaniciAd.Enabled = true;
            btnEkle.Visible = true;
            btnSil.Visible = true;
            btnGuncelle.Visible = true;
            btnYenile.Visible = true;
            btnGuncelleOnay.Visible = false;
            btnGuncelleIptal.Visible = false;
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            KullaniciCek();
        }

        private void tmrZaman_Tick(object sender, EventArgs e)
        {
            tsslTarih.Text = DateTime.Now.ToLongDateString();
            tsslSaat.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
