namespace PresentationLayer
{
    partial class KullaniciEklemeİşlemleri
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
            txtAdSoyad = new TextBox();
            txtYas = new TextBox();
            btnEkle = new Button();
            txtTel = new TextBox();
            txtAdres = new TextBox();
            txtMail = new TextBox();
            txtOkuKitapSayi = new TextBox();
            comboCinsiyet = new ComboBox();
            btnİptal = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            SuspendLayout();
            // 
            // txtTc
            // 
            txtTc.Location = new Point(108, 38);
            txtTc.Name = "txtTc";
            txtTc.Size = new Size(105, 23);
            txtTc.TabIndex = 0;
            // 
            // txtAdSoyad
            // 
            txtAdSoyad.Location = new Point(108, 67);
            txtAdSoyad.Name = "txtAdSoyad";
            txtAdSoyad.Size = new Size(105, 23);
            txtAdSoyad.TabIndex = 1;
            // 
            // txtYas
            // 
            txtYas.Location = new Point(108, 96);
            txtYas.Name = "txtYas";
            txtYas.Size = new Size(105, 23);
            txtYas.TabIndex = 2;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(74, 270);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(75, 41);
            btnEkle.TabIndex = 3;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += button1_Click;
            // 
            // txtTel
            // 
            txtTel.Location = new Point(108, 154);
            txtTel.Name = "txtTel";
            txtTel.Size = new Size(105, 23);
            txtTel.TabIndex = 4;
            // 
            // txtAdres
            // 
            txtAdres.Location = new Point(108, 183);
            txtAdres.Name = "txtAdres";
            txtAdres.Size = new Size(105, 23);
            txtAdres.TabIndex = 5;
            // 
            // txtMail
            // 
            txtMail.Location = new Point(108, 212);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(105, 23);
            txtMail.TabIndex = 6;
            // 
            // txtOkuKitapSayi
            // 
            txtOkuKitapSayi.Location = new Point(108, 241);
            txtOkuKitapSayi.Name = "txtOkuKitapSayi";
            txtOkuKitapSayi.Size = new Size(105, 23);
            txtOkuKitapSayi.TabIndex = 7;
            // 
            // comboCinsiyet
            // 
            comboCinsiyet.FormattingEnabled = true;
            comboCinsiyet.Items.AddRange(new object[] { "Kadın ", "Erkek" });
            comboCinsiyet.Location = new Point(108, 125);
            comboCinsiyet.Name = "comboCinsiyet";
            comboCinsiyet.Size = new Size(119, 23);
            comboCinsiyet.TabIndex = 8;
            // 
            // btnİptal
            // 
            btnİptal.Location = new Point(155, 270);
            btnİptal.Name = "btnİptal";
            btnİptal.Size = new Size(75, 41);
            btnİptal.TabIndex = 9;
            btnİptal.Text = "İptal";
            btnİptal.UseVisualStyleBackColor = true;
            btnİptal.Click += btnİptal_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(82, 41);
            label1.Name = "label1";
            label1.Size = new Size(20, 15);
            label1.TabIndex = 10;
            label1.Text = "TC";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 69);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 11;
            label2.Text = "Ad Soyad";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(78, 98);
            label3.Name = "label3";
            label3.Size = new Size(24, 15);
            label3.TabIndex = 12;
            label3.Text = "Yaş";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(53, 127);
            label4.Name = "label4";
            label4.Size = new Size(49, 15);
            label4.TabIndex = 13;
            label4.Text = "Cinsiyet";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(57, 162);
            label5.Name = "label5";
            label5.Size = new Size(45, 15);
            label5.TabIndex = 14;
            label5.Text = "Telefon";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(65, 191);
            label6.Name = "label6";
            label6.Size = new Size(37, 15);
            label6.TabIndex = 15;
            label6.Text = "Adres";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(66, 220);
            label7.Name = "label7";
            label7.Size = new Size(36, 15);
            label7.TabIndex = 16;
            label7.Text = "Email";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(8, 241);
            label8.Name = "label8";
            label8.Size = new Size(94, 15);
            label8.TabIndex = 17;
            label8.Text = "Oku. Kitap Sayısı";
            // 
            // KullaniciEklemeİşlemleri
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(282, 348);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnİptal);
            Controls.Add(comboCinsiyet);
            Controls.Add(txtOkuKitapSayi);
            Controls.Add(txtMail);
            Controls.Add(txtAdres);
            Controls.Add(txtTel);
            Controls.Add(btnEkle);
            Controls.Add(txtYas);
            Controls.Add(txtAdSoyad);
            Controls.Add(txtTc);
            Name = "KullaniciEklemeİşlemleri";
            Text = "KullaniciEklemeFormu";
            Load += KullaniciEklemeFormu_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTc;
        private TextBox txtAdSoyad;
        private TextBox txtYas;
        private Button btnEkle;
        private TextBox txtTel;
        private TextBox txtAdres;
        private TextBox txtMail;
        private TextBox txtOkuKitapSayi;
        private ComboBox comboCinsiyet;
        private Button btnİptal;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
    }
}