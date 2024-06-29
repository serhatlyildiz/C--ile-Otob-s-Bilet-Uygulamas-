using Npgsql;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    public partial class frm_anaForm : Form
    {
        public frm_anaForm()
        {
            InitializeComponent();
        }
        frm_biletAl biletAl = new frm_biletAl();
        frm_biletlerim biletlerim = new frm_biletlerim();
        frm_yonetici yonetici = new frm_yonetici();
        string baglanti = "Host=localhost;Username=postgres;Password=1420;Database=OtobusBiletVT";
        int kontrol = 0;
        bool SayiMi(string text)
        {
            foreach (char chr in text)
            {
                if (!Char.IsNumber(chr)) return false;
            }
            return true;
        }
        private void frm_anaForm_Load(object sender, EventArgs e)
        {
            var bag = new NpgsqlConnection(baglanti);
            bag.Open();

            string sorgu = "select ilad from Iller";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, bag);
            DataSet ds = new DataSet();
            da.Fill(ds);
            for (int i = 0; i < 81; i++)
            {
                cmb_nereden.Items.Add(ds.Tables[0].Rows[i][0].ToString());
                cmb_nereye.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }          
            dtp_tarih.MinDate = DateTime.Now;
            dtp_tarih.Value = DateTime.Now;
            NpgsqlCommand command = new NpgsqlCommand("update_sefer_durumu_procedure", bag);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.ExecuteNonQuery();
            bag.Close();
        }

        private void btn_biletlerim_Click(object sender, EventArgs e)
        {
            var bag = new NpgsqlConnection(baglanti);
            bag.Open();
            if (txt_Tc.Text != "" && txt_Tc.Text.Length == 11 && SayiMi(txt_Tc.Text) == true)
            {
                string sorgu2 = "select mtc from musteri where mtc = '"+txt_Tc.Text+"'";
                NpgsqlDataAdapter da2 = new NpgsqlDataAdapter(sorgu2, bag);
                DataSet ds2 = new DataSet();
                da2.Fill(ds2);
                if (ds2.Tables[0].Rows.Count!=0)
                {
                    for (int i = 0; i < ds2.Tables[0].Rows.Count; i++)
                    {
                        if (ds2.Tables[0].Rows[i][0].ToString()==txt_Tc.Text.ToString())
                        {
                            kontrol = 1;
                        }
                        else
                        {
                            
                        }
                        if (kontrol==1)
                        {
                            biletlerim.tcNumarasi = txt_Tc.Text.ToString();
                            biletlerim.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("Lütfen tc kimlik numaranızı kontrol ediniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }                
                }
                else
                {
                    MessageBox.Show("Geçmiş veya aktif biletiniz bulunmamaktadır.","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Lütfen tc kimlik numaranızı kontrol ediniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            bag.Close();
        }

        private void btn_yGiris_Click(object sender, EventArgs e)
        {
            yonetici.ShowDialog();
        }

        private void btn_cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_biletBul_Click(object sender, EventArgs e)
        {
            var bag = new NpgsqlConnection(baglanti);
            bag.Open();
            if (cmb_nereden.Text!=""&&cmb_nereye.Text!=""&&cmb_nereden.Text!=cmb_nereye.Text)
            {
                string sorgu2 = "select kalkisyeri, varisyeri, kalkiszaman, variszaman, kalkissaati, varissaati, koltuksayisi, boskoltuksayisi from sefer where kalkisyeri = '" + cmb_nereden.Text + "' and " +
                "varisyeri = '" + cmb_nereye.Text + "' and kalkiszaman = '" + dtp_tarih.Value.ToShortDateString() + "'";
                NpgsqlDataAdapter da2 = new NpgsqlDataAdapter(sorgu2, bag);
                DataSet ds2 = new DataSet();
                da2.Fill(ds2);
                if (ds2.Tables[0].Rows.Count != 0)
                {
                    bag.Close();
                    biletAl.nereden = cmb_nereden.Text;
                    biletAl.nereye = cmb_nereye.Text;
                    biletAl.tarih = Convert.ToDateTime(dtp_tarih.Value.ToShortDateString());
                    biletAl.ShowDialog();
                }
                else
                {
                    bag.Close();
                    MessageBox.Show("Uygun sefer bulunamadı","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }          
            }
            else
            {
                MessageBox.Show("Lütfen Alanları doğru girdiğinizden emin olunuz","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }
    }
}
