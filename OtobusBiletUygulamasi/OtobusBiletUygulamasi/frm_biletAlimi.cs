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
    public partial class frm_biletAlimi : Form
    {
        public frm_biletAlimi()
        {
            InitializeComponent();
        }
        public int sid = 0;
        public int koltukSayisi = 0;
        PictureBox btn;
        PictureBox btnn;
        int x = 118;
        int y = 256;
        string baglanti = "Host=localhost;Username=postgres;Password=1420;Database=OtobusBiletVT";
        PictureBox[] buton40 = new PictureBox[40];
        PictureBox[] buton58 = new PictureBox[58];
        string hangibtn = "";
        string secilibutontext = "";
        int cinsiyet = 0;
        int tckontrol=0;
        char cins = ' ';
        int biletAlimKontrol = 0;
        bool SayiMi(string text)
        {
            foreach (char chr in text)
            {
                if (!Char.IsNumber(chr)) return false;
            }
            return true;
        }
        private void btn_cikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void koltukOlustur() 
        {
            if (koltukSayisi==40)
            {
                for (int i = 1; i <= koltukSayisi; i++)
                {
                    btn = new PictureBox();
                    btn.Location = new Point(x, y);
                    btn.Height = 40;
                    btn.Width = 40;
                    btn.Text = i.ToString();
                    btn.Name = "btn_" + i.ToString();
                    btn.Click += new EventHandler(btn_Click);
                    btn.Image = Image.FromFile(Application.StartupPath + "\\resimler\\bos.png");
                    btn.BackgroundImageLayout = ImageLayout.Stretch;
                    Image img = btn.Image;
                    img.RotateFlip(RotateFlipType.Rotate270FlipNone);
                    btn.Image = img;
                    Controls.Add((PictureBox)btn);
                    buton40[i-1] = btn;
                    y -= 129;
                    if (i%3==0)
                    {
                        y = 256;
                        if (i!=39)
                        {
                            x += 46;
                        }
                        else
                        {
                            y = 81;
                        }
                    }
                    else if (i==37)
                    {
                        y = 210;
                    }
                    else if (i == 38)
                    {
                        y = 127;
                    }
                    else
                    {
                        if (y == -2)
                        {
                            y = 81;
                        }
                    }
                    
                }
            }
            else
            {
                for (int i = 1; i <= 28; i++)
                {
                    btnn = new PictureBox();
                    btnn.Location = new Point(x, y);
                    btnn.Height = 40;
                    btnn.Width = 40;
                    btnn.Text = i.ToString();
                    btnn.Name = "btnn_" + i.ToString();
                    btnn.Click += new EventHandler(btnn_Click);
                    btnn.Image = Image.FromFile(Application.StartupPath + "\\resimler\\bos.png");
                    btnn.BackgroundImageLayout = ImageLayout.Stretch;
                    Image imgg = btnn.Image;
                    imgg.RotateFlip(RotateFlipType.Rotate270FlipNone);
                    btnn.Image = imgg;
                    Controls.Add((PictureBox)btnn);
                    buton58[i - 1] = btnn;
                    y -= 46;
                    if (i%4==0)
                    {
                        x += 46;
                        y = 256;
                    }
                    if (i % 4 != 0 && i % 2 == 0)
                    {
                        y = 132;
                    }
                }
                btnn = new PictureBox();
                btnn.Location = new Point(440, 256);
                btnn.Height = 40;
                btnn.Width = 40;
                btnn.Text = "29";
                btnn.Name = "btnn_29";
                btnn.Click += new EventHandler(btnn_Click);
                btnn.Image = Image.FromFile(Application.StartupPath + "\\resimler\\bos.png");
                btnn.BackgroundImageLayout = ImageLayout.Stretch;
                Image img = btnn.Image;
                img.RotateFlip(RotateFlipType.Rotate270FlipNone);
                btnn.Image = img;
                Controls.Add((PictureBox)btnn);
                buton58[28] = btnn;
                btnn = new PictureBox();
                btnn.Location = new Point(440, 210);
                btnn.Height = 40;
                btnn.Width = 40;
                btnn.Text = "30";
                btnn.Name = "btnn_30";
                btnn.Click += new EventHandler(btnn_Click);
                btnn.Image = Image.FromFile(Application.StartupPath + "\\resimler\\bos.png");
                btnn.BackgroundImageLayout = ImageLayout.Stretch;
                btnn.Image = img;
                Controls.Add((PictureBox)btnn);
                buton58[29] = btnn;
                x = 486;
                y = 256;
                for (int i = 31; i <= koltukSayisi; i++)
                {
                    btnn = new PictureBox();
                    btnn.Location = new Point(x, y);
                    btnn.Height = 40;
                    btnn.Width = 40;
                    btnn.Text = i.ToString();
                    btnn.Name = "btnn_" + i.ToString();
                    btnn.Click += new EventHandler(btnn_Click);
                    btnn.Image = Image.FromFile(Application.StartupPath + "\\resimler\\bos.png");
                    btnn.BackgroundImageLayout = ImageLayout.Stretch;
                    Image imgg = btnn.Image;
                    imgg.RotateFlip(RotateFlipType.Rotate270FlipNone);
                    btnn.Image = imgg;
                    Controls.Add((PictureBox)btnn);
                    buton58[i-1] = btnn;
                    y -= 46;
                    if (i==34 || i==38 || i==46 || i == 42 || i == 50 || i==54)
                    {
                        x += 46;
                        y = 256;
                    }
                    if (i % 4 == 0)
                    {
                        y = 132;
                    }
                }

            }
        }
        private void frm_biletAlimi_Load(object sender, EventArgs e)
        {
            x = 118;
            y = 256;
            biletAlimKontrol = 0;
            if (buton40[0]!=null)
            {
                for (int i = 0; i < 40; i++)
                {
                    Controls.Remove((PictureBox)buton40[i]);
                }
            }
            if (buton58[0]!=null)
            {
                for (int i = 0; i < 58; i++)
                {
                    Controls.Remove((PictureBox)buton58[i]);
                }
            }
                      
            koltukOlustur();
            pctbox_sofor.Image = Image.FromFile(Application.StartupPath + "\\resimler\\otobusOn.png");
            Image img = pctbox_sofor.Image;
            img.RotateFlip(RotateFlipType.Rotate270FlipNone);
            pctbox_sofor.Image = img;
            var bag = new NpgsqlConnection(baglanti);
            bag.Open();
            string sorgu2 = "select dolukoltuksayisi from sefer where sid = "+sid+"";
            NpgsqlDataAdapter da2 = new NpgsqlDataAdapter(sorgu2, bag);
            DataSet ds2 = new DataSet();
            da2.Fill(ds2);
            string sorgu3 = "select mid, koltukno from bilet where sid = " + sid + " and biletdurumu = 'aktif'";
            NpgsqlDataAdapter da3 = new NpgsqlDataAdapter(sorgu3, bag);
            DataSet ds3 = new DataSet();
            da3.Fill(ds3);
            if (Convert.ToInt16(ds2.Tables[0].Rows[0][0])!=0)
            {
                for (int i = 0; i < ds3.Tables[0].Rows.Count; i++)
                {
                    string sorgu4 = "select mcinsiyet from musteri where mid = " + ds3.Tables[0].Rows[i][0] + "";
                    NpgsqlDataAdapter da4 = new NpgsqlDataAdapter(sorgu4, bag);
                    DataSet ds4 = new DataSet();
                    da4.Fill(ds4);
                    if (buton40[0] != null)
                    {
                        for (int a = 0; a < 40; a++)
                        {
                            if (Convert.ToInt16(buton40[a].Text) == Convert.ToInt16(ds3.Tables[0].Rows[i][1]))
                            {
                                if (Convert.ToChar(ds4.Tables[0].Rows[0][0])=='K')
                                {
                                    buton40[a].Image = Image.FromFile(Application.StartupPath + "\\resimler\\bayan.png");
                                    buton40[a].BackgroundImageLayout = ImageLayout.Stretch;
                                    Image imgg = buton40[a].Image;
                                    imgg.RotateFlip(RotateFlipType.Rotate270FlipNone);
                                    buton40[a].Image = imgg;
                                    buton40[a].Enabled = false;
                                }
                                else
                                {
                                    buton40[a].Image = Image.FromFile(Application.StartupPath + "\\resimler\\bay.png");
                                    buton40[a].BackgroundImageLayout = ImageLayout.Stretch;
                                    Image imgg = buton40[a].Image;
                                    imgg.RotateFlip(RotateFlipType.Rotate270FlipNone);
                                    buton40[a].Image = imgg;
                                    buton40[a].Enabled = false;
                                }
                            }
                        }
                    }
                    if (buton58[0] != null)
                    {
                        for (int b = 0; b < 58; b++)
                        {
                            if (Convert.ToInt16(buton58[b].Text) == Convert.ToInt16(ds3.Tables[0].Rows[i][1]))
                            {

                                if (Convert.ToChar(ds4.Tables[0].Rows[0][0]) == 'K')
                                {
                                    buton58[b].Image = Image.FromFile(Application.StartupPath + "\\resimler\\bayan.png");
                                    buton58[b].BackgroundImageLayout = ImageLayout.Stretch;
                                    Image imgg = buton58[b].Image;
                                    imgg.RotateFlip(RotateFlipType.Rotate270FlipNone);
                                    buton58[b].Image = imgg;
                                    buton58[b].Enabled = false;
                                }
                                else
                                {
                                    buton58[b].Image = Image.FromFile(Application.StartupPath + "\\resimler\\bay.png");
                                    buton58[b].BackgroundImageLayout = ImageLayout.Stretch;
                                    Image imgg = buton58[b].Image;
                                    imgg.RotateFlip(RotateFlipType.Rotate270FlipNone);
                                    buton58[b].Image = imgg;
                                    buton58[b].Enabled = false;
                                }
                            }
                        }
                    }

                }
            }
            bag.Close();
            lbl_koltukSayisi.Text = "";
            grpbx_cinsiyet.Enabled = false;
            grpbx_cinsiyet.Visible = false;
            grpbx_kullaniciBilgileri.Enabled = false;
            biletAlimKontrol = 0;
        }
        private void btn_Click(object sender, EventArgs e)
        {
            PictureBox button = sender as PictureBox;
            grpbx_cinsiyet.Enabled = true;
            grpbx_cinsiyet.Visible = true;
            hangibtn = button.Name;
            secilibutontext = button.Text;
            lbl_koltukSayisi.Text = "Koltuk Sayısı : " + secilibutontext;
        }
        private void btnn_Click(object sender, EventArgs e)
        {
            PictureBox button = sender as PictureBox;
            grpbx_cinsiyet.Enabled = true;
            grpbx_cinsiyet.Visible = true;
            hangibtn = button.Name;
            secilibutontext = button.Text;
            lbl_koltukSayisi.Text = "Koltuk Sayısı : " + secilibutontext;
        }

        private void btn_al_Click(object sender, EventArgs e)
        {
            if (txt_ad.Text!="" && txt_soyad.Text!="" && txt_tc.Text!="" && txt_eposta.Text!="" && txt_tel.Text!="" &&
                SayiMi(txt_tel.Text) == true && SayiMi(txt_tc.Text) == true && txt_tel.Text.Length==10 && txt_tc.Text.Length==11 &&
                txt_kartno.Text.Length==16 && txt_kartno.Text!="" && SayiMi(txt_kartno.Text)==true && txt_cvc.Text!="" && txt_cvc.Text.Length==3 &&
                SayiMi(txt_cvc.Text)==true && cmbx_ay.Text!="" && cmbx_yil.Text!="")
            {
                var bag = new NpgsqlConnection(baglanti);
                bag.Open();
                string sorgu = "select mtc from musteri";
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, bag);
                DataSet ds = new DataSet();
                da.Fill(ds);
                if (ds.Tables[0].Rows.Count!=0)
                {
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        if (ds.Tables[0].Rows.Count != 0)
                        {
                            for (int a = 0; a < ds.Tables[0].Rows.Count; a++)
                            {
                                if (txt_tc.Text.ToString() != ds.Tables[0].Rows[i][0].ToString())
                                {
                                    tckontrol = 0;
                                }
                                else
                                {
                                    tckontrol = 1;
                                }
                            }
                            if (tckontrol == 0)
                            {
                                biletAlimKontrol = 1;
                            }
                            else
                            {
                                biletAlimKontrol = 2;
                            }
                        }
                    }
                    if (biletAlimKontrol == 1)
                    {
                        DbCommand dbCommand = bag.CreateCommand();
                        dbCommand.CommandText = @"
                                INSERT INTO musteri (mad, msoyad, mtc, mtel, mmail, mcinsiyet) 
                                VALUES('" + txt_ad.Text + "', '" + txt_soyad.Text + "', '" + txt_tc.Text + "', '" + txt_tel.Text + "', '" + txt_eposta.Text + "', '" + cins + "')";
                        dbCommand.ExecuteNonQuery();

                        string sorgu7 = "select mid from musteri where mtc='" + txt_tc.Text + "'";
                        NpgsqlDataAdapter da7 = new NpgsqlDataAdapter(sorgu7, bag);
                        DataSet ds7 = new DataSet();
                        da7.Fill(ds7);

                        DbCommand dbCommand2 = bag.CreateCommand();
                        dbCommand2.CommandText = @"
                                INSERT INTO bilet (mid, sid, koltukno, biletdurumu) 
                                VALUES(" + Convert.ToInt16(ds7.Tables[0].Rows[0][0]) + ", " + sid + ", " + Convert.ToInt16(secilibutontext) + ", 'aktif')";
                        dbCommand2.ExecuteNonQuery();
                    }
                    else if (biletAlimKontrol == 2)
                    {
                        string sorgu8 = "select mid from musteri where mtc = '" + txt_tc.Text + "'";
                        NpgsqlDataAdapter da8 = new NpgsqlDataAdapter(sorgu8, bag);
                        DataSet ds8 = new DataSet();
                        da8.Fill(ds8);
                        DbCommand dbCommand2 = bag.CreateCommand();
                        dbCommand2.CommandText = @"
                                INSERT INTO bilet (mid, sid, koltukno, biletdurumu) 
                                VALUES(" + ds8.Tables[0].Rows[0][0] + ", " + sid + ", " + Convert.ToInt16(secilibutontext) + ", 'aktif')";
                        dbCommand2.ExecuteNonQuery();
                    }
                }
                else
                {
                    DbCommand dbCommand = bag.CreateCommand();
                    dbCommand.CommandText = @"
                                INSERT INTO musteri (mad, msoyad, mtc, mtel, mmail, mcinsiyet) 
                                VALUES('" + txt_ad.Text + "', '" + txt_soyad.Text + "', '" + txt_tc.Text + "', '" + txt_tel.Text + "', '" + txt_eposta.Text + "', '" + cins + "')";

                    dbCommand.ExecuteNonQuery();

                    string sorgu7 = "select mid from musteri where mtc='" + txt_tc.Text + "'";
                    NpgsqlDataAdapter da7 = new NpgsqlDataAdapter(sorgu7, bag);
                    DataSet ds7 = new DataSet();
                    da7.Fill(ds7);

                    DbCommand dbCommand2 = bag.CreateCommand();
                    dbCommand2.CommandText = @"
                                INSERT INTO bilet (mid, sid, koltukno, biletdurumu) 
                                VALUES(" + Convert.ToInt16(ds7.Tables[0].Rows[0][0]) + ", " + sid + ", " + Convert.ToInt16(secilibutontext) + ", 'aktif')";

                    dbCommand2.ExecuteNonQuery();

                    NpgsqlCommand command = new NpgsqlCommand("UpdateBosKoltukSayisiFunction", bag);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.ExecuteNonQuery();

                }
                MessageBox.Show("Satın Alım Başarılı","Bilgilendirme",MessageBoxButtons.OK,MessageBoxIcon.Information);
                x = 118;
                y = 256;
                if (buton40[0] != null)
                {
                    for (int i = 0; i < 40; i++)
                    {
                        Controls.Remove((PictureBox)buton40[i]);
                    }
                }
                if (buton58[0] != null)
                {
                    for (int i = 0; i < 58; i++)
                    {
                        Controls.Remove((PictureBox)buton58[i]);
                    }
                }

                koltukOlustur();
                pctbox_sofor.Image = Image.FromFile(Application.StartupPath + "\\resimler\\otobusOn.png");
                Image img = pctbox_sofor.Image;
                img.RotateFlip(RotateFlipType.Rotate270FlipNone);
                pctbox_sofor.Image = img;
                string sorgu2 = "select dolukoltuksayisi from sefer where sid = " + sid + "";
                NpgsqlDataAdapter da2 = new NpgsqlDataAdapter(sorgu2, bag);
                DataSet ds2 = new DataSet();
                da2.Fill(ds2);
                string sorgu3 = "select mid, koltukno from bilet where sid = " + sid + " and biletdurumu = 'aktif'";
                NpgsqlDataAdapter da3 = new NpgsqlDataAdapter(sorgu3, bag);
                DataSet ds3 = new DataSet();
                da3.Fill(ds3);
                if (Convert.ToInt16(ds2.Tables[0].Rows[0][0]) != 0)
                {
                    for (int i = 0; i < ds3.Tables[0].Rows.Count; i++)
                    {
                        string sorgu4 = "select mcinsiyet from musteri where mid = " + ds3.Tables[0].Rows[i][0] + "";
                        NpgsqlDataAdapter da4 = new NpgsqlDataAdapter(sorgu4, bag);
                        DataSet ds4 = new DataSet();
                        da4.Fill(ds4);
                        if (buton40[0] != null)
                        {
                            for (int a = 0; a < 40; a++)
                            {
                                if (Convert.ToInt16(buton40[a].Text) == Convert.ToInt16(ds3.Tables[0].Rows[i][1]))
                                {
                                    if (Convert.ToChar(ds4.Tables[0].Rows[0][0]) == 'K')
                                    {
                                        buton40[a].Image = Image.FromFile(Application.StartupPath + "\\resimler\\bayan.png");
                                        buton40[a].BackgroundImageLayout = ImageLayout.Stretch;
                                        Image imgg = buton40[a].Image;
                                        imgg.RotateFlip(RotateFlipType.Rotate270FlipNone);
                                        buton40[a].Image = imgg;
                                        buton40[a].Enabled = false;
                                    }
                                    else
                                    {
                                        buton40[a].Image = Image.FromFile(Application.StartupPath + "\\resimler\\bay.png");
                                        buton40[a].BackgroundImageLayout = ImageLayout.Stretch;
                                        Image imgg = buton40[a].Image;
                                        imgg.RotateFlip(RotateFlipType.Rotate270FlipNone);
                                        buton40[a].Image = imgg;
                                        buton40[a].Enabled = false;
                                    }
                                }
                            }
                        }
                        if (buton58[0] != null)
                        {
                            for (int b = 0; b < 58; b++)
                            {
                                if (Convert.ToInt16(buton58[b].Text) == Convert.ToInt16(ds3.Tables[0].Rows[i][1]))
                                {

                                    if (Convert.ToChar(ds4.Tables[0].Rows[0][0]) == 'K')
                                    {
                                        buton58[b].Image = Image.FromFile(Application.StartupPath + "\\resimler\\bayan.png");
                                        buton58[b].BackgroundImageLayout = ImageLayout.Stretch;
                                        Image imgg = buton58[b].Image;
                                        imgg.RotateFlip(RotateFlipType.Rotate270FlipNone);
                                        buton58[b].Image = imgg;
                                        buton58[b].Enabled = false;
                                    }
                                    else
                                    {
                                        buton58[b].Image = Image.FromFile(Application.StartupPath + "\\resimler\\bay.png");
                                        buton58[b].BackgroundImageLayout = ImageLayout.Stretch;
                                        Image imgg = buton58[b].Image;
                                        imgg.RotateFlip(RotateFlipType.Rotate270FlipNone);
                                        buton58[b].Image = imgg;
                                        buton58[b].Enabled = false;
                                    }
                                }
                            }
                        }

                    }
                }
                bag.Close();
                grpbx_cinsiyet.Enabled = false;
                grpbx_cinsiyet.Visible = false;
                grpbx_kullaniciBilgileri.Enabled = false;
                cmbx_ay.Text = "";
                cmbx_yil.Text = "";
                txt_ad.Text = "";
                txt_soyad.Text = "";
                txt_cvc.Text = "";
                txt_eposta.Text = "";
                txt_kartno.Text = "";
                txt_tc.Text = "";
                txt_tel.Text = "";
                hangibtn = "";
                secilibutontext = "";
                cinsiyet = 0;
                tckontrol = 0;
                cins = ' ';
                lbl_koltukSayisi.Text = "";
                biletAlimKontrol = 0;
            }
            else
            {
                MessageBox.Show("Lütfen alanları eksiksiz ve doğru girdiğinizden emin olunuz","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            
            grpbx_kullaniciBilgileri.Enabled = false;
        }

        private void pctbx_kadin_Click(object sender, EventArgs e)
        {
            cinsiyet = 1;
            cins = 'K';
            if (buton40[0] != null)
            {
                for (int i = 0; i < 40; i++)
                {
                    if (buton40[i].Name==hangibtn)
                    {
                        buton40[i].Image = Image.FromFile(Application.StartupPath + "\\resimler\\rezerve.png");
                        buton40[i].BackgroundImageLayout = ImageLayout.Stretch;
                        Image img = buton40[i].Image;
                        img.RotateFlip(RotateFlipType.Rotate270FlipNone);
                        buton40[i].Image = img;
                    }
                    buton40[i].Enabled = false;
                    if (buton40[i].Name == hangibtn)
                    {
                        buton40[i].Enabled = true;
                    }
                }
            }
            if (buton58[0] != null)
            {
                for (int i = 0; i < 58; i++)
                {
                    if (buton58[i].Name == hangibtn)
                    {
                        buton58[i].Image = Image.FromFile(Application.StartupPath + "\\resimler\\rezerve.png");
                        buton58[i].BackgroundImageLayout = ImageLayout.Stretch;
                        Image img = buton58[i].Image;
                        img.RotateFlip(RotateFlipType.Rotate270FlipNone);
                        buton58[i].Image = img;
                    }
                    buton58[i].Enabled = false;
                    if (buton58[i].Name == hangibtn)
                    {
                        buton58[i].Enabled = true;
                    }
                }
            }
            grpbx_kullaniciBilgileri.Enabled = true;
            grpbx_cinsiyet.Enabled = false;
            grpbx_cinsiyet.Visible = false;
        }

        private void pctbx_erkek_Click(object sender, EventArgs e)
        {
            cinsiyet = 2;
            cins = 'E';
            if (buton40[0] != null)
            {
                for (int i = 0; i < 40; i++)
                {
                    if (buton40[i].Name == hangibtn)
                    {
                        buton40[i].Image = Image.FromFile(Application.StartupPath + "\\resimler\\rezerve.png");
                        buton40[i].BackgroundImageLayout = ImageLayout.Stretch;
                        Image img = buton40[i].Image;
                        img.RotateFlip(RotateFlipType.Rotate270FlipNone);
                        buton40[i].Image = img;
                    }
                    buton40[i].Enabled = false;
                    if (buton40[i].Name == hangibtn)
                    {
                        buton40[i].Enabled = true;
                    }
                }
            }
            if (buton58[0] != null)
            {
                for (int i = 0; i < 58; i++)
                {
                    if (buton58[i].Name == hangibtn)
                    {
                        buton58[i].Image = Image.FromFile(Application.StartupPath + "\\resimler\\rezerve.png");
                        buton58[i].BackgroundImageLayout = ImageLayout.Stretch;
                        Image img = buton58[i].Image;
                        img.RotateFlip(RotateFlipType.Rotate270FlipNone);
                        buton58[i].Image = img;
                    }
                    buton58[i].Enabled = false;
                    if (buton58[i].Name == hangibtn)
                    {
                        buton58[i].Enabled = true;
                    }
                }
            }
            grpbx_kullaniciBilgileri.Enabled = true;
            grpbx_cinsiyet.Enabled = false;
            grpbx_cinsiyet.Visible = false;
        }

        private void btn_iptal_Click(object sender, EventArgs e)
        {
            cinsiyet = 0;
            cins = ' ';
            if (buton40[0] != null)
            {
                for (int i = 0; i < 40; i++)
                {
                    buton40[i].Enabled = true;
                }
            }
            if (buton58[0] != null)
            {
                for (int i = 0; i < 58; i++)
                { 
                    buton58[i].Enabled = true;
                }
            }
            lbl_koltukSayisi.Text = "" ;
            grpbx_kullaniciBilgileri.Enabled = false;
            grpbx_cinsiyet.Enabled = false;
            grpbx_cinsiyet.Visible = false;
        }
    }
}
