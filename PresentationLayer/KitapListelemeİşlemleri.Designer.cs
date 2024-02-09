namespace PresentationLayer
{
    partial class KitapListelemeİşlemleri
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
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnİptal = new Button();
            btnGuncelle = new Button();
            txtAciklama = new TextBox();
            txtRafNo = new TextBox();
            txtStokSayisi = new TextBox();
            comboTuru = new ComboBox();
            txtSayfaSayisi = new TextBox();
            txtYayinevi = new TextBox();
            txtYazarAdi = new TextBox();
            txtKitapAdı = new TextBox();
            txtBarkodNo = new TextBox();
            dataGridView1 = new DataGridView();
            txtBarkodNoAra = new TextBox();
            btnSil = new Button();
            label10 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(26, 275);
            label9.Name = "label9";
            label9.Size = new Size(56, 15);
            label9.TabIndex = 39;
            label9.Text = "Açıklama";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(39, 243);
            label8.Name = "label8";
            label8.Size = new Size(43, 15);
            label8.TabIndex = 38;
            label8.Text = "Raf No";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(20, 213);
            label7.Name = "label7";
            label7.Size = new Size(62, 15);
            label7.TabIndex = 37;
            label7.Text = "Stok Sayısı";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(51, 181);
            label6.Name = "label6";
            label6.Size = new Size(31, 15);
            label6.TabIndex = 36;
            label6.Text = "Türü";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 149);
            label5.Name = "label5";
            label5.Size = new Size(67, 15);
            label5.TabIndex = 35;
            label5.Text = "Sayfa Sayısı";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(32, 126);
            label4.Name = "label4";
            label4.Size = new Size(50, 15);
            label4.TabIndex = 34;
            label4.Text = "Yayınevi";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 94);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 33;
            label3.Text = "Yazar Adı";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 58);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 32;
            label2.Text = "Kitap Adı";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 24);
            label1.Name = "label1";
            label1.Size = new Size(76, 15);
            label1.TabIndex = 31;
            label1.Text = "K. Barkod No";
            // 
            // btnİptal
            // 
            btnİptal.Location = new Point(133, 311);
            btnİptal.Name = "btnİptal";
            btnİptal.Size = new Size(75, 58);
            btnİptal.TabIndex = 30;
            btnİptal.Text = "İptal";
            btnİptal.UseVisualStyleBackColor = true;
            btnİptal.Click += btnİptal_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(38, 311);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(75, 58);
            btnGuncelle.TabIndex = 29;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // txtAciklama
            // 
            txtAciklama.Location = new Point(87, 282);
            txtAciklama.Name = "txtAciklama";
            txtAciklama.Size = new Size(100, 23);
            txtAciklama.TabIndex = 28;
            // 
            // txtRafNo
            // 
            txtRafNo.Location = new Point(87, 244);
            txtRafNo.Name = "txtRafNo";
            txtRafNo.Size = new Size(100, 23);
            txtRafNo.TabIndex = 27;
            // 
            // txtStokSayisi
            // 
            txtStokSayisi.Location = new Point(87, 214);
            txtStokSayisi.Name = "txtStokSayisi";
            txtStokSayisi.Size = new Size(100, 23);
            txtStokSayisi.TabIndex = 26;
            // 
            // comboTuru
            // 
            comboTuru.FormattingEnabled = true;
            comboTuru.Items.AddRange(new object[] { "Roman", "Hikaye", "Masal", "Şiir", "Çocuk Kitapları" });
            comboTuru.Location = new Point(87, 185);
            comboTuru.Name = "comboTuru";
            comboTuru.Size = new Size(121, 23);
            comboTuru.TabIndex = 25;
            // 
            // txtSayfaSayisi
            // 
            txtSayfaSayisi.Location = new Point(87, 154);
            txtSayfaSayisi.Name = "txtSayfaSayisi";
            txtSayfaSayisi.Size = new Size(100, 23);
            txtSayfaSayisi.TabIndex = 24;
            // 
            // txtYayinevi
            // 
            txtYayinevi.Location = new Point(87, 124);
            txtYayinevi.Name = "txtYayinevi";
            txtYayinevi.Size = new Size(100, 23);
            txtYayinevi.TabIndex = 23;
            // 
            // txtYazarAdi
            // 
            txtYazarAdi.Location = new Point(87, 95);
            txtYazarAdi.Name = "txtYazarAdi";
            txtYazarAdi.Size = new Size(100, 23);
            txtYazarAdi.TabIndex = 22;
            // 
            // txtKitapAdı
            // 
            txtKitapAdı.Location = new Point(87, 56);
            txtKitapAdı.Name = "txtKitapAdı";
            txtKitapAdı.Size = new Size(100, 23);
            txtKitapAdı.TabIndex = 21;
            // 
            // txtBarkodNo
            // 
            txtBarkodNo.Location = new Point(87, 22);
            txtBarkodNo.Name = "txtBarkodNo";
            txtBarkodNo.Size = new Size(100, 23);
            txtBarkodNo.TabIndex = 20;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonFace;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(216, 78);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(575, 200);
            dataGridView1.TabIndex = 40;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // txtBarkodNoAra
            // 
            txtBarkodNoAra.Location = new Point(628, 46);
            txtBarkodNoAra.Name = "txtBarkodNoAra";
            txtBarkodNoAra.Size = new Size(100, 23);
            txtBarkodNoAra.TabIndex = 41;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(716, 284);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(75, 38);
            btnSil.TabIndex = 43;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(526, 49);
            label10.Name = "label10";
            label10.Size = new Size(96, 15);
            label10.TabIndex = 44;
            label10.Text = "k. Barkod No Ara";
            // 
            // KitapListelemeİşlemleri
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(803, 386);
            Controls.Add(label10);
            Controls.Add(btnSil);
            Controls.Add(txtBarkodNoAra);
            Controls.Add(dataGridView1);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnİptal);
            Controls.Add(btnGuncelle);
            Controls.Add(txtAciklama);
            Controls.Add(txtRafNo);
            Controls.Add(txtStokSayisi);
            Controls.Add(comboTuru);
            Controls.Add(txtSayfaSayisi);
            Controls.Add(txtYayinevi);
            Controls.Add(txtYazarAdi);
            Controls.Add(txtKitapAdı);
            Controls.Add(txtBarkodNo);
            Name = "KitapListelemeİşlemleri";
            Text = "KitapGuncellemeFormu";
            Load += KitapGuncellemeFormu_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnİptal;
        private Button btnGuncelle;
        private TextBox txtAciklama;
        private TextBox txtRafNo;
        private TextBox txtStokSayisi;
        private ComboBox comboTuru;
        private TextBox txtSayfaSayisi;
        private TextBox txtYayinevi;
        private TextBox txtYazarAdi;
        private TextBox txtKitapAdı;
        private TextBox txtBarkodNo;
        private DataGridView dataGridView1;
        private TextBox txtBarkodNoAra;
        private Button btnSil;
        private Label label10;
    }
}