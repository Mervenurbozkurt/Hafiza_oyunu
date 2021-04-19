namespace kim_milyoner_olmak_istemez_v2
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
            this.GİRİSBUTON = new System.Windows.Forms.Button();
            this.LBLPNUM = new System.Windows.Forms.Label();
            this.textBoxPNUM = new System.Windows.Forms.TextBox();
            this.textBoxSİF = new System.Windows.Forms.TextBox();
            this.labelSİF = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // GİRİSBUTON
            // 
            this.GİRİSBUTON.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.GİRİSBUTON.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GİRİSBUTON.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.GİRİSBUTON.Location = new System.Drawing.Point(732, 493);
            this.GİRİSBUTON.Name = "GİRİSBUTON";
            this.GİRİSBUTON.Size = new System.Drawing.Size(273, 107);
            this.GİRİSBUTON.TabIndex = 0;
            this.GİRİSBUTON.Text = "GİRİŞ YAP";
            this.GİRİSBUTON.UseVisualStyleBackColor = false;
            this.GİRİSBUTON.Click += new System.EventHandler(this.GİRİSBUTON_Click);
            // 
            // LBLPNUM
            // 
            this.LBLPNUM.AutoSize = true;
            this.LBLPNUM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LBLPNUM.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.LBLPNUM.Location = new System.Drawing.Point(473, 362);
            this.LBLPNUM.Name = "LBLPNUM";
            this.LBLPNUM.Size = new System.Drawing.Size(360, 25);
            this.LBLPNUM.TabIndex = 1;
            this.LBLPNUM.Text = "PERSONEL NUMARANIZI GİRİNİZ :";
            // 
            // textBoxPNUM
            // 
            this.textBoxPNUM.Location = new System.Drawing.Point(896, 362);
            this.textBoxPNUM.Name = "textBoxPNUM";
            this.textBoxPNUM.Size = new System.Drawing.Size(128, 22);
            this.textBoxPNUM.TabIndex = 2;
            // 
            // textBoxSİF
            // 
            this.textBoxSİF.Location = new System.Drawing.Point(896, 421);
            this.textBoxSİF.Name = "textBoxSİF";
            this.textBoxSİF.Size = new System.Drawing.Size(128, 22);
            this.textBoxSİF.TabIndex = 3;
            // 
            // labelSİF
            // 
            this.labelSİF.AutoSize = true;
            this.labelSİF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelSİF.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelSİF.Location = new System.Drawing.Point(473, 421);
            this.labelSİF.Name = "labelSİF";
            this.labelSİF.Size = new System.Drawing.Size(209, 25);
            this.labelSİF.TabIndex = 4;
            this.labelSİF.Text = "ŞİFRENİZİ GİRİNİZ :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1290, 678);
            this.Controls.Add(this.labelSİF);
            this.Controls.Add(this.textBoxSİF);
            this.Controls.Add(this.textBoxPNUM);
            this.Controls.Add(this.LBLPNUM);
            this.Controls.Add(this.GİRİSBUTON);
            this.Name = "Form1";
            this.Text = "KÜTÜPHANE";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GİRİSBUTON;
        private System.Windows.Forms.Label LBLPNUM;
        private System.Windows.Forms.TextBox textBoxPNUM;
        private System.Windows.Forms.TextBox textBoxSİF;
        private System.Windows.Forms.Label labelSİF;
    }
}

