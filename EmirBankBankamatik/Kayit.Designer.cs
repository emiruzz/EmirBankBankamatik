namespace EmirBankBankamatik
{
    partial class Kayit
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtKullaniciAdi = new TextBox();
            txtSifreTekrar = new TextBox();
            txtSifre = new TextBox();
            chcOnayliyorum = new CheckBox();
            lblMail = new Label();
            btnKayit = new Button();
            pnlKayit = new Panel();
            txtSixth = new TextBox();
            txtFifth = new TextBox();
            txtFourth = new TextBox();
            txtThird = new TextBox();
            txtSecond = new TextBox();
            txtFirst = new TextBox();
            pnlKayit.SuspendLayout();
            SuspendLayout();
            // 
            // lblEmirBank
            // 
            lblEmirBank.AutoSize = true;
            lblEmirBank.BackColor = Color.Transparent;
            lblEmirBank.Font = new Font("Wide Latin", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmirBank.ForeColor = Color.FromArgb(60, 71, 93);
            lblEmirBank.Location = new Point(63, 24);
            lblEmirBank.Name = "lblEmirBank";
            lblEmirBank.Size = new Size(561, 59);
            lblEmirBank.TabIndex = 4;
            lblEmirBank.Text = "EMIRBANK";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label1.Location = new Point(36, 61);
            label1.Name = "label1";
            label1.Size = new Size(124, 25);
            label1.TabIndex = 5;
            label1.Text = "Kullanıcı Adı :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label2.Location = new Point(36, 101);
            label2.Name = "label2";
            label2.Size = new Size(64, 25);
            label2.TabIndex = 5;
            label2.Text = "Şifre : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label3.Location = new Point(36, 140);
            label3.Name = "label3";
            label3.Size = new Size(114, 25);
            label3.TabIndex = 5;
            label3.Text = "Şifre Tekrar :";
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.Location = new Point(190, 61);
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.Size = new Size(261, 31);
            txtKullaniciAdi.TabIndex = 6;
            // 
            // txtSifreTekrar
            // 
            txtSifreTekrar.Location = new Point(190, 140);
            txtSifreTekrar.Name = "txtSifreTekrar";
            txtSifreTekrar.PasswordChar = '*';
            txtSifreTekrar.Size = new Size(261, 31);
            txtSifreTekrar.TabIndex = 8;
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(190, 101);
            txtSifre.Name = "txtSifre";
            txtSifre.PasswordChar = '*';
            txtSifre.Size = new Size(261, 31);
            txtSifre.TabIndex = 7;
            // 
            // chcOnayliyorum
            // 
            chcOnayliyorum.AutoSize = true;
            chcOnayliyorum.Location = new Point(278, 319);
            chcOnayliyorum.Name = "chcOnayliyorum";
            chcOnayliyorum.Size = new Size(144, 29);
            chcOnayliyorum.TabIndex = 9;
            chcOnayliyorum.Text = "Onaylıyorum.";
            chcOnayliyorum.UseVisualStyleBackColor = true;
            // 
            // lblMail
            // 
            lblMail.AutoSize = true;
            lblMail.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblMail.Location = new Point(92, 91);
            lblMail.Name = "lblMail";
            lblMail.Size = new Size(504, 25);
            lblMail.TabIndex = 5;
            lblMail.Text = "Lütfen mail adresinize gönderilen 6 haneli şifreyi tuşlayınız.";
            // 
            // btnKayit
            // 
            btnKayit.Location = new Point(502, 316);
            btnKayit.Name = "btnKayit";
            btnKayit.Size = new Size(112, 34);
            btnKayit.TabIndex = 10;
            btnKayit.Text = "Kayıt Ol";
            btnKayit.UseVisualStyleBackColor = true;
            btnKayit.Click += btnKayit_Click;
            // 
            // pnlKayit
            // 
            pnlKayit.Controls.Add(txtSixth);
            pnlKayit.Controls.Add(txtFifth);
            pnlKayit.Controls.Add(txtFourth);
            pnlKayit.Controls.Add(txtThird);
            pnlKayit.Controls.Add(txtSecond);
            pnlKayit.Controls.Add(txtFirst);
            pnlKayit.Controls.Add(txtSifreTekrar);
            pnlKayit.Controls.Add(label1);
            pnlKayit.Controls.Add(txtSifre);
            pnlKayit.Controls.Add(label2);
            pnlKayit.Controls.Add(label3);
            pnlKayit.Controls.Add(txtKullaniciAdi);
            pnlKayit.Location = new Point(102, 119);
            pnlKayit.Name = "pnlKayit";
            pnlKayit.Size = new Size(482, 179);
            pnlKayit.TabIndex = 6;
            // 
            // txtSixth
            // 
            txtSixth.Location = new Point(313, 3);
            txtSixth.MaxLength = 1;
            txtSixth.Name = "txtSixth";
            txtSixth.Size = new Size(31, 31);
            txtSixth.TabIndex = 5;
            // 
            // txtFifth
            // 
            txtFifth.Location = new Point(276, 3);
            txtFifth.MaxLength = 1;
            txtFifth.Name = "txtFifth";
            txtFifth.Size = new Size(31, 31);
            txtFifth.TabIndex = 4;
            // 
            // txtFourth
            // 
            txtFourth.Location = new Point(239, 3);
            txtFourth.MaxLength = 1;
            txtFourth.Name = "txtFourth";
            txtFourth.Size = new Size(31, 31);
            txtFourth.TabIndex = 3;
            // 
            // txtThird
            // 
            txtThird.Location = new Point(202, 3);
            txtThird.MaxLength = 1;
            txtThird.Name = "txtThird";
            txtThird.Size = new Size(31, 31);
            txtThird.TabIndex = 2;
            // 
            // txtSecond
            // 
            txtSecond.Location = new Point(165, 3);
            txtSecond.MaxLength = 1;
            txtSecond.Name = "txtSecond";
            txtSecond.Size = new Size(31, 31);
            txtSecond.TabIndex = 1;
            // 
            // txtFirst
            // 
            txtFirst.Location = new Point(128, 3);
            txtFirst.MaxLength = 1;
            txtFirst.Name = "txtFirst";
            txtFirst.Size = new Size(31, 31);
            txtFirst.TabIndex = 0;
            // 
            // Kayit
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(695, 371);
            Controls.Add(pnlKayit);
            Controls.Add(chcOnayliyorum);
            Controls.Add(lblMail);
            Controls.Add(btnKayit);
            Controls.Add(lblEmirBank);
            Name = "Kayit";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EmirBank";
            Load += Kayit_Load;
            pnlKayit.ResumeLayout(false);
            pnlKayit.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblEmirBank;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtKullaniciAdi;
        private TextBox txtSifreTekrar;
        private TextBox txtSifre;
        private CheckBox chcOnayliyorum;
        private Label lblMail;
        private Button btnKayit;
        private Panel pnlKayit;
        private TextBox txtSixth;
        private TextBox txtFifth;
        private TextBox txtFourth;
        private TextBox txtThird;
        private TextBox txtSecond;
        private TextBox txtFirst;
    }
}