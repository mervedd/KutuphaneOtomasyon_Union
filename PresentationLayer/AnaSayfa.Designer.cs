namespace PresentationLayer
{
    partial class AnaSayfa
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
            groupBox1 = new GroupBox();
            btnKullaniciListele = new Button();
            btnKullaniciEkle = new Button();
            groupBox2 = new GroupBox();
            button4 = new Button();
            button3 = new Button();
            groupBox3 = new GroupBox();
            btnEmanetVerme = new Button();
            groupBox4 = new GroupBox();
            btnSıralama = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnKullaniciListele);
            groupBox1.Controls.Add(btnKullaniciEkle);
            groupBox1.Location = new Point(27, 22);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(211, 100);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Kullanıcı İşlemleri";
            // 
            // btnKullaniciListele
            // 
            btnKullaniciListele.Location = new Point(19, 56);
            btnKullaniciListele.Name = "btnKullaniciListele";
            btnKullaniciListele.Size = new Size(175, 32);
            btnKullaniciListele.TabIndex = 1;
            btnKullaniciListele.Text = "Kullanıcı Listeleme İşlemleri";
            btnKullaniciListele.UseVisualStyleBackColor = true;
            btnKullaniciListele.Click += btnKullaniciListele_Click;
            // 
            // btnKullaniciEkle
            // 
            btnKullaniciEkle.Location = new Point(20, 23);
            btnKullaniciEkle.Name = "btnKullaniciEkle";
            btnKullaniciEkle.Size = new Size(174, 31);
            btnKullaniciEkle.TabIndex = 0;
            btnKullaniciEkle.Text = "Kullanıcı Ekleme İşlemleri";
            btnKullaniciEkle.UseVisualStyleBackColor = true;
            btnKullaniciEkle.Click += button1_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button4);
            groupBox2.Controls.Add(button3);
            groupBox2.Location = new Point(253, 22);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(200, 100);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Kitap İşlemleri";
            // 
            // button4
            // 
            button4.Location = new Point(18, 54);
            button4.Name = "button4";
            button4.Size = new Size(163, 32);
            button4.TabIndex = 1;
            button4.Text = "Kitap Listeleme İşlemleri";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(18, 20);
            button3.Name = "button3";
            button3.Size = new Size(163, 28);
            button3.TabIndex = 0;
            button3.Text = "Kitap Ekleme İşlemleri";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnEmanetVerme);
            groupBox3.Location = new Point(29, 144);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(209, 111);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Emanet Kitap İşlemleri";
            // 
            // btnEmanetVerme
            // 
            btnEmanetVerme.Location = new Point(18, 22);
            btnEmanetVerme.Name = "btnEmanetVerme";
            btnEmanetVerme.Size = new Size(174, 72);
            btnEmanetVerme.TabIndex = 2;
            btnEmanetVerme.Text = "Emanet Kitap Verme İşlemleri";
            btnEmanetVerme.UseVisualStyleBackColor = true;
            btnEmanetVerme.Click += btnEmanetVerme_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(btnSıralama);
            groupBox4.Location = new Point(253, 144);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(200, 111);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "Sıralama İşlemleri";
            // 
            // btnSıralama
            // 
            btnSıralama.Location = new Point(18, 22);
            btnSıralama.Name = "btnSıralama";
            btnSıralama.Size = new Size(163, 72);
            btnSıralama.TabIndex = 0;
            btnSıralama.Text = "Rapor";
            btnSıralama.UseVisualStyleBackColor = true;
            btnSıralama.Click += btnSıralama_Click;
            // 
            // AnaSayfa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(476, 283);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "AnaSayfa";
            Text = "AnaSayfa";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnKullaniciListele;
        private Button btnKullaniciEkle;
        private GroupBox groupBox2;
        private Button button3;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private Button button4;
        private Button btnEmanetVerme;
        private Button btnSıralama;
    }
}