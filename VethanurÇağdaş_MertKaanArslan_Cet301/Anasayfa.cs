namespace VethanurÇağdaş_MertKaanArslan_Cet301
{
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }

        private void Anasayfa_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmAraçOtoparkKaydı kayit = new frmAraçOtoparkKaydı();
            kayit.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmAraçOtoparkYerleri yer = new frmAraçOtoparkYerleri();
            yer.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmAraçOtoparkÇıkışı çıkış = new frmAraçOtoparkÇıkışı();
            çıkış.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmSatis satis = new frmSatis();
            satis.ShowDialog();
        }
    }
}
