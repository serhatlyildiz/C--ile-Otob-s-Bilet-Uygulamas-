using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtobusBiletUygulamasi
{
    public partial class frm_yoneticilerYonetimi : Form
    {
        public frm_yoneticilerYonetimi()
        {
            InitializeComponent();
        }
        public int firmaid = 0;
        string baglanti = "Host=localhost;Username=postgres;Password=1420;Database=OtobusBiletVT";
        int kullaniciAdiKontrol = 0;
        int indexKontrol = 0;
        string kadi = "";
        public void temizle()
        {
            var bag = new NpgsqlConnection(baglanti);
            bag.Open();
            string sorgu = "select * from yoneticiler where firmaid = '" + firmaid + "'";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, bag);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgw_yoneticiler.DataSource = ds.Tables[0].DefaultView;
            
            txtbx_kadi.Text = "";
            txtbx_kisim.Text = "";
            txtbx_ksifre.Text = "";
            txtbx_ksoyisim.Text = "";
            cmbx_bolge.Text = "";
            btn_kaydet.Text = "Ekle";
            kullaniciAdiKontrol = 0;
            indexKontrol = 0;
            kadi = "";
            cmbx_bolge.Items.Clear();
            string sorgu2 = "select * from bolgeler";
            NpgsqlDataAdapter da2 = new NpgsqlDataAdapter(sorgu2, bag);
            DataSet ds2 = new DataSet();
            da2.Fill(ds2);
            for (int i = 0; i < ds2.Tables[0].Rows.Count; i++)
            {
                cmbx_bolge.Items.Add(ds2.Tables[0].Rows[i][1].ToString());
            }
            btn_sil.Enabled = false;
            btn_sil.Visible = false;
        }
        private void frm_yoneticilerYonetimi_Load(object sender, EventArgs e)
        {
            temizle();
        }

        private void dgw_yoneticiler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtbx_kadi.Text = dgw_yoneticiler.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtbx_ksifre.Text = dgw_yoneticiler.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtbx_kisim.Text = dgw_yoneticiler.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtbx_ksoyisim.Text = dgw_yoneticiler.Rows[e.RowIndex].Cells[3].Value.ToString();
            indexKontrol = e.RowIndex;
            kadi = dgw_yoneticiler.Rows[e.RowIndex].Cells[0].Value.ToString();
            cmbx_bolge.SelectedIndex =Convert.ToInt16(Convert.ToInt16(dgw_yoneticiler.Rows[e.RowIndex].Cells[4].Value.ToString()) - 1);
            btn_kaydet.Text = "Güncelle";
            btn_sil.Enabled = true;
            btn_sil.Visible = true;
        }

        private void rbtn_admin_CheckedChanged(object sender, EventArgs e)
        {
            cmbx_bolge.Text = "";
            cmbx_bolge.Enabled = false;         
        }

        private void rbtn_yonetici_CheckedChanged(object sender, EventArgs e)
        {
            cmbx_bolge.Enabled = true;
        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            var bag = new NpgsqlConnection(baglanti);
            bag.Open();
            string sorgu2 = "select ykadi from yoneticiler where firmaid = '" + firmaid + "'";
            NpgsqlDataAdapter da2 = new NpgsqlDataAdapter(sorgu2, bag);
            DataSet ds2 = new DataSet();
            da2.Fill(ds2);
            string sorgu3 = "select akadi from adminler where firmaid = '" + firmaid + "'";
            NpgsqlDataAdapter da3 = new NpgsqlDataAdapter(sorgu3, bag);
            DataSet ds3 = new DataSet();
            da3.Fill(ds3);
            bag.Close();
            if (btn_kaydet.Text=="Ekle" && txtbx_kadi.Text!="" && txtbx_kisim.Text!="" && txtbx_ksifre.Text!="" && txtbx_ksoyisim.Text!="" && cmbx_bolge.Text!="")
            {
                for (int i = 0; i < ds2.Tables[0].Rows.Count; i++)
                {
                    if (ds2.Tables[0].Rows[i][0].ToString()==txtbx_kadi.Text.ToString())
                    {
                        kullaniciAdiKontrol = 1;
                    }
                }
                for (int i = 0; i < ds3.Tables[0].Rows.Count; i++)
                {
                    if (ds3.Tables[0].Rows[i][0].ToString() == txtbx_kadi.Text.ToString())
                    {
                        kullaniciAdiKontrol = 1;
                    }
                }
                if (kullaniciAdiKontrol==0)
                {
                    var bag2 = new NpgsqlConnection(baglanti);
                    bag2.Open();
                    DbCommand dbCommand = bag2.CreateCommand();
                    dbCommand.CommandText = @"
                    INSERT INTO yoneticiler (ykadi, ysifre, yadi, ysoyadi, ysorumlubolge, firmaid) 
                        VALUES ('" + txtbx_kadi.Text + "', '" + txtbx_ksifre.Text + "', '" + txtbx_kisim.Text + "', '" + txtbx_ksoyisim.Text + "' ," +
                        " '" + (cmbx_bolge.SelectedIndex - 1) + "', "+firmaid+")";
                        dbCommand.ExecuteNonQuery();
                        bag2.Close();
                        temizle();
                }
                else
                {
                    MessageBox.Show("Bu kullanıcı adı uygun değil", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (btn_kaydet.Text == "Güncelle" && txtbx_kadi.Text != "" && txtbx_kisim.Text != "" && txtbx_ksifre.Text != "" && txtbx_ksoyisim.Text != "" && cmbx_bolge.Text!="")
            {
                for (int i = 0; i < ds2.Tables[0].Rows.Count; i++)
                {
                    if (i == indexKontrol)
                    {

                    }
                    else
                    {
                        if (ds2.Tables[0].Rows[i][0].ToString() == txtbx_kadi.Text.ToString())
                        {
                            kullaniciAdiKontrol = 1;
                        }
                    }           
                }
                if (kullaniciAdiKontrol == 0)
                {
                    string sorgu4 = "select bolgeno from bolgeler where bolgead = '" + cmbx_bolge.Text + "'";
                    NpgsqlDataAdapter da4 = new NpgsqlDataAdapter(sorgu4, bag);
                    DataSet ds4 = new DataSet();
                    da4.Fill(ds4);
                    var bag3 = new NpgsqlConnection(baglanti);
                    bag3.Open();
                    DbCommand dbCommand = bag3.CreateCommand();
                    dbCommand.CommandText = @"
                    UPDATE yoneticiler set ykadi = '" + txtbx_kadi.Text + "', ysifre = '" + txtbx_ksifre.Text + "', yadi = '" + txtbx_kisim.Text + "', " +
                    "ysoyadi = '" + txtbx_ksoyisim.Text + "', ysorumlubolge = "+ Convert.ToInt16(ds4.Tables[0].Rows[0][0].ToString()) + " " +
                    "where ykadi='" + kadi + "'";
                    dbCommand.ExecuteNonQuery();
                    bag3.Close();
                    temizle();
                }
                else
                {
                    MessageBox.Show("Bu kullanıcı adı uygun değil", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Lütfen alanları boş bırakmadığınızdan emin olunuz","Uyarı", MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            var bag5 = new NpgsqlConnection(baglanti);
            bag5.Open();
            DbCommand dbCommand = bag5.CreateCommand();
            dbCommand.CommandText = @"
                DELETE FROM yoneticiler WHERE ykadi = '" + kadi + "'";

            dbCommand.ExecuteNonQuery();
            bag5.Close();
            temizle();
        }

        private void btn_cikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
