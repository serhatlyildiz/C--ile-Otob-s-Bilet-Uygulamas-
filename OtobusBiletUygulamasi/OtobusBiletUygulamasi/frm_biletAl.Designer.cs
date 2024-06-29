namespace OtobusBiletUygulamasi
{
    partial class frm_biletAl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_biletAl));
            this.btn_cikis = new System.Windows.Forms.Button();
            this.dgw_seferler = new System.Windows.Forms.DataGridView();
            this.dtp_tarih = new System.Windows.Forms.DateTimePicker();
            this.rbtn_tek = new System.Windows.Forms.RadioButton();
            this.rbtn_cift = new System.Windows.Forms.RadioButton();
            this.btn_temzile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_seferler)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_cikis
            // 
            this.btn_cikis.Image = ((System.Drawing.Image)(resources.GetObject("btn_cikis.Image")));
            this.btn_cikis.Location = new System.Drawing.Point(1262, 12);
            this.btn_cikis.Name = "btn_cikis";
            this.btn_cikis.Size = new System.Drawing.Size(45, 45);
            this.btn_cikis.TabIndex = 0;
            this.btn_cikis.UseVisualStyleBackColor = true;
            this.btn_cikis.Click += new System.EventHandler(this.btn_cikis_Click);
            // 
            // dgw_seferler
            // 
            this.dgw_seferler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_seferler.Location = new System.Drawing.Point(12, 85);
            this.dgw_seferler.Name = "dgw_seferler";
            this.dgw_seferler.Size = new System.Drawing.Size(1295, 530);
            this.dgw_seferler.TabIndex = 1;
            this.dgw_seferler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgw_seferler_CellClick);
            // 
            // dtp_tarih
            // 
            this.dtp_tarih.Location = new System.Drawing.Point(438, 34);
            this.dtp_tarih.Name = "dtp_tarih";
            this.dtp_tarih.Size = new System.Drawing.Size(200, 23);
            this.dtp_tarih.TabIndex = 6;
            this.dtp_tarih.ValueChanged += new System.EventHandler(this.dtp_tarih_ValueChanged);
            // 
            // rbtn_tek
            // 
            this.rbtn_tek.AutoSize = true;
            this.rbtn_tek.ForeColor = System.Drawing.Color.White;
            this.rbtn_tek.Location = new System.Drawing.Point(656, 35);
            this.rbtn_tek.Name = "rbtn_tek";
            this.rbtn_tek.Size = new System.Drawing.Size(53, 21);
            this.rbtn_tek.TabIndex = 7;
            this.rbtn_tek.TabStop = true;
            this.rbtn_tek.Text = "2+1";
            this.rbtn_tek.UseVisualStyleBackColor = true;
            this.rbtn_tek.CheckedChanged += new System.EventHandler(this.rbtn_tek_CheckedChanged);
            // 
            // rbtn_cift
            // 
            this.rbtn_cift.AutoSize = true;
            this.rbtn_cift.ForeColor = System.Drawing.Color.White;
            this.rbtn_cift.Location = new System.Drawing.Point(715, 35);
            this.rbtn_cift.Name = "rbtn_cift";
            this.rbtn_cift.Size = new System.Drawing.Size(53, 21);
            this.rbtn_cift.TabIndex = 8;
            this.rbtn_cift.TabStop = true;
            this.rbtn_cift.Text = "2+2";
            this.rbtn_cift.UseVisualStyleBackColor = true;
            this.rbtn_cift.CheckedChanged += new System.EventHandler(this.rbtn_cift_CheckedChanged);
            // 
            // btn_temzile
            // 
            this.btn_temzile.Location = new System.Drawing.Point(774, 34);
            this.btn_temzile.Name = "btn_temzile";
            this.btn_temzile.Size = new System.Drawing.Size(127, 23);
            this.btn_temzile.TabIndex = 9;
            this.btn_temzile.Text = "Filtreleri Kaldır";
            this.btn_temzile.UseVisualStyleBackColor = true;
            this.btn_temzile.Click += new System.EventHandler(this.btn_temzile_Click);
            // 
            // frm_biletAl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(1319, 627);
            this.Controls.Add(this.btn_temzile);
            this.Controls.Add(this.rbtn_cift);
            this.Controls.Add(this.rbtn_tek);
            this.Controls.Add(this.dtp_tarih);
            this.Controls.Add(this.dgw_seferler);
            this.Controls.Add(this.btn_cikis);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frm_biletAl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_biletAl";
            this.Load += new System.EventHandler(this.frm_biletAl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgw_seferler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_cikis;
        private System.Windows.Forms.DataGridView dgw_seferler;
        private System.Windows.Forms.DateTimePicker dtp_tarih;
        private System.Windows.Forms.RadioButton rbtn_tek;
        private System.Windows.Forms.RadioButton rbtn_cift;
        private System.Windows.Forms.Button btn_temzile;
    }
}