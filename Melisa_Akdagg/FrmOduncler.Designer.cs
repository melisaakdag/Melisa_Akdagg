namespace Melisa_Akdagg
{
    partial class FrmOduncler
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbSoyisim = new System.Windows.Forms.RadioButton();
            this.txtArama = new System.Windows.Forms.TextBox();
            this.rdbIsim = new System.Windows.Forms.RadioButton();
            this.btnSil = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnEkleme = new System.Windows.Forms.Button();
            this.txtAdi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGoster = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cmbKullanicilar = new System.Windows.Forms.ComboBox();
            this.cmbKitaplar = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.rdbSoyisim);
            this.groupBox1.Controls.Add(this.txtArama);
            this.groupBox1.Controls.Add(this.rdbIsim);
            this.groupBox1.Location = new System.Drawing.Point(434, 316);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(320, 74);
            this.groupBox1.TabIndex = 41;
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
            // 
            // txtArama
            // 
            this.txtArama.Location = new System.Drawing.Point(19, 31);
            this.txtArama.Name = "txtArama";
            this.txtArama.Size = new System.Drawing.Size(166, 20);
            this.txtArama.TabIndex = 19;
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
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSil.Location = new System.Drawing.Point(462, 264);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(132, 23);
            this.btnSil.TabIndex = 40;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(255, 238);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(129, 20);
            this.txtID.TabIndex = 39;
            this.txtID.Visible = false;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnGuncelle.Location = new System.Drawing.Point(316, 264);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(127, 23);
            this.btnGuncelle.TabIndex = 38;
            this.btnGuncelle.Text = " Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            // 
            // btnEkleme
            // 
            this.btnEkleme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnEkleme.Location = new System.Drawing.Point(172, 264);
            this.btnEkleme.Name = "btnEkleme";
            this.btnEkleme.Size = new System.Drawing.Size(132, 23);
            this.btnEkleme.TabIndex = 37;
            this.btnEkleme.Text = " Ekle";
            this.btnEkleme.UseVisualStyleBackColor = false;
            // 
            // txtAdi
            // 
            this.txtAdi.Location = new System.Drawing.Point(34, 325);
            this.txtAdi.Name = "txtAdi";
            this.txtAdi.Size = new System.Drawing.Size(100, 20);
            this.txtAdi.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(52, 309);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Verdiği Tarih";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 309);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Kullanici Adi";
            // 
            // btnGoster
            // 
            this.btnGoster.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnGoster.Location = new System.Drawing.Point(34, 264);
            this.btnGoster.Name = "btnGoster";
            this.btnGoster.Size = new System.Drawing.Size(127, 23);
            this.btnGoster.TabIndex = 23;
            this.btnGoster.Text = "Ödünç  Goster";
            this.btnGoster.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(626, 212);
            this.dataGridView1.TabIndex = 22;
            // 
            // cmbKullanicilar
            // 
            this.cmbKullanicilar.FormattingEnabled = true;
            this.cmbKullanicilar.Location = new System.Drawing.Point(172, 325);
            this.cmbKullanicilar.Name = "cmbKullanicilar";
            this.cmbKullanicilar.Size = new System.Drawing.Size(121, 21);
            this.cmbKullanicilar.TabIndex = 42;
            // 
            // cmbKitaplar
            // 
            this.cmbKitaplar.FormattingEnabled = true;
            this.cmbKitaplar.Location = new System.Drawing.Point(172, 381);
            this.cmbKitaplar.Name = "cmbKitaplar";
            this.cmbKitaplar.Size = new System.Drawing.Size(121, 21);
            this.cmbKitaplar.TabIndex = 43;
            // 
            // FrmOduncler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1301, 450);
            this.Controls.Add(this.cmbKitaplar);
            this.Controls.Add(this.cmbKullanicilar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnEkleme);
            this.Controls.Add(this.txtAdi);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGoster);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmOduncler";
            this.Text = "FrmOduncler";
            this.Load += new System.EventHandler(this.FrmOduncler_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbSoyisim;
        private System.Windows.Forms.TextBox txtArama;
        private System.Windows.Forms.RadioButton rdbIsim;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnEkleme;
        private System.Windows.Forms.TextBox txtAdi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGoster;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cmbKullanicilar;
        private System.Windows.Forms.ComboBox cmbKitaplar;
    }
}