namespace VethanurÇağdaş_MertKaanArslan_Cet301
{
    partial class Anasayfa
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(77, 88);
            button1.Name = "button1";
            button1.Size = new Size(165, 23);
            button1.TabIndex = 0;
            button1.Text = "Araç Otopark Kaydı Sayfası";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(77, 124);
            button2.Name = "button2";
            button2.Size = new Size(165, 23);
            button2.TabIndex = 1;
            button2.Text = "Araç Otopark Yerleri";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(77, 160);
            button3.Name = "button3";
            button3.Size = new Size(165, 23);
            button3.TabIndex = 2;
            button3.Text = "Araç Otopark Çıkış Sayfası";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Red;
            button4.Location = new Point(122, 258);
            button4.Name = "button4";
            button4.Size = new Size(75, 32);
            button4.TabIndex = 3;
            button4.Text = "Çıkış";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(77, 196);
            button5.Name = "button5";
            button5.Size = new Size(165, 23);
            button5.TabIndex = 4;
            button5.Text = "Satış Raporları Sayfası";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.LightCoral;
            label1.Font = new Font("Arial Rounded MT Bold", 25.25F);
            label1.Location = new Point(40, 20);
            label1.Name = "label1";
            label1.Size = new Size(252, 39);
            label1.TabIndex = 5;
            label1.Text = "OTOPARKING";
            // 
            // Anasayfa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Firebrick;
            ClientSize = new Size(314, 302);
            Controls.Add(label1);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Anasayfa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "OtoparkOtomasyonuAnasayfa";
            Load += Anasayfa_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Label label1;
    }
}
