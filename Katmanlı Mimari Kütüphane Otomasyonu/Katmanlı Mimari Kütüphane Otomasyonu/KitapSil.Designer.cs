namespace Katmanlı_Mimari_Kütüphane_Otomasyonu
{
    partial class KitapSil
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
            this.kitapıdtextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.silbutton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // temizlebutton
            // 
            this.temizlebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.temizlebutton.Location = new System.Drawing.Point(210, 298);
            this.temizlebutton.Name = "temizlebutton";
            this.temizlebutton.Size = new System.Drawing.Size(95, 47);
            this.temizlebutton.TabIndex = 7;
            this.temizlebutton.Text = "temizle";
            this.temizlebutton.UseVisualStyleBackColor = true;
            this.temizlebutton.Click += new System.EventHandler(this.temizlebutton_Click);
            // 
            // kitapıdtextBox
            // 
            this.kitapıdtextBox.BackColor = System.Drawing.Color.White;
            this.kitapıdtextBox.Location = new System.Drawing.Point(98, 257);
            this.kitapıdtextBox.Name = "kitapıdtextBox";
            this.kitapıdtextBox.Size = new System.Drawing.Size(213, 20);
            this.kitapıdtextBox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(71, 231);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "lütfen silmek istediğiniz kitabın kitap Idsini giriniz.";
            // 
            // silbutton
            // 
            this.silbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.silbutton.Location = new System.Drawing.Point(109, 298);
            this.silbutton.Name = "silbutton";
            this.silbutton.Size = new System.Drawing.Size(95, 47);
            this.silbutton.TabIndex = 4;
            this.silbutton.Text = "Sil";
            this.silbutton.UseVisualStyleBackColor = true;
            this.silbutton.Click += new System.EventHandler(this.silbutton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(458, 214);
            this.dataGridView1.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(12, 365);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 23);
            this.button1.TabIndex = 58;
            this.button1.Text = "Ana menüye dön";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // KitapSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 391);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.temizlebutton);
            this.Controls.Add(this.kitapıdtextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.silbutton);
            this.Name = "KitapSil";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.KitapSil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button temizlebutton;
        private System.Windows.Forms.TextBox kitapıdtextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button silbutton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
    }
}