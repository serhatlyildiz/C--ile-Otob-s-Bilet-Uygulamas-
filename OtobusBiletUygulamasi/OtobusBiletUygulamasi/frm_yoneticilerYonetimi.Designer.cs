namespace OtobusBiletUygulamasi
{
    partial class frm_yoneticilerYonetimi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_yoneticilerYonetimi));
            this.dgw_yoneticiler = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtbx_ksifre = new System.Windows.Forms.TextBox();
            this.txtbx_kadi = new System.Windows.Forms.TextBox();
            this.txtbx_kisim = new System.Windows.Forms.TextBox();
            this.txtbx_ksoyisim = new System.Windows.Forms.TextBox();
            this.cmbx_bolge = new System.Windows.Forms.ComboBox();
            this.btn_kaydet = new System.Windows.Forms.Button();
            this.btn_temizle = new System.Windows.Forms.Button();
            this.btn_sil = new System.Windows.Forms.Button();
            this.btn_cikis = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_yoneticiler)).BeginInit();
            this.SuspendLayout();
            // 
            // dgw_yoneticiler
            // 
            this.dgw_yoneticiler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_yoneticiler.Location = new System.Drawing.Point(6, 11);
            this.dgw_yoneticiler.Name = "dgw_yoneticiler";
            this.dgw_yoneticiler.Size = new System.Drawing.Size(643, 302);
            this.dgw_yoneticiler.TabIndex = 0;
            this.dgw_yoneticiler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgw_yoneticiler_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(125, 322);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kullanıcı Adı : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(125, 350);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kullanıcı Şifre : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(125, 379);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Kullanıcı İsim : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(125, 408);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Kullanıcı Soyisim : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(125, 437);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(185, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Sorumlu Olduğu Bölge : ";
            // 
            // txtbx_ksifre
            // 
            this.txtbx_ksifre.Location = new System.Drawing.Point(316, 347);
            this.txtbx_ksifre.Name = "txtbx_ksifre";
            this.txtbx_ksifre.Size = new System.Drawing.Size(185, 23);
            this.txtbx_ksifre.TabIndex = 8;
            // 
            // txtbx_kadi
            // 
            this.txtbx_kadi.Location = new System.Drawing.Point(316, 319);
            this.txtbx_kadi.Name = "txtbx_kadi";
            this.txtbx_kadi.Size = new System.Drawing.Size(185, 23);
            this.txtbx_kadi.TabIndex = 9;
            // 
            // txtbx_kisim
            // 
            this.txtbx_kisim.Location = new System.Drawing.Point(316, 376);
            this.txtbx_kisim.Name = "txtbx_kisim";
            this.txtbx_kisim.Size = new System.Drawing.Size(185, 23);
            this.txtbx_kisim.TabIndex = 10;
            // 
            // txtbx_ksoyisim
            // 
            this.txtbx_ksoyisim.Location = new System.Drawing.Point(316, 405);
            this.txtbx_ksoyisim.Name = "txtbx_ksoyisim";
            this.txtbx_ksoyisim.Size = new System.Drawing.Size(185, 23);
            this.txtbx_ksoyisim.TabIndex = 11;
            // 
            // cmbx_bolge
            // 
            this.cmbx_bolge.FormattingEnabled = true;
            this.cmbx_bolge.Location = new System.Drawing.Point(316, 434);
            this.cmbx_bolge.Name = "cmbx_bolge";
            this.cmbx_bolge.Size = new System.Drawing.Size(185, 24);
            this.cmbx_bolge.TabIndex = 14;
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.Location = new System.Drawing.Point(417, 464);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(84, 40);
            this.btn_kaydet.TabIndex = 15;
            this.btn_kaydet.Text = "Ekle";
            this.btn_kaydet.UseVisualStyleBackColor = true;
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // btn_temizle
            // 
            this.btn_temizle.Location = new System.Drawing.Point(237, 464);
            this.btn_temizle.Name = "btn_temizle";
            this.btn_temizle.Size = new System.Drawing.Size(84, 40);
            this.btn_temizle.TabIndex = 16;
            this.btn_temizle.Text = "Temizle";
            this.btn_temizle.UseVisualStyleBackColor = true;
            this.btn_temizle.Click += new System.EventHandler(this.btn_temizle_Click);
            // 
            // btn_sil
            // 
            this.btn_sil.Location = new System.Drawing.Point(327, 464);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(84, 40);
            this.btn_sil.TabIndex = 17;
            this.btn_sil.Text = "Sil";
            this.btn_sil.UseVisualStyleBackColor = true;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // btn_cikis
            // 
            this.btn_cikis.Image = ((System.Drawing.Image)(resources.GetObject("btn_cikis.Image")));
            this.btn_cikis.Location = new System.Drawing.Point(655, 11);
            this.btn_cikis.Name = "btn_cikis";
            this.btn_cikis.Size = new System.Drawing.Size(45, 45);
            this.btn_cikis.TabIndex = 19;
            this.btn_cikis.UseVisualStyleBackColor = true;
            this.btn_cikis.Click += new System.EventHandler(this.btn_cikis_Click);
            // 
            // frm_yoneticilerYonetimi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.ClientSize = new System.Drawing.Size(709, 513);
            this.Controls.Add(this.btn_cikis);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.btn_temizle);
            this.Controls.Add(this.btn_kaydet);
            this.Controls.Add(this.cmbx_bolge);
            this.Controls.Add(this.txtbx_ksoyisim);
            this.Controls.Add(this.txtbx_kisim);
            this.Controls.Add(this.txtbx_kadi);
            this.Controls.Add(this.txtbx_ksifre);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgw_yoneticiler);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frm_yoneticilerYonetimi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yöneticileri Düzenle";
            this.Load += new System.EventHandler(this.frm_yoneticilerYonetimi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgw_yoneticiler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgw_yoneticiler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtbx_ksifre;
        private System.Windows.Forms.TextBox txtbx_kadi;
        private System.Windows.Forms.TextBox txtbx_kisim;
        private System.Windows.Forms.TextBox txtbx_ksoyisim;
        private System.Windows.Forms.ComboBox cmbx_bolge;
        private System.Windows.Forms.Button btn_kaydet;
        private System.Windows.Forms.Button btn_temizle;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.Button btn_cikis;
    }
}