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
    public partial class frmSeri : Form
    {
        public frmSeri()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=VETHA\\SQLEXPRESS;Initial Catalog=araç_otopark;Integrated Security=True;");

        private void marka()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select marka from markabilgileri", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                comboBox1.Items.Add(read["marka"].ToString());
            }
            baglanti.Close();
        }

        private void frmSeri_Load(object sender, EventArgs e)
        {
            marka();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();

                // Marka bilgisini parametre olarak ekleyin
                SqlCommand markaKomut = new SqlCommand("SELECT * FROM markabilgileri WHERE marka = @marka", baglanti);
                markaKomut.Parameters.AddWithValue("@marka", comboBox1.Text);
                SqlDataReader markaReader = markaKomut.ExecuteReader();

                // Marka bulunamazsa ekleme işlemi yapma
                if (!markaReader.HasRows)
                {
                    MessageBox.Show("Belirtilen marka bulunamadı.");
                    return;
                }

                baglanti.Close();

                // Ekleme işlemi
                baglanti.Open();
                SqlCommand komut = new SqlCommand("INSERT INTO seribilgileri (marka, seri) VALUES (@marka, @seri)", baglanti);
                komut.Parameters.AddWithValue("@marka", comboBox1.Text);
                komut.Parameters.AddWithValue("@seri", textBox1.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show("Markaya bağlı araç serisi eklendi");
                textBox1.Clear();
                comboBox1.Text = "";
                comboBox1.Items.Clear();
                marka();
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
            