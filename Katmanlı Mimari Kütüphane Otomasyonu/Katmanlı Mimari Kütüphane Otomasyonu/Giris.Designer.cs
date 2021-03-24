namespace Katmanlı_Mimari_Kütüphane_Otomasyonu
{
    partial class Giris
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
            this.şifretextBox = new System.Windows.Forms.TextBox();
            this.kullanıcıadıtextBox = new System.Windows.Forms.TextBox();
            this.çıkışbutton = new System.Windows.Forms.Button();
            this.girişbutton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // şifretextBox
            // 
            this.şifretextBox.BackColor = System.Drawing.Color.White;
            this.şifretextBox.Location = new System.Drawing.Point(158, 73);
            this.şifretextBox.Name = "şifretextBox";
            this.şifretextBox.Size = new System.Drawing.Size(225, 20);
            this.şifretextBox.TabIndex = 11;
            this.şifretextBox.Text = "11111111";
            // 
            // kullanıcıadıtextBox
            // 
            this.kullanıcıadıtextBox.BackColor = System.Drawing.Color.White;
            this.kullanıcıadıtextBox.Location = new System.Drawing.Point(158, 30);
            this.kullanıcıadıtextBox.Name = "kullanıcıadıtextBox";
            this.kullanıcıadıtextBox.Size = new System.Drawing.Size(225, 20);
            this.kullanıcıadıtextBox.TabIndex = 10;
            this.kullanıcıadıtextBox.Text = "galip";
            // 
            // çıkışbutton
            // 
            this.çıkışbutton.BackColor = System.Drawing.Color.White;
            this.çıkışbutton.Location = new System.Drawing.Point(252, 120);
            this.çıkışbutton.Name = "çıkışbutton";
            this.çıkışbutton.Size = new System.Drawing.Size(111, 48);
            this.çıkışbutton.TabIndex = 9;
            this.çıkışbutton.Text = "ÇIKIŞ";
            this.çıkışbutton.UseVisualStyleBackColor = false;
            this.çıkışbutton.Click += new System.EventHandler(this.çıkışbutton_Click);
            // 
            // girişbutton
            // 
            this.girişbutton.BackColor = System.Drawing.Color.White;
            this.girişbutton.Location = new System.Drawing.Point(110, 120);
            this.girişbutton.Name = "girişbutton";
            this.girişbutton.Size = new System.Drawing.Size(111, 48);
            this.girişbutton.TabIndex = 8;
            this.girişbutton.Text = "GİRİŞ";
            this.girişbutton.UseVisualStyleBackColor = false;
            this.girişbutton.Click += new System.EventHandler(this.girişbutton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Şifre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // Giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 199);
            this.Controls.Add(this.şifretextBox);
            this.Controls.Add(this.kullanıcıadıtextBox);
            this.Controls.Add(this.çıkışbutton);
            this.Controls.Add(this.girişbutton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Giris";
            this.Text = "Giris";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox şifretextBox;
        private System.Windows.Forms.TextBox kullanıcıadıtextBox;
        private System.Windows.Forms.Button çıkışbutton;
        private System.Windows.Forms.Button girişbutton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

