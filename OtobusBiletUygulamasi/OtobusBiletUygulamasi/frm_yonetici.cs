using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace OtobusBiletUygulamasi
{
    public partial class frm_yonetici : Form
    {
        public frm_yonetici()
        {
             InitializeComponent();
           }
        frm_yoneticiYonetim frm_yoneticiYonetimm = new frm_yoneticiYonetim();
        string baglanti = "Host=localhost;Username=postgres;Password=1420;Database=OtobusBiletVT";
         
        private void btn_cikis_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_giris_Click(object sender, EventArgs e)
        {
            var bag = new NpgsqlConnection(baglanti);
            bag.Open();

            string sorgu = "select count(*) from Adminler where aKadi = '" + txtbx_kAdi.Text + "' and aSifre = '" + txtbx_kSifre.Text+"'";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, bag);
            DataSet ds = new DataSet();
            da.Fill(ds);
            string sorgu2 = "select count(*) from Yoneticiler where yKadi = '" + txtbx_kAdi.Text + "' and ySifre = '" + txtbx_kSifre.Text + "'";
            NpgsqlDataAdapter da2 = new NpgsqlDataAdapter(sorgu2, bag);
            DataSet ds2 = new DataSet();
            da2.Fill(ds2);
            if (Convert.ToInt32(ds.Tables[0].Rows[0][0]) ==1)
            {
                frm_yoneticiYonetimm.girisKontrol = "adminler";
                frm_yoneticiYonetimm.sutunKontrol = "a";
                frm_yoneticiYonetimm.kAdi = txtbx_kAdi.Text.ToString();
                frm_yoneticiYonetimm.ShowDialog();
                this.Close();
            }
            else if (Convert.ToInt32(ds2.Tables[0].Rows[0][0]) == 1)
            {
                frm_yoneticiYonetimm.girisKontrol = "yoneticiler";
                frm_yoneticiYonetimm.sutunKontrol = "y";
                frm_yoneticiYonetimm.kAdi = txtbx_kAdi.Text.ToString();
                frm_yoneticiYonetimm.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Hatalı Giriş Yaptınız");
            }
            bag.Close();
        }

        private void frm_yonetici_Load(object sender, EventArgs e)
        {
            txtbx_kAdi.Text = "";
            txtbx_kSifre.Text = "";
        }

        private void frm_yonetici_Shown(object sender, EventArgs e)
        {
            txtbx_kAdi.Focus();
        }
    }
}
