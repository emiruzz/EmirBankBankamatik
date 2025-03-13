namespace EmirBankBankamatik
{
    partial class ParaCek
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
            lblCekilecekTutar = new Label();
            txtCekilecekTutar = new TextBox();
            lblTl = new Label();
            chcOnayliyorumParaCek = new CheckBox();
            btnParayiCek = new Button();
            SuspendLayout();
            // 
            // lblEmirBank
            // 
            lblEmirBank.AutoSize = true;
            lblEmirBank.BackColor = Color.Transparent;
            lblEmirBank.Font = new Font("Wide Latin", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmirBank.ForeColor = Color.FromArgb(60, 71, 93);
            lblEmirBank.Location = new Point(62, 36);
            lblEmirBank.Name = "lblEmirBank";
            lblEmirBank.Size = new Size(561, 59);
            lblEmirBank.TabIndex = 4;
            lblEmirBank.Text = "EMIRBANK";
            // 
            // lblCekilecekTutar
            // 
            lblCekilecekTutar.AutoSize = true;
            lblCekilecekTutar.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblCekilecekTutar.Location = new Point(167, 111);
            lblCekilecekTutar.Name = "lblCekilecekTutar";
            lblCekilecekTutar.Size = new Size(346, 28);
            lblCekilecekTutar.TabIndex = 5;
            lblCekilecekTutar.Text = "Lütfen çekmek istediğiniz tutarı giriniz.";
            // 
            // txtCekilecekTutar
            // 
            txtCekilecekTutar.Location = new Point(254, 168);
            txtCekilecekTutar.Name = "txtCekilecekTutar";
            txtCekilecekTutar.Size = new Size(150, 31);
            txtCekilecekTutar.TabIndex = 0;
            // 
            // lblTl
            // 
            lblTl.AutoSize = true;
            lblTl.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblTl.Location = new Point(410, 169);
            lblTl.Name = "lblTl";
            lblTl.Size = new Size(25, 30);
            lblTl.TabIndex = 7;
            lblTl.Text = "₺";
            // 
            // chcOnayliyorumParaCek
            // 
            chcOnayliyorumParaCek.AutoSize = true;
            chcOnayliyorumParaCek.Location = new Point(445, 214);
            chcOnayliyorumParaCek.Name = "chcOnayliyorumParaCek";
            chcOnayliyorumParaCek.Size = new Size(144, 29);
            chcOnayliyorumParaCek.TabIndex = 1;
            chcOnayliyorumParaCek.Text = "Onaylıyorum.";
            chcOnayliyorumParaCek.UseVisualStyleBackColor = true;
            // 
            // btnParayiCek
            // 
            btnParayiCek.Location = new Point(443, 249);
            btnParayiCek.Name = "btnParayiCek";
            btnParayiCek.Size = new Size(146, 34);
            btnParayiCek.TabIndex = 2;
            btnParayiCek.Text = "Parayı Çek";
            btnParayiCek.UseVisualStyleBackColor = true;
            btnParayiCek.Click += btnParayiCek_Click;
            // 
            // ParaCek
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(695, 307);
            Controls.Add(btnParayiCek);
            Controls.Add(chcOnayliyorumParaCek);
            Controls.Add(lblTl);
            Controls.Add(txtCekilecekTutar);
            Controls.Add(lblCekilecekTutar);
            Controls.Add(lblEmirBank);
            Name = "ParaCek";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EmirBank";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblEmirBank;
        private Label lblCekilecekTutar;
        private TextBox txtCekilecekTutar;
        private Label lblTl;
        private CheckBox chcOnayliyorumParaCek;
        private Button btnParayiCek;
    }
}