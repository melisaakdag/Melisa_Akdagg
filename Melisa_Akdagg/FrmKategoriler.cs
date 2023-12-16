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
    public partial class FrmKategoriler : Form
    {
        public FrmKategoriler()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-OGSV1AA\MSSQLSERVER01;Initial Catalog=KutuphaneMelisaDB;Integrated Security=True;MultipleActiveResultSets=True");
        DataTable tablo = new DataTable();
        private void FrmKategoriler_Load(object sender, EventArgs e)
        {
            Goster();
        }

        private void Goster()
        {
            tablo.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Kategoriler", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }

        private void btnEkleme_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into kategoriler values" +
                "(@p1,@p2)", baglanti);
            komut.Parameters.AddWithValue("@p2", txtKategori.Text);
            komut.Parameters.AddWithValue("@p1", 4); // ID

            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("İşlem başarılı");

            Goster();
        }

        private void btnGoster_Click(object sender, EventArgs e)
        {
            Goster();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult secenek = MessageBox.Show("Silme işlemini onaylıyor musunuz?", " ", MessageBoxButtons.YesNoCancel);

            baglanti.Open();
            if (secenek == DialogResult.Yes)
            {
                SqlCommand sil = new SqlCommand("delete from kategoriler where kategoriID=@p1", baglanti);
                sil.Parameters.AddWithValue("@p1", txtID.Text);
                sil.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Silme işlemi başarılı");
            }
            else
            {
                MessageBox.Show("Silme işlemi iptal edildi...");
            }


            baglanti.Close();
            Goster();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update  kategoriler set kategoriAdı=@p2 where KategoriID=@p1", baglanti);
            komut.Parameters.AddWithValue("@p2", txtKategori.Text.ToString());
            komut.Parameters.AddWithValue("@p1", txtID.Text.ToString());
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Güncelleme başarılı");
            Goster();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtID.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtKategori.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
        }

        private void txtArama_TextChanged(object sender, EventArgs e)
        {
            tablo.Clear();
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from kategoriler where kategoriAdı like '" + txtArama.Text + "%'", baglanti);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }
    }
}
