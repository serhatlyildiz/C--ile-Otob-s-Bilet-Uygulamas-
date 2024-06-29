using Npgsql;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtobusBiletUygulamasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tmr_acilis.Start();
        }
        frm_anaForm frm_ana = new frm_anaForm();
        int sayac = 0;
        private void tmr_acilis_Tick(object sender, EventArgs e)
        {
            sayac++;
            if (sayac==2)
            {
                tmr_acilis.Stop();
                this.Hide();
                frm_ana.Show();
            }
        }
    }
}
