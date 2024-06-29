namespace OtobusBiletUygulamasi
{
    partial class frm_yoneticiYonetim
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_yoneticiYonetim));
            this.btn_cikis = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbx_nereden = new System.Windows.Forms.ComboBox();
            this.cmbx_nereye = new System.Windows.Forms.ComboBox();
            this.dtp_kalkis = new System.Windows.Forms.DateTimePicker();
            this.dtp_varis = new System.Windows.Forms.DateTimePicker();
            this.txt_kalkisSaat = new System.Windows.Forms.TextBox();
            this.txt_kalkisDakika = new System.Windows.Forms.TextBox();
            this.txt_varisDakika = new System.Windows.Forms.TextBox();
            this.txt_varissSaat = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbx_sofor = new System.Windows.Forms.ComboBox();
            this.cmbx_muavin = new System.Windows.Forms.ComboBox();
            this.rbtn_cift = new System.Windows.Forms.RadioButton();
            this.rbtn_tek = new System.Windows.Forms.RadioButton();
            this.btn_seferEkle = new System.Windows.Forms.Button();
            this.grpbx_sefer = new System.Windows.Forms.GroupBox();
            this.dgw_seferler = new System.Windows.Forms.DataGridView();
            this.btn_temizle = new System.Windows.Forms.Button();
            this.btn_sil = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtbx_ucret = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_personel = new System.Windows.Forms.Button();
            this.btn_yoneticiler = new System.Windows.Forms.Button();
            this.grpbx_sefer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_seferler)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_cikis
            // 
            this.btn_cikis.Image = ((System.Drawing.Image)(resources.GetObject("btn_cikis.Image")));
            this.btn_cikis.Location = new System.Drawing.Point(1046, 12);
            this.btn_cikis.Name = "btn_cikis";
            this.btn_cikis.Size = new System.Drawing.Size(45, 45);
            this.btn_cikis.TabIndex = 0;
            this.btn_cikis.UseVisualStyleBackColor = true;
            this.btn_cikis.Click += new System.EventHandler(this.btn_cikis_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 447);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nereden : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(6, 487);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nereye : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(360, 487);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Varış Zamanı : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(360, 447);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Kalkış Zamanı : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(7, 567);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Muavin : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(6, 534);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Şoför : ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(387, 534);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(116, 17);
            this.label11.TabIndex = 9;
            this.label11.Text = "Koltuk Sayisi : ";
            // 
            // cmbx_nereden
            // 
            this.cmbx_nereden.FormattingEnabled = true;
            this.cmbx_nereden.Location = new System.Drawing.Point(181, 444);
            this.cmbx_nereden.Name = "cmbx_nereden";
            this.cmbx_nereden.Size = new System.Drawing.Size(173, 24);
            this.cmbx_nereden.TabIndex = 10;
            // 
            // cmbx_nereye
            // 
            this.cmbx_nereye.FormattingEnabled = true;
            this.cmbx_nereye.Location = new System.Drawing.Point(181, 484);
            this.cmbx_nereye.Name = "cmbx_nereye";
            this.cmbx_nereye.Size = new System.Drawing.Size(173, 24);
            this.cmbx_nereye.TabIndex = 11;
            // 
            // dtp_kalkis
            // 
            this.dtp_kalkis.Location = new System.Drawing.Point(535, 442);
            this.dtp_kalkis.Name = "dtp_kalkis";
            this.dtp_kalkis.Size = new System.Drawing.Size(200, 23);
            this.dtp_kalkis.TabIndex = 12;
            // 
            // dtp_varis
            // 
            this.dtp_varis.Location = new System.Drawing.Point(535, 482);
            this.dtp_varis.Name = "dtp_varis";
            this.dtp_varis.Size = new System.Drawing.Size(200, 23);
            this.dtp_varis.TabIndex = 13;
            // 
            // txt_kalkisSaat
            // 
            this.txt_kalkisSaat.Location = new System.Drawing.Point(761, 442);
            this.txt_kalkisSaat.Name = "txt_kalkisSaat";
            this.txt_kalkisSaat.Size = new System.Drawing.Size(42, 23);
            this.txt_kalkisSaat.TabIndex = 14;
            // 
            // txt_kalkisDakika
            // 
            this.txt_kalkisDakika.Location = new System.Drawing.Point(828, 444);
            this.txt_kalkisDakika.Name = "txt_kalkisDakika";
            this.txt_kalkisDakika.Size = new System.Drawing.Size(42, 23);
            this.txt_kalkisDakika.TabIndex = 15;
            // 
            // txt_varisDakika
            // 
            this.txt_varisDakika.Location = new System.Drawing.Point(828, 487);
            this.txt_varisDakika.Name = "txt_varisDakika";
            this.txt_varisDakika.Size = new System.Drawing.Size(42, 23);
            this.txt_varisDakika.TabIndex = 17;
            // 
            // txt_varissSaat
            // 
            this.txt_varissSaat.Location = new System.Drawing.Point(761, 484);
            this.txt_varissSaat.Name = "txt_varissSaat";
            this.txt_varissSaat.Size = new System.Drawing.Size(42, 23);
            this.txt_varissSaat.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(809, 447);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(13, 17);
            this.label9.TabIndex = 18;
            this.label9.Text = ":";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(809, 488);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(13, 17);
            this.label10.TabIndex = 19;
            this.label10.Text = ":";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(758, 411);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 17);
            this.label12.TabIndex = 20;
            this.label12.Text = "Saat";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(825, 411);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(57, 17);
            this.label13.TabIndex = 21;
            this.label13.Text = "Dakika";
            // 
            // cmbx_sofor
            // 
            this.cmbx_sofor.FormattingEnabled = true;
            this.cmbx_sofor.Location = new System.Drawing.Point(181, 531);
            this.cmbx_sofor.Name = "cmbx_sofor";
            this.cmbx_sofor.Size = new System.Drawing.Size(200, 24);
            this.cmbx_sofor.TabIndex = 24;
            // 
            // cmbx_muavin
            // 
            this.cmbx_muavin.FormattingEnabled = true;
            this.cmbx_muavin.Location = new System.Drawing.Point(182, 564);
            this.cmbx_muavin.Name = "cmbx_muavin";
            this.cmbx_muavin.Size = new System.Drawing.Size(200, 24);
            this.cmbx_muavin.TabIndex = 25;
            // 
            // rbtn_cift
            // 
            this.rbtn_cift.AutoSize = true;
            this.rbtn_cift.ForeColor = System.Drawing.Color.White;
            this.rbtn_cift.Location = new System.Drawing.Point(656, 532);
            this.rbtn_cift.Name = "rbtn_cift";
            this.rbtn_cift.Size = new System.Drawing.Size(44, 21);
            this.rbtn_cift.TabIndex = 27;
            this.rbtn_cift.TabStop = true;
            this.rbtn_cift.Text = "58";
            this.rbtn_cift.UseVisualStyleBackColor = true;
            // 
            // rbtn_tek
            // 
            this.rbtn_tek.AutoSize = true;
            this.rbtn_tek.ForeColor = System.Drawing.Color.White;
            this.rbtn_tek.Location = new System.Drawing.Point(562, 532);
            this.rbtn_tek.Name = "rbtn_tek";
            this.rbtn_tek.Size = new System.Drawing.Size(44, 21);
            this.rbtn_tek.TabIndex = 28;
            this.rbtn_tek.TabStop = true;
            this.rbtn_tek.Text = "40";
            this.rbtn_tek.UseVisualStyleBackColor = true;
            // 
            // btn_seferEkle
            // 
            this.btn_seferEkle.Location = new System.Drawing.Point(728, 596);
            this.btn_seferEkle.Name = "btn_seferEkle";
            this.btn_seferEkle.Size = new System.Drawing.Size(142, 51);
            this.btn_seferEkle.TabIndex = 29;
            this.btn_seferEkle.Text = "Sefer Ekle";
            this.btn_seferEkle.UseVisualStyleBackColor = true;
            this.btn_seferEkle.Click += new System.EventHandler(this.btn_seferEkle_Click);
            // 
            // grpbx_sefer
            // 
            this.grpbx_sefer.Controls.Add(this.dgw_seferler);
            this.grpbx_sefer.Controls.Add(this.btn_temizle);
            this.grpbx_sefer.Controls.Add(this.btn_sil);
            this.grpbx_sefer.Controls.Add(this.label14);
            this.grpbx_sefer.Controls.Add(this.label8);
            this.grpbx_sefer.Controls.Add(this.txtbx_ucret);
            this.grpbx_sefer.Controls.Add(this.label15);
            this.grpbx_sefer.Controls.Add(this.label5);
            this.grpbx_sefer.Controls.Add(this.cmbx_nereden);
            this.grpbx_sefer.Controls.Add(this.btn_seferEkle);
            this.grpbx_sefer.Controls.Add(this.label1);
            this.grpbx_sefer.Controls.Add(this.rbtn_tek);
            this.grpbx_sefer.Controls.Add(this.label2);
            this.grpbx_sefer.Controls.Add(this.rbtn_cift);
            this.grpbx_sefer.Controls.Add(this.label4);
            this.grpbx_sefer.Controls.Add(this.label3);
            this.grpbx_sefer.Controls.Add(this.cmbx_muavin);
            this.grpbx_sefer.Controls.Add(this.cmbx_sofor);
            this.grpbx_sefer.Controls.Add(this.label7);
            this.grpbx_sefer.Controls.Add(this.label6);
            this.grpbx_sefer.Controls.Add(this.label13);
            this.grpbx_sefer.Controls.Add(this.label11);
            this.grpbx_sefer.Controls.Add(this.label12);
            this.grpbx_sefer.Controls.Add(this.cmbx_nereye);
            this.grpbx_sefer.Controls.Add(this.label10);
            this.grpbx_sefer.Controls.Add(this.dtp_kalkis);
            this.grpbx_sefer.Controls.Add(this.label9);
            this.grpbx_sefer.Controls.Add(this.dtp_varis);
            this.grpbx_sefer.Controls.Add(this.txt_varisDakika);
            this.grpbx_sefer.Controls.Add(this.txt_kalkisSaat);
            this.grpbx_sefer.Controls.Add(this.txt_varissSaat);
            this.grpbx_sefer.Controls.Add(this.txt_kalkisDakika);
            this.grpbx_sefer.Location = new System.Drawing.Point(12, 12);
            this.grpbx_sefer.Name = "grpbx_sefer";
            this.grpbx_sefer.Size = new System.Drawing.Size(884, 653);
            this.grpbx_sefer.TabIndex = 30;
            this.grpbx_sefer.TabStop = false;
            // 
            // dgw_seferler
            // 
            this.dgw_seferler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_seferler.Location = new System.Drawing.Point(6, 22);
            this.dgw_seferler.Name = "dgw_seferler";
            this.dgw_seferler.Size = new System.Drawing.Size(864, 386);
            this.dgw_seferler.TabIndex = 38;
            this.dgw_seferler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgw_seferler_CellClick);
            // 
            // btn_temizle
            // 
            this.btn_temizle.Location = new System.Drawing.Point(432, 596);
            this.btn_temizle.Name = "btn_temizle";
            this.btn_temizle.Size = new System.Drawing.Size(142, 51);
            this.btn_temizle.TabIndex = 37;
            this.btn_temizle.Text = "Temizle";
            this.btn_temizle.UseVisualStyleBackColor = true;
            this.btn_temizle.Click += new System.EventHandler(this.btn_temizle_Click);
            // 
            // btn_sil
            // 
            this.btn_sil.Location = new System.Drawing.Point(580, 596);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(142, 51);
            this.btn_sil.TabIndex = 36;
            this.btn_sil.Text = "Sefer Sil";
            this.btn_sil.UseVisualStyleBackColor = true;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(728, 570);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(17, 17);
            this.label14.TabIndex = 35;
            this.label14.Text = "₺";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(397, 570);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 17);
            this.label8.TabIndex = 34;
            this.label8.Text = "Ücret : ";
            // 
            // txtbx_ucret
            // 
            this.txtbx_ucret.Location = new System.Drawing.Point(572, 567);
            this.txtbx_ucret.Name = "txtbx_ucret";
            this.txtbx_ucret.Size = new System.Drawing.Size(150, 23);
            this.txtbx_ucret.TabIndex = 33;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(653, 510);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(35, 17);
            this.label15.TabIndex = 31;
            this.label15.Text = "2+2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(559, 510);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 17);
            this.label5.TabIndex = 30;
            this.label5.Text = "2+1";
            // 
            // btn_personel
            // 
            this.btn_personel.Location = new System.Drawing.Point(902, 263);
            this.btn_personel.Name = "btn_personel";
            this.btn_personel.Size = new System.Drawing.Size(135, 64);
            this.btn_personel.TabIndex = 31;
            this.btn_personel.Text = "Personeller";
            this.btn_personel.UseVisualStyleBackColor = true;
            this.btn_personel.Click += new System.EventHandler(this.btn_personel_Click);
            // 
            // btn_yoneticiler
            // 
            this.btn_yoneticiler.Location = new System.Drawing.Point(902, 377);
            this.btn_yoneticiler.Name = "btn_yoneticiler";
            this.btn_yoneticiler.Size = new System.Drawing.Size(135, 64);
            this.btn_yoneticiler.TabIndex = 33;
            this.btn_yoneticiler.Text = "Yöneticiler";
            this.btn_yoneticiler.UseVisualStyleBackColor = true;
            this.btn_yoneticiler.Click += new System.EventHandler(this.btn_yoneticiler_Click);
            // 
            // frm_yoneticiYonetim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(1103, 677);
            this.Controls.Add(this.btn_yoneticiler);
            this.Controls.Add(this.btn_personel);
            this.Controls.Add(this.grpbx_sefer);
            this.Controls.Add(this.btn_cikis);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frm_yoneticiYonetim";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_yoneticiYonetim";
            this.Load += new System.EventHandler(this.frm_yoneticiYonetim_Load);
            this.grpbx_sefer.ResumeLayout(false);
            this.grpbx_sefer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_seferler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_cikis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbx_nereden;
        private System.Windows.Forms.ComboBox cmbx_nereye;
        private System.Windows.Forms.DateTimePicker dtp_kalkis;
        private System.Windows.Forms.DateTimePicker dtp_varis;
        private System.Windows.Forms.TextBox txt_kalkisSaat;
        private System.Windows.Forms.TextBox txt_kalkisDakika;
        private System.Windows.Forms.TextBox txt_varisDakika;
        private System.Windows.Forms.TextBox txt_varissSaat;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbx_sofor;
        private System.Windows.Forms.ComboBox cmbx_muavin;
        private System.Windows.Forms.RadioButton rbtn_cift;
        private System.Windows.Forms.RadioButton rbtn_tek;
        private System.Windows.Forms.Button btn_seferEkle;
        private System.Windows.Forms.GroupBox grpbx_sefer;
        private System.Windows.Forms.Button btn_personel;
        private System.Windows.Forms.Button btn_yoneticiler;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtbx_ucret;
        private System.Windows.Forms.DataGridView dgw_seferler;
        private System.Windows.Forms.Button btn_temizle;
        private System.Windows.Forms.Button btn_sil;
    }
}