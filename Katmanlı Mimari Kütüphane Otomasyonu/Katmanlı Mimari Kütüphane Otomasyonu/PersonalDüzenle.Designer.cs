namespace Katmanlı_Mimari_Kütüphane_Otomasyonu
{
    partial class PersonalDüzenle
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
            this.kaydetbutton = new System.Windows.Forms.Button();
            this.Temizlebutton = new System.Windows.Forms.Button();
            this.şifretextBox = new System.Windows.Forms.TextBox();
            this.kullanıcıadıtextBox = new System.Windows.Forms.TextBox();
            this.soyadıtextBox = new System.Windows.Forms.TextBox();
            this.adıtextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // kaydetbutton
            // 
            this.kaydetbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kaydetbutton.Location = new System.Drawing.Point(342, 81);
            this.kaydetbutton.Name = "kaydetbutton";
            this.kaydetbutton.Size = new System.Drawing.Size(108, 55);
            this.kaydetbutton.TabIndex = 65;
            this.kaydetbutton.Text = "Kaydet";
            this.kaydetbutton.UseVisualStyleBackColor = true;
            this.kaydetbutton.Click += new System.EventHandler(this.kaydetbutton_Click);
            // 
            // Temizlebutton
            // 
            this.Temizlebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Temizlebutton.Location = new System.Drawing.Point(342, 12);
            this.Temizlebutton.Name = "Temizlebutton";
            this.Temizlebutton.Size = new System.Drawing.Size(108, 55);
            this.Temizlebutton.TabIndex = 64;
            this.Temizlebutton.Text = "Temizle";
            this.Temizlebutton.UseVisualStyleBackColor = true;
            this.Temizlebutton.Click += new System.EventHandler(this.Temizlebutton_Click);
            // 
            // şifretextBox
            // 
            this.şifretextBox.BackColor = System.Drawing.Color.White;
            this.şifretextBox.Location = new System.Drawing.Point(93, 116);
            this.şifretextBox.Name = "şifretextBox";
            this.şifretextBox.Size = new System.Drawing.Size(187, 20);
            this.şifretextBox.TabIndex = 63;
            // 
            // kullanıcıadıtextBox
            // 
            this.kullanıcıadıtextBox.BackColor = System.Drawing.Color.White;
            this.kullanıcıadıtextBox.Location = new System.Drawing.Point(93, 81);
            this.kullanıcıadıtextBox.Name = "kullanıcıadıtextBox";
            this.kullanıcıadıtextBox.Size = new System.Drawing.Size(187, 20);
            this.kullanıcıadıtextBox.TabIndex = 62;
            // 
            // soyadıtextBox
            // 
            this.soyadıtextBox.BackColor = System.Drawing.Color.White;
            this.soyadıtextBox.Location = new System.Drawing.Point(93, 47);
            this.soyadıtextBox.Name = "soyadıtextBox";
            this.soyadıtextBox.Size = new System.Drawing.Size(187, 20);
            this.soyadıtextBox.TabIndex = 61;
            // 
            // adıtextBox
            // 
            this.adıtextBox.BackColor = System.Drawing.Color.White;
            this.adıtextBox.Location = new System.Drawing.Point(93, 12);
            this.adıtextBox.Name = "adıtextBox";
            this.adıtextBox.Size = new System.Drawing.Size(187, 20);
            this.adıtextBox.TabIndex = 60;
            this.adıtextBox.TextChanged += new System.EventHandler(this.adıtextBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(5, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 59;
            this.label4.Text = "Şifre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(5, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 58;
            this.label3.Text = "Kullanıcı Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(5, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 57;
            this.label2.Text = "Personal Soyadı:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(5, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 56;
            this.label1.Text = "Personal Adı:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(8, 167);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 23);
            this.button1.TabIndex = 66;
            this.button1.Text = "Ana menüye dön";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PersonalDüzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 192);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.kaydetbutton);
            this.Controls.Add(this.Temizlebutton);
            this.Controls.Add(this.şifretextBox);
            this.Controls.Add(this.kullanıcıadıtextBox);
            this.Controls.Add(this.soyadıtextBox);
            this.Controls.Add(this.adıtextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PersonalDüzenle";
            this.Text = "PersonalDüzenle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button kaydetbutton;
        private System.Windows.Forms.Button Temizlebutton;
        private System.Windows.Forms.TextBox şifretextBox;
        private System.Windows.Forms.TextBox kullanıcıadıtextBox;
        private System.Windows.Forms.TextBox soyadıtextBox;
        private System.Windows.Forms.TextBox adıtextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}