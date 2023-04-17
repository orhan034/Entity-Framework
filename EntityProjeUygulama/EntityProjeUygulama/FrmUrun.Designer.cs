namespace EntityProjeUygulama
{
    partial class FrmUrun
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMarka = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtStok = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDurum = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnLitsele = new System.Windows.Forms.Button();
            this.bntekle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnguncelle = new System.Windows.Forms.Button();
            this.btntemizle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cmbkategori = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(199, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(241, 41);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(175, 30);
            this.txtid.TabIndex = 1;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(241, 91);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(175, 30);
            this.txtAd.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(136, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ürün Adı:";
            // 
            // txtMarka
            // 
            this.txtMarka.Location = new System.Drawing.Point(241, 138);
            this.txtMarka.Name = "txtMarka";
            this.txtMarka.Size = new System.Drawing.Size(175, 30);
            this.txtMarka.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(160, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Marka:";
            // 
            // txtStok
            // 
            this.txtStok.Location = new System.Drawing.Point(241, 186);
            this.txtStok.Name = "txtStok";
            this.txtStok.Size = new System.Drawing.Size(175, 30);
            this.txtStok.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(176, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Stok:";
            // 
            // txtFiyat
            // 
            this.txtFiyat.Location = new System.Drawing.Point(241, 234);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(175, 30);
            this.txtFiyat.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(176, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Fiyat:";
            // 
            // txtDurum
            // 
            this.txtDurum.Location = new System.Drawing.Point(241, 283);
            this.txtDurum.Name = "txtDurum";
            this.txtDurum.Size = new System.Drawing.Size(175, 30);
            this.txtDurum.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(157, 286);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "Durum:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(142, 337);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 25);
            this.label7.TabIndex = 12;
            this.label7.Text = "Kategori:";
            // 
            // btnLitsele
            // 
            this.btnLitsele.Location = new System.Drawing.Point(527, 29);
            this.btnLitsele.Name = "btnLitsele";
            this.btnLitsele.Size = new System.Drawing.Size(205, 55);
            this.btnLitsele.TabIndex = 14;
            this.btnLitsele.Text = "Listele";
            this.btnLitsele.UseVisualStyleBackColor = true;
            this.btnLitsele.Click += new System.EventHandler(this.btnLitsele_Click);
            // 
            // bntekle
            // 
            this.bntekle.Location = new System.Drawing.Point(527, 91);
            this.bntekle.Name = "bntekle";
            this.bntekle.Size = new System.Drawing.Size(205, 55);
            this.bntekle.TabIndex = 15;
            this.bntekle.Text = "Ekle";
            this.bntekle.UseVisualStyleBackColor = true;
            this.bntekle.Click += new System.EventHandler(this.bntekle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(527, 161);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(205, 55);
            this.btnSil.TabIndex = 16;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnguncelle
            // 
            this.btnguncelle.Location = new System.Drawing.Point(527, 234);
            this.btnguncelle.Name = "btnguncelle";
            this.btnguncelle.Size = new System.Drawing.Size(205, 55);
            this.btnguncelle.TabIndex = 17;
            this.btnguncelle.Text = "Güncelle";
            this.btnguncelle.UseVisualStyleBackColor = true;
            this.btnguncelle.Click += new System.EventHandler(this.btnguncelle_Click);
            // 
            // btntemizle
            // 
            this.btntemizle.Location = new System.Drawing.Point(527, 307);
            this.btntemizle.Name = "btntemizle";
            this.btntemizle.Size = new System.Drawing.Size(205, 55);
            this.btntemizle.TabIndex = 18;
            this.btntemizle.Text = "Temizle";
            this.btntemizle.UseVisualStyleBackColor = true;
            this.btntemizle.Click += new System.EventHandler(this.button5_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 404);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(902, 267);
            this.dataGridView1.TabIndex = 19;
            // 
            // cmbkategori
            // 
            this.cmbkategori.FormattingEnabled = true;
            this.cmbkategori.Location = new System.Drawing.Point(241, 334);
            this.cmbkategori.Name = "cmbkategori";
            this.cmbkategori.Size = new System.Drawing.Size(175, 33);
            this.cmbkategori.TabIndex = 20;
            // 
            // FrmUrun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 683);
            this.Controls.Add(this.cmbkategori);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btntemizle);
            this.Controls.Add(this.btnguncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.bntekle);
            this.Controls.Add(this.btnLitsele);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtDurum);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtFiyat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtStok);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMarka);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "FrmUrun";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmUrun";
            this.Load += new System.EventHandler(this.FrmUrun_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMarka;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtStok;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFiyat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDurum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnLitsele;
        private System.Windows.Forms.Button bntekle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnguncelle;
        private System.Windows.Forms.Button btntemizle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cmbkategori;
    }
}