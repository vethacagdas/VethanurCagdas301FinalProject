﻿using System;
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
    public partial class frmMarka : Form
    {
        public frmMarka()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=VETHA\\SQLEXPRESS;Initial Catalog=araç_otopark;Integrated Security=True;");
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into markabilgileri(marka) values('" + textBox1.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Marka Eklendi");
            textBox1.Clear();

        }

    }
}
