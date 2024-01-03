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

namespace VethanurÇağdaş_MertKaanArslan_Cet301
{
    public partial class frmAraçOtoparkÇıkışı : Form
    {
        public frmAraçOtoparkÇıkışı()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=VETHA\\SQLEXPRESS;Initial Catalog=araç_otopark;Integrated Security=True;");

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void frmAraçOtoparkÇıkışı_Load(object sender, EventArgs e)
        {
            DoluYerler();
            Plakalar();
            timer1.Enabled = true;
        }

        private void Plakalar()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select *from araç_otopark_kaydı", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                comboPlaka.Items.Add(read["plaka"]);
            }
            baglanti.Close();
        }





        private void DoluYerler()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * from araçdurumu where durumu = 'DOLU'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                comboParkYeri.Items.Add(read["parkyeri"]);
            }
            baglanti.Close();
        }

        private void comboPlaka_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboPlaka.SelectedItem != null)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("SELECT * FROM araç_otopark_kaydı WHERE plaka = @plaka", baglanti);
                komut.Parameters.AddWithValue("@plaka", comboPlaka.SelectedItem.ToString());
                SqlDataReader read = komut.ExecuteReader();
                while (read.Read())
                {
                    txtParkYeri.Text = read["parkyeri"].ToString();
                }
                baglanti.Close();
            }
        }


        private void comboParkYeri_SelectedIndexChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("'Select *from araç_otopark_kaydı where parkyeri'" + comboPlaka.SelectedItem, baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                txtParkYeri2.Text = read["parkyeri"].ToString();
                txtTc.Text = read["tc"].ToString();
                txtAd.Text = read["ad"].ToString();
                txtSoyad.Text = read["soyad"].ToString();
                txtMarka.Text = read["marka"].ToString();
                txtPlaka.Text = read["plaka"].ToString();
                txtSeri.Text = read["seri"].ToString();
                lblGelişTarihi.Text = read["tarih"].ToString();

            }
            baglanti.Close();
            DateTime geliş, çıkış;
            geliş = DateTime.Parse(lblGelişTarihi.Text);
            çıkış = DateTime.Parse(lblÇıkışTarihi.Text);
            TimeSpan fark;
            fark = çıkış - geliş;
            lblSüre.Text = fark.TotalHours.ToString("0.00");
            lblToplamTutar.Text = (double.Parse(lblSüre.Text) * (0.75)).ToString("0.00");
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblÇıkışTarihi.Text = DateTime.Now.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete *from araç_otopark_kaydı where plaka = '" + txtPlaka.Text + "'", baglanti);
            komut.ExecuteNonQuery();

            SqlCommand komut2 = new SqlCommand("update araçdurumu set durumu ='BOŞ' where parkyeri = '" + txtParkYeri2.Text + "'", baglanti);
            komut2.ExecuteNonQuery();
            SqlCommand komut3 = new SqlCommand("insert into satis(@parkyeri,@plaka,@geliş_tarihi,@çıkış_tarihi,@süre,@tutar) values()", baglanti);
            komut3.Parameters.AddWithValue("@parkyeri", txtParkYeri2.Text);
            komut3.Parameters.AddWithValue("@plaka", txtPlaka.Text);
            komut3.Parameters.AddWithValue("@geliş_tarihi", lblGelişTarihi.Text);
            komut3.Parameters.AddWithValue("@çıkış_tarihi", lblÇıkışTarihi.Text);
            komut3.Parameters.AddWithValue("@süre", double.Parse(lblSüre.Text));
            komut3.Parameters.AddWithValue("@tutar", double.Parse(lblToplamTutar.Text));
            komut3.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Araç çıkışı yapıldı.");

            foreach (Control item in groupBox2.Controls)
            {
                if (item is TextBox) ;
                {
                    item.Text = "";
                    txtParkYeri.Text = "";
                    comboParkYeri.Text = "";
                    comboPlaka.Text = "";
                }
                

            }
            comboPlaka.Items.Clear();
            comboParkYeri.Items.Clear();
            DoluYerler();
            Plakalar();

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void txtRenk_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
