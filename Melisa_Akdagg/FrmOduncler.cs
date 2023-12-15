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
            while (dr3.Read())
            {
                cmbKitaplar.Items.Add(dr3[1].ToString());
            }
            cmbKullanicilar.Text = "Kullanıcı Listesi";
            cmbKitaplar.Text = "Kitapların Listesi";

            SqlCommand komut4 = new SqlCommand("select count(o.KitapID), KitapAdi from oduncler o \r\ninner join Kitaplar k on k.KitapID=o.KitapID\r\ngroup by k.KitapAdi\r\norder by  count(o.KitapID) ", baglanti);
            SqlDataReader dr4=komut4.ExecuteReader();
            while (dr4.Read())
            {
                lblMaxKitap.Text = dr4[1].ToString();
            }

            SqlCommand komut5 = new SqlCommand("select count(o.KitapID), k.KullaniciAdi+' '+k.KullaniciSoyadi from oduncler o \r\ninner join Kullanicilar k on k.KullaniciID=o.KitapID\r\ngroup by k.KullaniciAdi+' '+k.KullaniciSoyadi\r\norder by  count(o.KitapID) ", baglanti);
            SqlDataReader dr5 = komut5.ExecuteReader();
            while (dr5.Read())
            {
                lblKullanici.Text = dr5[1].ToString();
            }


            baglanti.Close();
                //asdasdasds
        }

        private void btnEkleme_Click(object sender, EventArgs e)
        {
            DateTime nowDate = DateTime.Now;
            baglanti.Open();        
            SqlCommand komut = new SqlCommand("insert into Oduncler values" +
                "(@p1,@p2,@p3,@p4,@p5,@p6)", baglanti);
            komut.Parameters.AddWithValue("@p2", cmbKullanicilar.SelectedIndex+1);
            komut.Parameters.AddWithValue("@p3", cmbKitaplar.SelectedIndex+1);
            komut.Parameters.AddWithValue("@p4", nowDate);
            komut.Parameters.AddWithValue("@p5", nowDate.AddDays(14));
            komut.Parameters.AddWithValue("@p6", "1001 - 01 - 01");// Verdiği Tarih
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("İşlem başarılı");
            Goster();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update  oduncler set VerildigiTarih=@p1  where oduncID=@p7", baglanti);
            komut.Parameters.AddWithValue("@p1", txtTarih.Text.ToString());//Sadece verildiği tarih değişecek
            komut.Parameters.AddWithValue("@p7", txtID.Text.ToString());
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Güncelleme başarılı");
            Goster();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtID.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtTarih.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult secenek = MessageBox.Show("Silme işlemini onaylıyor musunuz?", " ", MessageBoxButtons.YesNoCancel);

            baglanti.Open();
            if (secenek == DialogResult.Yes)
            {
                SqlCommand sil = new SqlCommand("delete from oduncler where oduncID=@p1", baglanti);
                sil.Parameters.AddWithValue("@p1", txtID.Text);
                sil.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Silme işlemi başarılı");
                Goster();
            }
            else
            {
                MessageBox.Show("Silme işlemi iptal edildi...");
            }


            baglanti.Close();
        }

        private void txtArama_TextChanged(object sender, EventArgs e)
        {
            tablo.Clear();
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from oduncler where kullaniciID like '" + txtArama.Text + "%'", baglanti);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }

       
    }
}
