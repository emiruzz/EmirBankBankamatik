namespace EmirBankBankamatik
{
    partial class MailKontrol
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
            lblMail = new Label();
            txtMail = new TextBox();
            chcOnayliyorum = new CheckBox();
            btnSifreAl = new Button();
            SuspendLayout();
            // 
            // lblEmirBank
            // 
            lblEmirBank.AutoSize = true;
            lblEmirBank.BackColor = Color.Transparent;
            lblEmirBank.Font = new Font("Wide Latin", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmirBank.ForeColor = Color.White;
            lblEmirBank.Location = new Point(62, 36);
            lblEmirBank.Name = "lblEmirBank";
            lblEmirBank.Size = new Size(561, 59);
            lblEmirBank.TabIndex = 5;
            lblEmirBank.Text = "EMIRBANK";
            // 
            // lblMail
            // 
            lblMail.AutoSize = true;
            lblMail.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblMail.ForeColor = Color.White;
            lblMail.Location = new Point(103, 145);
            lblMail.Name = "lblMail";
            lblMail.Size = new Size(474, 28);
            lblMail.TabIndex = 7;
            lblMail.Text = "Lütfen doğrulama işleminiz için mail adresinizi giriniz.";
            // 
            // txtMail
            // 
            txtMail.Location = new Point(198, 187);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(283, 31);
            txtMail.TabIndex = 0;
            // 
            // chcOnayliyorum
            // 
            chcOnayliyorum.AutoSize = true;
            chcOnayliyorum.BackColor = Color.Transparent;
            chcOnayliyorum.ForeColor = Color.White;
            chcOnayliyorum.Location = new Point(507, 216);
            chcOnayliyorum.Name = "chcOnayliyorum";
            chcOnayliyorum.Size = new Size(144, 29);
            chcOnayliyorum.TabIndex = 1;
            chcOnayliyorum.Text = "Onaylıyorum.";
            chcOnayliyorum.UseVisualStyleBackColor = false;
            // 
            // btnSifreAl
            // 
            btnSifreAl.Location = new Point(503, 251);
            btnSifreAl.Name = "btnSifreAl";
            btnSifreAl.Size = new Size(146, 34);
            btnSifreAl.TabIndex = 2;
            btnSifreAl.Text = "Şifre Al";
            btnSifreAl.UseVisualStyleBackColor = true;
            btnSifreAl.Click += btnSifreAl_Click;
            // 
            // MailKontrol
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(60, 71, 93);
            ClientSize = new Size(695, 307);
            Controls.Add(btnSifreAl);
            Controls.Add(chcOnayliyorum);
            Controls.Add(txtMail);
            Controls.Add(lblMail);
            Controls.Add(lblEmirBank);
            Name = "MailKontrol";
            Text = "Mail Doğrulama";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblEmirBank;
        private Label lblMail;
        private TextBox txtMail;
        private CheckBox chcOnayliyorum;
        private Button btnSifreAl;
    }
}