namespace VethanurÇağdaş_MertKaanArslan_Cet301
{
    partial class frmAraçOtoparkKaydı
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtTc = new TextBox();
            txtSoyad = new TextBox();
            txtAd = new TextBox();
            txtTelefon = new TextBox();
            txtEmail = new TextBox();
            txtPlaka = new TextBox();
            txtRenk = new TextBox();
            comboMarka = new ComboBox();
            comboSeri = new ComboBox();
            comboParkYeri = new ComboBox();
            grupKişi = new GroupBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            grupAraç = new GroupBox();
            btnSeri = new Button();
            btnMarka = new Button();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label6 = new Label();
            button1 = new Button();
            button2 = new Button();
            grupKişi.SuspendLayout();
            grupAraç.SuspendLayout();
            SuspendLayout();
            // 
            // txtTc
            // 
            txtTc.Location = new Point(128, 91);
            txtTc.Name = "txtTc";
            txtTc.Size = new Size(100, 23);
            txtTc.TabIndex = 0;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(128, 167);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(100, 23);
            txtSoyad.TabIndex = 1;
            // 
            // txtAd
            // 
            txtAd.Location = new Point(128, 129);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(100, 23);
            txtAd.TabIndex = 2;
            // 
            // txtTelefon
            // 
            txtTelefon.Location = new Point(128, 205);
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(100, 23);
            txtTelefon.TabIndex = 3;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(128, 243);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(100, 23);
            txtEmail.TabIndex = 4;
            // 
            // txtPlaka
            // 
            txtPlaka.Location = new Point(127, 94);
            txtPlaka.Name = "txtPlaka";
            txtPlaka.Size = new Size(120, 23);
            txtPlaka.TabIndex = 5;
            // 
            // txtRenk
            // 
            txtRenk.Location = new Point(127, 226);
            txtRenk.Name = "txtRenk";
            txtRenk.Size = new Size(120, 23);
            txtRenk.TabIndex = 6;
            // 
            // comboMarka
            // 
            comboMarka.FormattingEnabled = true;
            comboMarka.Location = new Point(127, 138);
            comboMarka.Name = "comboMarka";
            comboMarka.Size = new Size(120, 23);
            comboMarka.TabIndex = 7;
            comboMarka.SelectedIndexChanged += comboMarka_SelectedIndexChanged;
            // 
            // comboSeri
            // 
            comboSeri.FormattingEnabled = true;
            comboSeri.Location = new Point(127, 182);
            comboSeri.Name = "comboSeri";
            comboSeri.Size = new Size(120, 23);
            comboSeri.TabIndex = 8;
            comboSeri.SelectedIndexChanged += comboSeri_SelectedIndexChanged;
            // 
            // comboParkYeri
            // 
            comboParkYeri.FormattingEnabled = true;
            comboParkYeri.Location = new Point(127, 270);
            comboParkYeri.Name = "comboParkYeri";
            comboParkYeri.Size = new Size(120, 23);
            comboParkYeri.TabIndex = 9;
            comboParkYeri.SelectedIndexChanged += comboParkYeri_SelectedIndexChanged;
            // 
            // grupKişi
            // 
            grupKişi.Controls.Add(label5);
            grupKişi.Controls.Add(label4);
            grupKişi.Controls.Add(label3);
            grupKişi.Controls.Add(label2);
            grupKişi.Controls.Add(label1);
            grupKişi.Controls.Add(txtTc);
            grupKişi.Controls.Add(txtSoyad);
            grupKişi.Controls.Add(txtAd);
            grupKişi.Controls.Add(txtTelefon);
            grupKişi.Controls.Add(txtEmail);
            grupKişi.Location = new Point(78, 54);
            grupKişi.Name = "grupKişi";
            grupKişi.Size = new Size(305, 407);
            grupKişi.TabIndex = 10;
            grupKişi.TabStop = false;
            grupKişi.Text = "Kişi Bilgileri";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(58, 246);
            label5.Name = "label5";
            label5.Size = new Size(46, 15);
            label5.TabIndex = 9;
            label5.Text = "E-MAIL";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(49, 208);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 8;
            label4.Text = "TELEFON";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(60, 170);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 7;
            label3.Text = "SOYAD";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(81, 132);
            label2.Name = "label2";
            label2.Size = new Size(23, 15);
            label2.TabIndex = 6;
            label2.Text = "AD";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(84, 94);
            label1.Name = "label1";
            label1.Size = new Size(20, 15);
            label1.TabIndex = 5;
            label1.Text = "TC";
            // 
            // grupAraç
            // 
            grupAraç.Controls.Add(btnSeri);
            grupAraç.Controls.Add(btnMarka);
            grupAraç.Controls.Add(label7);
            grupAraç.Controls.Add(label8);
            grupAraç.Controls.Add(label9);
            grupAraç.Controls.Add(label10);
            grupAraç.Controls.Add(txtPlaka);
            grupAraç.Controls.Add(txtRenk);
            grupAraç.Controls.Add(comboParkYeri);
            grupAraç.Controls.Add(comboMarka);
            grupAraç.Controls.Add(label6);
            grupAraç.Controls.Add(comboSeri);
            grupAraç.Location = new Point(389, 54);
            grupAraç.Name = "grupAraç";
            grupAraç.Size = new Size(305, 407);
            grupAraç.TabIndex = 11;
            grupAraç.TabStop = false;
            grupAraç.Text = "Araç Bilgileri";
            grupAraç.Enter += grupAraç_Enter;
            // 
            // btnSeri
            // 
            btnSeri.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnSeri.Location = new Point(253, 183);
            btnSeri.Name = "btnSeri";
            btnSeri.Size = new Size(28, 23);
            btnSeri.TabIndex = 18;
            btnSeri.Text = "+";
            btnSeri.UseVisualStyleBackColor = true;
            btnSeri.Click += btnSeri_Click;
            // 
            // btnMarka
            // 
            btnMarka.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnMarka.Location = new Point(253, 138);
            btnMarka.Name = "btnMarka";
            btnMarka.Size = new Size(28, 23);
            btnMarka.TabIndex = 17;
            btnMarka.Text = "+";
            btnMarka.UseVisualStyleBackColor = true;
            btnMarka.Click += btnMarka_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(36, 146);
            label7.Name = "label7";
            label7.Size = new Size(48, 15);
            label7.TabIndex = 13;
            label7.Text = "MARKA";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(55, 190);
            label8.Name = "label8";
            label8.Size = new Size(29, 15);
            label8.TabIndex = 14;
            label8.Text = "SERİ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(48, 229);
            label9.Name = "label9";
            label9.Size = new Size(36, 15);
            label9.TabIndex = 15;
            label9.Text = "RENK";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(23, 278);
            label10.Name = "label10";
            label10.Size = new Size(61, 15);
            label10.TabIndex = 16;
            label10.Text = "PARK YERİ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(41, 97);
            label6.Name = "label6";
            label6.Size = new Size(43, 15);
            label6.TabIndex = 12;
            label6.Text = "PLAKA";
            // 
            // button1
            // 
            button1.Location = new Point(352, 495);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 12;
            button1.Text = "KAYIT";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(697, 546);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 13;
            button2.Text = "İPTAL";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // frmAraçOtoparkKaydı
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Olive;
            ClientSize = new Size(784, 581);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(grupAraç);
            Controls.Add(grupKişi);
            Name = "frmAraçOtoparkKaydı";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Araç Otopark Kaydı";
            Load += frmAraçOtoparkKaydı_Load;
            grupKişi.ResumeLayout(false);
            grupKişi.PerformLayout();
            grupAraç.ResumeLayout(false);
            grupAraç.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtTc;
        private TextBox txtSoyad;
        private TextBox txtAd;
        private TextBox txtTelefon;
        private TextBox txtEmail;
        private TextBox txtPlaka;
        private TextBox txtRenk;
        private ComboBox comboMarka;
        private ComboBox comboSeri;
        private ComboBox comboParkYeri;
        private GroupBox grupKişi;
        private GroupBox grupAraç;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label6;
        private Button button1;
        private Button button2;
        private Button btnMarka;
        private Button btnSeri;
    }
}