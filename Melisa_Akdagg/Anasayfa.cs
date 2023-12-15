using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Melisa_Akdagg
{
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }

        private void btnKullanicilar_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }

        private void lblYazarlar_Click(object sender, EventArgs e)
        {
            FrmYazarlar frmYazarlar = new FrmYazarlar();
            frmYazarlar.ShowDialog();
        }

        private void btnOduncler_Click(object sender, EventArgs e)
        {
            FrmOduncler frm =new FrmOduncler();
            frm.ShowDialog();
        }

        private void btnCeza_Click(object sender, EventArgs e)
        {
            FrmCezalar frmCezalar=new FrmCezalar();
            frmCezalar.ShowDialog();
        }
    }
}
