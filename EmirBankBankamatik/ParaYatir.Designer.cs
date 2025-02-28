namespace EmirBankBankamatik
{
    partial class ParaYatir
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
            lblYatirilacakTutar = new Label();
            txtYatirilacakTutar = new TextBox();
            lblTl = new Label();
            chcOnayliyorum = new CheckBox();
            btnParayiYatir = new Button();
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
            lblEmirBank.TabIndex = 3;
            lblEmirBank.Text = "EMIRBANK";
            // 
            // lblYatirilacakTutar
            // 
            lblYatirilacakTutar.AutoSize = true;
            lblYatirilacakTutar.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblYatirilacakTutar.Location = new Point(160, 111);
            lblYatirilacakTutar.Name = "lblYatirilacakTutar";
            lblYatirilacakTutar.Size = new Size(356, 28);
            lblYatirilacakTutar.TabIndex = 4;
            lblYatirilacakTutar.Text = "Lütfen yatırmak istediğiniz tutarı giriniz.";
           
            // 
            // txtYatirilacakTutar
            // 
            txtYatirilacakTutar.Location = new Point(254, 168);
            txtYatirilacakTutar.Name = "txtYatirilacakTutar";
            txtYatirilacakTutar.Size = new Size(150, 31);
            txtYatirilacakTutar.TabIndex = 0;
            // 
            // lblTl
            // 
            lblTl.AutoSize = true;
            lblTl.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblTl.Location = new Point(410, 169);
            lblTl.Name = "lblTl";
            lblTl.Size = new Size(25, 30);
            lblTl.TabIndex = 6;
            lblTl.Text = "₺";
            // 
            // chcOnayliyorum
            // 
            chcOnayliyorum.AutoSize = true;
            chcOnayliyorum.Location = new Point(445, 214);
            chcOnayliyorum.Name = "chcOnayliyorum";
            chcOnayliyorum.Size = new Size(144, 29);
            chcOnayliyorum.TabIndex = 1;
            chcOnayliyorum.Text = "Onaylıyorum.";
            chcOnayliyorum.UseVisualStyleBackColor = true;
            // 
            // btnParayiYatir
            // 
            btnParayiYatir.Location = new Point(443, 249);
            btnParayiYatir.Name = "btnParayiYatir";
            btnParayiYatir.Size = new Size(146, 34);
            btnParayiYatir.TabIndex = 2;
            btnParayiYatir.Text = "Parayı Yatır";
            btnParayiYatir.UseVisualStyleBackColor = true;
            btnParayiYatir.Click += btnParayiYatir_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(695, 307);
            Controls.Add(btnParayiYatir);
            Controls.Add(chcOnayliyorum);
            Controls.Add(lblTl);
            Controls.Add(txtYatirilacakTutar);
            Controls.Add(lblYatirilacakTutar);
            Controls.Add(lblEmirBank);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblEmirBank;
        private Label lblYatirilacakTutar;
        private TextBox txtYatirilacakTutar;
        private Label lblTl;
        private CheckBox chcOnayliyorum;
        private Button btnParayiYatir;
    }
}