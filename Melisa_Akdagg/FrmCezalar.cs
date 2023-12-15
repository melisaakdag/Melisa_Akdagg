using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Melisa_Akdagg
{
    public partial class FrmCezalar : Form
    {
        public FrmCezalar()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-OGSV1AA\MSSQLSERVER01;Initial Catalog=KutuphaneMelisaDB;Integrated Security=True;MultipleActiveResultSets=True");
        DataTable tablo = new DataTable();


        private void FrmCezalar_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select c.CezaID,k.KullaniciAdi+k.KullaniciSoyadi 'Adı ve Soyadı',c.CezaTuru,c.CezaMiktari,c.Tarih from Cezalar c\r\ninner join Kullanicilar k on k.KullaniciID=c.KullaniciID", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;

        }

        private void btnGoster_Click(object sender, EventArgs e)
        {

        }
    }
}
