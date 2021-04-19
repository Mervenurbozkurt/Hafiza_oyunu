namespace kim_milyoner_olmak_istemez_v2
{
    partial class Form2
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.LBLPNUM = new System.Windows.Forms.Label();
            this.KİTAP_EKLE = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // LBLPNUM
            // 
            this.LBLPNUM.AutoSize = true;
            this.LBLPNUM.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LBLPNUM.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.LBLPNUM.Location = new System.Drawing.Point(142, 154);
            this.LBLPNUM.Name = "LBLPNUM";
            this.LBLPNUM.Size = new System.Drawing.Size(606, 36);
            this.LBLPNUM.TabIndex = 2;
            this.LBLPNUM.Text = "YAPMAK İSTEDİĞİNİZ İŞLEMİ SEÇİNİZ :";
            // 
            // KİTAP_EKLE
            // 
            this.KİTAP_EKLE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.KİTAP_EKLE.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KİTAP_EKLE.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.KİTAP_EKLE.Location = new System.Drawing.Point(100, 311);
            this.KİTAP_EKLE.Name = "KİTAP_EKLE";
            this.KİTAP_EKLE.Size = new System.Drawing.Size(273, 107);
            this.KİTAP_EKLE.TabIndex = 3;
            this.KİTAP_EKLE.Text = "YENİ KİTAP EKLE";
            this.KİTAP_EKLE.UseVisualStyleBackColor = false;
            this.KİTAP_EKLE.Click += new System.EventHandler(this.KİTAP_EKLE_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(506, 311);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(273, 107);
            this.button1.TabIndex = 4;
            this.button1.Text = "KİTAPLARA GÖZ AT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(944, 585);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.KİTAP_EKLE);
            this.Controls.Add(this.LBLPNUM);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label LBLPNUM;
        private System.Windows.Forms.Button KİTAP_EKLE;
        private System.Windows.Forms.Button button1;
    }
}