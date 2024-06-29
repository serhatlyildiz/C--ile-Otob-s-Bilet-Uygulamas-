using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtobusBiletUygulamasi
{
    public partial class frm_biletAl : Form
    {
        public frm_biletAl()
        {
            InitializeComponent();
        }
        public string nereden = "";
        public string nereye = "";
        public DateTime tarih = DateTime.Now;
        string baglanti = "Host=localhost;Username=postgres;Password=1420;Database=OtobusBiletVT";
        frm_biletAlimi frmBilet = new frm_biletAlimi();
        int rbtnKontrol = 0;
        string[] basliklar = { "Firma", "Sefer No", "Nereden", "Nereye", "Kalkış Tarihi", "Varış Tarihi", "Kalkış Saati", "Varış Saati", "Koltuk Sayısı", "Boş Koltuk Sayısı", "Ücret"};

        public void dgwDuzen()
        {
            int a = 2;
            for (int i = 0; i < dgw_seferler.Columns.Count; i++)
            {
                if (dgw_seferler.Columns.Count-a!=i)
                {
                    dgw_seferler.Columns[i].HeaderText = basliklar[i];
                }
                else
                {
                    a--;
                }
            }          
        }
        public void tek() 
        {
            var bag = new NpgsqlConnection(baglanti);
            bag.Open();
            string sorgu2 = "select f.firmaadi, s.sid, s.kalkisyeri, s.varisyeri, s.kalkiszaman, s.variszaman, s.kalkissaati, s.varissaati, s.koltuksayisi, s.boskoltuksayisi, s.ucret from sefer as s inner join firma as f on s.firmaid = f.firmaid where s.kalkisyeri = '" + nereden + "' and " +
                "s.varisyeri = '" + nereye + "' and s.kalkiszaman = '" + dtp_tarih.Value.ToShortDateString() + "' and s.koltuksayisi = 40 and s.seferdurumu = 'aktif'";
            NpgsqlDataAdapter da2 = new NpgsqlDataAdapter(sorgu2, bag);
            DataSet ds2 = new DataSet();
            da2.Fill(ds2);
            dgw_seferler.Columns.Clear();
            dgw_seferler.DataSource = ds2.Tables[0].DefaultView;
            DataGridViewButtonColumn btn1 = new DataGridViewButtonColumn();
            btn1.HeaderText = "Koltuk Görüntüle";
            btn1.Text = "Seç";
            btn1.Name = "sec";
            btn1.UseColumnTextForButtonValue = true;
            btn1.Width = 150;
            btn1.DefaultCellStyle.BackColor = Color.Red;
            btn1.DefaultCellStyle.ForeColor = Color.White;
            dgw_seferler.Columns.Add(btn1);
            dgwDuzen();
            bag.Close();
        }
        public void cift()
        {
            var bag = new NpgsqlConnection(baglanti);
            bag.Open();
            string sorgu2 = "select f.firmaadi, s.sid, s.kalkisyeri, s.varisyeri, s.kalkiszaman, s.variszaman, s.kalkissaati, s.varissaati, s.koltuksayisi, s.boskoltuksayisi, s.ucret from sefer as s inner join firma as f on s.firmaid = f.firmaid where s.kalkisyeri = '" + nereden + "' and " +
                "s.varisyeri = '" + nereye + "' and s.kalkiszaman = '" + dtp_tarih.Value.ToShortDateString() + "' and s.koltuksayisi = 58 and s.seferdurumu = 'aktif'";
            NpgsqlDataAdapter da2 = new NpgsqlDataAdapter(sorgu2, bag);
            DataSet ds2 = new DataSet();
            da2.Fill(ds2);
            dgw_seferler.Columns.Clear();
            dgw_seferler.DataSource = ds2.Tables[0].DefaultView;
            DataGridViewButtonColumn btn1 = new DataGridViewButtonColumn();
            btn1.HeaderText = "Koltuk Görüntüle";
            btn1.Text = "Seç";
            btn1.Name = "sec";
            btn1.UseColumnTextForButtonValue = true;
            btn1.Width = 150;
            btn1.DefaultCellStyle.BackColor = Color.Red;
            btn1.DefaultCellStyle.ForeColor = Color.White;
            dgw_seferler.Columns.Add(btn1);
            dgwDuzen();
            bag.Close();
        }

        private void btn_cikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_biletAl_Load(object sender, EventArgs e)
        {
            dgw_seferler.Columns.Clear();
            dtp_tarih.MinDate = DateTime.Now;
            var bag = new NpgsqlConnection(baglanti);
            bag.Open();
            string sorgu2 = "select f.firmaadi, s.sid, s.kalkisyeri, s.varisyeri, s.kalkiszaman, s.variszaman, s.kalkissaati, s.varissaati, s.koltuksayisi, s.boskoltuksayisi, s.ucret from sefer as s inner join firma as f on s.firmaid = f.firmaid where s.kalkisyeri = '" + nereden + "' and " +
                    "s.varisyeri = '" + nereye + "' and s.kalkiszaman = '" + dtp_tarih.Value.ToShortDateString() + "' and s.seferdurumu = 'aktif'";
            NpgsqlDataAdapter da2 = new NpgsqlDataAdapter(sorgu2, bag);
            DataSet ds2 = new DataSet();
            da2.Fill(ds2);
            dgw_seferler.DataSource = ds2.Tables[0].DefaultView;
            dtp_tarih.Value = Convert.ToDateTime(tarih.ToShortDateString());
            DataGridViewButtonColumn btn1 = new DataGridViewButtonColumn();
            btn1.HeaderText = "Koltuk Görüntüle";
            btn1.Text = "Seç";
            btn1.Name = "sec";
            btn1.UseColumnTextForButtonValue = true;
            btn1.Width = 150;
            btn1.DefaultCellStyle.BackColor = Color.Red;
            btn1.DefaultCellStyle.ForeColor = Color.White;
            dgw_seferler.Columns.Add(btn1);
            dgwDuzen();
        }

        private void rbtn_tek_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_tek.Checked)
            {
                tek();
            }
        }

        private void rbtn_cift_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_cift.Checked)
            {
                cift();
            }
        }

        private void dtp_tarih_ValueChanged(object sender, EventArgs e)
        {
            var bag = new NpgsqlConnection(baglanti);
            bag.Open();
            rbtn_cift.Checked = false;
            rbtn_tek.Checked = false;
            string sorgu2 = "select f.firmaadi, s.sid, s.kalkisyeri, s.varisyeri, s.kalkiszaman, s.variszaman, s.kalkissaati, s.varissaati, s.koltuksayisi, s.boskoltuksayisi, s.ucret from sefer as s inner join firma as f on s.firmaid = f.firmaid where s.kalkisyeri = '" + nereden + "' and " +
            "s.varisyeri = '" + nereye + "' and s.kalkiszaman = '" + dtp_tarih.Value.ToShortDateString() + "' and s.seferdurumu = 'aktif'";
            NpgsqlDataAdapter da2 = new NpgsqlDataAdapter(sorgu2, bag);
            DataSet ds2 = new DataSet();
            da2.Fill(ds2);
            dgw_seferler.Columns.Clear();
            dgw_seferler.DataSource = ds2.Tables[0].DefaultView;
            DataGridViewButtonColumn btn1 = new DataGridViewButtonColumn();
            btn1.HeaderText = "Koltuk Görüntüle";
            btn1.Text = "Seç";
            btn1.Name = "sec";
            btn1.UseColumnTextForButtonValue = true;
            btn1.Width = 150;
            btn1.DefaultCellStyle.BackColor = Color.Red;
            btn1.DefaultCellStyle.ForeColor = Color.White;
            dgw_seferler.Columns.Add(btn1);
            dgwDuzen();
            bag.Close();
        }

        private void dgw_seferler_CellClick(object sender, DataGridViewCellEventArgs e)
        {     
            if (e.ColumnIndex == dgw_seferler.Columns["sec"].Index) 
            {
                if (Convert.ToInt16(dgw_seferler.Rows[e.RowIndex].Cells[9].Value)!=0)
                {
                    frmBilet.koltukSayisi = Convert.ToInt16(dgw_seferler.Rows[e.RowIndex].Cells[8].Value);
                    frmBilet.sid = Convert.ToInt16(dgw_seferler.Rows[e.RowIndex].Cells[1].Value);
                    frmBilet.ShowDialog();
                    dgw_seferler.Columns.Clear();
                    dtp_tarih.MinDate = DateTime.Now;
                    var bag = new NpgsqlConnection(baglanti);
                    bag.Open();
                    string sorgu2 = "select f.firmaadi, s.sid, s.kalkisyeri, s.varisyeri, s.kalkiszaman, s.variszaman, s.kalkissaati, s.varissaati, s.koltuksayisi, s.boskoltuksayisi, s.ucret from sefer as s inner join firma as f on s.firmaid = f.firmaid where s.kalkisyeri = '" + nereden + "' and " +
                            "s.varisyeri = '" + nereye + "' and s.kalkiszaman = '" + dtp_tarih.Value.ToShortDateString() + "' and s.seferdurumu = 'aktif'";
                    NpgsqlDataAdapter da2 = new NpgsqlDataAdapter(sorgu2, bag);
                    DataSet ds2 = new DataSet();
                    da2.Fill(ds2);
                    dgw_seferler.DataSource = ds2.Tables[0].DefaultView;
                    dtp_tarih.Value = Convert.ToDateTime(tarih.ToShortDateString());
                    DataGridViewButtonColumn btn1 = new DataGridViewButtonColumn();
                    btn1.HeaderText = "Koltuk Görüntüle";
                    btn1.Text = "Seç";
                    btn1.Name = "sec";
                    btn1.UseColumnTextForButtonValue = true;
                    btn1.Width = 150;
                    btn1.DefaultCellStyle.BackColor = Color.Red;
                    btn1.DefaultCellStyle.ForeColor = Color.White;
                    dgw_seferler.Columns.Add(btn1);
                    dgwDuzen();

                }
                else
                {
                    MessageBox.Show("Bu sefer doludur","Bilgilendirme",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                
            }
        }

        private void btn_temzile_Click(object sender, EventArgs e)
        {
            rbtn_cift.Checked = false;
            rbtn_tek.Checked = false;
            dtp_tarih.Value = Convert.ToDateTime(tarih.ToShortDateString());
            var bag = new NpgsqlConnection(baglanti);
            bag.Open();
            string sorgu2 = "select f.firmaadi, s.sid, s.kalkisyeri, s.varisyeri, s.kalkiszaman, s.variszaman, s.kalkissaati, s.varissaati, s.koltuksayisi, s.boskoltuksayisi, s.ucret from sefer as s inner join firma as f on s.firmaid = f.firmaid where s.kalkisyeri = '" + nereden + "' and " +
                    "s.varisyeri = '" + nereye + "' and s.kalkiszaman = '" + dtp_tarih.Value.ToShortDateString() + "' and s.seferdurumu = 'aktif'";
            NpgsqlDataAdapter da2 = new NpgsqlDataAdapter(sorgu2, bag);
            DataSet ds2 = new DataSet();
            da2.Fill(ds2);
            dgw_seferler.Columns.Clear();
            dgw_seferler.DataSource = ds2.Tables[0].DefaultView;
            DataGridViewButtonColumn btn1 = new DataGridViewButtonColumn();
            btn1.HeaderText = "Koltuk Görüntüle";
            btn1.Text = "Seç";
            btn1.Name = "sec";
            btn1.UseColumnTextForButtonValue = true;
            btn1.Width = 150;
            btn1.DefaultCellStyle.BackColor = Color.Red;
            btn1.DefaultCellStyle.ForeColor = Color.White;
            dgw_seferler.Columns.Add(btn1);
            dgwDuzen();
        }
    }
}
