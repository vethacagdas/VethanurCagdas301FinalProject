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
    public partial class frmAraçOtoparkKaydı : Form
    {
        public frmAraçOtoparkKaydı()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=VETHA\\SQLEXPRESS;Initial Catalog=araç_otopark;Integrated Security=True;");

        private void grupAraç_Enter(object sender, EventArgs e)
        {

        }

        private void frmAraçOtoparkKaydı_Load(object sender, EventArgs e)
        {
            BoşAraçlar();
            Marka();


        }

        private void Marka()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select marka from markabilgileri", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                if (read["marka"] != DBNull.Value) // Null kontrolü eklenmiş
                {
                    comboMarka.Items.Add(read["marka"].ToString());
                }
            }
            baglanti.Close();
        }

        private void BoşAraçlar()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from araçdurumu WHERE durumu = 'BOŞ'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                comboParkYeri.Items.Add(read["parkyeri"].ToString());
            }
            baglanti.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into araç_otopark_kaydı(tc,ad,soyad,telefon,email,plaka,marka,seri,renk,parkyeri,tarih) values(@tc,@ad,@soyad,@telefon,@email,@plaka,@marka,@seri,@renk,@parkyeri,@tarih)", baglanti);
                komut.Parameters.AddWithValue("@tc", txtTc.Text);
                komut.Parameters.AddWithValue("@ad", txtAd.Text);
                komut.Parameters.AddWithValue("@soyad", txtSoyad.Text);
                komut.Parameters.AddWithValue("@telefon", txtTelefon.Text);
                komut.Parameters.AddWithValue("@email", txtEmail.Text);
                komut.Parameters.AddWithValue("@plaka", txtPlaka.Text);
                komut.Parameters.AddWithValue("@marka", comboMarka.Text);
                komut.Parameters.AddWithValue("@seri", comboSeri.Text);
                komut.Parameters.AddWithValue("@renk", txtRenk.Text);
                komut.Parameters.AddWithValue("@parkyeri", comboParkYeri.Text);
                komut.Parameters.AddWithValue("@tarih", DateTime.Now.ToString());
                komut.ExecuteNonQuery();

                SqlCommand komut2 = new SqlCommand("update araçdurumu set durumu = 'DOLU' WHERE parkyeri = @parkyeri", baglanti);
                komut2.Parameters.AddWithValue("@parkyeri", comboParkYeri.SelectedItem);
                komut2.ExecuteNonQuery();

                MessageBox.Show("Araç kaydı oluşturuldu", "Kayıt");
                comboParkYeri.Items.Clear();
                BoşAraçlar();
               
                Marka();
               

                foreach (Control item in grupKişi.Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";
                    }
                }
                foreach (Control item in grupAraç.Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";
                    }
                }
                foreach (Control item in grupAraç.Controls)
                {
                    if (item is ComboBox)
                    {
                        item.Text = "";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }
        }


        private void btnMarka_Click(object sender, EventArgs e)
        {
            frmMarka marka = new frmMarka();
            marka.ShowDialog();
        }

        private void btnSeri_Click(object sender, EventArgs e)
        {
            frmSeri seri = new frmSeri();
            seri.ShowDialog();
        }

        private void comboMarka_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboMarka.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select marka,seri from seribilgileri where marka = '" + comboMarka.SelectedItem + "'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                comboSeri.Items.Add(read["seri"].ToString());
            }
            baglanti.Close();

           
        }

        private void comboParkYeri_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboSeri_SelectedIndexChanged(object sender, EventArgs e)
        {
         

        }
    }
}
