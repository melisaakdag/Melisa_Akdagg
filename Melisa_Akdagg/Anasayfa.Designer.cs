namespace Melisa_Akdagg
{
    partial class Anasayfa
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
            this.btnKullanicilar = new System.Windows.Forms.Button();
            this.btnOduncler = new System.Windows.Forms.Button();
            this.btnCeza = new System.Windows.Forms.Button();
            this.btnKategori = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnKullanicilar
            // 
            this.btnKullanicilar.Location = new System.Drawing.Point(12, 29);
            this.btnKullanicilar.Name = "btnKullanicilar";
            this.btnKullanicilar.Size = new System.Drawing.Size(153, 75);
            this.btnKullanicilar.TabIndex = 0;
            this.btnKullanicilar.Text = "Kullanicilar";
            this.btnKullanicilar.UseVisualStyleBackColor = true;
            this.btnKullanicilar.Click += new System.EventHandler(this.btnKullanicilar_Click);
            // 
            // btnOduncler
            // 
            this.btnOduncler.Location = new System.Drawing.Point(196, 29);
            this.btnOduncler.Name = "btnOduncler";
            this.btnOduncler.Size = new System.Drawing.Size(153, 75);
            this.btnOduncler.TabIndex = 2;
            this.btnOduncler.Text = "Ödüncler";
            this.btnOduncler.UseVisualStyleBackColor = true;
            this.btnOduncler.Click += new System.EventHandler(this.btnOduncler_Click);
            // 
            // btnCeza
            // 
            this.btnCeza.Location = new System.Drawing.Point(12, 129);
            this.btnCeza.Name = "btnCeza";
            this.btnCeza.Size = new System.Drawing.Size(153, 75);
            this.btnCeza.TabIndex = 3;
            this.btnCeza.Text = "Cezalar";
            this.btnCeza.UseVisualStyleBackColor = true;
            this.btnCeza.Click += new System.EventHandler(this.btnCeza_Click);
            // 
            // btnKategori
            // 
            this.btnKategori.Location = new System.Drawing.Point(12, 229);
            this.btnKategori.Name = "btnKategori";
            this.btnKategori.Size = new System.Drawing.Size(153, 75);
            this.btnKategori.TabIndex = 4;
            this.btnKategori.Text = "Kategoriler";
            this.btnKategori.UseVisualStyleBackColor = true;
            this.btnKategori.Click += new System.EventHandler(this.btnKategori_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(196, 129);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 75);
            this.button1.TabIndex = 5;
            this.button1.Text = "Kitaplar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(196, 229);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(153, 75);
            this.button2.TabIndex = 6;
            this.button2.Text = "Yazarlar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Anasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 390);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnKategori);
            this.Controls.Add(this.btnCeza);
            this.Controls.Add(this.btnOduncler);
            this.Controls.Add(this.btnKullanicilar);
            this.Name = "Anasayfa";
            this.Text = "Anasayfa";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnKullanicilar;
        private System.Windows.Forms.Button btnOduncler;
        private System.Windows.Forms.Button btnCeza;
        private System.Windows.Forms.Button btnKategori;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}