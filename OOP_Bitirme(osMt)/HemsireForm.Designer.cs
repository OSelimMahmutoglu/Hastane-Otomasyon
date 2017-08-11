namespace OOP_Bitirme_osMt_
{
    partial class HemsireForm
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
            this.txtMaas = new System.Windows.Forms.TextBox();
            this.lblMaas = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbBrans = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(32, 279);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnKaydet.Size = new System.Drawing.Size(110, 51);
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // cmbCinsiyet
            // 
            this.cmbCinsiyet.Margin = new System.Windows.Forms.Padding(2);
            this.cmbCinsiyet.TabIndex = 3;
            // 
            // dtpDogumTarihi
            // 
            this.dtpDogumTarihi.MaxDate = new System.DateTime(1995, 1, 1, 0, 0, 0, 0);
            this.dtpDogumTarihi.MinDate = new System.DateTime(1940, 1, 1, 0, 0, 0, 0);
            this.dtpDogumTarihi.TabIndex = 2;
            this.dtpDogumTarihi.Value = new System.DateTime(1995, 1, 1, 0, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.TabIndex = 11;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSoyad.TabIndex = 1;
            // 
            // txtTCKN
            // 
            this.txtTCKN.Location = new System.Drawing.Point(116, 151);
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
            this.txtArama.Location = new System.Drawing.Point(363, 24);
            this.txtArama.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtArama.Size = new System.Drawing.Size(163, 20);
            this.txtArama.TabIndex = 9;
            this.txtArama.TextChanged += new System.EventHandler(this.txtArama_TextChanged_1);
            // 
            // lstKisi
            // 
            this.lstKisi.Location = new System.Drawing.Point(320, 56);
            this.lstKisi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstKisi.Size = new System.Drawing.Size(206, 277);
            this.lstKisi.TabIndex = 10;
            this.lstKisi.SelectedIndexChanged += new System.EventHandler(this.lstKisi_SelectedIndexChanged);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(182, 279);
            this.btnSil.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSil.Size = new System.Drawing.Size(108, 51);
            this.btnSil.TabIndex = 8;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(319, 28);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.label5.TabIndex = 18;
            // 
            // txtMaas
            // 
            this.txtMaas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtMaas.Location = new System.Drawing.Point(116, 188);
            this.txtMaas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMaas.Name = "txtMaas";
            this.txtMaas.Size = new System.Drawing.Size(175, 20);
            this.txtMaas.TabIndex = 5;
            // 
            // lblMaas
            // 
            this.lblMaas.AutoSize = true;
            this.lblMaas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMaas.ForeColor = System.Drawing.Color.White;
            this.lblMaas.Location = new System.Drawing.Point(66, 188);
            this.lblMaas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaas.Name = "lblMaas";
            this.lblMaas.Size = new System.Drawing.Size(46, 17);
            this.lblMaas.TabIndex = 16;
            this.lblMaas.Text = "Maaş";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(64, 223);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "Branş";
            // 
            // cmbBrans
            // 
            this.cmbBrans.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBrans.FormattingEnabled = true;
            this.cmbBrans.Location = new System.Drawing.Point(116, 223);
            this.cmbBrans.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbBrans.Name = "cmbBrans";
            this.cmbBrans.Size = new System.Drawing.Size(175, 21);
            this.cmbBrans.TabIndex = 6;
            // 
            // HemsireForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 367);
            this.Controls.Add(this.cmbBrans);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblMaas);
            this.Controls.Add(this.txtMaas);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "HemsireForm";
            this.Text = "Hemsire";
            this.Load += new System.EventHandler(this.Hemsire_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.HemsireForm_KeyDown);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.HemsireForm_MouseClick);
            this.Controls.SetChildIndex(this.txtAd, 0);
            this.Controls.SetChildIndex(this.txtTCKN, 0);
            this.Controls.SetChildIndex(this.txtSoyad, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.dtpDogumTarihi, 0);
            this.Controls.SetChildIndex(this.cmbCinsiyet, 0);
            this.Controls.SetChildIndex(this.btnKaydet, 0);
            this.Controls.SetChildIndex(this.lstKisi, 0);
            this.Controls.SetChildIndex(this.txtArama, 0);
            this.Controls.SetChildIndex(this.btnSil, 0);
            this.Controls.SetChildIndex(this.txtMaas, 0);
            this.Controls.SetChildIndex(this.lblMaas, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.cmbBrans, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMaas;
        private System.Windows.Forms.Label lblMaas;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbBrans;
    }
}