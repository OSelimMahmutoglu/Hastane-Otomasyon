namespace OOP_Bitirme_osMt_
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.DoktorIsleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HemsireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personelİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hastaİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.randevuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dosyaİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.içeAktarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dışarAktarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DosyaKaydet = new System.Windows.Forms.SaveFileDialog();
            this.DosyaAc = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DoktorIsleriToolStripMenuItem,
            this.HemsireToolStripMenuItem,
            this.personelİşlemleriToolStripMenuItem,
            this.hastaİşlemleriToolStripMenuItem,
            this.randevuToolStripMenuItem,
            this.dosyaİşlemleriToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.menuStrip1.Size = new System.Drawing.Size(213, 503);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // DoktorIsleriToolStripMenuItem
            // 
            this.DoktorIsleriToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DoktorIsleriToolStripMenuItem.Name = "DoktorIsleriToolStripMenuItem";
            this.DoktorIsleriToolStripMenuItem.Size = new System.Drawing.Size(200, 34);
            this.DoktorIsleriToolStripMenuItem.Text = "&Doktor İşlemleri";
            this.DoktorIsleriToolStripMenuItem.Click += new System.EventHandler(this.DoktorIsleriToolStripMenuItem_Click_1);
            // 
            // HemsireToolStripMenuItem
            // 
            this.HemsireToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.HemsireToolStripMenuItem.Name = "HemsireToolStripMenuItem";
            this.HemsireToolStripMenuItem.Size = new System.Drawing.Size(200, 34);
            this.HemsireToolStripMenuItem.Text = "&Hemşire İşlemleri";
            this.HemsireToolStripMenuItem.Click += new System.EventHandler(this.HemsireToolStripMenuItem_Click_1);
            // 
            // personelİşlemleriToolStripMenuItem
            // 
            this.personelİşlemleriToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.personelİşlemleriToolStripMenuItem.Name = "personelİşlemleriToolStripMenuItem";
            this.personelİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(200, 34);
            this.personelİşlemleriToolStripMenuItem.Text = "&Personel İşlemleri";
            this.personelİşlemleriToolStripMenuItem.Click += new System.EventHandler(this.personelİşlemleriToolStripMenuItem_Click);
            // 
            // hastaİşlemleriToolStripMenuItem
            // 
            this.hastaİşlemleriToolStripMenuItem.Name = "hastaİşlemleriToolStripMenuItem";
            this.hastaİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(200, 34);
            this.hastaİşlemleriToolStripMenuItem.Text = "&Hasta İşlemleri";
            this.hastaİşlemleriToolStripMenuItem.Click += new System.EventHandler(this.hastaİşlemleriToolStripMenuItem_Click);
            // 
            // randevuToolStripMenuItem
            // 
            this.randevuToolStripMenuItem.Name = "randevuToolStripMenuItem";
            this.randevuToolStripMenuItem.Size = new System.Drawing.Size(200, 34);
            this.randevuToolStripMenuItem.Text = "&Randevu";
            this.randevuToolStripMenuItem.Click += new System.EventHandler(this.randevuToolStripMenuItem_Click);
            // 
            // dosyaİşlemleriToolStripMenuItem
            // 
            this.dosyaİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.içeAktarToolStripMenuItem,
            this.dışarAktarToolStripMenuItem});
            this.dosyaİşlemleriToolStripMenuItem.Name = "dosyaİşlemleriToolStripMenuItem";
            this.dosyaİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(200, 34);
            this.dosyaİşlemleriToolStripMenuItem.Text = "&Dosya İşlemleri";
            this.dosyaİşlemleriToolStripMenuItem.Click += new System.EventHandler(this.dosyaİşlemleriToolStripMenuItem_Click);
            // 
            // içeAktarToolStripMenuItem
            // 
            this.içeAktarToolStripMenuItem.Name = "içeAktarToolStripMenuItem";
            this.içeAktarToolStripMenuItem.Size = new System.Drawing.Size(208, 34);
            this.içeAktarToolStripMenuItem.Text = "&İçe Aktar";
            this.içeAktarToolStripMenuItem.Click += new System.EventHandler(this.içeAktarToolStripMenuItem_Click);
            // 
            // dışarAktarToolStripMenuItem
            // 
            this.dışarAktarToolStripMenuItem.Name = "dışarAktarToolStripMenuItem";
            this.dışarAktarToolStripMenuItem.Size = new System.Drawing.Size(208, 34);
            this.dışarAktarToolStripMenuItem.Text = "&Dışarı Aktar";
            this.dışarAktarToolStripMenuItem.Click += new System.EventHandler(this.dışarAktarToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1006, 503);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem DoktorIsleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HemsireToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personelİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem randevuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dosyaİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem içeAktarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dışarAktarToolStripMenuItem;
        public System.Windows.Forms.MenuStrip menuStrip1;
        public System.Windows.Forms.ToolStripMenuItem hastaİşlemleriToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog DosyaKaydet;
        private System.Windows.Forms.OpenFileDialog DosyaAc;
    }
}

