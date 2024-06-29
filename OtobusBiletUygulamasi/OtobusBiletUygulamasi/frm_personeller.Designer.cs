namespace OtobusBiletUygulamasi
{
    partial class frm_personeller
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_personeller));
            this.dgw_personeller = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.grpbx_personelBilgileri = new System.Windows.Forms.GroupBox();
            this.btn_temizle = new System.Windows.Forms.Button();
            this.rbtn_muavin = new System.Windows.Forms.RadioButton();
            this.rbtn_sofor = new System.Windows.Forms.RadioButton();
            this.btn_sil = new System.Windows.Forms.Button();
            this.btn_kaydet = new System.Windows.Forms.Button();
            this.txtbx_soyadi = new System.Windows.Forms.TextBox();
            this.txtbx_padi = new System.Windows.Forms.TextBox();
            this.btn_cikis = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_personeller)).BeginInit();
            this.grpbx_personelBilgileri.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgw_personeller
            // 
            this.dgw_personeller.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_personeller.Location = new System.Drawing.Point(12, 12);
            this.dgw_personeller.Name = "dgw_personeller";
            this.dgw_personeller.Size = new System.Drawing.Size(540, 356);
            this.dgw_personeller.TabIndex = 0;
            this.dgw_personeller.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgw_personeller_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(20, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Personel Adı : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(20, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Personel Soyadı : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(20, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Personel Pozisyon : ";
            // 
            // grpbx_personelBilgileri
            // 
            this.grpbx_personelBilgileri.Controls.Add(this.btn_temizle);
            this.grpbx_personelBilgileri.Controls.Add(this.rbtn_muavin);
            this.grpbx_personelBilgileri.Controls.Add(this.rbtn_sofor);
            this.grpbx_personelBilgileri.Controls.Add(this.btn_sil);
            this.grpbx_personelBilgileri.Controls.Add(this.btn_kaydet);
            this.grpbx_personelBilgileri.Controls.Add(this.txtbx_soyadi);
            this.grpbx_personelBilgileri.Controls.Add(this.txtbx_padi);
            this.grpbx_personelBilgileri.Controls.Add(this.label1);
            this.grpbx_personelBilgileri.Controls.Add(this.label2);
            this.grpbx_personelBilgileri.Controls.Add(this.label3);
            this.grpbx_personelBilgileri.Location = new System.Drawing.Point(558, 101);
            this.grpbx_personelBilgileri.Name = "grpbx_personelBilgileri";
            this.grpbx_personelBilgileri.Size = new System.Drawing.Size(410, 186);
            this.grpbx_personelBilgileri.TabIndex = 5;
            this.grpbx_personelBilgileri.TabStop = false;
            // 
            // btn_temizle
            // 
            this.btn_temizle.Location = new System.Drawing.Point(137, 154);
            this.btn_temizle.Name = "btn_temizle";
            this.btn_temizle.Size = new System.Drawing.Size(75, 23);
            this.btn_temizle.TabIndex = 11;
            this.btn_temizle.Text = "Temizle";
            this.btn_temizle.UseVisualStyleBackColor = true;
            this.btn_temizle.Click += new System.EventHandler(this.btn_temizle_Click);
            // 
            // rbtn_muavin
            // 
            this.rbtn_muavin.AutoSize = true;
            this.rbtn_muavin.ForeColor = System.Drawing.Color.White;
            this.rbtn_muavin.Location = new System.Drawing.Point(299, 109);
            this.rbtn_muavin.Name = "rbtn_muavin";
            this.rbtn_muavin.Size = new System.Drawing.Size(77, 21);
            this.rbtn_muavin.TabIndex = 10;
            this.rbtn_muavin.TabStop = true;
            this.rbtn_muavin.Text = "Muavin";
            this.rbtn_muavin.UseVisualStyleBackColor = true;
            // 
            // rbtn_sofor
            // 
            this.rbtn_sofor.AutoSize = true;
            this.rbtn_sofor.ForeColor = System.Drawing.Color.White;
            this.rbtn_sofor.Location = new System.Drawing.Point(183, 109);
            this.rbtn_sofor.Name = "rbtn_sofor";
            this.rbtn_sofor.Size = new System.Drawing.Size(65, 21);
            this.rbtn_sofor.TabIndex = 9;
            this.rbtn_sofor.TabStop = true;
            this.rbtn_sofor.Text = "Şoför";
            this.rbtn_sofor.UseVisualStyleBackColor = true;
            // 
            // btn_sil
            // 
            this.btn_sil.Location = new System.Drawing.Point(218, 154);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(75, 23);
            this.btn_sil.TabIndex = 8;
            this.btn_sil.Text = "Sil";
            this.btn_sil.UseVisualStyleBackColor = true;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.Location = new System.Drawing.Point(299, 151);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(85, 29);
            this.btn_kaydet.TabIndex = 7;
            this.btn_kaydet.Text = "Ekle";
            this.btn_kaydet.UseVisualStyleBackColor = true;
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // txtbx_soyadi
            // 
            this.txtbx_soyadi.Location = new System.Drawing.Point(183, 69);
            this.txtbx_soyadi.Name = "txtbx_soyadi";
            this.txtbx_soyadi.Size = new System.Drawing.Size(201, 23);
            this.txtbx_soyadi.TabIndex = 5;
            // 
            // txtbx_padi
            // 
            this.txtbx_padi.Location = new System.Drawing.Point(183, 28);
            this.txtbx_padi.Name = "txtbx_padi";
            this.txtbx_padi.Size = new System.Drawing.Size(201, 23);
            this.txtbx_padi.TabIndex = 4;
            // 
            // btn_cikis
            // 
            this.btn_cikis.Image = ((System.Drawing.Image)(resources.GetObject("btn_cikis.Image")));
            this.btn_cikis.Location = new System.Drawing.Point(929, 12);
            this.btn_cikis.Name = "btn_cikis";
            this.btn_cikis.Size = new System.Drawing.Size(45, 45);
            this.btn_cikis.TabIndex = 20;
            this.btn_cikis.UseVisualStyleBackColor = true;
            this.btn_cikis.Click += new System.EventHandler(this.btn_cikis_Click);
            // 
            // frm_personeller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(986, 384);
            this.Controls.Add(this.btn_cikis);
            this.Controls.Add(this.grpbx_personelBilgileri);
            this.Controls.Add(this.dgw_personeller);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frm_personeller";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personel İşlemleri";
            this.Load += new System.EventHandler(this.frm_personeller_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgw_personeller)).EndInit();
            this.grpbx_personelBilgileri.ResumeLayout(false);
            this.grpbx_personelBilgileri.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgw_personeller;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grpbx_personelBilgileri;
        private System.Windows.Forms.Button btn_kaydet;
        private System.Windows.Forms.TextBox txtbx_soyadi;
        private System.Windows.Forms.TextBox txtbx_padi;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.RadioButton rbtn_muavin;
        private System.Windows.Forms.RadioButton rbtn_sofor;
        private System.Windows.Forms.Button btn_temizle;
        private System.Windows.Forms.Button btn_cikis;
    }
}