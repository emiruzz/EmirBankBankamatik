namespace EmirBankBankamatik
{
    partial class GirisYap
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
            lblEmirBank = new Label();
            lblHosgeldiniz = new Label();
            lblKullaniciAdi = new Label();
            lblSifre = new Label();
            txtKullaniciAdi = new TextBox();
            txtSifre = new TextBox();
            btnGirisYap = new Button();
            lblKayit = new Label();
            btnKayitOl = new Button();
            SuspendLayout();
            // 
            // lblEmirBank
            // 
            lblEmirBank.AutoSize = true;
            lblEmirBank.BackColor = Color.Transparent;
            lblEmirBank.Font = new Font("Wide Latin", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmirBank.ForeColor = Color.Transparent;
            lblEmirBank.Location = new Point(65, 24);
            lblEmirBank.Name = "lblEmirBank";
            lblEmirBank.Size = new Size(561, 59);
            lblEmirBank.TabIndex = 3;
            lblEmirBank.Text = "EMIRBANK";
            // 
            // lblHosgeldiniz
            // 
            lblHosgeldiniz.AutoSize = true;
            lblHosgeldiniz.BackColor = Color.Transparent;
            lblHosgeldiniz.Font = new Font("Monotype Corsiva", 20F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            lblHosgeldiniz.ForeColor = SystemColors.ButtonShadow;
            lblHosgeldiniz.Location = new Point(226, 85);
            lblHosgeldiniz.Name = "lblHosgeldiniz";
            lblHosgeldiniz.Size = new Size(215, 49);
            lblHosgeldiniz.TabIndex = 7;
            lblHosgeldiniz.Text = "Hoşgeldiniz!";
            // 
            // lblKullaniciAdi
            // 
            lblKullaniciAdi.AutoSize = true;
            lblKullaniciAdi.BackColor = Color.Transparent;
            lblKullaniciAdi.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblKullaniciAdi.ForeColor = Color.White;
            lblKullaniciAdi.Location = new Point(132, 170);
            lblKullaniciAdi.Name = "lblKullaniciAdi";
            lblKullaniciAdi.Size = new Size(129, 25);
            lblKullaniciAdi.TabIndex = 8;
            lblKullaniciAdi.Text = "Kullanıcı Adı : ";
            // 
            // lblSifre
            // 
            lblSifre.AutoSize = true;
            lblSifre.BackColor = Color.Transparent;
            lblSifre.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblSifre.ForeColor = Color.White;
            lblSifre.Location = new Point(132, 207);
            lblSifre.Name = "lblSifre";
            lblSifre.Size = new Size(59, 25);
            lblSifre.TabIndex = 8;
            lblSifre.Text = "Şifre :";
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.Location = new Point(261, 168);
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.Size = new Size(269, 31);
            txtKullaniciAdi.TabIndex = 0;
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(261, 204);
            txtSifre.Name = "txtSifre";
            txtSifre.PasswordChar = '*';
            txtSifre.Size = new Size(269, 31);
            txtSifre.TabIndex = 1;
            // 
            // btnGirisYap
            // 
            btnGirisYap.Location = new Point(514, 264);
            btnGirisYap.Name = "btnGirisYap";
            btnGirisYap.Size = new Size(112, 34);
            btnGirisYap.TabIndex = 2;
            btnGirisYap.Text = "Giriş Yap";
            btnGirisYap.UseVisualStyleBackColor = true;
            btnGirisYap.Click += btnGirisYap_Click;
            // 
            // lblKayit
            // 
            lblKayit.AutoSize = true;
            lblKayit.ForeColor = Color.White;
            lblKayit.Location = new Point(65, 300);
            lblKayit.Name = "lblKayit";
            lblKayit.Size = new Size(189, 25);
            lblKayit.TabIndex = 11;
            lblKayit.Text = "Hala kaydınız yok mu?";
            // 
            // btnKayitOl
            // 
            btnKayitOl.Location = new Point(261, 295);
            btnKayitOl.Name = "btnKayitOl";
            btnKayitOl.Size = new Size(112, 34);
            btnKayitOl.TabIndex = 3;
            btnKayitOl.Text = "Kayıt Ol";
            btnKayitOl.UseVisualStyleBackColor = true;
            btnKayitOl.Click += btnKayitOl_Click;
            // 
            // GirisYap
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(60, 71, 93);
            ClientSize = new Size(695, 371);
            Controls.Add(btnKayitOl);
            Controls.Add(lblKayit);
            Controls.Add(btnGirisYap);
            Controls.Add(txtSifre);
            Controls.Add(txtKullaniciAdi);
            Controls.Add(lblSifre);
            Controls.Add(lblKullaniciAdi);
            Controls.Add(lblHosgeldiniz);
            Controls.Add(lblEmirBank);
            Name = "GirisYap";
            Text = "Emirbank";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblEmirBank;
        private Label lblHosgeldiniz;
        private Label lblKullaniciAdi;
        private Label lblSifre;
        private TextBox txtKullaniciAdi;
        private TextBox txtSifre;
        private Button btnGirisYap;
        private Label lblKayit;
        private Button btnKayitOl;
    }
}