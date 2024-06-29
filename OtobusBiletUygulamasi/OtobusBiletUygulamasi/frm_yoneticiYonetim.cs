using Npgsql;
using Npgsql.Internal.Postgres;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtobusBiletUygulamasi
{
    public partial class frm_yoneticiYonetim : Form
    {
        public frm_yoneticiYonetim()
        {
            InitializeComponent();
        }
        public string kAdi = "";
        public string girisKontrol = "";
        public string sutunKontrol = "";
        string baglanti = "Host=localhost;Username=postgres;Password=1420;Database=OtobusBiletVT";
        int firmaid = 0;
        int secilenSeferid = 0;
        string viewTablo = "";
        frm_yoneticilerYonetimi frm_yYonetimi = new frm_yoneticilerYonetimi();
        bool SayiMi(string text)
        {
            foreach (char chr in text)
            {
                if (!Char.IsNumber(chr)) return false;
            }
            return true;
        }
        public void temizle() {
            int personelKontrol = 0;
            cmbx_nereden.Text = "";
            cmbx_nereye.Text = "";
            txt_kalkisSaat.Text = "";
            txt_kalkisDakika.Text = "";
            txt_varissSaat.Text = "";
            txt_varisDakika.Text = "";
            dtp_kalkis.MinDate = DateTime.Now.AddDays(-1);
            dtp_varis.MinDate = DateTime.Now.AddDays(-1);
            dtp_kalkis.Value = DateTime.Now;
            dtp_varis.Value = DateTime.Now;
            cmbx_sofor.Text = "";
            cmbx_muavin.Text = "";
            rbtn_cift.Checked = false;
            rbtn_tek.Checked = false;
            btn_seferEkle.Text = "Sefer Ekle";
            btn_sil.Enabled = false;
            btn_sil.Visible = false;
            txtbx_ucret.Text = "";
            dgw_seferler.DataSource="";

            var bag = new NpgsqlConnection(baglanti);
            bag.Open();
            string sorgu = "select firmaid from " + girisKontrol + " where " + sutunKontrol + "kadi = '" + kAdi + "'";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, bag);
            DataSet ds = new DataSet();
            da.Fill(ds);

            string sorgu3 = "select ilad from iller";
            NpgsqlDataAdapter da3 = new NpgsqlDataAdapter(sorgu3, bag);
            DataSet ds3 = new DataSet();
            da3.Fill(ds3);
            firmaid = Convert.ToInt32(ds.Tables[0].Rows[0][0].ToString());
            if (girisKontrol == "adminler")
            {
                string sorgu7 = "select * from sefer where firmaid = " + firmaid + "";
                NpgsqlDataAdapter da7 = new NpgsqlDataAdapter(sorgu7, bag);
                DataSet ds7 = new DataSet();
                da7.Fill(ds7);
                if (ds7.Tables[0].Rows.Count != 0)
                {
                    dgw_seferler.DataSource = ds7.Tables[0].DefaultView;
                }
                else
                {
                    MessageBox.Show("Sefer yok", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                cmbx_nereden.Items.Clear();

                for (int i = 0; i < ds3.Tables[0].Rows.Count; i++)
                {
                    cmbx_nereden.Items.Add(ds3.Tables[0].Rows[i][0]);
                }
                frm_yYonetimi.firmaid = firmaid;
                btn_yoneticiler.Enabled = true;
                btn_yoneticiler.Visible = true;
            }
            else
            {
                cmbx_nereden.Items.Clear();
                cmbx_nereye.Items.Clear();
                string sorgu6 = "select ysorumlubolge from yoneticiler where ykadi = '" + kAdi + "'";
                NpgsqlDataAdapter da6 = new NpgsqlDataAdapter(sorgu6, bag);
                DataSet ds6 = new DataSet();
                da6.Fill(ds6);
                switch (Convert.ToInt16(ds6.Tables[0].Rows[0][0].ToString()))
                {
                    case 1:
                        viewTablo = "bolge1";
                        break;
                    case 2:
                        viewTablo = "bolge2";
                        break;
                    case 3:
                        viewTablo = "bolge3";
                        break;
                    case 4:
                        viewTablo = "bolge4";
                        break;
                    case 5:
                        viewTablo = "bolge5";
                        break;
                    case 6:
                        viewTablo = "bolge6";
                        break;
                    case 7:
                        viewTablo = "bolge7";
                        break;

                    default:
                        break;
                }
                string sorgu2 = "select ilad from iller where bolgeno = " + Convert.ToInt32(ds6.Tables[0].Rows[0][0].ToString()) + "";
                NpgsqlDataAdapter da2 = new NpgsqlDataAdapter(sorgu2, bag);
                DataSet ds2 = new DataSet();
                da2.Fill(ds2);
                for (int i = 0; i < ds2.Tables[0].Rows.Count; i++)
                {
                    cmbx_nereden.Items.Add(ds2.Tables[0].Rows[i][0]);
                }
                string sorgu8 = "select * from "+viewTablo+"";
                NpgsqlDataAdapter da8 = new NpgsqlDataAdapter(sorgu8, bag);
                DataSet ds8 = new DataSet();
                da8.Fill(ds8);
                dgw_seferler.DataSource = ds8.Tables[0].DefaultView;
                btn_yoneticiler.Enabled = false;
                btn_yoneticiler.Visible = false;
            }
            cmbx_sofor.Items.Clear();
            cmbx_muavin.Items.Clear();
            string sorgu9 = "select p1, p2 from sefer where kalkiszaman = '"+ DateTime.Now.ToShortDateString() + "'";
            NpgsqlDataAdapter da9 = new NpgsqlDataAdapter(sorgu9, bag);
            DataSet ds9 = new DataSet();
            da9.Fill(ds9);
            string sorgu10 = "select p1, p2 from sefer";
            NpgsqlDataAdapter da10 = new NpgsqlDataAdapter(sorgu10, bag);
            DataSet ds10 = new DataSet();
            da10.Fill(ds10);

            string sorgu4 = "select pid, pad, psoyad from personel where firmaid = " + firmaid + " and ppozisyon = 'şoför'";
            NpgsqlDataAdapter da4 = new NpgsqlDataAdapter(sorgu4, bag);
            DataSet ds4 = new DataSet();
            da4.Fill(ds4);
            for (int i = 0; i < ds4.Tables[0].Rows.Count; i++)
            {
                if (ds9.Tables[0].Rows.Count!=0)
                {
                    for (int b = 0; b < ds9.Tables[0].Rows.Count; b++)
                    { 
                        if (ds4.Tables[0].Rows[i][0].ToString() == ds9.Tables[0].Rows[b][0].ToString())
                        {
                            personelKontrol = 1;
                        }
                    }                      
                    if (personelKontrol == 0)
                    {
                        cmbx_sofor.Items.Add(ds4.Tables[0].Rows[i][0] + " " + ds4.Tables[0].Rows[i][1] + " " + ds4.Tables[0].Rows[i][2]);
                    }
                    else
                    {
                        personelKontrol = 0;
                    }                  
                }
                else
                {
                    cmbx_sofor.Items.Add(ds4.Tables[0].Rows[i][0] + " " + ds4.Tables[0].Rows[i][1] + " " + ds4.Tables[0].Rows[i][2]);
                }
            }
            string sorgu5 = "select pid, pad, psoyad from personel where firmaid = " + firmaid + " and ppozisyon = 'muavin'";
            NpgsqlDataAdapter da5 = new NpgsqlDataAdapter(sorgu5, bag);
            DataSet ds5 = new DataSet();
            da5.Fill(ds5);
            for (int i = 0; i < ds5.Tables[0].Rows.Count; i++)
            {
                if (ds.Tables[0].Rows.Count != 0)
                {
                    for (int a = 0; a < ds9.Tables[0].Rows.Count; a++)
                    {
                        if (ds4.Tables[0].Rows[i][0] == ds9.Tables[0].Rows[a][1])
                        {
                            personelKontrol = 1;
                        }
                    }
                    if (personelKontrol == 0)
                    {
                        cmbx_muavin.Items.Add(ds5.Tables[0].Rows[i][0] + " " + ds5.Tables[0].Rows[i][1] + " " + ds5.Tables[0].Rows[i][2]);
                    }
                    else
                    {
                        personelKontrol = 0;
                    }
                }
                else
                {
                    cmbx_muavin.Items.Add(ds5.Tables[0].Rows[i][0] + " " + ds5.Tables[0].Rows[i][1] + " " + ds5.Tables[0].Rows[i][2]);
                }             
            }
            if (cmbx_sofor.Items.Count==0)
            {
                MessageBox.Show("Boşta Şoför yok");
            }
            else if (cmbx_muavin.Items.Count==0)
            {
                MessageBox.Show("Boşta muavin yok");
            }
            bag.Close();
        }
        private void btn_cikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_yoneticiYonetim_Load(object sender, EventArgs e)
        {
            temizle();
            var bag = new NpgsqlConnection(baglanti);
            bag.Open();

            string sorgu3 = "select ilad from iller";
            NpgsqlDataAdapter da3 = new NpgsqlDataAdapter(sorgu3, bag);
            DataSet ds3 = new DataSet();
            da3.Fill(ds3);
            for (int i = 0; i < ds3.Tables[0].Rows.Count; i++)
            {
                cmbx_nereye.Items.Add(ds3.Tables[0].Rows[i][0]);
            }
            bag.Close();
        }

        private void btn_seferEkle_Click(object sender, EventArgs e)
        {
            var bag = new NpgsqlConnection(baglanti);
            bag.Open();
            if (btn_seferEkle.Text=="Sefer Ekle")
            {
                if (cmbx_nereden.Text != "" && cmbx_nereye.Text != "" && cmbx_nereden.Text != cmbx_nereye.Text &&
                txt_kalkisSaat.Text.Length == 2 && txt_kalkisDakika.Text.Length == 2 && txt_varissSaat.Text.Length == 2 &&
                txt_varisDakika.Text.Length == 2 && SayiMi(txt_kalkisSaat.Text) == true && SayiMi(txt_kalkisDakika.Text) == true &&
                SayiMi(txt_varissSaat.Text) == true && SayiMi(txt_varisDakika.Text) == true && cmbx_sofor.Text != "" &&
                cmbx_muavin.Text != "" && (rbtn_cift.Checked || rbtn_tek.Checked) && txtbx_ucret.Text != "" && SayiMi(txtbx_ucret.Text) == true && dtp_kalkis.Value<=dtp_varis.Value)
                {
                    string kalkissaat = txt_kalkisSaat.Text + ":" + txt_kalkisDakika.Text;
                    string varissaat = txt_varissSaat.Text + ":" + txt_varisDakika.Text;
                    int koltuksayisi = 0;
                    if (rbtn_cift.Checked)
                    {
                        koltuksayisi = Convert.ToInt16(rbtn_cift.Text);
                    }
                    else
                    {
                        koltuksayisi = Convert.ToInt16(rbtn_tek.Text);
                    }
                    string sofor = cmbx_sofor.Text;
                    string[] soforr = sofor.Split(' ');
                    string muavin = cmbx_muavin.Text;
                    string[] muavinn = muavin.Split(' ');
                    DbCommand dbCommand = bag.CreateCommand();
                    dbCommand.CommandText = @"
                INSERT INTO sefer (firmaid, kalkisyeri, varisyeri, kalkiszaman, variszaman, kalkissaati, varissaati, p1, p2, 
                koltuksayisi, dolukoltuksayisi, boskoltuksayisi, seferdurumu, ucret) 
                VALUES(" + firmaid + ", '" + cmbx_nereden.Text + "', '" + cmbx_nereye.Text + "', '" + dtp_kalkis.Value.Date.ToShortDateString() + "', " +
                    " '" + dtp_varis.Value.Date.ToShortDateString() + "', '" + kalkissaat + "', '" + varissaat + "'," +
                    " " + Convert.ToInt16(soforr[0].ToString()) + ", " + Convert.ToInt16(muavinn[0].ToString()) + ", " +
                    " " + koltuksayisi + ", 0, " + koltuksayisi + ", 'aktif', " + Convert.ToInt16(txtbx_ucret.Text) + ")";

                    dbCommand.ExecuteNonQuery();
                    temizle();
                }
                else
                {
                    MessageBox.Show("Girilen değerlerde yanlışlık var lütfen doğru girdiğinizden emin olun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                int koltuksayi = 0;
                if (cmbx_nereden.Text != "" && cmbx_nereye.Text != "" && cmbx_nereden.Text != cmbx_nereye.Text &&
                txt_kalkisSaat.Text.Length == 2 && txt_kalkisDakika.Text.Length == 2 && txt_varissSaat.Text.Length == 2 &&
                txt_varisDakika.Text.Length == 2 && SayiMi(txt_kalkisSaat.Text) == true && SayiMi(txt_kalkisDakika.Text) == true &&
                SayiMi(txt_varissSaat.Text) == true && SayiMi(txt_varisDakika.Text) == true && cmbx_sofor.Text != "" &&
                cmbx_muavin.Text != "" && (rbtn_cift.Checked || rbtn_tek.Checked) && txtbx_ucret.Text != "" && dtp_kalkis.Value <= dtp_varis.Value)
                {
                    string kalkissaat = txt_kalkisSaat.Text + ":" + txt_kalkisDakika.Text;
                    string varissaat = txt_varissSaat.Text + ":" + txt_varisDakika.Text;
                    int koltuksayisi = 0;
                    if (rbtn_cift.Checked)
                    {
                        koltuksayisi = Convert.ToInt16(rbtn_cift.Text);
                    }
                    else
                    {
                        koltuksayisi = Convert.ToInt16(rbtn_tek.Text);
                    }
                    string sorgu10 = "select koltuksayisi, dolukoltuksayisi, boskoltuksayisi, seferdurumu from sefer where sid = " + secilenSeferid+"";
                    NpgsqlDataAdapter da10 = new NpgsqlDataAdapter(sorgu10, bag);
                    DataSet ds10 = new DataSet();
                    da10.Fill(ds10);
                    if (rbtn_cift.Checked==true)
                    {
                        string sofor = cmbx_sofor.Text;
                        string[] soforr = sofor.Split(' ');
                        string muavin = cmbx_muavin.Text;
                        string[] muavinn = muavin.Split(' ');
                        DbCommand dbCommand = bag.CreateCommand();
                        dbCommand.CommandText = @"
                        UPDATE sefer set kalkisyeri = '" + cmbx_nereden.Text + "', varisyeri = '" + cmbx_nereye.Text + "', kalkiszaman = '" + dtp_kalkis.Value.Date.ToShortDateString() + "', " +
                        "variszaman = '" + dtp_varis.Value.Date.ToShortDateString() + "', kalkissaati = '" + kalkissaat + "', " +
                        "varissaati = '" + varissaat + "', p1 = " + Convert.ToInt16(soforr[0].ToString()) + ", p2 = " + Convert.ToInt16(muavinn[0].ToString()) + ", " +
                        "koltuksayisi = " + Convert.ToInt16(rbtn_cift.Text) + ", dolukoltuksayisi = " + Convert.ToInt16(ds10.Tables[0].Rows[0][1].ToString()) + ", " +
                        "boskoltuksayisi = " + Convert.ToInt16(rbtn_cift.Text) + ", ucret = " + Convert.ToInt16(txtbx_ucret.Text) + "  where sid = " + secilenSeferid + "";
                        dbCommand.ExecuteNonQuery();
                        temizle();
                    }
                    else
                    {
                        string sofor = cmbx_sofor.Text;
                        string[] soforr = sofor.Split(' ');
                        string muavin = cmbx_muavin.Text;
                        string[] muavinn = muavin.Split(' ');
                        DbCommand dbCommand = bag.CreateCommand();
                        dbCommand.CommandText = @"
                        UPDATE sefer set kalkisyeri = '" + cmbx_nereden.Text + "', varisyeri = '" + cmbx_nereye.Text + "', kalkiszaman = '" + dtp_kalkis.Value.Date.ToShortDateString() + "', " +
                        "variszaman = '" + dtp_varis.Value.Date.ToShortDateString() + "', kalkissaati = '" + kalkissaat + "', " +
                        "varissaati = '" + varissaat + "', p1 = " + Convert.ToInt16(soforr[0].ToString()) + ", p2 = " + Convert.ToInt16(muavinn[0].ToString()) + ", " +
                        "koltuksayisi = " + Convert.ToInt16(rbtn_tek.Text) + ", dolukoltuksayisi = " + Convert.ToInt16(ds10.Tables[0].Rows[0][1].ToString()) + ", " +
                        "boskoltuksayisi = " + Convert.ToInt16(rbtn_tek.Text) + ", ucret = " + Convert.ToInt16(txtbx_ucret.Text) + "  where sid = " + secilenSeferid + "";
                        dbCommand.ExecuteNonQuery();
                        temizle();
                    }
                }
                else
                {
                    MessageBox.Show("Alanların doğru girildiğinden emin olun","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
            }                
            bag.Close();
        }

        private void btn_personel_Click(object sender, EventArgs e)
        {
            frm_personeller frm_personel = new frm_personeller();
            frm_personel.firmaidd = firmaid;
            frm_personel.ShowDialog();
            int personelKontrol = 0;
            var bag = new NpgsqlConnection(baglanti);
            bag.Open();
            string sorgu = "select firmaid from " + girisKontrol + " where " + sutunKontrol + "kadi = '" + kAdi + "'";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, bag);
            DataSet ds = new DataSet();
            da.Fill(ds);
            cmbx_sofor.Items.Clear();
            cmbx_muavin.Items.Clear();
            string sorgu9 = "select p1, p2 from sefer where kalkiszaman = '" + DateTime.Now.ToShortDateString() + "'";
            NpgsqlDataAdapter da9 = new NpgsqlDataAdapter(sorgu9, bag);
            DataSet ds9 = new DataSet();
            da9.Fill(ds9);
            string sorgu10 = "select p1, p2 from sefer";
            NpgsqlDataAdapter da10 = new NpgsqlDataAdapter(sorgu10, bag);
            DataSet ds10 = new DataSet();
            da10.Fill(ds10);

            string sorgu4 = "select pid, pad, psoyad from personel where firmaid = " + firmaid + " and ppozisyon = 'şoför'";
            NpgsqlDataAdapter da4 = new NpgsqlDataAdapter(sorgu4, bag);
            DataSet ds4 = new DataSet();
            da4.Fill(ds4);
            for (int i = 0; i < ds4.Tables[0].Rows.Count; i++)
            {
                if (ds9.Tables[0].Rows.Count != 0)
                {
                    for (int b = 0; b < ds9.Tables[0].Rows.Count; b++)
                    {
                        if (ds4.Tables[0].Rows[i][0].ToString() == ds9.Tables[0].Rows[b][0].ToString())
                        {
                            personelKontrol = 1;
                        }
                    }
                    if (personelKontrol == 0)
                    {
                        cmbx_sofor.Items.Add(ds4.Tables[0].Rows[i][0] + " " + ds4.Tables[0].Rows[i][1] + " " + ds4.Tables[0].Rows[i][2]);
                    }
                    else
                    {
                        personelKontrol = 0;
                    }
                }
                else
                {
                    cmbx_sofor.Items.Add(ds4.Tables[0].Rows[i][0] + " " + ds4.Tables[0].Rows[i][1] + " " + ds4.Tables[0].Rows[i][2]);
                }
            }
            string sorgu5 = "select pid, pad, psoyad from personel where firmaid = " + firmaid + " and ppozisyon = 'muavin'";
            NpgsqlDataAdapter da5 = new NpgsqlDataAdapter(sorgu5, bag);
            DataSet ds5 = new DataSet();
            da5.Fill(ds5);
            for (int i = 0; i < ds5.Tables[0].Rows.Count; i++)
            {
                if (ds.Tables[0].Rows.Count != 0)
                {
                    for (int a = 0; a < ds9.Tables[0].Rows.Count; a++)
                    {
                        if (ds4.Tables[0].Rows[i][0] == ds9.Tables[0].Rows[a][1])
                        {
                            personelKontrol = 1;
                        }
                    }
                    if (personelKontrol == 0)
                    {
                        cmbx_muavin.Items.Add(ds5.Tables[0].Rows[i][0] + " " + ds5.Tables[0].Rows[i][1] + " " + ds5.Tables[0].Rows[i][2]);
                    }
                    else
                    {
                        personelKontrol = 0;
                    }
                }
                else
                {
                    cmbx_muavin.Items.Add(ds5.Tables[0].Rows[i][0] + " " + ds5.Tables[0].Rows[i][1] + " " + ds5.Tables[0].Rows[i][2]);
                }
            }
            if (cmbx_sofor.Items.Count == 0)
            {
                MessageBox.Show("Boşta Şoför yok");
            }
            else if (cmbx_muavin.Items.Count == 0)
            {
                MessageBox.Show("Boşta muavin yok");
            }
            bag.Close();
        }

        private void btn_yoneticiler_Click(object sender, EventArgs e)
        {
            frm_yYonetimi.ShowDialog();
        }

        private void dgw_seferler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var bag = new NpgsqlConnection(baglanti);
            bag.Open();
            if (dgw_seferler.Rows[e.RowIndex].Cells[13].Value.ToString()=="aktif")
            {
                string kalkissaat = "";
                string varissat = "";
                DateTime kalkis = Convert.ToDateTime(dgw_seferler.Rows[e.RowIndex].Cells[4].Value);
                DateTime varis = Convert.ToDateTime(dgw_seferler.Rows[e.RowIndex].Cells[5].Value);
                cmbx_nereden.SelectedItem = dgw_seferler.Rows[e.RowIndex].Cells[2].Value.ToString();
                cmbx_nereye.SelectedItem = dgw_seferler.Rows[e.RowIndex].Cells[3].Value.ToString();
                dtp_kalkis.Value = Convert.ToDateTime(kalkis.ToShortDateString());
                dtp_varis.Value = Convert.ToDateTime(varis.ToShortDateString());
                kalkissaat = dgw_seferler.Rows[e.RowIndex].Cells[6].Value.ToString();
                varissat = dgw_seferler.Rows[e.RowIndex].Cells[7].Value.ToString();
                txt_kalkisSaat.Text = kalkissaat[0].ToString()+kalkissaat[1].ToString();
                txt_kalkisDakika.Text = kalkissaat[3].ToString() + kalkissaat[4].ToString();
                txt_varissSaat.Text = varissat[0].ToString()+varissat[1].ToString();
                txt_varisDakika.Text = varissat[3].ToString() + varissat[4].ToString();            
                string sorgu11 = "select pid, pad, psoyad from personel where pid = "+ dgw_seferler.Rows[e.RowIndex].Cells[8].Value+ "";
                NpgsqlDataAdapter da11 = new NpgsqlDataAdapter(sorgu11, bag);
                DataSet ds11 = new DataSet();
                da11.Fill(ds11);
                string sorgu12 = "select pid, pad, psoyad from personel where pid = " + dgw_seferler.Rows[e.RowIndex].Cells[9].Value + "";
                NpgsqlDataAdapter da12 = new NpgsqlDataAdapter(sorgu12, bag);
                DataSet ds12 = new DataSet();
                da12.Fill(ds12);
                cmbx_sofor.Text = ds11.Tables[0].Rows[0][0].ToString() + " " + ds11.Tables[0].Rows[0][1].ToString() + " " + ds11.Tables[0].Rows[0][2].ToString();
                cmbx_muavin.Text = ds12.Tables[0].Rows[0][0].ToString() + " " + ds12.Tables[0].Rows[0][1].ToString() + " " + ds12.Tables[0].Rows[0][2].ToString();
                if (Convert.ToInt16(dgw_seferler.Rows[e.RowIndex].Cells[10].Value)==40)
                {
                    rbtn_tek.Checked = true;
                }
                else
                {
                    rbtn_cift.Checked = true;
                }
                txtbx_ucret.Text = dgw_seferler.Rows[e.RowIndex].Cells[14].Value.ToString();
                string ucret = txtbx_ucret.Text;
                string[] ucrett = ucret.Split(',');
                txtbx_ucret.Text = ucrett[0].ToString();
                btn_sil.Enabled = true;
                btn_sil.Visible = true;
                btn_seferEkle.Text = "Sefer Güncelle";
                secilenSeferid = Convert.ToInt32(dgw_seferler.Rows[e.RowIndex].Cells[0].Value);
                string sorgu10 = "select koltuksayisi, dolukoltuksayisi, boskoltuksayisi, seferdurumu from sefer where sid = " + secilenSeferid + "";
                NpgsqlDataAdapter da10 = new NpgsqlDataAdapter(sorgu10, bag);
                DataSet ds10 = new DataSet();
                da10.Fill(ds10);
                if (Convert.ToInt16(ds10.Tables[0].Rows[0][1]) == 0)
                {
                    rbtn_cift.Enabled = true;
                    rbtn_tek.Enabled = true;
                }
                else
                {
                    rbtn_cift.Enabled = false;
                    rbtn_tek.Enabled = false;
                    MessageBox.Show("Koltuk satın alımı yapıldığından dolayı koltuk tipini değiştiremezsiniz", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Pasif durumunda olan seferleri güncelleyip silemezsiniz.","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            bag.Close();
        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            var bag = new NpgsqlConnection(baglanti);
            bag.Open();
            DbCommand dbCommand = bag.CreateCommand();
            dbCommand.CommandText = @"
                DELETE FROM sefer WHERE sid = " + secilenSeferid  + "";

            dbCommand.ExecuteNonQuery();
            bag.Close();
            temizle();
        }
    }
}
