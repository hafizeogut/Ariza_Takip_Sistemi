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
    public partial class frmKullaniciEkrani : Form
    {
        public frmKullaniciEkrani()
        {
            InitializeComponent();
        }

        OleDbConnection baglanti = new OleDbConnection("Provider = Microsoft.Jet.Oledb.4.0;Data Source = vt.mdb");

        private void Temizle()
        {
            txtDemirBasNo.Text = "";
            txtAriza.Text = "";
        }

        private void ArizaKontrol()
        {
            baglanti.Open();
            OleDbCommand komutGirisYap = new OleDbCommand("SELECT * FROM Arizalar WHERE KullaniciId = '" + lblId.Text + "'", baglanti);
            OleDbDataReader dr = komutGirisYap.ExecuteReader();
            if (dr.Read())
            {
                if (dr[3].ToString() == lblId.Text)
                {
                    baglanti.Close();
                    dgvAriza.Visible = true;
                    btnArizaGonder.Visible = false;
                }
                else
                {
                    baglanti.Close();
                    dgvAriza.Visible = false;
                    btnArizaGonder.Visible = true;
                }
                baglanti.Close();
            }
        }

        private void ArizaCek()
        {
            baglanti.Open();
            OleDbCommand komutArizaCek = new OleDbCommand("SELECT * FROM Arizalar WHERE KullaniciId = '" + lblId.Text + "'", baglanti);
            OleDbDataAdapter da = new OleDbDataAdapter(komutArizaCek);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvAriza.DataSource = dt;
            baglanti.Close();
        }

        private void frmKullaniciEkrani_Load(object sender, EventArgs e)
        {
            tmrZaman.Enabled = true;
            ArizaKontrol();
            ArizaCek(); 
        }

        private void tmrZaman_Tick(object sender, EventArgs e)
        {
            tsslTarih.Text = DateTime.Now.ToLongDateString();
            tsslSaat.Text = DateTime.Now.ToLongTimeString();
        }

        private void btnArizaGonder_Click(object sender, EventArgs e)
        {
            baglanti.Close();
            btnArizaGonder.Visible = false;
            pArizaEkle.Visible = true;
            
        }

        private void btnArizaEkle_Click(object sender, EventArgs e)
        {
            if (txtDemirBasNo.Text == "")
            {
                MessageBox.Show("DEMİR BAŞ NO BOŞ BIRAKILAMAZ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txtAriza.Text == "")
            {
                MessageBox.Show("ARIZA BOŞ BIRAKILAMAZ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DialogResult soru = MessageBox.Show("ARIZA EKLEMEK İSTİYOR MUSUNUZ ?", "UYARI", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (soru == DialogResult.Yes)
                {
                    baglanti.Open();
                    OleDbCommand komutArizaEkle = new OleDbCommand("INSERT INTO Arizalar (DemirBasNo,Ariza,Tarih,KullaniciId,KullaniciAd,Durum) VALUES (@DemirBasNo,@Ariza,@Tarih,@KullaniciId,@KullaniciAd,@Durum)", baglanti);
                    komutArizaEkle.Parameters.AddWithValue("DemirBasNo", txtDemirBasNo.Text);
                    komutArizaEkle.Parameters.AddWithValue("Ariza", txtAriza.Text);
                    komutArizaEkle.Parameters.AddWithValue("Tarih", DateTime.Now);
                    komutArizaEkle.Parameters.AddWithValue("KullaniciId", lblId.Text);
                    komutArizaEkle.Parameters.AddWithValue("KullaniciAd", lblKullaniciAd.Text);
                    komutArizaEkle.Parameters.AddWithValue("Durum", "ALINDI");
                    int sonuc = komutArizaEkle.ExecuteNonQuery();
                    if (sonuc > 0)
                    {
                        baglanti.Close();
                        Temizle();
                        ArizaKontrol();
                        ArizaCek();
                        pArizaEkle.Visible = false;
                        dgvAriza.Visible = true; 

                    }
                }
                else if (soru == DialogResult.No)
                {
                    Temizle();
                    btnArizaGonder.Visible = true;
                    pArizaEkle.Visible = false;
                }
                else
                {

                }
            }
        }

        private void btnArizaEkleKapat_Click(object sender, EventArgs e)
        {
            Temizle();
            btnArizaGonder.Visible = true;
            pArizaEkle.Visible = false; 
            dgvAriza.Visible = true;
        }

        private void yenileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            baglanti.Close();
            ArizaCek();
            ArizaKontrol();
        }

        private void çıkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iletişimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("İREM NAZ BAYOĞLU" + "\n" + "irmbyoglu@gmail.com", "İLETİŞİM", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnArizaEklee_Click(object sender, EventArgs e)
        {
            pArizaEkle.Width = 415;
            pArizaEkle.Height = 203;
            pArizaEkle.Left = 163;
            pArizaEkle.Top = 317;
            pArizaEkle.Visible = true;
            dgvAriza.Visible = false;
        }
    }
}
