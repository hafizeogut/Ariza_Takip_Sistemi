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
    public partial class frmArizaGecmisi : Form
    {
        public frmArizaGecmisi()
        {
            InitializeComponent();
        }

        OleDbConnection baglanti = new OleDbConnection("Provider = Microsoft.Jet.Oledb.4.0;Data Source = vt.mdb");

        private void ArizaGecmisiCek()
        {
            baglanti.Open();
            OleDbCommand komutArizaCek = new OleDbCommand("SELECT * FROM ArizaGecmis", baglanti);
            OleDbDataAdapter da = new OleDbDataAdapter(komutArizaCek);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvArizaGecmisi.DataSource = dt;
            baglanti.Close();
        }

        private void frmArizaGecmisi_Load(object sender, EventArgs e)
        {
            tmrZaman.Enabled = true;
            ArizaGecmisiCek();
        }

        private void tmrZaman_Tick(object sender, EventArgs e)
        {
            tsslTarih.Text = DateTime.Now.ToLongDateString();
            tsslSaat.Text = DateTime.Now.ToLongTimeString();
        }

        private void yenileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ArizaGecmisiCek();
        }
    }
}
