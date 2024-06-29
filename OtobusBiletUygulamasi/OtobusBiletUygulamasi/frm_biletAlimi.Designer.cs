namespace OtobusBiletUygulamasi
{
    partial class frm_biletAlimi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_biletAlimi));
            this.btn_cikis = new System.Windows.Forms.Button();
            this.pctbox_sofor = new System.Windows.Forms.PictureBox();
            this.grpbx_kullaniciBilgileri = new System.Windows.Forms.GroupBox();
            this.cmbx_yil = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbx_ay = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_cvc = new System.Windows.Forms.TextBox();
            this.txt_kartno = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_al = new System.Windows.Forms.Button();
            this.txt_tel = new System.Windows.Forms.TextBox();
            this.txt_eposta = new System.Windows.Forms.TextBox();
            this.txt_tc = new System.Windows.Forms.TextBox();
            this.txt_soyad = new System.Windows.Forms.TextBox();
            this.txt_ad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpbx_cinsiyet = new System.Windows.Forms.GroupBox();
            this.btn_iptal = new System.Windows.Forms.Button();
            this.pctbx_erkek = new System.Windows.Forms.PictureBox();
            this.pctbx_kadin = new System.Windows.Forms.PictureBox();
            this.lbl_koltukSayisi = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pctbox_sofor)).BeginInit();
            this.grpbx_kullaniciBilgileri.SuspendLayout();
            this.grpbx_cinsiyet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctbx_erkek)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbx_kadin)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_cikis
            // 
            this.btn_cikis.Image = ((System.Drawing.Image)(resources.GetObject("btn_cikis.Image")));
            this.btn_cikis.Location = new System.Drawing.Point(1029, 12);
            this.btn_cikis.Name = "btn_cikis";
            this.btn_cikis.Size = new System.Drawing.Size(45, 45);
            this.btn_cikis.TabIndex = 25;
            this.btn_cikis.UseVisualStyleBackColor = true;
            this.btn_cikis.Click += new System.EventHandler(this.btn_cikis_Click);
            // 
            // pctbox_sofor
            // 
            this.pctbox_sofor.Location = new System.Drawing.Point(12, 99);
            this.pctbox_sofor.Name = "pctbox_sofor";
            this.pctbox_sofor.Size = new System.Drawing.Size(100, 178);
            this.pctbox_sofor.TabIndex = 26;
            this.pctbox_sofor.TabStop = false;
            // 
            // grpbx_kullaniciBilgileri
            // 
            this.grpbx_kullaniciBilgileri.Controls.Add(this.cmbx_yil);
            this.grpbx_kullaniciBilgileri.Controls.Add(this.label9);
            this.grpbx_kullaniciBilgileri.Controls.Add(this.cmbx_ay);
            this.grpbx_kullaniciBilgileri.Controls.Add(this.label8);
            this.grpbx_kullaniciBilgileri.Controls.Add(this.label7);
            this.grpbx_kullaniciBilgileri.Controls.Add(this.txt_cvc);
            this.grpbx_kullaniciBilgileri.Controls.Add(this.txt_kartno);
            this.grpbx_kullaniciBilgileri.Controls.Add(this.label6);
            this.grpbx_kullaniciBilgileri.Controls.Add(this.btn_al);
            this.grpbx_kullaniciBilgileri.Controls.Add(this.txt_tel);
            this.grpbx_kullaniciBilgileri.Controls.Add(this.txt_eposta);
            this.grpbx_kullaniciBilgileri.Controls.Add(this.txt_tc);
            this.grpbx_kullaniciBilgileri.Controls.Add(this.txt_soyad);
            this.grpbx_kullaniciBilgileri.Controls.Add(this.txt_ad);
            this.grpbx_kullaniciBilgileri.Controls.Add(this.label5);
            this.grpbx_kullaniciBilgileri.Controls.Add(this.label4);
            this.grpbx_kullaniciBilgileri.Controls.Add(this.label3);
            this.grpbx_kullaniciBilgileri.Controls.Add(this.label2);
            this.grpbx_kullaniciBilgileri.Controls.Add(this.label1);
            this.grpbx_kullaniciBilgileri.Location = new System.Drawing.Point(10, 368);
            this.grpbx_kullaniciBilgileri.Name = "grpbx_kullaniciBilgileri";
            this.grpbx_kullaniciBilgileri.Size = new System.Drawing.Size(1064, 213);
            this.grpbx_kullaniciBilgileri.TabIndex = 69;
            this.grpbx_kullaniciBilgileri.TabStop = false;
            this.grpbx_kullaniciBilgileri.Text = "Bilgilerinizi Giriniz";
            // 
            // cmbx_yil
            // 
            this.cmbx_yil.FormattingEnabled = true;
            this.cmbx_yil.Items.AddRange(new object[] {
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030",
            "2031",
            "2032",
            "2033",
            "2034",
            "2035",
            "2036"});
            this.cmbx_yil.Location = new System.Drawing.Point(738, 119);
            this.cmbx_yil.Name = "cmbx_yil";
            this.cmbx_yil.Size = new System.Drawing.Size(78, 24);
            this.cmbx_yil.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(719, 122);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(13, 17);
            this.label9.TabIndex = 21;
            this.label9.Text = "/";
            // 
            // cmbx_ay
            // 
            this.cmbx_ay.FormattingEnabled = true;
            this.cmbx_ay.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cmbx_ay.Location = new System.Drawing.Point(656, 119);
            this.cmbx_ay.Name = "cmbx_ay";
            this.cmbx_ay.Size = new System.Drawing.Size(57, 24);
            this.cmbx_ay.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(433, 122);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(217, 17);
            this.label8.TabIndex = 19;
            this.label8.Text = "Kartın Son Kullanma Tarihi : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(822, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 17);
            this.label7.TabIndex = 18;
            this.label7.Text = "CVC : ";
            // 
            // txt_cvc
            // 
            this.txt_cvc.Location = new System.Drawing.Point(881, 119);
            this.txt_cvc.MaxLength = 3;
            this.txt_cvc.Name = "txt_cvc";
            this.txt_cvc.Size = new System.Drawing.Size(61, 23);
            this.txt_cvc.TabIndex = 17;
            // 
            // txt_kartno
            // 
            this.txt_kartno.Location = new System.Drawing.Point(183, 119);
            this.txt_kartno.MaxLength = 16;
            this.txt_kartno.Name = "txt_kartno";
            this.txt_kartno.Size = new System.Drawing.Size(244, 23);
            this.txt_kartno.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(171, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Banka/Kredi Kart No : ";
            // 
            // btn_al
            // 
            this.btn_al.Location = new System.Drawing.Point(478, 163);
            this.btn_al.Name = "btn_al";
            this.btn_al.Size = new System.Drawing.Size(90, 40);
            this.btn_al.TabIndex = 13;
            this.btn_al.Text = "Satın Al";
            this.btn_al.UseVisualStyleBackColor = true;
            this.btn_al.Click += new System.EventHandler(this.btn_al_Click);
            // 
            // txt_tel
            // 
            this.txt_tel.Location = new System.Drawing.Point(183, 90);
            this.txt_tel.MaxLength = 10;
            this.txt_tel.Name = "txt_tel";
            this.txt_tel.Size = new System.Drawing.Size(244, 23);
            this.txt_tel.TabIndex = 9;
            // 
            // txt_eposta
            // 
            this.txt_eposta.Location = new System.Drawing.Point(656, 61);
            this.txt_eposta.MaxLength = 50;
            this.txt_eposta.Name = "txt_eposta";
            this.txt_eposta.Size = new System.Drawing.Size(244, 23);
            this.txt_eposta.TabIndex = 8;
            // 
            // txt_tc
            // 
            this.txt_tc.Location = new System.Drawing.Point(183, 61);
            this.txt_tc.MaxLength = 11;
            this.txt_tc.Name = "txt_tc";
            this.txt_tc.Size = new System.Drawing.Size(244, 23);
            this.txt_tc.TabIndex = 7;
            // 
            // txt_soyad
            // 
            this.txt_soyad.Location = new System.Drawing.Point(656, 32);
            this.txt_soyad.Name = "txt_soyad";
            this.txt_soyad.Size = new System.Drawing.Size(244, 23);
            this.txt_soyad.TabIndex = 6;
            // 
            // txt_ad
            // 
            this.txt_ad.Location = new System.Drawing.Point(183, 32);
            this.txt_ad.Name = "txt_ad";
            this.txt_ad.Size = new System.Drawing.Size(244, 23);
            this.txt_ad.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(570, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "E-Posta : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tel No (+90) : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "TC Kimlik No : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(557, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyadınız : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adınız : ";
            // 
            // grpbx_cinsiyet
            // 
            this.grpbx_cinsiyet.Controls.Add(this.btn_iptal);
            this.grpbx_cinsiyet.Controls.Add(this.pctbx_erkek);
            this.grpbx_cinsiyet.Controls.Add(this.pctbx_kadin);
            this.grpbx_cinsiyet.Location = new System.Drawing.Point(825, 76);
            this.grpbx_cinsiyet.Name = "grpbx_cinsiyet";
            this.grpbx_cinsiyet.Size = new System.Drawing.Size(249, 260);
            this.grpbx_cinsiyet.TabIndex = 70;
            this.grpbx_cinsiyet.TabStop = false;
            // 
            // btn_iptal
            // 
            this.btn_iptal.Location = new System.Drawing.Point(90, 199);
            this.btn_iptal.Name = "btn_iptal";
            this.btn_iptal.Size = new System.Drawing.Size(75, 35);
            this.btn_iptal.TabIndex = 2;
            this.btn_iptal.Text = "İptal";
            this.btn_iptal.UseVisualStyleBackColor = true;
            this.btn_iptal.Click += new System.EventHandler(this.btn_iptal_Click);
            // 
            // pctbx_erkek
            // 
            this.pctbx_erkek.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pctbx_erkek.BackgroundImage")));
            this.pctbx_erkek.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pctbx_erkek.Location = new System.Drawing.Point(133, 22);
            this.pctbx_erkek.Name = "pctbx_erkek";
            this.pctbx_erkek.Size = new System.Drawing.Size(110, 152);
            this.pctbx_erkek.TabIndex = 1;
            this.pctbx_erkek.TabStop = false;
            this.pctbx_erkek.Click += new System.EventHandler(this.pctbx_erkek_Click);
            // 
            // pctbx_kadin
            // 
            this.pctbx_kadin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pctbx_kadin.BackgroundImage")));
            this.pctbx_kadin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pctbx_kadin.Location = new System.Drawing.Point(10, 22);
            this.pctbx_kadin.Name = "pctbx_kadin";
            this.pctbx_kadin.Size = new System.Drawing.Size(110, 152);
            this.pctbx_kadin.TabIndex = 0;
            this.pctbx_kadin.TabStop = false;
            this.pctbx_kadin.Click += new System.EventHandler(this.pctbx_kadin_Click);
            // 
            // lbl_koltukSayisi
            // 
            this.lbl_koltukSayisi.AutoSize = true;
            this.lbl_koltukSayisi.Location = new System.Drawing.Point(360, 328);
            this.lbl_koltukSayisi.Name = "lbl_koltukSayisi";
            this.lbl_koltukSayisi.Size = new System.Drawing.Size(0, 17);
            this.lbl_koltukSayisi.TabIndex = 71;
            // 
            // frm_biletAlimi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(1086, 592);
            this.Controls.Add(this.lbl_koltukSayisi);
            this.Controls.Add(this.grpbx_cinsiyet);
            this.Controls.Add(this.grpbx_kullaniciBilgileri);
            this.Controls.Add(this.pctbox_sofor);
            this.Controls.Add(this.btn_cikis);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimizeBox = false;
            this.Name = "frm_biletAlimi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_biletAlimi";
            this.Load += new System.EventHandler(this.frm_biletAlimi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctbox_sofor)).EndInit();
            this.grpbx_kullaniciBilgileri.ResumeLayout(false);
            this.grpbx_kullaniciBilgileri.PerformLayout();
            this.grpbx_cinsiyet.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctbx_erkek)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbx_kadin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_cikis;
        private System.Windows.Forms.PictureBox pctbox_sofor;
        private System.Windows.Forms.GroupBox grpbx_kullaniciBilgileri;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_al;
        private System.Windows.Forms.TextBox txt_tel;
        private System.Windows.Forms.TextBox txt_eposta;
        private System.Windows.Forms.TextBox txt_tc;
        private System.Windows.Forms.TextBox txt_soyad;
        private System.Windows.Forms.TextBox txt_ad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_kartno;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_cvc;
        private System.Windows.Forms.ComboBox cmbx_yil;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbx_ay;
        private System.Windows.Forms.GroupBox grpbx_cinsiyet;
        private System.Windows.Forms.PictureBox pctbx_erkek;
        private System.Windows.Forms.PictureBox pctbx_kadin;
        private System.Windows.Forms.Button btn_iptal;
        private System.Windows.Forms.Label lbl_koltukSayisi;
    }
}