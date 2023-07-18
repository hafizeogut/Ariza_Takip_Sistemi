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
    public partial class frmBilgisayarIslemleri : Form
    {
        public frmBilgisayarIslemleri()
        {
            InitializeComponent();
        }

        OleDbConnection baglanti = new OleDbConnection("Provider = Microsoft.Jet.Oledb.4.0;Data Source = vt.mdb");

        string[] durumlar = new string[3] { "ARIZALI", "ONARIMDA", "AKTİF" };

        private void Temizle()
        {
            txtBarkod.Text = "";
            txtDemirBasNo.Text = "";
            txtAnakart.Text = "";
            txtIslemci.Text = "";
            txtRam.Text = "";
            txtEkranKarti.Text = "";
            txtSesKarti.Text = "";
            txtEthernetKarti.Text = "";
            txtMonitor.Text = "";
            txtFare.Text = "";
            txtKlavye.Text = "";
            txtEkDonanim.Text = "";
            txtGucKaynagi.Text = "";
            dtpTarih.Text = DateTime.Now.ToLongDateString();
            cbDurum.SelectedIndex = 0;
            cbOnay.Checked = false;
        }

        private void BilgisayarCek()
        {
            baglanti.Open();
            OleDbCommand komutBilgisayarCek = new OleDbCommand("SELECT * FROM Bilgisayarlar", baglanti);
            OleDbDataAdapter da = new OleDbDataAdapter(komutBilgisayarCek);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvBilgisayarlar.DataSource = dt;
            baglanti.Close();
        }

        private void frmBilgisayarIslemleri_Load(object sender, EventArgs e)
        {
            tmrZaman.Enabled = true;
            BilgisayarCek();
            cbDurum.Items.Add("SEÇİNİZ");
            cbDurum.SelectedIndex = 0;
            for (int i = 0; i < durumlar.Length; i++)
            {
                cbDurum.Items.Add(durumlar[i].ToString());
            }
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
            if (txtBarkod.Text == "")
            {
                MessageBox.Show("BARKOD BOŞ BIRAKILAMAZ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txtDemirBasNo.Text == "")
            {
                MessageBox.Show("DEMİR BAŞ NO BOŞ BIRAKILAMAZ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txtAnakart.Text == "")
            {
                MessageBox.Show("ANAKART BOŞ BIRAKILAMAZ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txtIslemci.Text == "")
            {
                MessageBox.Show("İŞLEMCİ BOŞ BIRAKILAMAZ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txtRam.Text == "")
            {
                MessageBox.Show("RAM BOŞ BIRAKILAMAZ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txtEkranKarti.Text == "")
            {
                MessageBox.Show("EKRAN KARTI BOŞ BIRAKILAMAZ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txtSesKarti.Text == "")
            {
                MessageBox.Show("SES KARTI BOŞ BIRAKILAMAZ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txtEthernetKarti.Text == "")
            {
                MessageBox.Show("ETHERNET KARTI BOŞ BIRAKILAMAZ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txtMonitor.Text == "")
            {
                MessageBox.Show("MONİTÖR BOŞ BIRAKILAMAZ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txtFare.Text == "")
            {
                MessageBox.Show("FARE BOŞ BIRAKILAMAZ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txtKlavye.Text == "")
            {
                MessageBox.Show("KLAVYE BOŞ BIRAKILAMAZ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txtEkDonanim.Text == "")
            {
                MessageBox.Show("EK DONANIM BOŞ BIRAKILAMAZ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txtGucKaynagi.Text == "")
            {
                MessageBox.Show("GÜÇ KAYNAĞI BOŞ BIRAKILAMAZ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (dtpTarih.Text == "")
            {
                MessageBox.Show("TARİH BOŞ BIRAKILAMAZ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (cbDurum.Text == "")
            {
                MessageBox.Show("DURUM BOŞ BIRAKILAMAZ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DialogResult soru = MessageBox.Show("BİLGİSAYAR EKLEMEK İSTİYOR MUSUNUZ ?", "UYARI", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (soru == DialogResult.Yes)
                {
                    baglanti.Open();
                    OleDbCommand komutBilgisayarEkle = new OleDbCommand("INSERT INTO Bilgisayarlar (Barkod,DemirBasNo,Anakart,Islemci,Ram,Ekrankarti,Seskarti,Ethernetkarti,Monitor,Fare,Klavye,Ekdonanim,Guckaynagi,Tarih,Durum) VALUES (@Barkod,@DemirBasNo,@Anakart,@Islemci,@Ram,@Ekrankarti,@Seskarti,@Ethernetkarti,@Monitor,@Fare,@Klavye,@Ekdonanim,@Guckaynagi,@Tarih,@Durum)", baglanti);
                    komutBilgisayarEkle.Parameters.AddWithValue("Barkod", txtBarkod.Text);
                    komutBilgisayarEkle.Parameters.AddWithValue("DemirBasNo", txtDemirBasNo.Text);
                    komutBilgisayarEkle.Parameters.AddWithValue("Anakart", txtAnakart.Text);
                    komutBilgisayarEkle.Parameters.AddWithValue("Islemci", txtIslemci.Text);
                    komutBilgisayarEkle.Parameters.AddWithValue("Ram", txtRam.Text);
                    komutBilgisayarEkle.Parameters.AddWithValue("Ekrankarti", txtEkranKarti.Text);
                    komutBilgisayarEkle.Parameters.AddWithValue("Seskarti", txtSesKarti.Text);
                    komutBilgisayarEkle.Parameters.AddWithValue("Ethernetkarti", txtEthernetKarti.Text);
                    komutBilgisayarEkle.Parameters.AddWithValue("Monitor", txtMonitor.Text);
                    komutBilgisayarEkle.Parameters.AddWithValue("Fare", txtFare.Text);
                    komutBilgisayarEkle.Parameters.AddWithValue("Klavye", txtKlavye.Text);
                    komutBilgisayarEkle.Parameters.AddWithValue("Ekdonanim", txtEkDonanim.Text);
                    komutBilgisayarEkle.Parameters.AddWithValue("Guckaynagi", txtGucKaynagi.Text);
                    komutBilgisayarEkle.Parameters.AddWithValue("Tarih", dtpTarih.Text);
                    komutBilgisayarEkle.Parameters.AddWithValue("Durum", cbDurum.Text);
                    int sonuc = komutBilgisayarEkle.ExecuteNonQuery();
                    if (sonuc > 0)
                    {
                        baglanti.Close();
                        BilgisayarCek();
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
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult soru = MessageBox.Show("BİLGİSAYAR SİLMEK İSTİYOR MUSUNUZ ?", "UYARI", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (soru == DialogResult.Yes)
            {
                baglanti.Open();
                OleDbCommand komutBilgisayarSil = new OleDbCommand("DELETE * FROM Bilgisayarlar WHERE Barkod = @Barkod", baglanti);
                komutBilgisayarSil.Parameters.AddWithValue("Barkod", dgvBilgisayarlar.CurrentRow.Cells[1].Value.ToString());
                int sonuc = komutBilgisayarSil.ExecuteNonQuery();
                if (sonuc > 0)
                {
                    baglanti.Close();
                    BilgisayarCek();
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
            OleDbCommand komutBilgiCek = new OleDbCommand("SELECT * FROM Bilgisayarlar WHERE Barkod = @Barkod", baglanti);
            komutBilgiCek.Parameters.AddWithValue("Barkod", dgvBilgisayarlar.CurrentRow.Cells[1].Value.ToString());
            OleDbDataReader dr = komutBilgiCek.ExecuteReader();
            while (dr.Read())
            {
                txtBarkod.Text = dr[1].ToString();
                txtDemirBasNo.Text = dr[2].ToString();
                txtAnakart.Text = dr[3].ToString();
                txtIslemci.Text = dr[4].ToString();
                txtRam.Text = dr[5].ToString();
                txtEkranKarti.Text = dr[6].ToString();
                txtSesKarti.Text = dr[7].ToString();
                txtEthernetKarti.Text = dr[8].ToString();
                txtMonitor.Text = dr[9].ToString();
                txtFare.Text = dr[10].ToString();
                txtKlavye.Text = dr[11].ToString();
                txtEkDonanim.Text = dr[12].ToString();
                txtGucKaynagi.Text = dr[13].ToString();
                dtpTarih.Text = dr[14].ToString();
                cbDurum.Text = dr[15].ToString();
            }
            baglanti.Close();
            txtBarkod.Enabled = false;
            btnEkle.Visible = false;
            btnSil.Visible = false;
            btnGuncelle.Visible = false;
            btnYenile.Visible = false;
            btnGuncelleOnay.Visible = true;
            btnGuncelleIptal.Visible = true;
        }

        private void btnGuncelleOnay_Click(object sender, EventArgs e)
        {
            DialogResult soru = MessageBox.Show("BİLGİSAYAR GÜNCELLEMEK İSTİYOR MUSUNUZ ?", "UYARI", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (soru == DialogResult.Yes)
            {
                baglanti.Open();
                OleDbCommand komutBilgisayarGuncelle = new OleDbCommand("UPDATE Bilgisayarlar SET DemirBasNo = '" + txtDemirBasNo.Text + "',Anakart = '" + txtAnakart.Text + "',Islemci = '" + txtIslemci.Text + "',Ram = '" + txtRam.Text + "',Ekrankarti = '" + txtEkranKarti.Text + "',Seskarti = '" + txtSesKarti.Text + "',Ethernetkarti = '" + txtEthernetKarti.Text + "',Monitor = '" + txtMonitor.Text + "',Fare = '" + txtFare.Text + "',Klavye = '" + txtKlavye.Text + "',Ekdonanim = '" + txtEkDonanim.Text + "',Guckaynagi = '" + txtGucKaynagi.Text + "',Tarih = '" + dtpTarih.Text + "',Durum = '" + cbDurum.Text + "' WHERE Barkod = '" + txtBarkod.Text + "'", baglanti);
                int sonuc = komutBilgisayarGuncelle.ExecuteNonQuery();
                if (sonuc > 0)
                {
                    baglanti.Close();
                    BilgisayarCek();
                    Temizle();
                    txtBarkod.Enabled = true;
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
                txtBarkod.Enabled = true;
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
            txtBarkod.Enabled = true;
            btnEkle.Visible = true;
            btnSil.Visible = true;
            btnGuncelle.Visible = true;
            btnYenile.Visible = true;
            btnGuncelleOnay.Visible = false;
            btnGuncelleIptal.Visible = false;
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            BilgisayarCek();
        }

        private void tmrZaman_Tick(object sender, EventArgs e)
        {
            tsslTarih.Text = DateTime.Now.ToLongDateString();
            tsslSaat.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
