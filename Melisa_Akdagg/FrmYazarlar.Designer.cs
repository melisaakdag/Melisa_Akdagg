﻿namespace Melisa_Akdagg
{
    partial class FrmYazarlar
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
            this.txtArama = new System.Windows.Forms.TextBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnEkleme = new System.Windows.Forms.Button();
            this.txtSoyadi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.txtArama);
            this.groupBox1.Location = new System.Drawing.Point(257, 331);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(187, 74);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Arama";
            // 
            // txtArama
            // 
            this.txtArama.Location = new System.Drawing.Point(19, 31);
            this.txtArama.Name = "txtArama";
            this.txtArama.Size = new System.Drawing.Size(166, 20);
            this.txtArama.TabIndex = 19;
            this.txtArama.TextChanged += new System.EventHandler(this.txtArama_TextChanged_1);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSil.Location = new System.Drawing.Point(310, 286);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(132, 23);
            this.btnSil.TabIndex = 41;
            this.btnSil.Text = "Yazar Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(256, 443);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(129, 20);
            this.txtID.TabIndex = 40;
            this.txtID.Visible = false;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnGuncelle.Location = new System.Drawing.Point(166, 286);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(127, 23);
            this.btnGuncelle.TabIndex = 39;
            this.btnGuncelle.Text = "Yazar Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnEkleme
            // 
            this.btnEkleme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnEkleme.Location = new System.Drawing.Point(22, 286);
            this.btnEkleme.Name = "btnEkleme";
            this.btnEkleme.Size = new System.Drawing.Size(132, 23);
            this.btnEkleme.TabIndex = 38;
            this.btnEkleme.Text = "Yeni Yazar Ekle";
            this.btnEkleme.UseVisualStyleBackColor = false;
            this.btnEkleme.Click += new System.EventHandler(this.btnEkleme_Click);
            // 
            // txtSoyadi
            // 
            this.txtSoyadi.Location = new System.Drawing.Point(144, 373);
            this.txtSoyadi.Name = "txtSoyadi";
            this.txtSoyadi.Size = new System.Drawing.Size(100, 20);
            this.txtSoyadi.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(163, 357);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Yazar SoyAdı";
            // 
            // txtAdi
            // 
            this.txtAdi.Location = new System.Drawing.Point(22, 373);
            this.txtAdi.Name = "txtAdi";
            this.txtAdi.Size = new System.Drawing.Size(100, 20);
            this.txtAdi.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 357);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Yazar Adı";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(-71, 327);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Kullanici Adi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-71, 327);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Kullanici Adi";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(422, 212);
            this.dataGridView1.TabIndex = 23;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // FrmYazarlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 417);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnEkleme);
            this.Controls.Add(this.txtSoyadi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAdi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmYazarlar";
            this.Text = "FrmYazarlar";
            this.Load += new System.EventHandler(this.FrmYazarlar_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtArama;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnEkleme;
        private System.Windows.Forms.TextBox txtSoyadi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}