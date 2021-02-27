namespace hesap_makinesi
{
    partial class Form1
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
            this.hesapla = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Toplama = new System.Windows.Forms.Button();
            this.cıkarma = new System.Windows.Forms.Button();
            this.carpma = new System.Windows.Forms.Button();
            this.bolme = new System.Windows.Forms.Button();
            this.temızle = new System.Windows.Forms.Button();
            this.kare = new System.Windows.Forms.Button();
            this.kup = new System.Windows.Forms.Button();
            this.karekok = new System.Windows.Forms.Button();
            this.bolualma = new System.Windows.Forms.Button();
            this.bır = new System.Windows.Forms.Button();
            this.ıkı = new System.Windows.Forms.Button();
            this.uc = new System.Windows.Forms.Button();
            this.dort = new System.Windows.Forms.Button();
            this.bes = new System.Windows.Forms.Button();
            this.altı = new System.Windows.Forms.Button();
            this.yedı = new System.Windows.Forms.Button();
            this.sekız = new System.Windows.Forms.Button();
            this.dokuz = new System.Windows.Forms.Button();
            this.sıfır = new System.Windows.Forms.Button();
            this.vırgul = new System.Windows.Forms.Button();
            this.nokta = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // hesapla
            // 
            this.hesapla.Location = new System.Drawing.Point(56, 442);
            this.hesapla.Name = "hesapla";
            this.hesapla.Size = new System.Drawing.Size(411, 58);
            this.hesapla.TabIndex = 20;
            this.hesapla.Text = "Hesapla";
            this.hesapla.UseVisualStyleBackColor = true;
            this.hesapla.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(56, 127);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(177, 64);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // Toplama
            // 
            this.Toplama.Location = new System.Drawing.Point(259, 210);
            this.Toplama.Name = "Toplama";
            this.Toplama.Size = new System.Drawing.Size(101, 53);
            this.Toplama.TabIndex = 2;
            this.Toplama.Text = "+";
            this.Toplama.UseVisualStyleBackColor = true;
            this.Toplama.Click += new System.EventHandler(this.Toplama_Click);
            // 
            // cıkarma
            // 
            this.cıkarma.Location = new System.Drawing.Point(366, 210);
            this.cıkarma.Name = "cıkarma";
            this.cıkarma.Size = new System.Drawing.Size(101, 53);
            this.cıkarma.TabIndex = 3;
            this.cıkarma.Text = "-";
            this.cıkarma.UseVisualStyleBackColor = true;
            this.cıkarma.Click += new System.EventHandler(this.cıkarma_Click);
            // 
            // carpma
            // 
            this.carpma.Location = new System.Drawing.Point(259, 269);
            this.carpma.Name = "carpma";
            this.carpma.Size = new System.Drawing.Size(101, 51);
            this.carpma.TabIndex = 4;
            this.carpma.Text = "*";
            this.carpma.UseVisualStyleBackColor = true;
            this.carpma.Click += new System.EventHandler(this.carpma_Click);
            // 
            // bolme
            // 
            this.bolme.Location = new System.Drawing.Point(366, 269);
            this.bolme.Name = "bolme";
            this.bolme.Size = new System.Drawing.Size(101, 51);
            this.bolme.TabIndex = 5;
            this.bolme.Text = "/";
            this.bolme.UseVisualStyleBackColor = true;
            this.bolme.Click += new System.EventHandler(this.bolme_Click);
            // 
            // temızle
            // 
            this.temızle.Location = new System.Drawing.Point(56, 394);
            this.temızle.Name = "temızle";
            this.temızle.Size = new System.Drawing.Size(177, 42);
            this.temızle.TabIndex = 6;
            this.temızle.Text = "temizle";
            this.temızle.UseVisualStyleBackColor = true;
            this.temızle.Click += new System.EventHandler(this.button5_Click);
            // 
            // kare
            // 
            this.kare.Location = new System.Drawing.Point(259, 326);
            this.kare.Name = "kare";
            this.kare.Size = new System.Drawing.Size(101, 53);
            this.kare.TabIndex = 7;
            this.kare.Text = "x²";
            this.kare.UseVisualStyleBackColor = true;
            this.kare.Click += new System.EventHandler(this.kare_Click);
            // 
            // kup
            // 
            this.kup.Location = new System.Drawing.Point(366, 326);
            this.kup.Name = "kup";
            this.kup.Size = new System.Drawing.Size(101, 53);
            this.kup.TabIndex = 8;
            this.kup.Text = "X³";
            this.kup.UseVisualStyleBackColor = true;
            this.kup.Click += new System.EventHandler(this.kup_Click);
            // 
            // karekok
            // 
            this.karekok.Location = new System.Drawing.Point(259, 385);
            this.karekok.Name = "karekok";
            this.karekok.Size = new System.Drawing.Size(101, 51);
            this.karekok.TabIndex = 9;
            this.karekok.Text = "√X";
            this.karekok.UseVisualStyleBackColor = true;
            this.karekok.Click += new System.EventHandler(this.karekok_Click);
            // 
            // bolualma
            // 
            this.bolualma.Location = new System.Drawing.Point(366, 385);
            this.bolualma.Name = "bolualma";
            this.bolualma.Size = new System.Drawing.Size(101, 51);
            this.bolualma.TabIndex = 10;
            this.bolualma.Text = "1/x";
            this.bolualma.UseVisualStyleBackColor = true;
            this.bolualma.Click += new System.EventHandler(this.bolualma_Click);
            // 
            // bır
            // 
            this.bır.BackColor = System.Drawing.Color.Transparent;
            this.bır.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bır.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bır.ForeColor = System.Drawing.Color.Black;
            this.bır.Location = new System.Drawing.Point(56, 210);
            this.bır.Name = "bır";
            this.bır.Size = new System.Drawing.Size(55, 40);
            this.bır.TabIndex = 11;
            this.bır.Text = "1";
            this.bır.UseVisualStyleBackColor = false;
            this.bır.Click += new System.EventHandler(this.button10_Click);
            // 
            // ıkı
            // 
            this.ıkı.BackColor = System.Drawing.Color.Transparent;
            this.ıkı.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ıkı.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ıkı.ForeColor = System.Drawing.Color.Black;
            this.ıkı.Location = new System.Drawing.Point(117, 210);
            this.ıkı.Name = "ıkı";
            this.ıkı.Size = new System.Drawing.Size(55, 40);
            this.ıkı.TabIndex = 12;
            this.ıkı.Text = "2";
            this.ıkı.UseVisualStyleBackColor = false;
            this.ıkı.Click += new System.EventHandler(this.button11_Click);
            // 
            // uc
            // 
            this.uc.BackColor = System.Drawing.Color.Transparent;
            this.uc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uc.ForeColor = System.Drawing.Color.Black;
            this.uc.Location = new System.Drawing.Point(178, 210);
            this.uc.Name = "uc";
            this.uc.Size = new System.Drawing.Size(55, 40);
            this.uc.TabIndex = 13;
            this.uc.Text = "3";
            this.uc.UseVisualStyleBackColor = false;
            this.uc.Click += new System.EventHandler(this.button12_Click);
            // 
            // dort
            // 
            this.dort.BackColor = System.Drawing.Color.Transparent;
            this.dort.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dort.ForeColor = System.Drawing.Color.Black;
            this.dort.Location = new System.Drawing.Point(56, 256);
            this.dort.Name = "dort";
            this.dort.Size = new System.Drawing.Size(55, 40);
            this.dort.TabIndex = 14;
            this.dort.Text = "4";
            this.dort.UseVisualStyleBackColor = false;
            this.dort.Click += new System.EventHandler(this.button13_Click);
            // 
            // bes
            // 
            this.bes.BackColor = System.Drawing.Color.Transparent;
            this.bes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bes.ForeColor = System.Drawing.Color.Black;
            this.bes.Location = new System.Drawing.Point(117, 256);
            this.bes.Name = "bes";
            this.bes.Size = new System.Drawing.Size(55, 40);
            this.bes.TabIndex = 15;
            this.bes.Text = "5";
            this.bes.UseVisualStyleBackColor = false;
            this.bes.Click += new System.EventHandler(this.button14_Click);
            // 
            // altı
            // 
            this.altı.BackColor = System.Drawing.Color.Transparent;
            this.altı.Cursor = System.Windows.Forms.Cursors.Hand;
            this.altı.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.altı.ForeColor = System.Drawing.Color.Black;
            this.altı.Location = new System.Drawing.Point(178, 256);
            this.altı.Name = "altı";
            this.altı.Size = new System.Drawing.Size(55, 40);
            this.altı.TabIndex = 16;
            this.altı.Text = "6";
            this.altı.UseVisualStyleBackColor = false;
            this.altı.Click += new System.EventHandler(this.button15_Click);
            // 
            // yedı
            // 
            this.yedı.BackColor = System.Drawing.Color.Transparent;
            this.yedı.Cursor = System.Windows.Forms.Cursors.Hand;
            this.yedı.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yedı.ForeColor = System.Drawing.Color.Black;
            this.yedı.Location = new System.Drawing.Point(56, 302);
            this.yedı.Name = "yedı";
            this.yedı.Size = new System.Drawing.Size(55, 40);
            this.yedı.TabIndex = 17;
            this.yedı.Text = "7";
            this.yedı.UseVisualStyleBackColor = false;
            this.yedı.Click += new System.EventHandler(this.button16_Click);
            // 
            // sekız
            // 
            this.sekız.BackColor = System.Drawing.Color.Transparent;
            this.sekız.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sekız.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sekız.ForeColor = System.Drawing.Color.Black;
            this.sekız.Location = new System.Drawing.Point(117, 302);
            this.sekız.Name = "sekız";
            this.sekız.Size = new System.Drawing.Size(55, 40);
            this.sekız.TabIndex = 18;
            this.sekız.Text = "8";
            this.sekız.UseVisualStyleBackColor = false;
            this.sekız.Click += new System.EventHandler(this.button17_Click);
            // 
            // dokuz
            // 
            this.dokuz.BackColor = System.Drawing.Color.Transparent;
            this.dokuz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dokuz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dokuz.ForeColor = System.Drawing.Color.Black;
            this.dokuz.Location = new System.Drawing.Point(178, 302);
            this.dokuz.Name = "dokuz";
            this.dokuz.Size = new System.Drawing.Size(55, 40);
            this.dokuz.TabIndex = 19;
            this.dokuz.Text = "9";
            this.dokuz.UseVisualStyleBackColor = false;
            this.dokuz.Click += new System.EventHandler(this.button18_Click);
            // 
            // sıfır
            // 
            this.sıfır.BackColor = System.Drawing.Color.Transparent;
            this.sıfır.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sıfır.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sıfır.ForeColor = System.Drawing.Color.Black;
            this.sıfır.Location = new System.Drawing.Point(117, 348);
            this.sıfır.Name = "sıfır";
            this.sıfır.Size = new System.Drawing.Size(55, 40);
            this.sıfır.TabIndex = 20;
            this.sıfır.Text = "0";
            this.sıfır.UseVisualStyleBackColor = false;
            this.sıfır.Click += new System.EventHandler(this.button19_Click);
            // 
            // vırgul
            // 
            this.vırgul.BackColor = System.Drawing.Color.Transparent;
            this.vırgul.Cursor = System.Windows.Forms.Cursors.Hand;
            this.vırgul.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vırgul.ForeColor = System.Drawing.Color.Black;
            this.vırgul.Location = new System.Drawing.Point(56, 348);
            this.vırgul.Name = "vırgul";
            this.vırgul.Size = new System.Drawing.Size(55, 40);
            this.vırgul.TabIndex = 21;
            this.vırgul.Text = ",";
            this.vırgul.UseVisualStyleBackColor = false;
            this.vırgul.Click += new System.EventHandler(this.button20_Click);
            // 
            // nokta
            // 
            this.nokta.BackColor = System.Drawing.Color.Transparent;
            this.nokta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nokta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nokta.ForeColor = System.Drawing.Color.Black;
            this.nokta.Location = new System.Drawing.Point(178, 348);
            this.nokta.Name = "nokta";
            this.nokta.Size = new System.Drawing.Size(55, 40);
            this.nokta.TabIndex = 22;
            this.nokta.Text = ".";
            this.nokta.UseVisualStyleBackColor = false;
            this.nokta.Click += new System.EventHandler(this.button21_Click);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold);
            this.textBox2.Location = new System.Drawing.Point(259, 127);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(208, 64);
            this.textBox2.TabIndex = 23;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.Color.White;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(77, 90);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(83, 19);
            this.materialLabel1.TabIndex = 26;
            this.materialLabel1.Text = "Girilen sayı";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(321, 90);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(51, 19);
            this.materialLabel2.TabIndex = 27;
            this.materialLabel2.Text = "Sonuç";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(544, 561);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.nokta);
            this.Controls.Add(this.vırgul);
            this.Controls.Add(this.sıfır);
            this.Controls.Add(this.dokuz);
            this.Controls.Add(this.sekız);
            this.Controls.Add(this.yedı);
            this.Controls.Add(this.altı);
            this.Controls.Add(this.bes);
            this.Controls.Add(this.dort);
            this.Controls.Add(this.uc);
            this.Controls.Add(this.ıkı);
            this.Controls.Add(this.bır);
            this.Controls.Add(this.bolualma);
            this.Controls.Add(this.karekok);
            this.Controls.Add(this.kup);
            this.Controls.Add(this.kare);
            this.Controls.Add(this.temızle);
            this.Controls.Add(this.bolme);
            this.Controls.Add(this.carpma);
            this.Controls.Add(this.cıkarma);
            this.Controls.Add(this.Toplama);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.hesapla);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Hesap Makinesi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button hesapla;
        private System.Windows.Forms.Button Toplama;
        private System.Windows.Forms.Button cıkarma;
        private System.Windows.Forms.Button carpma;
        private System.Windows.Forms.Button bolme;
        private System.Windows.Forms.Button temızle;
        private System.Windows.Forms.Button kare;
        private System.Windows.Forms.Button kup;
        private System.Windows.Forms.Button karekok;
        private System.Windows.Forms.Button bolualma;
        private System.Windows.Forms.Button bır;
        private System.Windows.Forms.Button ıkı;
        private System.Windows.Forms.Button uc;
        private System.Windows.Forms.Button dort;
        private System.Windows.Forms.Button bes;
        private System.Windows.Forms.Button altı;
        private System.Windows.Forms.Button yedı;
        private System.Windows.Forms.Button sekız;
        private System.Windows.Forms.Button dokuz;
        private System.Windows.Forms.Button sıfır;
        private System.Windows.Forms.Button vırgul;
        private System.Windows.Forms.Button nokta;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
    }
}

