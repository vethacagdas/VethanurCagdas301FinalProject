namespace VethanurÇağdaş_MertKaanArslan_Cet301
{
    partial class frmSeri
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
            button1 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            comboBox1 = new ComboBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(150, 161);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 5;
            button1.Text = "Ekle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(113, 77);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(164, 23);
            textBox1.TabIndex = 4;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(67, 56);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 3;
            label1.Text = "Marka";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(113, 48);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(164, 23);
            comboBox1.TabIndex = 6;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(81, 80);
            label2.Name = "label2";
            label2.Size = new Size(26, 15);
            label2.TabIndex = 7;
            label2.Text = "Seri";
            label2.Click += label2_Click;
            // 
            // frmSeri
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(378, 196);
            Controls.Add(label2);
            Controls.Add(comboBox1);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "frmSeri";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmSeri";
            Load += frmSeri_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private Label label1;
        private ComboBox comboBox1;
        private Label label2;
    }
}