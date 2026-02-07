namespace IngilizceKodSozlugu
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtKelimeAra = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtAnlam = new System.Windows.Forms.TextBox();
            this.btnKelimeSil = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnKelimleriGuncelle = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnKelimeKaydet = new System.Windows.Forms.Button();
            this.txtKelime = new System.Windows.Forms.TextBox();
            this.txtKullanim = new System.Windows.Forms.TextBox();
            this.dgvKelimeler = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtKodAra = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.btnKodSil = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnKodGuncelle = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtKodAdi = new System.Windows.Forms.TextBox();
            this.btnKodKaydet = new System.Windows.Forms.Button();
            this.txtKodAciklama = new System.Windows.Forms.TextBox();
            this.txtOrnekKod = new System.Windows.Forms.TextBox();
            this.dgvKodlar = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKelimeler)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKodlar)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Linen;
            this.tabPage1.Controls.Add(this.txtKelimeAra);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.dgvKelimeler);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 421);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "İngilizce Kelimeler";
            // 
            // txtKelimeAra
            // 
            this.txtKelimeAra.Location = new System.Drawing.Point(351, 6);
            this.txtKelimeAra.Name = "txtKelimeAra";
            this.txtKelimeAra.Size = new System.Drawing.Size(155, 22);
            this.txtKelimeAra.TabIndex = 11;
            this.txtKelimeAra.TextChanged += new System.EventHandler(this.txtKelimeAra_TextChanged);
            this.txtKelimeAra.Enter += new System.EventHandler(this.txtKelimeAra_Enter);
            this.txtKelimeAra.Leave += new System.EventHandler(this.txtKelimeAra_Leave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PapayaWhip;
            this.panel2.Controls.Add(this.txtAnlam);
            this.panel2.Controls.Add(this.btnKelimeSil);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnKelimleriGuncelle);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.btnKelimeKaydet);
            this.panel2.Controls.Add(this.txtKelime);
            this.panel2.Controls.Add(this.txtKullanim);
            this.panel2.Location = new System.Drawing.Point(8, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(337, 132);
            this.panel2.TabIndex = 10;
            // 
            // txtAnlam
            // 
            this.txtAnlam.Location = new System.Drawing.Point(118, 53);
            this.txtAnlam.Name = "txtAnlam";
            this.txtAnlam.Size = new System.Drawing.Size(100, 22);
            this.txtAnlam.TabIndex = 4;
            // 
            // btnKelimeSil
            // 
            this.btnKelimeSil.Location = new System.Drawing.Point(234, 86);
            this.btnKelimeSil.Name = "btnKelimeSil";
            this.btnKelimeSil.Size = new System.Drawing.Size(91, 37);
            this.btnKelimeSil.TabIndex = 9;
            this.btnKelimeSil.Text = "Sil";
            this.btnKelimeSil.UseVisualStyleBackColor = true;
            this.btnKelimeSil.Click += new System.EventHandler(this.btnKelimeSil_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kelime:";
            // 
            // btnKelimleriGuncelle
            // 
            this.btnKelimleriGuncelle.Location = new System.Drawing.Point(234, 46);
            this.btnKelimleriGuncelle.Name = "btnKelimleriGuncelle";
            this.btnKelimleriGuncelle.Size = new System.Drawing.Size(91, 37);
            this.btnKelimleriGuncelle.TabIndex = 8;
            this.btnKelimleriGuncelle.Text = "Güncelle";
            this.btnKelimleriGuncelle.UseVisualStyleBackColor = true;
            this.btnKelimleriGuncelle.Click += new System.EventHandler(this.btnKelimleriGuncelle_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Anlamı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kullanım Alanı:";
            // 
            // btnKelimeKaydet
            // 
            this.btnKelimeKaydet.Location = new System.Drawing.Point(234, 7);
            this.btnKelimeKaydet.Name = "btnKelimeKaydet";
            this.btnKelimeKaydet.Size = new System.Drawing.Size(91, 37);
            this.btnKelimeKaydet.TabIndex = 6;
            this.btnKelimeKaydet.Text = "Kaydet";
            this.btnKelimeKaydet.UseVisualStyleBackColor = true;
            this.btnKelimeKaydet.Click += new System.EventHandler(this.btnKelimeKaydet_Click);
            // 
            // txtKelime
            // 
            this.txtKelime.Location = new System.Drawing.Point(119, 14);
            this.txtKelime.Name = "txtKelime";
            this.txtKelime.Size = new System.Drawing.Size(100, 22);
            this.txtKelime.TabIndex = 3;
            // 
            // txtKullanim
            // 
            this.txtKullanim.Location = new System.Drawing.Point(119, 93);
            this.txtKullanim.Multiline = true;
            this.txtKullanim.Name = "txtKullanim";
            this.txtKullanim.Size = new System.Drawing.Size(100, 22);
            this.txtKullanim.TabIndex = 5;
            // 
            // dgvKelimeler
            // 
            this.dgvKelimeler.BackgroundColor = System.Drawing.Color.Wheat;
            this.dgvKelimeler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKelimeler.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvKelimeler.Location = new System.Drawing.Point(3, 157);
            this.dgvKelimeler.Name = "dgvKelimeler";
            this.dgvKelimeler.RowHeadersWidth = 51;
            this.dgvKelimeler.RowTemplate.Height = 24;
            this.dgvKelimeler.Size = new System.Drawing.Size(786, 261);
            this.dgvKelimeler.TabIndex = 7;
            this.dgvKelimeler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKelimeler_CellClick);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Azure;
            this.tabPage2.Controls.Add(this.txtKodAra);
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Controls.Add(this.dgvKodlar);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 421);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Kod Terimleri";
            // 
            // txtKodAra
            // 
            this.txtKodAra.Location = new System.Drawing.Point(348, 6);
            this.txtKodAra.Name = "txtKodAra";
            this.txtKodAra.Size = new System.Drawing.Size(127, 22);
            this.txtKodAra.TabIndex = 11;
            this.txtKodAra.TextChanged += new System.EventHandler(this.txtKodAra_TextChanged);
            this.txtKodAra.Enter += new System.EventHandler(this.txtKodAra_Enter);
            this.txtKodAra.Leave += new System.EventHandler(this.txtKodAra_Leave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PowderBlue;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnKodSil);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnKodGuncelle);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtKodAdi);
            this.panel1.Controls.Add(this.btnKodKaydet);
            this.panel1.Controls.Add(this.txtKodAciklama);
            this.panel1.Controls.Add(this.txtOrnekKod);
            this.panel1.Location = new System.Drawing.Point(3, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(339, 140);
            this.panel1.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Kod Adı:";
            // 
            // btnKodSil
            // 
            this.btnKodSil.Location = new System.Drawing.Point(232, 95);
            this.btnKodSil.Name = "btnKodSil";
            this.btnKodSil.Size = new System.Drawing.Size(89, 36);
            this.btnKodSil.TabIndex = 9;
            this.btnKodSil.Text = "Sil";
            this.btnKodSil.UseVisualStyleBackColor = true;
            this.btnKodSil.Click += new System.EventHandler(this.btnKodSil_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Açıklama:";
            // 
            // btnKodGuncelle
            // 
            this.btnKodGuncelle.Location = new System.Drawing.Point(232, 56);
            this.btnKodGuncelle.Name = "btnKodGuncelle";
            this.btnKodGuncelle.Size = new System.Drawing.Size(89, 36);
            this.btnKodGuncelle.TabIndex = 8;
            this.btnKodGuncelle.Text = "Güncelle";
            this.btnKodGuncelle.UseVisualStyleBackColor = true;
            this.btnKodGuncelle.Click += new System.EventHandler(this.btnKodGuncelle_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "Örnek Kod:";
            // 
            // txtKodAdi
            // 
            this.txtKodAdi.Location = new System.Drawing.Point(104, 22);
            this.txtKodAdi.Name = "txtKodAdi";
            this.txtKodAdi.Size = new System.Drawing.Size(100, 22);
            this.txtKodAdi.TabIndex = 3;
            // 
            // btnKodKaydet
            // 
            this.btnKodKaydet.Location = new System.Drawing.Point(232, 16);
            this.btnKodKaydet.Name = "btnKodKaydet";
            this.btnKodKaydet.Size = new System.Drawing.Size(89, 36);
            this.btnKodKaydet.TabIndex = 6;
            this.btnKodKaydet.Text = "Kaydet";
            this.btnKodKaydet.UseVisualStyleBackColor = true;
            this.btnKodKaydet.Click += new System.EventHandler(this.btnKodKaydet_Click);
            // 
            // txtKodAciklama
            // 
            this.txtKodAciklama.Location = new System.Drawing.Point(104, 63);
            this.txtKodAciklama.Multiline = true;
            this.txtKodAciklama.Name = "txtKodAciklama";
            this.txtKodAciklama.Size = new System.Drawing.Size(100, 22);
            this.txtKodAciklama.TabIndex = 4;
            // 
            // txtOrnekKod
            // 
            this.txtOrnekKod.Location = new System.Drawing.Point(104, 102);
            this.txtOrnekKod.Multiline = true;
            this.txtOrnekKod.Name = "txtOrnekKod";
            this.txtOrnekKod.Size = new System.Drawing.Size(100, 22);
            this.txtOrnekKod.TabIndex = 5;
            // 
            // dgvKodlar
            // 
            this.dgvKodlar.BackgroundColor = System.Drawing.Color.LightBlue;
            this.dgvKodlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKodlar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvKodlar.Location = new System.Drawing.Point(3, 162);
            this.dgvKodlar.Name = "dgvKodlar";
            this.dgvKodlar.RowHeadersWidth = 51;
            this.dgvKodlar.RowTemplate.Height = 24;
            this.dgvKodlar.Size = new System.Drawing.Size(786, 256);
            this.dgvKodlar.TabIndex = 7;
            this.dgvKodlar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKodlar_CellClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKelimeler)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKodlar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvKelimeler;
        private System.Windows.Forms.Button btnKelimeKaydet;
        private System.Windows.Forms.TextBox txtKullanim;
        private System.Windows.Forms.TextBox txtAnlam;
        private System.Windows.Forms.TextBox txtKelime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOrnekKod;
        private System.Windows.Forms.TextBox txtKodAciklama;
        private System.Windows.Forms.TextBox txtKodAdi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvKodlar;
        private System.Windows.Forms.Button btnKodKaydet;
        private System.Windows.Forms.Button btnKelimeSil;
        private System.Windows.Forms.Button btnKelimleriGuncelle;
        private System.Windows.Forms.Button btnKodSil;
        private System.Windows.Forms.Button btnKodGuncelle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtKodAra;
        private System.Windows.Forms.TextBox txtKelimeAra;
    }
}

