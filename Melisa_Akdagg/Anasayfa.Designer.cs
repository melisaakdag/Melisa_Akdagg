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
            this.lblYazarlar = new System.Windows.Forms.Button();
            this.btnOduncler = new System.Windows.Forms.Button();
            this.btnCeza = new System.Windows.Forms.Button();
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
            // lblYazarlar
            // 
            this.lblYazarlar.Location = new System.Drawing.Point(196, 29);
            this.lblYazarlar.Name = "lblYazarlar";
            this.lblYazarlar.Size = new System.Drawing.Size(153, 75);
            this.lblYazarlar.TabIndex = 1;
            this.lblYazarlar.Text = "Yazarlar";
            this.lblYazarlar.UseVisualStyleBackColor = true;
            this.lblYazarlar.Click += new System.EventHandler(this.lblYazarlar_Click);
            // 
            // btnOduncler
            // 
            this.btnOduncler.Location = new System.Drawing.Point(12, 145);
            this.btnOduncler.Name = "btnOduncler";
            this.btnOduncler.Size = new System.Drawing.Size(153, 75);
            this.btnOduncler.TabIndex = 2;
            this.btnOduncler.Text = "Ödüncler";
            this.btnOduncler.UseVisualStyleBackColor = true;
            this.btnOduncler.Click += new System.EventHandler(this.btnOduncler_Click);
            // 
            // btnCeza
            // 
            this.btnCeza.Location = new System.Drawing.Point(196, 145);
            this.btnCeza.Name = "btnCeza";
            this.btnCeza.Size = new System.Drawing.Size(153, 75);
            this.btnCeza.TabIndex = 3;
            this.btnCeza.Text = "Cezalar";
            this.btnCeza.UseVisualStyleBackColor = true;
            this.btnCeza.Click += new System.EventHandler(this.btnCeza_Click);
            // 
            // Anasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 450);
            this.Controls.Add(this.btnCeza);
            this.Controls.Add(this.btnOduncler);
            this.Controls.Add(this.lblYazarlar);
            this.Controls.Add(this.btnKullanicilar);
            this.Name = "Anasayfa";
            this.Text = "Anasayfa";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnKullanicilar;
        private System.Windows.Forms.Button lblYazarlar;
        private System.Windows.Forms.Button btnOduncler;
        private System.Windows.Forms.Button btnCeza;
    }
}