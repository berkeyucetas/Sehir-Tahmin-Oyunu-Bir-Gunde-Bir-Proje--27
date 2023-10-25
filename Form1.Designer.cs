namespace Şehir_Tahmin_Oyunu
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpSoru = new System.Windows.Forms.GroupBox();
            this.btnBaslat = new System.Windows.Forms.Button();
            this.grpCevap = new System.Windows.Forms.GroupBox();
            this.txtHarf = new System.Windows.Forms.TextBox();
            this.txtKelime = new System.Windows.Forms.TextBox();
            this.btnHarf = new System.Windows.Forms.Button();
            this.btnTahmin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblkalan = new System.Windows.Forms.Label();
            this.lblHarf = new System.Windows.Forms.Label();
            this.grpCevap.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpSoru
            // 
            this.grpSoru.Location = new System.Drawing.Point(12, 68);
            this.grpSoru.Name = "grpSoru";
            this.grpSoru.Size = new System.Drawing.Size(750, 246);
            this.grpSoru.TabIndex = 0;
            this.grpSoru.TabStop = false;
            this.grpSoru.Text = "Soru Alanı";
            // 
            // btnBaslat
            // 
            this.btnBaslat.Location = new System.Drawing.Point(12, 12);
            this.btnBaslat.Name = "btnBaslat";
            this.btnBaslat.Size = new System.Drawing.Size(750, 50);
            this.btnBaslat.TabIndex = 1;
            this.btnBaslat.Text = "Yeni Oyun Başlat";
            this.btnBaslat.UseVisualStyleBackColor = true;
            this.btnBaslat.Click += new System.EventHandler(this.btnBaslat_Click);
            // 
            // grpCevap
            // 
            this.grpCevap.Controls.Add(this.lblkalan);
            this.grpCevap.Controls.Add(this.lblHarf);
            this.grpCevap.Controls.Add(this.label2);
            this.grpCevap.Controls.Add(this.label1);
            this.grpCevap.Controls.Add(this.btnTahmin);
            this.grpCevap.Controls.Add(this.btnHarf);
            this.grpCevap.Controls.Add(this.txtKelime);
            this.grpCevap.Controls.Add(this.txtHarf);
            this.grpCevap.Location = new System.Drawing.Point(12, 320);
            this.grpCevap.Name = "grpCevap";
            this.grpCevap.Size = new System.Drawing.Size(750, 246);
            this.grpCevap.TabIndex = 1;
            this.grpCevap.TabStop = false;
            this.grpCevap.Text = "Cevap Alanı";
            // 
            // txtHarf
            // 
            this.txtHarf.Location = new System.Drawing.Point(6, 47);
            this.txtHarf.Multiline = true;
            this.txtHarf.Name = "txtHarf";
            this.txtHarf.Size = new System.Drawing.Size(160, 59);
            this.txtHarf.TabIndex = 0;
            // 
            // txtKelime
            // 
            this.txtKelime.Location = new System.Drawing.Point(390, 47);
            this.txtKelime.Multiline = true;
            this.txtKelime.Name = "txtKelime";
            this.txtKelime.Size = new System.Drawing.Size(160, 59);
            this.txtKelime.TabIndex = 1;
            // 
            // btnHarf
            // 
            this.btnHarf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHarf.Location = new System.Drawing.Point(179, 47);
            this.btnHarf.Name = "btnHarf";
            this.btnHarf.Size = new System.Drawing.Size(181, 59);
            this.btnHarf.TabIndex = 2;
            this.btnHarf.Text = "Harf Gir";
            this.btnHarf.UseVisualStyleBackColor = true;
            this.btnHarf.Click += new System.EventHandler(this.btnHarf_Click);
            // 
            // btnTahmin
            // 
            this.btnTahmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTahmin.Location = new System.Drawing.Point(563, 47);
            this.btnTahmin.Name = "btnTahmin";
            this.btnTahmin.Size = new System.Drawing.Size(181, 59);
            this.btnTahmin.TabIndex = 3;
            this.btnTahmin.Text = "Tahmin Et";
            this.btnTahmin.UseVisualStyleBackColor = true;
            this.btnTahmin.Click += new System.EventHandler(this.btnTahmin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Girilen Harfler:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Kalan Haklar:";
            // 
            // lblkalan
            // 
            this.lblkalan.AutoSize = true;
            this.lblkalan.Location = new System.Drawing.Point(132, 188);
            this.lblkalan.Name = "lblkalan";
            this.lblkalan.Size = new System.Drawing.Size(18, 20);
            this.lblkalan.TabIndex = 7;
            this.lblkalan.Text = "5";
            // 
            // lblHarf
            // 
            this.lblHarf.AutoSize = true;
            this.lblHarf.Location = new System.Drawing.Point(132, 155);
            this.lblHarf.Name = "lblHarf";
            this.lblHarf.Size = new System.Drawing.Size(18, 20);
            this.lblHarf.TabIndex = 6;
            this.lblHarf.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.ClientSize = new System.Drawing.Size(771, 575);
            this.Controls.Add(this.grpCevap);
            this.Controls.Add(this.btnBaslat);
            this.Controls.Add(this.grpSoru);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpCevap.ResumeLayout(false);
            this.grpCevap.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpSoru;
        private System.Windows.Forms.Button btnBaslat;
        private System.Windows.Forms.GroupBox grpCevap;
        private System.Windows.Forms.TextBox txtHarf;
        private System.Windows.Forms.Button btnTahmin;
        private System.Windows.Forms.Button btnHarf;
        private System.Windows.Forms.TextBox txtKelime;
        private System.Windows.Forms.Label lblkalan;
        private System.Windows.Forms.Label lblHarf;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

