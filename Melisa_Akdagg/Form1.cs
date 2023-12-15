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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Melisa_Akdagg
{
    public partial class Form1 : Form
    {
        public Form1()
        {
           
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-OGSV1AA\MSSQLSERVER01;Initial Catalog=KutuphaneMelisaDB;Integrated Security=True;MultipleActiveResultSets=True");
        DataTable tablo = new DataTable();
        private void Form1_Load(object sender, EventArgs e)
        {
            int yasToplam = 0;
            Goster();
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("select count(*) from kullanicilar", baglanti);
            SqlDataReader dr1= komut1.ExecuteReader();
            while (dr1.Read())
            {
                lblOgrenciS.Text = dr1[0].ToString();
            }

            SqlCommand komut2 = new SqlCommand("select * from kullanicilar", baglanti);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                yasToplam  = Convert.ToInt32(dr2[6])+yasToplam;
            }
            lblYasOrt.Text = (yasToplam / Convert.ToDouble(lblOgrenciS.Text)).ToString();
            baglanti.Close();

        }

        private void Goster()
        {
           tablo.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from kullanicilar  ", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }

        private void btnEkleme_Click(object sender, EventArgs e)
        {

            //SqlCommand count = new SqlCommand("select count(*) from kullanicilar");
            //int Sayi = count.ExecuteNonQuery();

            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Kullanicilar values" +
                "(@p1,@p2,@p3,@p4,@p5,@p6,@p7)", baglanti);
            komut.Parameters.AddWithValue("@p2", txtAdi.Text);
            komut.Parameters.AddWithValue("@p3", txtSoyadi.Text);
            komut.Parameters.AddWithValue("@p4", txtTc.Text);
            komut.Parameters.AddWithValue("@p5", txtTelefonNo.Text);
            komut.Parameters.AddWithValue("@p6", txtMail.Text);
            komut.Parameters.AddWithValue("@p7", txtYasi.Text.ToString());
            komut.Parameters.AddWithValue("@p1",  6); // ID

            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("İşlem başarılı");
            Goster();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtID.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtAdi.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtSoyadi.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            txtTc.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            txtTelefonNo.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            txtMail.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            txtYasi.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();


            
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update  Kullanicilar set KullaniciAdi=@p1,KullaniciSoyadi=@p2,TC=@p3,TelefonNumarasi=@p4,Mail=@p5,Yasi=@p6 where KullaniciID=@p7", baglanti);
            komut.Parameters.AddWithValue("@p1", txtAdi.Text.ToString());
            komut.Parameters.AddWithValue("@p2", txtSoyadi.Text.ToString());
            komut.Parameters.AddWithValue("@p3", txtTc.Text.ToString());
            komut.Parameters.AddWithValue("@p4", txtTelefonNo.Text.ToString());
            komut.Parameters.AddWithValue("@p5", txtMail.Text.ToString());
            komut.Parameters.AddWithValue("@p6", txtYasi.Text.ToString());
            komut.Parameters.AddWithValue("@p7", txtID.Text.ToString());
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Güncelleme başarılı");
            Goster();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult secenek = MessageBox.Show("Silme işlemini onaylıyor musunuz?", " ", MessageBoxButtons.YesNoCancel);

            baglanti.Open();
            if (secenek == DialogResult.Yes)
            {
                SqlCommand sil = new SqlCommand("delete from kullanicilar where kullaniciID=@p1", baglanti);
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
            if (rdbIsim.Checked)
            {
                tablo.Clear();
                baglanti.Open();
                SqlDataAdapter adtr = new SqlDataAdapter("select * from kullanicilar where kullaniciAdi like '" + txtArama.Text + "%'", baglanti);
                adtr.Fill(tablo);
                dataGridView1.DataSource = tablo;
                baglanti.Close();
            }
            else if (rdbSoyisim.Checked)
            {
                tablo.Clear();
                baglanti.Open();
                SqlDataAdapter adtr = new SqlDataAdapter("select * from kullanicilar where kullaniciSoyadi like '" + txtArama.Text + "%'", baglanti);
                adtr.Fill(tablo);
                dataGridView1.DataSource = tablo;
                baglanti.Close();
            }
           
        }

        private void rdbIsim_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Text = "İsme Göre Ara";
        }

        private void rdbSoyisim_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Text = "Soyİsme Göre Ara";
        }
    }
}
