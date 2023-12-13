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
    public partial class FrmOduncler : Form
    {
        public FrmOduncler()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-OGSV1AA\MSSQLSERVER01;Initial Catalog=KutuphaneMelisaDB;Integrated Security=True;MultipleActiveResultSets=True");
        DataTable tablo = new DataTable();
        DataTable tablo2 = new DataTable();
        private void FrmOduncler_Load(object sender, EventArgs e)
        {
            Goster();

        }

        private void Goster()
        {
            tablo.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select o.OduncID,k.KullaniciAdi+k.KullaniciSoyadi 'Adı ve Soyadı',k1.KitapAdi,o.AlisTarihi,o.VerisTarihi,o.VerildigiTarih from oduncler o \r\ninner join kullanicilar k on k.KullaniciID=o.KullaniciID\r\ninner join Kitaplar k1 on k1.KitapID=o.KitapID", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;

            SqlCommand komut2 = new SqlCommand("select * from Kullanicilar", baglanti);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                cmbKullanicilar.Items.Add(dr2[1] + dr2[2].ToString());
            }
           

            SqlCommand komut3 = new SqlCommand("select * from kitaplar", baglanti);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr2.Read())
            {
                cmbKitaplar.Items.Add(dr2[1].ToString());
            }
            baglanti.Close();
        }
    }
}
