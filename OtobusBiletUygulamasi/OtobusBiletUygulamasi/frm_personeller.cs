using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtobusBiletUygulamasi
{
    public partial class frm_personeller : Form
    {
        public frm_personeller()
        {
            InitializeComponent();
        }
        public int firmaidd = 0;
        public void temizle() {
            var bag = new NpgsqlConnection(baglanti);
            bag.Open();
            string sorgu = "select * from personel where firmaid = " + firmaidd + "";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, bag);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgw_personeller.DataSource = ds.Tables[0].DefaultView;
            bag.Close();
            txtbx_padi.Text = "";
            txtbx_soyadi.Text = "";
            rbtn_sofor.Checked = false;
            rbtn_muavin.Checked = false;
            btn_sil.Enabled = false;
            btn_sil.Visible = false;
            btn_kaydet.Text = "Ekle";
        }
        
        string baglanti = "Host=localhost;Username=postgres;Password=1420;Database=OtobusBiletVT";
        int pid = 0;
        private void frm_personeller_Load(object sender, EventArgs e)
        {
            temizle();
        }

        private void dgw_personeller_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtbx_padi.Text = dgw_personeller.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtbx_soyadi.Text = dgw_personeller.Rows[e.RowIndex].Cells[2].Value.ToString();
            if (dgw_personeller.Rows[e.RowIndex].Cells[3].Value.ToString() == "şoför") {
                rbtn_sofor.Checked = true;
            }
            else
            {
                rbtn_muavin.Checked = true;
            }   
            pid = Convert.ToInt32(dgw_personeller.Rows[e.RowIndex].Cells[0].Value.ToString());
            btn_kaydet.Text = "Güncelle";
            btn_sil.Enabled = true;
            btn_sil.Visible = true;
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            string pozisyon = "";
            if (btn_kaydet.Text=="Ekle" && txtbx_padi.Text!=""  && txtbx_soyadi.Text!="" && (rbtn_sofor.Checked || rbtn_muavin.Checked))
            {
                if (rbtn_sofor.Checked)
                {
                    pozisyon = "şoför";
                }
                else
                {
                    pozisyon = "muavin";
                }
                var bag = new NpgsqlConnection(baglanti);
                bag.Open();
                DbCommand dbCommand = bag.CreateCommand();
                dbCommand.CommandText = @"
                INSERT INTO personel (pad, psoyad, ppozisyon, firmaid) 
                VALUES ('"+txtbx_padi.Text+"', '"+txtbx_soyadi.Text+"', '"+pozisyon+"', "+firmaidd+")";

                dbCommand.ExecuteNonQuery();
                bag.Close();
                temizle();
            }
            else if (btn_kaydet.Text=="Güncelle" && txtbx_padi.Text != "" && txtbx_soyadi.Text != "" && (rbtn_sofor.Checked || rbtn_muavin.Checked))
            {
                if (rbtn_sofor.Checked)
                {
                    pozisyon = "şoför";
                }
                else
                {
                    pozisyon = "muavin";
                }
                var bag = new NpgsqlConnection(baglanti);
                bag.Open();
                DbCommand dbCommand = bag.CreateCommand();
                dbCommand.CommandText = @"
                UPDATE personel set pad = '"+txtbx_padi.Text+"', psoyad = '"+txtbx_soyadi.Text+"', ppozisyon = '"+pozisyon+"' " +
                "where pid = "+pid+"";

                dbCommand.ExecuteNonQuery();
                bag.Close();

                temizle();
            }
            else
            {
                MessageBox.Show("Lütfen alanları boş bırakmadığınızdan emin olunuz","Uyarı", MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            var bag = new NpgsqlConnection(baglanti);
            bag.Open();
            DbCommand dbCommand = bag.CreateCommand();
            dbCommand.CommandText = @"
                DELETE FROM personel WHERE pid = " + pid + "";

            dbCommand.ExecuteNonQuery();
            bag.Close();
            temizle();
        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void btn_cikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
