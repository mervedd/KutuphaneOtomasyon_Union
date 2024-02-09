namespace PresentationLayer
{
    partial class KitapEklemeİşlemleri
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
            txtBarkodNo = new TextBox();
            txtKitapAdı = new TextBox();
            txtYazarAdi = new TextBox();
            txtYayinevi = new TextBox();
            txtSayfaSayisi = new TextBox();
            comboTuru = new ComboBox();
            txtStokSayisi = new TextBox();
            txtRafNo = new TextBox();
            txtAciklama = new TextBox();
            btnEkle = new Button();
            btnSil = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            SuspendLayout();
            // 
            // txtBarkodNo
            // 
            txtBarkodNo.Location = new Point(119, 28);
            txtBarkodNo.Name = "txtBarkodNo";
            txtBarkodNo.Size = new Size(100, 23);
            txtBarkodNo.TabIndex = 0;
            // 
            // txtKitapAdı
            // 
            txtKitapAdı.Location = new Point(119, 62);
            txtKitapAdı.Name = "txtKitapAdı";
            txtKitapAdı.Size = new Size(100, 23);
            txtKitapAdı.TabIndex = 1;
            // 
            // txtYazarAdi
            // 
            txtYazarAdi.Location = new Point(119, 101);
            txtYazarAdi.Name = "txtYazarAdi";
            txtYazarAdi.Size = new Size(100, 23);
            txtYazarAdi.TabIndex = 2;
            // 
            // txtYayinevi
            // 
            txtYayinevi.Location = new Point(119, 130);
            txtYayinevi.Name = "txtYayinevi";
            txtYayinevi.Size = new Size(100, 23);
            txtYayinevi.TabIndex = 3;
            // 
            // txtSayfaSayisi
            // 
            txtSayfaSayisi.Location = new Point(119, 160);
            txtSayfaSayisi.Name = "txtSayfaSayisi";
            txtSayfaSayisi.Size = new Size(100, 23);
            txtSayfaSayisi.TabIndex = 4;
            // 
            // comboTuru
            // 
            comboTuru.FormattingEnabled = true;
            comboTuru.Items.AddRange(new object[] { "Roman", "Hikaye", "Masal", "Şiir", "Çocuk Kitapları" });
            comboTuru.Location = new Point(119, 191);
            comboTuru.Name = "comboTuru";
            comboTuru.Size = new Size(121, 23);
            comboTuru.TabIndex = 5;
            // 
            // txtStokSayisi
            // 
            txtStokSayisi.Location = new Point(119, 220);
            txtStokSayisi.Name = "txtStokSayisi";
            txtStokSayisi.Size = new Size(100, 23);
            txtStokSayisi.TabIndex = 6;
            // 
            // txtRafNo
            // 
            txtRafNo.Location = new Point(119, 250);
            txtRafNo.Name = "txtRafNo";
            txtRafNo.Size = new Size(100, 23);
            txtRafNo.TabIndex = 7;
            // 
            // txtAciklama
            // 
            txtAciklama.Location = new Point(119, 288);
            txtAciklama.Name = "txtAciklama";
            txtAciklama.Size = new Size(100, 23);
            txtAciklama.TabIndex = 8;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(70, 317);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(75, 58);
            btnEkle.TabIndex = 9;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(165, 317);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(75, 58);
            btnSil.TabIndex = 10;
            btnSil.Text = "İptal";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 30);
            label1.Name = "label1";
            label1.Size = new Size(76, 15);
            label1.TabIndex = 11;
            label1.Text = "K. Barkod No";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(59, 64);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 12;
            label2.Text = "Kitap Adı";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(59, 100);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 13;
            label3.Text = "Yazar Adı";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(64, 132);
            label4.Name = "label4";
            label4.Size = new Size(50, 15);
            label4.TabIndex = 14;
            label4.Text = "Yayınevi";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(47, 155);
            label5.Name = "label5";
            label5.Size = new Size(67, 15);
            label5.TabIndex = 15;
            label5.Text = "Sayfa Sayısı";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(83, 187);
            label6.Name = "label6";
            label6.Size = new Size(31, 15);
            label6.TabIndex = 16;
            label6.Text = "Türü";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(52, 219);
            label7.Name = "label7";
            label7.Size = new Size(62, 15);
            label7.TabIndex = 17;
            label7.Text = "Stok Sayısı";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(71, 249);
            label8.Name = "label8";
            label8.Size = new Size(43, 15);
            label8.TabIndex = 18;
            label8.Text = "Raf No";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(58, 281);
            label9.Name = "label9";
            label9.Size = new Size(56, 15);
            label9.TabIndex = 19;
            label9.Text = "Açıklama";
            // 
            // KitapEklemeFormu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(335, 400);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSil);
            Controls.Add(btnEkle);
            Controls.Add(txtAciklama);
            Controls.Add(txtRafNo);
            Controls.Add(txtStokSayisi);
            Controls.Add(comboTuru);
            Controls.Add(txtSayfaSayisi);
            Controls.Add(txtYayinevi);
            Controls.Add(txtYazarAdi);
            Controls.Add(txtKitapAdı);
            Controls.Add(txtBarkodNo);
            Name = "KitapEklemeFormu";
            Text = "KitapEklemeFormu";
            Load += KitapEklemeFormu_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBarkodNo;
        private TextBox txtKitapAdı;
        private TextBox txtYazarAdi;
        private TextBox txtYayinevi;
        private TextBox txtSayfaSayisi;
        private ComboBox comboTuru;
        private TextBox txtStokSayisi;
        private TextBox txtRafNo;
        private TextBox txtAciklama;
        private Button btnEkle;
        private Button btnSil;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
    }
}