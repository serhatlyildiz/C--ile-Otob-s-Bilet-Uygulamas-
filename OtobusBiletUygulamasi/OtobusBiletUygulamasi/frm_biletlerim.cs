using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtobusBiletUygulamasi
{
    public partial class frm_biletlerim : Form
    {
        public frm_biletlerim()
        {
            InitializeComponent();
        }
        public string tcNumarasi = "";
        string baglanti = "Host=localhost;Username=postgres;Password=1420;Database=OtobusBiletVT";
        string bid = "";
        string durum = "";
        int sid = 0;
        private void btn_cikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_biletlerim_Load(object sender, EventArgs e)
        {
            var bag = new NpgsqlConnection(baglanti);
            bag.Open();
            string sorgu2 = "select mid from musteri where mtc = '"+tcNumarasi+"'";
            NpgsqlDataAdapter da2 = new NpgsqlDataAdapter(sorgu2, bag);
            DataSet ds2 = new DataSet();
            da2.Fill(ds2);

            string sorgu = "select f.firmaadi, s.sid, s.kalkisyeri, s.varisyeri, s.kalkiszaman, s.variszaman, s.kalkissaati, s.varissaati, s.koltuksayisi, s.boskoltuksayisi, b.koltukno, b.bid, s.ucret, b.biletdurumu from sefer as s inner join firma as f on s.firmaid = f.firmaid inner join bilet as b on b.sid = s.sid where b.mid=" + Convert.ToInt16(ds2.Tables[0].Rows[0][0]) +"";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, bag);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgw_biletler.Columns.Clear();
            dgw_biletler.DataSource = ds.Tables[0].DefaultView;
            bag.Close();
            DataGridViewButtonColumn btn1 = new DataGridViewButtonColumn();
            btn1.HeaderText = "İptal";
            btn1.Text = "İptal Et";
            btn1.Name = "iptal";
            btn1.UseColumnTextForButtonValue = true;
            btn1.Width = 100;
            btn1.DefaultCellStyle.BackColor = Color.Red;
            btn1.DefaultCellStyle.ForeColor = Color.White;
            dgw_biletler.Columns.Add(btn1);
        }

        private void dgw_biletler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var bag = new NpgsqlConnection(baglanti);
            bag.Open();
            if (e.ColumnIndex == dgw_biletler.Columns["iptal"].Index)
            {
                bid = dgw_biletler.Rows[e.RowIndex].Cells[11].Value.ToString();
                durum = dgw_biletler.Rows[e.RowIndex].Cells[13].Value.ToString();
                sid = Convert.ToInt16(dgw_biletler.Rows[e.RowIndex].Cells[1].Value);
                if (durum=="aktif")
                {
                    string sorgu = "select dolukoltuksayisi, boskoltuksayisi from sefer where sid = " + sid + "";
                    NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, bag);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    DbCommand dbCommand3 = bag.CreateCommand();
                    dbCommand3.CommandText = @"
                    UPDATE sefer set dolukoltuksayisi = " + Convert.ToInt16(Convert.ToInt16(ds.Tables[0].Rows[0][0]) - 1) + ", boskoltuksayisi = " + Convert.ToInt16(Convert.ToInt16(ds.Tables[0].Rows[0][1]) + 1) + "  where sid = " + sid + "";
                    dbCommand3.ExecuteNonQuery();

                    DbCommand dbCommand = bag.CreateCommand();
                    dbCommand.CommandText = @"
                    UPDATE bilet set biletdurumu = 'iptal' where bid = "+Convert.ToInt32(bid)+"";
                    dbCommand.ExecuteNonQuery();

                    string sorgu2 = "select mid from musteri where mtc = '" + tcNumarasi + "'";
                    NpgsqlDataAdapter da2 = new NpgsqlDataAdapter(sorgu2, bag);
                    DataSet ds2 = new DataSet();
                    da2.Fill(ds2);

                    string sorgu3 = "select f.firmaadi, s.sid, s.kalkisyeri, s.varisyeri, s.kalkiszaman, s.variszaman, s.kalkissaati, s.varissaati, s.koltuksayisi, s.boskoltuksayisi,b.koltukno, b.bid, s.ucret, b.biletdurumu from sefer as s inner join firma as f on s.firmaid = f.firmaid inner join bilet as b on b.sid = s.sid where b.mid=" + Convert.ToInt16(ds2.Tables[0].Rows[0][0]) + "";
                    NpgsqlDataAdapter da3 = new NpgsqlDataAdapter(sorgu3, bag);
                    DataSet ds3 = new DataSet();
                    da3.Fill(ds3);
                    dgw_biletler.Columns.Clear();
                    dgw_biletler.DataSource = ds3.Tables[0].DefaultView;
                    bag.Close();
                    DataGridViewButtonColumn btn1 = new DataGridViewButtonColumn();
                    btn1.HeaderText = "İptal";
                    btn1.Text = "İptal Et";
                    btn1.Name = "iptal";
                    btn1.UseColumnTextForButtonValue = true;
                    btn1.Width = 100;
                    btn1.DefaultCellStyle.BackColor = Color.Red;
                    btn1.DefaultCellStyle.ForeColor = Color.White;
                    dgw_biletler.Columns.Add(btn1);
                }
                else
                {
                    MessageBox.Show("Pasif veya iptal durumlarını iptal edemezsiniz","Bilgilendirme",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }

            }
            bag.Close();
        }
    }
}
