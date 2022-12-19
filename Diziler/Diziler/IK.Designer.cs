namespace Diziler
{
    partial class IK
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
            this.btn_KaydetGoster = new System.Windows.Forms.Button();
            this.lbox_Liste = new System.Windows.Forms.ListBox();
            this.lbl_CalisanAra = new System.Windows.Forms.Label();
            this.txt_Calisan = new System.Windows.Forms.TextBox();
            this.btn_Ara = new System.Windows.Forms.Button();
            this.lbl_SonKayit = new System.Windows.Forms.Label();
            this.txt_SonKayit = new System.Windows.Forms.TextBox();
            this.btn_KaydiGetir = new System.Windows.Forms.Button();
            this.btn_Gelir = new System.Windows.Forms.Button();
            this.txt_Gelir = new System.Windows.Forms.TextBox();
            this.lbl_Gelir = new System.Windows.Forms.Label();
            this.lbl_Mesaj = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_KaydetGoster
            // 
            this.btn_KaydetGoster.Location = new System.Drawing.Point(17, 95);
            this.btn_KaydetGoster.Name = "btn_KaydetGoster";
            this.btn_KaydetGoster.Size = new System.Drawing.Size(357, 49);
            this.btn_KaydetGoster.TabIndex = 0;
            this.btn_KaydetGoster.Text = "Kaydet ve Göster";
            this.btn_KaydetGoster.UseVisualStyleBackColor = true;
            this.btn_KaydetGoster.Click += new System.EventHandler(this.btn_KaydetGoster_Click);
            // 
            // lbox_Liste
            // 
            this.lbox_Liste.FormattingEnabled = true;
            this.lbox_Liste.ItemHeight = 20;
            this.lbox_Liste.Location = new System.Drawing.Point(17, 150);
            this.lbox_Liste.Name = "lbox_Liste";
            this.lbox_Liste.Size = new System.Drawing.Size(357, 304);
            this.lbox_Liste.TabIndex = 1;
            // 
            // lbl_CalisanAra
            // 
            this.lbl_CalisanAra.AutoSize = true;
            this.lbl_CalisanAra.Location = new System.Drawing.Point(11, 464);
            this.lbl_CalisanAra.Name = "lbl_CalisanAra";
            this.lbl_CalisanAra.Size = new System.Drawing.Size(90, 20);
            this.lbl_CalisanAra.TabIndex = 2;
            this.lbl_CalisanAra.Text = "Çalışan Ara: ";
            // 
            // txt_Calisan
            // 
            this.txt_Calisan.Location = new System.Drawing.Point(107, 461);
            this.txt_Calisan.Name = "txt_Calisan";
            this.txt_Calisan.Size = new System.Drawing.Size(149, 27);
            this.txt_Calisan.TabIndex = 3;
            // 
            // btn_Ara
            // 
            this.btn_Ara.Location = new System.Drawing.Point(262, 460);
            this.btn_Ara.Name = "btn_Ara";
            this.btn_Ara.Size = new System.Drawing.Size(112, 29);
            this.btn_Ara.TabIndex = 4;
            this.btn_Ara.Text = "Ara";
            this.btn_Ara.UseVisualStyleBackColor = true;
            this.btn_Ara.Click += new System.EventHandler(this.btn_Ara_Click);
            // 
            // lbl_SonKayit
            // 
            this.lbl_SonKayit.AutoSize = true;
            this.lbl_SonKayit.Location = new System.Drawing.Point(17, 497);
            this.lbl_SonKayit.Name = "lbl_SonKayit";
            this.lbl_SonKayit.Size = new System.Drawing.Size(78, 20);
            this.lbl_SonKayit.TabIndex = 5;
            this.lbl_SonKayit.Text = "Son Kayıt :";
            // 
            // txt_SonKayit
            // 
            this.txt_SonKayit.Location = new System.Drawing.Point(107, 494);
            this.txt_SonKayit.Name = "txt_SonKayit";
            this.txt_SonKayit.Size = new System.Drawing.Size(149, 27);
            this.txt_SonKayit.TabIndex = 6;
            // 
            // btn_KaydiGetir
            // 
            this.btn_KaydiGetir.Location = new System.Drawing.Point(262, 493);
            this.btn_KaydiGetir.Name = "btn_KaydiGetir";
            this.btn_KaydiGetir.Size = new System.Drawing.Size(112, 29);
            this.btn_KaydiGetir.TabIndex = 7;
            this.btn_KaydiGetir.Text = "Kayıt Getir";
            this.btn_KaydiGetir.UseVisualStyleBackColor = true;
            this.btn_KaydiGetir.Click += new System.EventHandler(this.btn_KaydiGetir_Click);
            // 
            // btn_Gelir
            // 
            this.btn_Gelir.Location = new System.Drawing.Point(262, 526);
            this.btn_Gelir.Name = "btn_Gelir";
            this.btn_Gelir.Size = new System.Drawing.Size(112, 29);
            this.btn_Gelir.TabIndex = 10;
            this.btn_Gelir.Text = "Gelir Göster";
            this.btn_Gelir.UseVisualStyleBackColor = true;
            this.btn_Gelir.Click += new System.EventHandler(this.btn_Gelir_Click);
            // 
            // txt_Gelir
            // 
            this.txt_Gelir.Location = new System.Drawing.Point(107, 527);
            this.txt_Gelir.Name = "txt_Gelir";
            this.txt_Gelir.Size = new System.Drawing.Size(149, 27);
            this.txt_Gelir.TabIndex = 9;
            // 
            // lbl_Gelir
            // 
            this.lbl_Gelir.AutoSize = true;
            this.lbl_Gelir.Location = new System.Drawing.Point(23, 530);
            this.lbl_Gelir.Name = "lbl_Gelir";
            this.lbl_Gelir.Size = new System.Drawing.Size(72, 20);
            this.lbl_Gelir.TabIndex = 8;
            this.lbl_Gelir.Text = "Üst Gelir :";
            // 
            // lbl_Mesaj
            // 
            this.lbl_Mesaj.AutoSize = true;
            this.lbl_Mesaj.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Mesaj.Location = new System.Drawing.Point(23, 18);
            this.lbl_Mesaj.Name = "lbl_Mesaj";
            this.lbl_Mesaj.Size = new System.Drawing.Size(118, 50);
            this.lbl_Mesaj.TabIndex = 11;
            this.lbl_Mesaj.Text = "Mesaj";
            // 
            // IK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 569);
            this.Controls.Add(this.lbl_Mesaj);
            this.Controls.Add(this.btn_Gelir);
            this.Controls.Add(this.txt_Gelir);
            this.Controls.Add(this.lbl_Gelir);
            this.Controls.Add(this.btn_KaydiGetir);
            this.Controls.Add(this.txt_SonKayit);
            this.Controls.Add(this.lbl_SonKayit);
            this.Controls.Add(this.btn_Ara);
            this.Controls.Add(this.txt_Calisan);
            this.Controls.Add(this.lbl_CalisanAra);
            this.Controls.Add(this.lbox_Liste);
            this.Controls.Add(this.btn_KaydetGoster);
            this.Name = "IK";
            this.Text = "IK";
            this.Load += new System.EventHandler(this.IK_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_KaydetGoster;
        private ListBox lbox_Liste;
        private Label lbl_CalisanAra;
        private TextBox txt_Calisan;
        private Button btn_Ara;
        private Label lbl_SonKayit;
        private TextBox txt_SonKayit;
        private Button btn_KaydiGetir;
        private Button btn_Gelir;
        private TextBox txt_Gelir;
        private Label lbl_Gelir;
        private Label lbl_Mesaj;
    }
}