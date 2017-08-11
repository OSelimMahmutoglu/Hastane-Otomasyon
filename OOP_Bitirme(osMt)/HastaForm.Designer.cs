namespace OOP_Bitirme_osMt_
{
    partial class HastaForm
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
            this.SuspendLayout();
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(12, 308);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnKaydet.Size = new System.Drawing.Size(187, 71);
            this.btnKaydet.TabIndex = 5;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            this.btnKaydet.MouseClick += new System.Windows.Forms.MouseEventHandler(this.HastaForm_MouseClick_1);
            // 
            // cmbCinsiyet
            // 
            this.cmbCinsiyet.Margin = new System.Windows.Forms.Padding(2);
            this.cmbCinsiyet.Size = new System.Drawing.Size(232, 24);
            this.cmbCinsiyet.TabIndex = 3;
            // 
            // dtpDogumTarihi
            // 
            this.dtpDogumTarihi.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.TabIndex = 9;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSoyad.TabIndex = 1;
            // 
            // txtTCKN
            // 
            this.txtTCKN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTCKN.TabIndex = 4;
            // 
            // txtAd
            // 
            this.txtAd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAd.TabIndex = 0;
            // 
            // txtArama
            // 
            this.txtArama.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtArama.Size = new System.Drawing.Size(228, 22);
            this.txtArama.TabIndex = 7;
            this.txtArama.TextChanged += new System.EventHandler(this.txtArama_TextChanged);
            // 
            // lstKisi
            // 
            this.lstKisi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstKisi.Size = new System.Drawing.Size(287, 308);
            this.lstKisi.TabIndex = 8;
            this.lstKisi.SelectedIndexChanged += new System.EventHandler(this.lstKisi_SelectedIndexChanged);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(237, 308);
            this.btnSil.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSil.Size = new System.Drawing.Size(154, 76);
            this.btnSil.TabIndex = 6;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // label5
            // 
            this.label5.TabIndex = 14;
            // 
            // HastaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 444);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "HastaForm";
            this.Text = "HastaForm";
            this.Load += new System.EventHandler(this.HastaForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.HastaForm_KeyDown);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.HastaForm_MouseClick_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}