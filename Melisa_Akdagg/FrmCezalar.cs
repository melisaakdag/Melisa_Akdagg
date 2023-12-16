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
            Goster();

        }

        private void Goster()
        {
            tablo.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select c.CezaID,k.KullaniciAdi+k.KullaniciSoyadi 'Adı ve Soyadı',c.CezaTuru,c.CezaMiktari,c.Tarih from Cezalar c\r\ninner join Kullanicilar k on k.KullaniciID=c.KullaniciID", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;

            SqlCommand komut2 = new SqlCommand("select * from Kullanicilar", baglanti);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                cmbKullanicilar.Items.Add(dr2[1] + dr2[2].ToString());
            }
            cmbKullanicilar.Text = "Kullanıcı Listesi";

            SqlCommand komut3 = new SqlCommand("select cezaMiktari from cezalar", baglanti);
            SqlDataReader dr3 = komut3.ExecuteReader();
            double miktar = 0;
            while (dr3.Read())
            {
               miktar=Convert.ToDouble(Convert.ToDouble(dr3[0])+miktar);
            }
            lblMiktar.Text = miktar.ToString()+"TL";

            SqlCommand komut4 = new SqlCommand("SELECT MAX(c.CezaMiktari),k.KullaniciAdi FROM Cezalar c\r\ninner join Kullanicilar k on k.KullaniciID=c.KullaniciID\r\ngroup by k.KullaniciAdi \r\norder by MAX(c.CezaMiktari)", baglanti);
            SqlDataReader dr4 = komut4.ExecuteReader();
            while (dr4.Read())
            {
                lblKullanici.Text = dr4[0]+"TL" +dr4[1].ToString();
            }
           

            baglanti.Close();
        }

        private void btnGoster_Click(object sender, EventArgs e)
        {
            Goster();
        }

        private void btnEkleme_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Cezalar values" +
                "(@p1,@p2,@p3,@p4,@p5)", baglanti);
            komut.Parameters.AddWithValue("@p2", cmbKullanicilar.SelectedIndex+1);
            komut.Parameters.AddWithValue("@p3", txtTarih.Text);
            komut.Parameters.AddWithValue("@p4", txtTur.Text);
            komut.Parameters.AddWithValue("@p5", txtMiktar.Text);
            komut.Parameters.AddWithValue("@p1", 4); // ID

            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("İşlem başarılı");

            Goster();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtID.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            cmbKullanicilar.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtTarih.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            txtTur.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            txtMiktar.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult secenek = MessageBox.Show("Silme işlemini onaylıyor musunuz?", " ", MessageBoxButtons.YesNoCancel);

            baglanti.Open();
            if (secenek == DialogResult.Yes)
            {
                SqlCommand sil = new SqlCommand("delete from cezalar where cezaID=@p1", baglanti);
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
            Goster();
        }

        private void txtArama_TextChanged(object sender, EventArgs e)
        {
            tablo.Clear();
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from cezalar where cezaTuru like '" + txtArama.Text + "%'", baglanti);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }
    }
}
