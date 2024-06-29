namespace OtobusBiletUygulamasi
{
    partial class frm_anaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_anaForm));
            this.btn_biletlerim = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Tc = new System.Windows.Forms.TextBox();
            this.btn_biletBul = new System.Windows.Forms.Button();
            this.cmb_nereye = new System.Windows.Forms.ComboBox();
            this.cmb_nereden = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_yGiris = new System.Windows.Forms.Button();
            this.dtp_tarih = new System.Windows.Forms.DateTimePicker();
            this.btn_cikis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_biletlerim
            // 
            this.btn_biletlerim.BackColor = System.Drawing.Color.Green;
            this.btn_biletlerim.ForeColor = System.Drawing.Color.White;
            this.btn_biletlerim.Location = new System.Drawing.Point(371, 65);
            this.btn_biletlerim.Name = "btn_biletlerim";
            this.btn_biletlerim.Size = new System.Drawing.Size(84, 48);
            this.btn_biletlerim.TabIndex = 22;
            this.btn_biletlerim.Text = "Biletlerim";
            this.btn_biletlerim.UseVisualStyleBackColor = false;
            this.btn_biletlerim.Click += new System.EventHandler(this.btn_biletlerim_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 17);
            this.label3.TabIndex = 21;
            this.label3.Text = "Tc Kimlik Numarası : ";
            // 
            // txt_Tc
            // 
            this.txt_Tc.Location = new System.Drawing.Point(179, 79);
            this.txt_Tc.MaxLength = 11;
            this.txt_Tc.Name = "txt_Tc";
            this.txt_Tc.Size = new System.Drawing.Size(179, 23);
            this.txt_Tc.TabIndex = 20;
            // 
            // btn_biletBul
            // 
            this.btn_biletBul.BackColor = System.Drawing.Color.Green;
            this.btn_biletBul.ForeColor = System.Drawing.Color.White;
            this.btn_biletBul.Location = new System.Drawing.Point(777, 14);
            this.btn_biletBul.Name = "btn_biletBul";
            this.btn_biletBul.Size = new System.Drawing.Size(84, 48);
            this.btn_biletBul.TabIndex = 19;
            this.btn_biletBul.Text = "Bilet Bul";
            this.btn_biletBul.UseVisualStyleBackColor = false;
            this.btn_biletBul.Click += new System.EventHandler(this.btn_biletBul_Click);
            // 
            // cmb_nereye
            // 
            this.cmb_nereye.FormattingEnabled = true;
            this.cmb_nereye.Location = new System.Drawing.Point(359, 27);
            this.cmb_nereye.Name = "cmb_nereye";
            this.cmb_nereye.Size = new System.Drawing.Size(179, 24);
            this.cmb_nereye.TabIndex = 18;
            // 
            // cmb_nereden
            // 
            this.cmb_nereden.FormattingEnabled = true;
            this.cmb_nereden.Location = new System.Drawing.Point(103, 27);
            this.cmb_nereden.Name = "cmb_nereden";
            this.cmb_nereden.Size = new System.Drawing.Size(179, 24);
            this.cmb_nereden.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(288, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Nereye : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Nereden : ";
            // 
            // btn_yGiris
            // 
            this.btn_yGiris.BackColor = System.Drawing.Color.Red;
            this.btn_yGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_yGiris.ForeColor = System.Drawing.Color.White;
            this.btn_yGiris.Location = new System.Drawing.Point(708, 66);
            this.btn_yGiris.Name = "btn_yGiris";
            this.btn_yGiris.Size = new System.Drawing.Size(153, 47);
            this.btn_yGiris.TabIndex = 14;
            this.btn_yGiris.Text = "Yetkili Girişi";
            this.btn_yGiris.UseVisualStyleBackColor = false;
            this.btn_yGiris.Click += new System.EventHandler(this.btn_yGiris_Click);
            // 
            // dtp_tarih
            // 
            this.dtp_tarih.Location = new System.Drawing.Point(544, 28);
            this.dtp_tarih.Name = "dtp_tarih";
            this.dtp_tarih.Size = new System.Drawing.Size(227, 23);
            this.dtp_tarih.TabIndex = 23;
            // 
            // btn_cikis
            // 
            this.btn_cikis.Image = ((System.Drawing.Image)(resources.GetObject("btn_cikis.Image")));
            this.btn_cikis.Location = new System.Drawing.Point(867, 6);
            this.btn_cikis.Name = "btn_cikis";
            this.btn_cikis.Size = new System.Drawing.Size(45, 45);
            this.btn_cikis.TabIndex = 24;
            this.btn_cikis.UseVisualStyleBackColor = true;
            this.btn_cikis.Click += new System.EventHandler(this.btn_cikis_Click);
            // 
            // frm_anaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(920, 121);
            this.Controls.Add(this.btn_cikis);
            this.Controls.Add(this.dtp_tarih);
            this.Controls.Add(this.btn_biletlerim);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Tc);
            this.Controls.Add(this.btn_biletBul);
            this.Controls.Add(this.cmb_nereye);
            this.Controls.Add(this.cmb_nereden);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_yGiris);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimizeBox = false;
            this.Name = "frm_anaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Otobüs Bilet Uygulaması";
            this.Load += new System.EventHandler(this.frm_anaForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_biletlerim;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Tc;
        private System.Windows.Forms.Button btn_biletBul;
        private System.Windows.Forms.ComboBox cmb_nereye;
        private System.Windows.Forms.ComboBox cmb_nereden;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_yGiris;
        private System.Windows.Forms.DateTimePicker dtp_tarih;
        private System.Windows.Forms.Button btn_cikis;
    }
}