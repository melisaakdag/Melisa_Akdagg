namespace Melisa_Akdagg
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnGoster = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAdi = new System.Windows.Forms.TextBox();
            this.txtSoyadi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTelefonNo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnEkleme = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.txtArama = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbSoyisim = new System.Windows.Forms.RadioButton();
            this.rdbIsim = new System.Windows.Forms.RadioButton();
            this.txtYasi = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblOgrenciS = new System.Windows.Forms.Label();
            this.lblYasOrt = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(742, 212);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btnGoster
            // 
            this.btnGoster.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnGoster.Location = new System.Drawing.Point(34, 283);
            this.btnGoster.Name = "btnGoster";
            this.btnGoster.Size = new System.Drawing.Size(127, 23);
            this.btnGoster.TabIndex = 1;
            this.btnGoster.Text = "Kullanicilari Goster";
            this.btnGoster.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 328);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kullanici Adi";
            // 
            // txtAdi
            // 
            this.txtAdi.Location = new System.Drawing.Point(34, 344);
            this.txtAdi.Name = "txtAdi";
            this.txtAdi.Size = new System.Drawing.Size(100, 20);
            this.txtAdi.TabIndex = 3;
            // 
            // txtSoyadi
            // 
            this.txtSoyadi.Location = new System.Drawing.Point(172, 344);
            this.txtSoyadi.Name = "txtSoyadi";
            this.txtSoyadi.Size = new System.Drawing.Size(100, 20);
            this.txtSoyadi.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(179, 328);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Kullanici Soyadi";
            // 
            // txtTc
            // 
            this.txtTc.Location = new System.Drawing.Point(294, 344);
            this.txtTc.Name = "txtTc";
            this.txtTc.Size = new System.Drawing.Size(100, 20);
            this.txtTc.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(313, 328);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "TC";
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(172, 389);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(100, 20);
            this.txtMail.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(307, 373);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Yasi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(169, 373);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Mail";
            // 
            // txtTelefonNo
            // 
            this.txtTelefonNo.Location = new System.Drawing.Point(34, 389);
            this.txtTelefonNo.Name = "txtTelefonNo";
            this.txtTelefonNo.Size = new System.Drawing.Size(100, 20);
            this.txtTelefonNo.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(44, 373);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Telefon Numarası";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(52, 328);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Kullanici Adi";
            // 
            // btnEkleme
            // 
            this.btnEkleme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnEkleme.Location = new System.Drawing.Point(172, 283);
            this.btnEkleme.Name = "btnEkleme";
            this.btnEkleme.Size = new System.Drawing.Size(132, 23);
            this.btnEkleme.TabIndex = 14;
            this.btnEkleme.Text = "Yeni Kullanıcı Ekle";
            this.btnEkleme.UseVisualStyleBackColor = false;
            this.btnEkleme.Click += new System.EventHandler(this.btnEkleme_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnGuncelle.Location = new System.Drawing.Point(316, 283);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(127, 23);
            this.btnGuncelle.TabIndex = 15;
            this.btnGuncelle.Text = "Kullanici Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(255, 257);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(129, 20);
            this.txtID.TabIndex = 17;
            this.txtID.Visible = false;
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSil.Location = new System.Drawing.Point(462, 283);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(132, 23);
            this.btnSil.TabIndex = 18;
            this.btnSil.Text = "Kullanici Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // txtArama
            // 
            this.txtArama.Location = new System.Drawing.Point(19, 31);
            this.txtArama.Name = "txtArama";
            this.txtArama.Size = new System.Drawing.Size(166, 20);
            this.txtArama.TabIndex = 19;
            this.txtArama.TextChanged += new System.EventHandler(this.txtArama_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.rdbSoyisim);
            this.groupBox1.Controls.Add(this.txtArama);
            this.groupBox1.Controls.Add(this.rdbIsim);
            this.groupBox1.Location = new System.Drawing.Point(434, 335);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(320, 74);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Arama";
            // 
            // rdbSoyisim
            // 
            this.rdbSoyisim.AutoSize = true;
            this.rdbSoyisim.Location = new System.Drawing.Point(217, 42);
            this.rdbSoyisim.Name = "rdbSoyisim";
            this.rdbSoyisim.Size = new System.Drawing.Size(103, 17);
            this.rdbSoyisim.TabIndex = 23;
            this.rdbSoyisim.TabStop = true;
            this.rdbSoyisim.Text = "Soyada göre ara";
            this.rdbSoyisim.UseVisualStyleBackColor = true;
            this.rdbSoyisim.CheckedChanged += new System.EventHandler(this.rdbSoyisim_CheckedChanged);
            // 
            // rdbIsim
            // 
            this.rdbIsim.AutoSize = true;
            this.rdbIsim.Location = new System.Drawing.Point(219, 19);
            this.rdbIsim.Name = "rdbIsim";
            this.rdbIsim.Size = new System.Drawing.Size(89, 17);
            this.rdbIsim.TabIndex = 22;
            this.rdbIsim.TabStop = true;
            this.rdbIsim.Text = "İsme göre ara";
            this.rdbIsim.UseVisualStyleBackColor = true;
            this.rdbIsim.CheckedChanged += new System.EventHandler(this.rdbIsim_CheckedChanged);
            // 
            // txtYasi
            // 
            this.txtYasi.Location = new System.Drawing.Point(294, 389);
            this.txtYasi.Name = "txtYasi";
            this.txtYasi.Size = new System.Drawing.Size(100, 20);
            this.txtYasi.TabIndex = 11;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblYasOrt);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.lblOgrenciS);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(761, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(274, 390);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Raporlama";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Toplam Kullanici Sayisi :";
            // 
            // lblOgrenciS
            // 
            this.lblOgrenciS.AutoSize = true;
            this.lblOgrenciS.Location = new System.Drawing.Point(165, 42);
            this.lblOgrenciS.Name = "lblOgrenciS";
            this.lblOgrenciS.Size = new System.Drawing.Size(13, 13);
            this.lblOgrenciS.TabIndex = 1;
            this.lblOgrenciS.Text = "0";
            // 
            // lblYasOrt
            // 
            this.lblYasOrt.AutoSize = true;
            this.lblYasOrt.Location = new System.Drawing.Point(165, 83);
            this.lblYasOrt.Name = "lblYasOrt";
            this.lblYasOrt.Size = new System.Drawing.Size(13, 13);
            this.lblYasOrt.TabIndex = 3;
            this.lblYasOrt.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 83);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(144, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Kullaniciların Yaş Ortalaması :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 433);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnEkleme);
            this.Controls.Add(this.txtTelefonNo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtYasi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSoyadi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAdi);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGoster);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnGoster;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAdi;
        private System.Windows.Forms.TextBox txtSoyadi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTelefonNo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnEkleme;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.TextBox txtArama;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbSoyisim;
        private System.Windows.Forms.RadioButton rdbIsim;
        private System.Windows.Forms.TextBox txtYasi;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblOgrenciS;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblYasOrt;
        private System.Windows.Forms.Label label10;
    }
}

