using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace IngilizceKodSozlugu
{
    public partial class Form1 : Form
    {
        SqlConnection baglanti= new SqlConnection("data source =.\\SQLEXPRESS;initial catalog=SozlukDB;integrated security=true");
        public Form1()
        {
            InitializeComponent();
        }
        void VerileriListele()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from IngilizceKelimeler order by Kelime asc", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvKelimeler.DataSource = dt;
        }
        void KodlariListele()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from KodTerimleri order by KodAdi asc", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvKodlar.DataSource = dt;
        }

        private void btnKelimeKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                string sorgu = "insert into IngilizceKelimeler (Kelime, Anlami, KullanimAlani)values (@p1, @p2, @p3)";
                SqlCommand komut = new SqlCommand(sorgu, baglanti);

                komut.Parameters.AddWithValue("@p1", txtKelime.Text);
                komut.Parameters.AddWithValue("@p2", txtAnlam.Text);
                komut.Parameters.AddWithValue("@p3", txtKullanim.Text);
                komut.ExecuteNonQuery(); 
                baglanti.Close();
                MessageBox.Show("kelime başarıyla kaydedildi.");
                VerileriListele(); 

                txtKelime.Text = "";
                txtAnlam.Text = "";
                txtKullanim.Text = "";
            }
            catch (Exception hata) 
            {
                MessageBox.Show("Bir hata oluştu: " + hata.Message.ToString());
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtKelimeAra.Text = "Kelime Ara...";
            txtKelimeAra.ForeColor = Color.Silver;

            txtKodAra.Text = "Kod Ara...";
            txtKodAra.ForeColor = Color.Silver;
            VerileriListele();
            KodlariListele();
        }

        private void btnKodKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                string sorgu = "insert into KodTerimleri ( KodAdi, Aciklama, OrnekAdi) values (@p1, @p2,@p3)";
                SqlCommand komut = new SqlCommand(sorgu, baglanti);

                komut.Parameters.AddWithValue("@p1", txtKodAdi.Text);
                komut.Parameters.AddWithValue("@p2", txtKodAciklama.Text);
                komut.Parameters.AddWithValue("@p3", txtOrnekKod.Text);

                komut.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show("kod terimleri başarıyla eklendi");
                KodlariListele();

                txtKodAdi.Clear();
                txtKodAciklama.Clear();
                txtOrnekKod.Clear();
            }
            catch(Exception hata)
            {
                MessageBox.Show("hata oluştu " + hata.Message);
                if (baglanti.State == ConnectionState.Open) baglanti.Close();
            }
        }

        private void dgvKelimeler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtKelime.Text = dgvKelimeler.CurrentRow.Cells[1].Value.ToString();
            txtAnlam.Text = dgvKelimeler.CurrentRow.Cells[2].Value.ToString();
            txtKullanim.Text = dgvKelimeler.CurrentRow.Cells[3].Value.ToString();
        }

        private void dgvKodlar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtKodAdi.Text = dgvKodlar.CurrentRow.Cells[1].Value.ToString();
            txtKodAciklama.Text = dgvKodlar.CurrentRow.Cells[2].Value.ToString();
            txtOrnekKod.Text = dgvKodlar.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnKelimeSil_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(dgvKelimeler.CurrentRow.Cells[0].Value);
                baglanti.Open();
                string sorgu = "delete from IngilizceKelimeler where ID = @id";
                SqlCommand komut = new SqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@id", id);

                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("kayıt başarıyla silindi.");
                VerileriListele();
            }
            catch(Exception hata)
            {
                MessageBox.Show("silme hatası" + hata.Message);
                if (baglanti.State == ConnectionState.Open) baglanti.Close();
            }
        }

        private void btnKelimleriGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(dgvKelimeler.CurrentRow.Cells[0].Value);
                baglanti.Open();
                string sorgu = "update IngilizceKelimeler set Kelime=@p1, Anlami=@p2, KullanimAlani=@p3 where ID=@id";
                SqlCommand komut = new SqlCommand(sorgu, baglanti);

                komut.Parameters.AddWithValue("@p1", txtKelime.Text);
                komut.Parameters.AddWithValue("@p2", txtAnlam.Text);
                komut.Parameters.AddWithValue("@p3", txtKullanim.Text);
                komut.Parameters.AddWithValue("@id", id);

                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("kayıt güncellendi");
                VerileriListele();
            }
            catch(Exception hata)
            {
                MessageBox.Show("güncelleme hatası: " + hata.Message);
                if (baglanti.State == ConnectionState.Open) baglanti.Close();
            }
        }

        private void btnKodGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(dgvKodlar.CurrentRow.Cells[0].Value);

                baglanti.Open();
                string sorgu = "UPDATE KodTerimleri SET KodAdi=@p1, Aciklama=@p2, OrnekAdi=@p3 WHERE ID=@id";
                SqlCommand komut = new SqlCommand(sorgu, baglanti);

                komut.Parameters.AddWithValue("@p1", txtKodAdi.Text);
                komut.Parameters.AddWithValue("@p2", txtKodAciklama.Text);
                komut.Parameters.AddWithValue("@p3", txtOrnekKod.Text);
                komut.Parameters.AddWithValue("@id", id);

                komut.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show("Kayıt güncellendi.");
                KodlariListele();
            }
            catch (Exception hata)
            {
                MessageBox.Show("Güncelleme hatası: " + hata.Message);
                if (baglanti.State == ConnectionState.Open) baglanti.Close();
            }
        }

        private void btnKodSil_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(dgvKodlar.CurrentRow.Cells[0].Value);

                baglanti.Open();
                string sorgu = "DELETE FROM KodTerimleri WHERE ID = @id";
                SqlCommand komut = new SqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@id", id);

                komut.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show("Kayıt başarıyla silindi.");
                KodlariListele();
            }
            catch (Exception hata)
            {
                MessageBox.Show("Silme hatası: " + hata.Message);
                if (baglanti.State == ConnectionState.Open) baglanti.Close();
            }
        }

        private void txtKelimeAra_TextChanged(object sender, EventArgs e)
        {
            string sorgu = "select * from IngilizceKelimeler where Kelime like @p1 or Anlami like @p1";
            SqlDataAdapter da = new SqlDataAdapter(sorgu, baglanti);
            da.SelectCommand.Parameters.AddWithValue("@p1", "%" + txtKelimeAra.Text + "%");

            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvKelimeler.DataSource = dt;
        }
        
        private void txtKodAra_TextChanged(object sender, EventArgs e)
        {
            string sorgu = "select * from KodTerimleri where KodAdi like @p1 or Aciklama like @p1";
            SqlDataAdapter da = new SqlDataAdapter(sorgu, baglanti);
            da.SelectCommand.Parameters.AddWithValue("@p1", "%" + txtKodAra.Text + "%");

            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvKodlar.DataSource = dt;
        }
        //placeholder kısmı 
        private void txtKodAra_Enter(object sender, EventArgs e)
        {
            if (txtKodAra.Text == "Kod Ara...")
            {
                txtKodAra.Text = ""; 
                txtKodAra.ForeColor = Color.Black; 
            }
        }

        private void txtKodAra_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtKodAra.Text))
            {
                txtKodAra.Text = "Kod Ara...";
                txtKodAra.ForeColor = Color.Silver;
            }
        }

        private void txtKelimeAra_Enter(object sender, EventArgs e)
        {
            if (txtKelimeAra.Text == "Kelime Ara...")
            {
                txtKelimeAra.Text = "";
                txtKelimeAra.ForeColor = Color.Black;
            }
        }

        private void txtKelimeAra_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtKelimeAra.Text))
            {
                txtKelimeAra.Text = "Kelime Ara...";
                txtKelimeAra.ForeColor = Color.Silver;
            }
        }

    }
}
