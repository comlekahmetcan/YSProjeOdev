namespace TeknikKartOdev1
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnTeknikKartEKLE = new System.Windows.Forms.Button();
            this.btnKartGoruntele = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btnTeknikKartEKLE
            // 
            this.btnTeknikKartEKLE.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnTeknikKartEKLE.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTeknikKartEKLE.Location = new System.Drawing.Point(12, 58);
            this.btnTeknikKartEKLE.Name = "btnTeknikKartEKLE";
            this.btnTeknikKartEKLE.Size = new System.Drawing.Size(228, 179);
            this.btnTeknikKartEKLE.TabIndex = 6;
            this.btnTeknikKartEKLE.Text = "Teknik Kart EKLE";
            this.btnTeknikKartEKLE.UseVisualStyleBackColor = false;
            this.btnTeknikKartEKLE.Click += new System.EventHandler(this.txtTeknikKartEKLE_Click);
            // 
            // btnKartGoruntele
            // 
            this.btnKartGoruntele.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnKartGoruntele.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKartGoruntele.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnKartGoruntele.Location = new System.Drawing.Point(277, 58);
            this.btnKartGoruntele.Name = "btnKartGoruntele";
            this.btnKartGoruntele.Size = new System.Drawing.Size(228, 179);
            this.btnKartGoruntele.TabIndex = 6;
            this.btnKartGoruntele.Text = "Teknik Kart Goruntule/Güncelle";
            this.btnKartGoruntele.UseVisualStyleBackColor = false;
            this.btnKartGoruntele.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(538, 323);
            this.Controls.Add(this.btnKartGoruntele);
            this.Controls.Add(this.btnTeknikKartEKLE);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btnTeknikKartEKLE;
        private System.Windows.Forms.Button btnKartGoruntele;
    }
}

