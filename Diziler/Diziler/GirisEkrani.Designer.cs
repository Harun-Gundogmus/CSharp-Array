namespace Diziler
{
    partial class GirisEkrani
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
            this.lbl_KullaniciAdi = new System.Windows.Forms.Label();
            this.lbl_Sifre = new System.Windows.Forms.Label();
            this.txt_KullanciAdi = new System.Windows.Forms.TextBox();
            this.txt_Sifre = new System.Windows.Forms.TextBox();
            this.btn_GirisYap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_KullaniciAdi
            // 
            this.lbl_KullaniciAdi.AutoSize = true;
            this.lbl_KullaniciAdi.Location = new System.Drawing.Point(26, 28);
            this.lbl_KullaniciAdi.Name = "lbl_KullaniciAdi";
            this.lbl_KullaniciAdi.Size = new System.Drawing.Size(99, 20);
            this.lbl_KullaniciAdi.TabIndex = 0;
            this.lbl_KullaniciAdi.Text = "Kullanıcı Adı: ";
            // 
            // lbl_Sifre
            // 
            this.lbl_Sifre.AutoSize = true;
            this.lbl_Sifre.Location = new System.Drawing.Point(83, 68);
            this.lbl_Sifre.Name = "lbl_Sifre";
            this.lbl_Sifre.Size = new System.Drawing.Size(42, 20);
            this.lbl_Sifre.TabIndex = 1;
            this.lbl_Sifre.Text = "Şifre:";
            // 
            // txt_KullanciAdi
            // 
            this.txt_KullanciAdi.Location = new System.Drawing.Point(131, 25);
            this.txt_KullanciAdi.Name = "txt_KullanciAdi";
            this.txt_KullanciAdi.Size = new System.Drawing.Size(125, 27);
            this.txt_KullanciAdi.TabIndex = 2;
            // 
            // txt_Sifre
            // 
            this.txt_Sifre.Location = new System.Drawing.Point(131, 65);
            this.txt_Sifre.Name = "txt_Sifre";
            this.txt_Sifre.Size = new System.Drawing.Size(125, 27);
            this.txt_Sifre.TabIndex = 3;
            this.txt_Sifre.UseSystemPasswordChar = true;
            // 
            // btn_GirisYap
            // 
            this.btn_GirisYap.Location = new System.Drawing.Point(67, 115);
            this.btn_GirisYap.Name = "btn_GirisYap";
            this.btn_GirisYap.Size = new System.Drawing.Size(156, 58);
            this.btn_GirisYap.TabIndex = 4;
            this.btn_GirisYap.Text = "Giriş Yap";
            this.btn_GirisYap.UseVisualStyleBackColor = true;
            this.btn_GirisYap.Click += new System.EventHandler(this.btn_GirisYap_Click);
            // 
            // GirisEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 219);
            this.Controls.Add(this.btn_GirisYap);
            this.Controls.Add(this.txt_Sifre);
            this.Controls.Add(this.txt_KullanciAdi);
            this.Controls.Add(this.lbl_Sifre);
            this.Controls.Add(this.lbl_KullaniciAdi);
            this.Name = "GirisEkrani";
            this.Text = "GirisEkrani";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_KullaniciAdi;
        private Label lbl_Sifre;
        private TextBox txt_KullanciAdi;
        private TextBox txt_Sifre;
        private Button btn_GirisYap;
    }
}