namespace EmirBankBankamatik
{
    partial class AnaEkran
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnParaCek = new Button();
            btnParaYatir = new Button();
            btnBakiye = new Button();
            btnCikis = new Button();
            lblParaCek = new Label();
            lblParaYatir = new Label();
            lblBakiye = new Label();
            lblCikis = new Label();
            lblEmirBank = new Label();
            lblHosgeldiniz = new Label();
            label1 = new Label();
            label2 = new Label();
            btnYeniGirisYap = new Button();
            SuspendLayout();
            // 
            // btnParaCek
            // 
            btnParaCek.Location = new Point(36, 287);
            btnParaCek.Name = "btnParaCek";
            btnParaCek.Size = new Size(69, 43);
            btnParaCek.TabIndex = 0;
            btnParaCek.Text = "✓";
            btnParaCek.UseVisualStyleBackColor = true;
            btnParaCek.Click += btnParaCek_Click;
            // 
            // btnParaYatir
            // 
            btnParaYatir.Location = new Point(36, 352);
            btnParaYatir.Name = "btnParaYatir";
            btnParaYatir.Size = new Size(69, 43);
            btnParaYatir.TabIndex = 1;
            btnParaYatir.Text = "✓";
            btnParaYatir.UseVisualStyleBackColor = true;
            btnParaYatir.Click += btnParaYatir_Click;
            // 
            // btnBakiye
            // 
            btnBakiye.Location = new Point(36, 419);
            btnBakiye.Name = "btnBakiye";
            btnBakiye.Size = new Size(69, 43);
            btnBakiye.TabIndex = 2;
            btnBakiye.Text = "✓";
            btnBakiye.UseVisualStyleBackColor = true;
            btnBakiye.Click += btnBakiye_Click;
            // 
            // btnCikis
            // 
            btnCikis.Location = new Point(36, 483);
            btnCikis.Name = "btnCikis";
            btnCikis.Size = new Size(69, 43);
            btnCikis.TabIndex = 3;
            btnCikis.Text = "✓";
            btnCikis.UseVisualStyleBackColor = true;
            btnCikis.Click += btnCikis_Click;
            // 
            // lblParaCek
            // 
            lblParaCek.AutoSize = true;
            lblParaCek.BackColor = SystemColors.ButtonHighlight;
            lblParaCek.Font = new Font("Segoe UI Emoji", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblParaCek.Location = new Point(131, 284);
            lblParaCek.Name = "lblParaCek";
            lblParaCek.Size = new Size(158, 48);
            lblParaCek.TabIndex = 1;
            lblParaCek.Text = "Para Çek";
            // 
            // lblParaYatir
            // 
            lblParaYatir.AutoSize = true;
            lblParaYatir.BackColor = SystemColors.ButtonHighlight;
            lblParaYatir.Font = new Font("Segoe UI Emoji", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblParaYatir.Location = new Point(131, 352);
            lblParaYatir.Name = "lblParaYatir";
            lblParaYatir.Size = new Size(171, 48);
            lblParaYatir.TabIndex = 1;
            lblParaYatir.Text = "Para Yatır";
            // 
            // lblBakiye
            // 
            lblBakiye.AutoSize = true;
            lblBakiye.BackColor = SystemColors.ButtonHighlight;
            lblBakiye.Font = new Font("Segoe UI Emoji", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBakiye.Location = new Point(131, 419);
            lblBakiye.Name = "lblBakiye";
            lblBakiye.Size = new Size(253, 48);
            lblBakiye.TabIndex = 1;
            lblBakiye.Text = "Bakiye Sorgula";
            // 
            // lblCikis
            // 
            lblCikis.AutoSize = true;
            lblCikis.BackColor = SystemColors.ButtonHighlight;
            lblCikis.Font = new Font("Segoe UI Emoji", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCikis.Location = new Point(131, 483);
            lblCikis.Name = "lblCikis";
            lblCikis.Size = new Size(162, 48);
            lblCikis.TabIndex = 1;
            lblCikis.Text = "Çıkıs Yap";
            // 
            // lblEmirBank
            // 
            lblEmirBank.AutoSize = true;
            lblEmirBank.BackColor = Color.Transparent;
            lblEmirBank.Font = new Font("Wide Latin", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmirBank.ForeColor = Color.Transparent;
            lblEmirBank.Location = new Point(154, 25);
            lblEmirBank.Name = "lblEmirBank";
            lblEmirBank.Size = new Size(561, 59);
            lblEmirBank.TabIndex = 2;
            lblEmirBank.Text = "EMIRBANK";
            // 
            // lblHosgeldiniz
            // 
            lblHosgeldiniz.AutoSize = true;
            lblHosgeldiniz.BackColor = Color.FromArgb(60, 71, 93);
            lblHosgeldiniz.Font = new Font("Monotype Corsiva", 20F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            lblHosgeldiniz.ForeColor = SystemColors.ButtonShadow;
            lblHosgeldiniz.Location = new Point(325, 135);
            lblHosgeldiniz.Name = "lblHosgeldiniz";
            lblHosgeldiniz.Size = new Size(215, 49);
            lblHosgeldiniz.TabIndex = 3;
            lblHosgeldiniz.Text = "Hoşgeldiniz!";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(60, 71, 93);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(269, 231);
            label1.Name = "label1";
            label1.Size = new Size(323, 25);
            label1.TabIndex = 4;
            label1.Text = "Lütfen yapmak istediğiniz işlemi seçiniz.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ButtonHighlight;
            label2.Font = new Font("Segoe UI Emoji", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(498, 483);
            label2.Name = "label2";
            label2.Size = new Size(238, 48);
            label2.TabIndex = 1;
            label2.Text = "Yeni Giris Yap";
            // 
            // btnYeniGirisYap
            // 
            btnYeniGirisYap.Location = new Point(762, 483);
            btnYeniGirisYap.Name = "btnYeniGirisYap";
            btnYeniGirisYap.Size = new Size(69, 43);
            btnYeniGirisYap.TabIndex = 2;
            btnYeniGirisYap.Text = "✓";
            btnYeniGirisYap.UseVisualStyleBackColor = true;
            btnYeniGirisYap.Click += btnYeniGirisYap_Click;
            // 
            // AnaEkran
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Ekran_görüntüsü_2025_02_18_235605;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(867, 589);
            Controls.Add(label1);
            Controls.Add(lblHosgeldiniz);
            Controls.Add(lblEmirBank);
            Controls.Add(lblCikis);
            Controls.Add(label2);
            Controls.Add(lblBakiye);
            Controls.Add(lblParaYatir);
            Controls.Add(lblParaCek);
            Controls.Add(btnCikis);
            Controls.Add(btnYeniGirisYap);
            Controls.Add(btnBakiye);
            Controls.Add(btnParaYatir);
            Controls.Add(btnParaCek);
            Name = "AnaEkran";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnParaCek;
        private Button btnParaYatir;
        private Button btnBakiye;
        private Button btnCikis;
        private Label lblParaCek;
        private Label lblParaYatir;
        private Label lblBakiye;
        private Label lblCikis;
        private Label lblEmirBank;
        private Label lblHosgeldiniz;
        private Label label1;
        private Label label2;
        private Button btnYeniGirisYap;
    }
}
