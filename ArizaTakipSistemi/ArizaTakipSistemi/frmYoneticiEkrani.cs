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
    public partial class frmYoneticiEkrani : Form
    {
        public frmYoneticiEkrani()
        {
            InitializeComponent();
        }

        OleDbConnection baglanti = new OleDbConnection("Provider = Microsoft.Jet.Oledb.4.0;Data Source = vt.mdb");

        frmYoneticiIslemleri frmYi = new frmYoneticiIslemleri();

        frmKullaniciIslemleri frmKi = new frmKullaniciIslemleri();

        frmBilgisayarIslemleri frmBi = new frmBilgisayarIslemleri();

        frmArizaGecmisi frmAg = new frmArizaGecmisi();

        private void Temizle()
        {
            lblDemirBasNo.Text = "";
            lblAriza.Text = "";
            lblTarih.Text = "";
            lblKullaniciId.Text = "";
            lblKullaniciAd.Text = "";
            cbDurum.Text = "";
            txtYetkili.Text = "";
        }

        private void ArizaCek()
        {
            baglanti.Open();
            OleDbCommand komutArizaCek = new OleDbCommand("SELECT * FROM Arizalar", baglanti);
            OleDbDataAdapter da = new OleDbDataAdapter(komutArizaCek);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvArizalar.DataSource = dt;
            baglanti.Close();
        }

        private void ArizaDetayCek()
        {
            baglanti.Open();
            OleDbCommand komutArizaCek = new OleDbCommand("SELECT * FROM Arizalar WHERE DemirBasNo = @DemirBasNo", baglanti);
            komutArizaCek.Parameters.AddWithValue("DemirBasNo", dgvArizalar.CurrentRow.Cells[0].Value.ToString());
            OleDbDataReader dr = komutArizaCek.ExecuteReader();
            while (dr.Read())
            {
                lblDemirBasNo.Text = dr[0].ToString();
                lblAriza.Text = dr[1].ToString();
                lblTarih.Text = dr[2].ToString();
                lblKullaniciId.Text = dr[3].ToString();
                lblKullaniciAd.Text = dr[4].ToString();
                cbDurum.Text = dr[5].ToString();
                txtYetkili.Text = dr[6].ToString();
            }
            baglanti.Close();
        }

        private void frmYoneticiEkrani_Load(object sender, EventArgs e)
        {
            tmrZaman.Enabled = true;
            ArizaCek();
        }

        private void tmrZaman_Tick(object sender, EventArgs e)
        {
            tsslTarih.Text = DateTime.Now.ToLongDateString();
            tsslSaat.Text = DateTime.Now.ToLongTimeString();
        }

        private void yöneticiİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmYi.ShowDialog();
        }

        private void kullanıcıİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKi.ShowDialog();
        }

        private void bilgisayarİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBi.ShowDialog();
        }

        private void arızaGeçmişiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAg.ShowDialog();
        }

        private void dgvArizalar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvArizalar.Height = 250;
            gbArizaBilgileri.Visible = true;
            ArizaDetayCek();
        }

        private void btnArizaGuncelle_Click(object sender, EventArgs e)
        {
            DialogResult soru = MessageBox.Show("ARIZA BİLGİLERİNİ GÜNCELLEMEK İSTİYOR MUSUNUZ ?", "UYARI", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (soru == DialogResult.Yes)
            {
                baglanti.Open();
                OleDbCommand komutArizaGuncelle = new OleDbCommand("UPDATE Arizalar SET Durum = '"+cbDurum.Text+"', Yetkili = '"+txtYetkili.Text+"' WHERE DemirBasNo = '"+lblDemirBasNo.Text+"'", baglanti);
                int sonuc = komutArizaGuncelle.ExecuteNonQuery();
                if (sonuc > 0)
                {
                    baglanti.Close();
                    ArizaCek();
                    dgvArizalar.Height = 510;
                    gbArizaBilgileri.Visible = false;
                    Temizle();
                }
                else
                {
                    baglanti.Close();
                }
            }
            else if (soru == DialogResult.No)
            {
                dgvArizalar.Height = 510;
                gbArizaBilgileri.Visible = false;
                Temizle();
            }
            else
            {

            }
        }

        private void btnArizaBitti_Click(object sender, EventArgs e)
        {
            DialogResult soru = MessageBox.Show("ARIZAYI SONLANDIRMAK İSTİYOR MUSUNUZ ?", "UYARI", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (soru == DialogResult.Yes)
            {
                baglanti.Open();
                OleDbCommand komutArizaGecmisEkle = new OleDbCommand("INSERT INTO ArizaGecmis (DemirBasNo,Ariza,IlkTarih,Sonuc,Yapan,SonTarih) VALUES (@DemirBasNo,@Ariza,@IlkTarih,@Sonuc,@Yapan,@SonTarih)", baglanti);
                komutArizaGecmisEkle.Parameters.AddWithValue("DemirBasNo", lblDemirBasNo.Text);
                komutArizaGecmisEkle.Parameters.AddWithValue("Ariza", lblAriza.Text);
                komutArizaGecmisEkle.Parameters.AddWithValue("IlkTarih", lblTarih.Text);
                komutArizaGecmisEkle.Parameters.AddWithValue("Sonuc", cbDurum.Text);
                komutArizaGecmisEkle.Parameters.AddWithValue("Yapan", txtYetkili.Text);
                komutArizaGecmisEkle.Parameters.AddWithValue("SonTarih", DateTime.Now);
                int sonuc = komutArizaGecmisEkle.ExecuteNonQuery();
                if (sonuc > 0)
                {
                    baglanti.Close();
                    baglanti.Open();
                    OleDbCommand komutArizaSil = new OleDbCommand("DELETE * FROM Arizalar WHERE DemirBasNo = @DemirBasNo", baglanti);
                    komutArizaSil.Parameters.AddWithValue("DemirBasNo", lblDemirBasNo.Text);
                    komutArizaSil.ExecuteNonQuery();
                    baglanti.Close();
                    ArizaCek();
                    dgvArizalar.Height = 510;
                    gbArizaBilgileri.Visible = false;
                    Temizle();
                }
                else
                {
                    baglanti.Close();
                }
            }
            else if (soru == DialogResult.No)
            {
                dgvArizalar.Height = 510;
                gbArizaBilgileri.Visible = false;
                Temizle();
            }
            else
            {

            }
        }

        private void yenileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            baglanti.Close();
            ArizaCek();
        }
    }
}
