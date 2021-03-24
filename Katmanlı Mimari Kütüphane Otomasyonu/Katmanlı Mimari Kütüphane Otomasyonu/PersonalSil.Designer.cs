namespace Katmanlı_Mimari_Kütüphane_Otomasyonu
{
    partial class PersonalSil
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
            this.temizlebutton = new System.Windows.Forms.Button();
            this.ıdtextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.silbutton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // temizlebutton
            // 
            this.temizlebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.temizlebutton.Location = new System.Drawing.Point(151, 88);
            this.temizlebutton.Name = "temizlebutton";
            this.temizlebutton.Size = new System.Drawing.Size(95, 47);
            this.temizlebutton.TabIndex = 15;
            this.temizlebutton.Text = "temizle";
            this.temizlebutton.UseVisualStyleBackColor = true;
            this.temizlebutton.Click += new System.EventHandler(this.temizlebutton_Click);
            // 
            // ıdtextBox
            // 
            this.ıdtextBox.BackColor = System.Drawing.Color.White;
            this.ıdtextBox.Location = new System.Drawing.Point(39, 47);
            this.ıdtextBox.Name = "ıdtextBox";
            this.ıdtextBox.Size = new System.Drawing.Size(213, 20);
            this.ıdtextBox.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "lütfen silmek istediğiniz personalin ıdsini giriniz.";
            // 
            // silbutton
            // 
            this.silbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.silbutton.Location = new System.Drawing.Point(50, 88);
            this.silbutton.Name = "silbutton";
            this.silbutton.Size = new System.Drawing.Size(95, 47);
            this.silbutton.TabIndex = 12;
            this.silbutton.Text = "Sil";
            this.silbutton.UseVisualStyleBackColor = true;
            this.silbutton.Click += new System.EventHandler(this.silbutton_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(12, 159);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 23);
            this.button1.TabIndex = 58;
            this.button1.Text = "Ana menüye dön";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PersonalSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 185);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.temizlebutton);
            this.Controls.Add(this.ıdtextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.silbutton);
            this.Name = "PersonalSil";
            this.Text = "PersonalSil";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button temizlebutton;
        private System.Windows.Forms.TextBox ıdtextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button silbutton;
        private System.Windows.Forms.Button button1;
    }
}