﻿
namespace Korisnicki_interfejs
{
    partial class FrmRegularniKorisnik
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
            System.Windows.Forms.Button btnObrisiUlogu;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegularniKorisnik));
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtOcena = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbTipoviIskustva = new System.Windows.Forms.ComboBox();
            this.txtOpisIskustva = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvIskustva = new System.Windows.Forms.DataGridView();
            this.btnDodajUlogu = new System.Windows.Forms.Button();
            this.btnSacuvajIskustvo = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            btnObrisiUlogu = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIskustva)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnObrisiUlogu
            // 
            btnObrisiUlogu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnObrisiUlogu.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnObrisiUlogu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(146)))));
            btnObrisiUlogu.Location = new System.Drawing.Point(647, 261);
            btnObrisiUlogu.Name = "btnObrisiUlogu";
            btnObrisiUlogu.Size = new System.Drawing.Size(124, 29);
            btnObrisiUlogu.TabIndex = 61;
            btnObrisiUlogu.Text = "Obrisi ocenu";
            btnObrisiUlogu.UseVisualStyleBackColor = true;
            btnObrisiUlogu.Click += new System.EventHandler(this.btnObrisiUlogu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(146)))));
            this.label1.Location = new System.Drawing.Point(646, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(50, 85);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(236, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(146)))));
            this.label2.Location = new System.Drawing.Point(47, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Izaberite seriju:";
            // 
            // btnClose
            // 
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Arial", 11.25F);
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(146)))));
            this.btnClose.Location = new System.Drawing.Point(755, 413);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(33, 25);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(35)))), ((int)(((byte)(43)))));
            this.groupBox1.Controls.Add(this.txtOcena);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cmbTipoviIskustva);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(146)))));
            this.groupBox1.Location = new System.Drawing.Point(347, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(270, 113);
            this.groupBox1.TabIndex = 60;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Unos iskustva";
            // 
            // txtOcena
            // 
            this.txtOcena.Location = new System.Drawing.Point(90, 76);
            this.txtOcena.Name = "txtOcena";
            this.txtOcena.Size = new System.Drawing.Size(53, 20);
            this.txtOcena.TabIndex = 64;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(146)))));
            this.label3.Location = new System.Drawing.Point(19, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 63;
            this.label3.Text = "Ocena:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(146)))));
            this.label7.Location = new System.Drawing.Point(15, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 61;
            this.label7.Text = "Tip ocene:";
            // 
            // cmbTipoviIskustva
            // 
            this.cmbTipoviIskustva.FormattingEnabled = true;
            this.cmbTipoviIskustva.Location = new System.Drawing.Point(90, 29);
            this.cmbTipoviIskustva.Name = "cmbTipoviIskustva";
            this.cmbTipoviIskustva.Size = new System.Drawing.Size(174, 21);
            this.cmbTipoviIskustva.TabIndex = 59;
            // 
            // txtOpisIskustva
            // 
            this.txtOpisIskustva.Location = new System.Drawing.Point(50, 175);
            this.txtOpisIskustva.Name = "txtOpisIskustva";
            this.txtOpisIskustva.Size = new System.Drawing.Size(267, 56);
            this.txtOpisIskustva.TabIndex = 62;
            this.txtOpisIskustva.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(146)))));
            this.label8.Location = new System.Drawing.Point(49, 160);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 61;
            this.label8.Text = "Opis iskustva:";
            // 
            // dgvIskustva
            // 
            this.dgvIskustva.AllowUserToAddRows = false;
            this.dgvIskustva.AllowUserToDeleteRows = false;
            this.dgvIskustva.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIskustva.Location = new System.Drawing.Point(347, 231);
            this.dgvIskustva.MultiSelect = false;
            this.dgvIskustva.Name = "dgvIskustva";
            this.dgvIskustva.Size = new System.Drawing.Size(258, 125);
            this.dgvIskustva.TabIndex = 63;
            // 
            // btnDodajUlogu
            // 
            this.btnDodajUlogu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDodajUlogu.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajUlogu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(146)))));
            this.btnDodajUlogu.Location = new System.Drawing.Point(647, 202);
            this.btnDodajUlogu.Name = "btnDodajUlogu";
            this.btnDodajUlogu.Size = new System.Drawing.Size(124, 29);
            this.btnDodajUlogu.TabIndex = 59;
            this.btnDodajUlogu.Text = "Dodaj ocenu";
            this.btnDodajUlogu.UseVisualStyleBackColor = true;
            this.btnDodajUlogu.Click += new System.EventHandler(this.btnDodajUlogu_Click);
            // 
            // btnSacuvajIskustvo
            // 
            this.btnSacuvajIskustvo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSacuvajIskustvo.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSacuvajIskustvo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(146)))));
            this.btnSacuvajIskustvo.Location = new System.Drawing.Point(649, 338);
            this.btnSacuvajIskustvo.Name = "btnSacuvajIskustvo";
            this.btnSacuvajIskustvo.Size = new System.Drawing.Size(139, 29);
            this.btnSacuvajIskustvo.TabIndex = 64;
            this.btnSacuvajIskustvo.Text = "Sacuvaj iskustvo";
            this.btnSacuvajIskustvo.UseVisualStyleBackColor = true;
            this.btnSacuvajIskustvo.Click += new System.EventHandler(this.btnSacuvajIskustvo_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(35)))), ((int)(((byte)(43)))));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(647, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(142, 112);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 65;
            this.pictureBox1.TabStop = false;
            // 
            // FrmRegularniKorisnik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSacuvajIskustvo);
            this.Controls.Add(this.txtOpisIskustva);
            this.Controls.Add(this.dgvIskustva);
            this.Controls.Add(this.label8);
            this.Controls.Add(btnObrisiUlogu);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDodajUlogu);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmRegularniKorisnik";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmRegularniKorisnik";
            this.Load += new System.EventHandler(this.FrmRegularniKorisnik_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIskustva)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtOcena;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox txtOpisIskustva;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbTipoviIskustva;
        private System.Windows.Forms.DataGridView dgvIskustva;
        private System.Windows.Forms.Button btnDodajUlogu;
        private System.Windows.Forms.Button btnSacuvajIskustvo;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}