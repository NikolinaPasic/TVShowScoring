namespace Korisnicki_interfejs
{
    partial class FrmGlavnaAdministrator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGlavnaAdministrator));
            this.pnlSideMenu = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlGlumci = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.btnUnosGlumca = new System.Windows.Forms.Button();
            this.btnPretragaGlumca = new System.Windows.Forms.Button();
            this.btnGlumci = new System.Windows.Forms.Button();
            this.pnlSerije = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnUnosSerije = new System.Windows.Forms.Button();
            this.btnPretragaSerije = new System.Windows.Forms.Button();
            this.btnSerije = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblPoruka = new System.Windows.Forms.Label();
            this.pnlSideMenu.SuspendLayout();
            this.pnlGlumci.SuspendLayout();
            this.pnlSerije.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSideMenu
            // 
            this.pnlSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.pnlSideMenu.Controls.Add(this.btnClose);
            this.pnlSideMenu.Controls.Add(this.pnlGlumci);
            this.pnlSideMenu.Controls.Add(this.btnGlumci);
            this.pnlSideMenu.Controls.Add(this.pnlSerije);
            this.pnlSideMenu.Controls.Add(this.btnSerije);
            this.pnlSideMenu.Controls.Add(this.flowLayoutPanel1);
            this.pnlSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSideMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlSideMenu.Name = "pnlSideMenu";
            this.pnlSideMenu.Size = new System.Drawing.Size(200, 514);
            this.pnlSideMenu.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Arial", 11.25F);
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(146)))));
            this.btnClose.Location = new System.Drawing.Point(3, 486);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(22, 25);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pnlGlumci
            // 
            this.pnlGlumci.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(146)))));
            this.pnlGlumci.Controls.Add(this.button3);
            this.pnlGlumci.Controls.Add(this.btnUnosGlumca);
            this.pnlGlumci.Controls.Add(this.btnPretragaGlumca);
            this.pnlGlumci.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlGlumci.Location = new System.Drawing.Point(0, 353);
            this.pnlGlumci.Name = "pnlGlumci";
            this.pnlGlumci.Size = new System.Drawing.Size(200, 125);
            this.pnlGlumci.TabIndex = 4;
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.button3.Location = new System.Drawing.Point(0, 82);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(200, 40);
            this.button3.TabIndex = 2;
            this.button3.Text = "Izmena glumca";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnUnosGlumca
            // 
            this.btnUnosGlumca.FlatAppearance.BorderSize = 0;
            this.btnUnosGlumca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUnosGlumca.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnosGlumca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.btnUnosGlumca.Location = new System.Drawing.Point(0, 40);
            this.btnUnosGlumca.Name = "btnUnosGlumca";
            this.btnUnosGlumca.Size = new System.Drawing.Size(200, 40);
            this.btnUnosGlumca.TabIndex = 1;
            this.btnUnosGlumca.Text = "Unos novog glumca";
            this.btnUnosGlumca.UseVisualStyleBackColor = true;
            this.btnUnosGlumca.Click += new System.EventHandler(this.btnUnosGlumca_Click);
            // 
            // btnPretragaGlumca
            // 
            this.btnPretragaGlumca.FlatAppearance.BorderSize = 0;
            this.btnPretragaGlumca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPretragaGlumca.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPretragaGlumca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.btnPretragaGlumca.Location = new System.Drawing.Point(0, 0);
            this.btnPretragaGlumca.Name = "btnPretragaGlumca";
            this.btnPretragaGlumca.Size = new System.Drawing.Size(200, 40);
            this.btnPretragaGlumca.TabIndex = 0;
            this.btnPretragaGlumca.Text = "Prikaz svih glumaca";
            this.btnPretragaGlumca.UseVisualStyleBackColor = true;
            this.btnPretragaGlumca.Click += new System.EventHandler(this.btnPretragaGlumca_Click);
            // 
            // btnGlumci
            // 
            this.btnGlumci.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGlumci.FlatAppearance.BorderSize = 0;
            this.btnGlumci.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGlumci.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGlumci.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(146)))));
            this.btnGlumci.Location = new System.Drawing.Point(0, 308);
            this.btnGlumci.Name = "btnGlumci";
            this.btnGlumci.Size = new System.Drawing.Size(200, 45);
            this.btnGlumci.TabIndex = 3;
            this.btnGlumci.Text = "Glumci";
            this.btnGlumci.UseVisualStyleBackColor = true;
            this.btnGlumci.Click += new System.EventHandler(this.btnGlumci_Click);
            // 
            // pnlSerije
            // 
            this.pnlSerije.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(146)))));
            this.pnlSerije.Controls.Add(this.button2);
            this.pnlSerije.Controls.Add(this.button1);
            this.pnlSerije.Controls.Add(this.btnUnosSerije);
            this.pnlSerije.Controls.Add(this.btnPretragaSerije);
            this.pnlSerije.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSerije.Location = new System.Drawing.Point(0, 145);
            this.pnlSerije.Name = "pnlSerije";
            this.pnlSerije.Size = new System.Drawing.Size(200, 163);
            this.pnlSerije.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.button2.Location = new System.Drawing.Point(0, 120);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 43);
            this.button2.TabIndex = 3;
            this.button2.Text = "Brisanje serije";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.button1.Location = new System.Drawing.Point(0, 80);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 40);
            this.button1.TabIndex = 2;
            this.button1.Text = "Izmena serije";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnUnosSerije
            // 
            this.btnUnosSerije.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUnosSerije.FlatAppearance.BorderSize = 0;
            this.btnUnosSerije.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUnosSerije.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnosSerije.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.btnUnosSerije.Location = new System.Drawing.Point(0, 40);
            this.btnUnosSerije.Name = "btnUnosSerije";
            this.btnUnosSerije.Size = new System.Drawing.Size(200, 40);
            this.btnUnosSerije.TabIndex = 1;
            this.btnUnosSerije.Text = "Unos nove serije";
            this.btnUnosSerije.UseVisualStyleBackColor = true;
            this.btnUnosSerije.Click += new System.EventHandler(this.btnUnosSerije_Click);
            // 
            // btnPretragaSerije
            // 
            this.btnPretragaSerije.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPretragaSerije.FlatAppearance.BorderSize = 0;
            this.btnPretragaSerije.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPretragaSerije.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPretragaSerije.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.btnPretragaSerije.Location = new System.Drawing.Point(0, 0);
            this.btnPretragaSerije.Name = "btnPretragaSerije";
            this.btnPretragaSerije.Size = new System.Drawing.Size(200, 40);
            this.btnPretragaSerije.TabIndex = 0;
            this.btnPretragaSerije.Text = "Prikaz svih serija";
            this.btnPretragaSerije.UseVisualStyleBackColor = true;
            this.btnPretragaSerije.Click += new System.EventHandler(this.btnPretragaSerije_Click);
            // 
            // btnSerije
            // 
            this.btnSerije.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSerije.FlatAppearance.BorderSize = 0;
            this.btnSerije.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSerije.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSerije.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(146)))));
            this.btnSerije.Location = new System.Drawing.Point(0, 100);
            this.btnSerije.Name = "btnSerije";
            this.btnSerije.Size = new System.Drawing.Size(200, 45);
            this.btnSerije.TabIndex = 1;
            this.btnSerije.Text = "Serije";
            this.btnSerije.UseVisualStyleBackColor = true;
            this.btnSerije.Click += new System.EventHandler(this.btnSerije_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("flowLayoutPanel1.BackgroundImage")));
            this.flowLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(200, 100);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(200, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(662, 514);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lblPoruka
            // 
            this.lblPoruka.AutoSize = true;
            this.lblPoruka.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblPoruka.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoruka.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPoruka.Location = new System.Drawing.Point(630, 25);
            this.lblPoruka.Name = "lblPoruka";
            this.lblPoruka.Size = new System.Drawing.Size(46, 18);
            this.lblPoruka.TabIndex = 2;
            this.lblPoruka.Text = "label2";
            this.lblPoruka.Click += new System.EventHandler(this.label2_Click);
            // 
            // FrmGlavnaAdministrator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 514);
            this.Controls.Add(this.lblPoruka);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pnlSideMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmGlavnaAdministrator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DAD";
            this.pnlSideMenu.ResumeLayout(false);
            this.pnlGlumci.ResumeLayout(false);
            this.pnlSerije.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlSideMenu;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel pnlSerije;
        private System.Windows.Forms.Button btnSerije;
        private System.Windows.Forms.Button btnUnosSerije;
        private System.Windows.Forms.Panel pnlGlumci;
        private System.Windows.Forms.Button btnGlumci;
        private System.Windows.Forms.Button btnUnosGlumca;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnPretragaGlumca;
        private System.Windows.Forms.Button btnPretragaSerije;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblPoruka;
    }
}