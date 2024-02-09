namespace PresentationLayer
{
    partial class Rapor
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
            dataGridView1 = new DataGridView();
            btnEmanette = new Button();
            btnBosta = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 84);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(611, 200);
            dataGridView1.TabIndex = 0;
            // 
            // btnEmanette
            // 
            btnEmanette.Location = new Point(25, 31);
            btnEmanette.Name = "btnEmanette";
            btnEmanette.Size = new Size(296, 47);
            btnEmanette.TabIndex = 1;
            btnEmanette.Text = "Teslim Alınan Kitaplar";
            btnEmanette.UseVisualStyleBackColor = true;
            btnEmanette.Click += btnEmanette_Click;
            // 
            // btnBosta
            // 
            btnBosta.Location = new Point(327, 31);
            btnBosta.Name = "btnBosta";
            btnBosta.Size = new Size(280, 47);
            btnBosta.TabIndex = 1;
            btnBosta.Text = "Mevcut Kitaplar";
            btnBosta.UseVisualStyleBackColor = true;
            btnBosta.Click += btnBosta_Click;
            // 
            // Rapor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(635, 298);
            Controls.Add(btnBosta);
            Controls.Add(btnEmanette);
            Controls.Add(dataGridView1);
            Name = "Rapor";
            Text = "Sıralama";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnEmanette;
        private Button btnBosta;
    }
}