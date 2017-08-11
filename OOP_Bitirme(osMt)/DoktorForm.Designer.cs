namespace OOP_Bitirme_osMt_
{
    partial class DoktorForm
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
            this.label6 = new System.Windows.Forms.Label();
            this.cmbBrans = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMaas = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lstHemsire = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(26, 297);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnKaydet.Size = new System.Drawing.Size(116, 58);
            this.btnKaydet.TabIndex = 8;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // cmbCinsiyet
            // 
            this.cmbCinsiyet.Margin = new System.Windows.Forms.Padding(2);
            this.cmbCinsiyet.TabIndex = 3;
            // 
            // dtpDogumTarihi
            // 
            this.dtpDogumTarihi.MaxDate = new System.DateTime(1993, 1, 1, 0, 0, 0, 0);
            this.dtpDogumTarihi.MinDate = new System.DateTime(1930, 1, 1, 0, 0, 0, 0);
            this.dtpDogumTarihi.TabIndex = 2;
            this.dtpDogumTarihi.Value = new System.DateTime(1993, 1, 1, 0, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.TabIndex = 12;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSoyad.TabIndex = 1;
            // 
            // txtTCKN
            // 
            this.txtTCKN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTCKN.TabIndex = 4;
            // 
            // txtAd
            // 
            this.txtAd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAd.TabIndex = 0;
            // 
            // txtArama
            // 
            this.txtArama.Location = new System.Drawing.Point(358, 33);
            this.txtArama.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtArama.Size = new System.Drawing.Size(142, 20);
            this.txtArama.TabIndex = 10;
            this.txtArama.TextChanged += new System.EventHandler(this.txtArama_TextChanged);
            // 
            // lstKisi
            // 
            this.lstKisi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstKisi.Size = new System.Drawing.Size(193, 277);
            this.lstKisi.TabIndex = 11;
            this.lstKisi.SelectedIndexChanged += new System.EventHandler(this.lstKisi_SelectedIndexChanged);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(177, 296);
            this.btnSil.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnSil.Size = new System.Drawing.Size(112, 58);
            this.btnSil.TabIndex = 9;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // label5
            // 
            this.label5.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(60, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "Branş";
            // 
            // cmbBrans
            // 
            this.cmbBrans.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBrans.FormattingEnabled = true;
            this.cmbBrans.Location = new System.Drawing.Point(116, 182);
            this.cmbBrans.Name = "cmbBrans";
            this.cmbBrans.Size = new System.Drawing.Size(175, 21);
            this.cmbBrans.TabIndex = 5;
            this.cmbBrans.SelectedIndexChanged += new System.EventHandler(this.cmbBrans_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(64, 214);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 17);
            this.label7.TabIndex = 18;
            this.label7.Text = "Maas";
            // 
            // txtMaas
            // 
            this.txtMaas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtMaas.Location = new System.Drawing.Point(116, 214);
            this.txtMaas.Name = "txtMaas";
            this.txtMaas.Size = new System.Drawing.Size(175, 20);
            this.txtMaas.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(31, 243);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 17);
            this.label8.TabIndex = 19;
            this.label8.Text = "Hemsiresi";
            // 
            // lstHemsire
            // 
            this.lstHemsire.FormattingEnabled = true;
            this.lstHemsire.Location = new System.Drawing.Point(116, 243);
            this.lstHemsire.Name = "lstHemsire";
            this.lstHemsire.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstHemsire.Size = new System.Drawing.Size(173, 43);
            this.lstHemsire.TabIndex = 21;
            // 
            // DoktorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 364);
            this.Controls.Add(this.lstHemsire);
            this.Controls.Add(this.txtMaas);
            this.Controls.Add(this.cmbBrans);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "DoktorForm";
            this.Text = "Doktor";
            this.Load += new System.EventHandler(this.Doktor_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DoktorForm_KeyDown);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DoktorForm_MouseClick);
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
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.cmbBrans, 0);
            this.Controls.SetChildIndex(this.txtMaas, 0);
            this.Controls.SetChildIndex(this.lstHemsire, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbBrans;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMaas;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox lstHemsire;
    }
}