namespace OOP_Bitirme_osMt_
{
    partial class RandevuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RandevuForm));
            this.label1 = new System.Windows.Forms.Label();
            this.cmbBrans = new System.Windows.Forms.ComboBox();
            this.cmbDoktor = new System.Windows.Forms.ComboBox();
            this.lstKisi = new System.Windows.Forms.ListBox();
            this.txtHastaArama = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gbHastaSecimi = new System.Windows.Forms.GroupBox();
            this.btnListeyiGuncelle = new System.Windows.Forms.Button();
            this.btnHastaEkle = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.gbSaatler = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.button28 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button27 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button26 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button25 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRandevuyuKaydet = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.gbHastaSecimi.SuspendLayout();
            this.gbSaatler.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(4, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Branş Seçiniz";
            // 
            // cmbBrans
            // 
            this.cmbBrans.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.cmbBrans.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBrans.FormattingEnabled = true;
            this.cmbBrans.Location = new System.Drawing.Point(166, 36);
            this.cmbBrans.Margin = new System.Windows.Forms.Padding(2);
            this.cmbBrans.Name = "cmbBrans";
            this.cmbBrans.Size = new System.Drawing.Size(269, 30);
            this.cmbBrans.TabIndex = 0;
            this.cmbBrans.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cmbDoktor
            // 
            this.cmbDoktor.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.cmbDoktor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDoktor.FormattingEnabled = true;
            this.cmbDoktor.Location = new System.Drawing.Point(166, 92);
            this.cmbDoktor.Margin = new System.Windows.Forms.Padding(2);
            this.cmbDoktor.Name = "cmbDoktor";
            this.cmbDoktor.Size = new System.Drawing.Size(269, 30);
            this.cmbDoktor.TabIndex = 1;
            this.cmbDoktor.SelectedIndexChanged += new System.EventHandler(this.cmbDoktor_SelectedIndexChanged);
            // 
            // lstKisi
            // 
            this.lstKisi.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lstKisi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lstKisi.FormattingEnabled = true;
            this.lstKisi.ItemHeight = 22;
            this.lstKisi.Location = new System.Drawing.Point(18, 72);
            this.lstKisi.Margin = new System.Windows.Forms.Padding(2);
            this.lstKisi.Name = "lstKisi";
            this.lstKisi.Size = new System.Drawing.Size(417, 268);
            this.lstKisi.TabIndex = 1;
            this.lstKisi.SelectedIndexChanged += new System.EventHandler(this.lbHastaListesi_SelectedIndexChanged);
            // 
            // txtHastaArama
            // 
            this.txtHastaArama.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtHastaArama.Location = new System.Drawing.Point(166, 30);
            this.txtHastaArama.Margin = new System.Windows.Forms.Padding(2);
            this.txtHastaArama.Name = "txtHastaArama";
            this.txtHastaArama.Size = new System.Drawing.Size(269, 28);
            this.txtHastaArama.TabIndex = 0;
            this.txtHastaArama.TextChanged += new System.EventHandler(this.txtHastaArama_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label3.Location = new System.Drawing.Point(4, 94);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Doktor Seçiniz";
            // 
            // gbHastaSecimi
            // 
            this.gbHastaSecimi.Controls.Add(this.btnListeyiGuncelle);
            this.gbHastaSecimi.Controls.Add(this.lstKisi);
            this.gbHastaSecimi.Controls.Add(this.btnHastaEkle);
            this.gbHastaSecimi.Controls.Add(this.txtHastaArama);
            this.gbHastaSecimi.Controls.Add(this.label4);
            this.gbHastaSecimi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbHastaSecimi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.gbHastaSecimi.Location = new System.Drawing.Point(23, 21);
            this.gbHastaSecimi.Margin = new System.Windows.Forms.Padding(2);
            this.gbHastaSecimi.Name = "gbHastaSecimi";
            this.gbHastaSecimi.Padding = new System.Windows.Forms.Padding(2);
            this.gbHastaSecimi.Size = new System.Drawing.Size(450, 412);
            this.gbHastaSecimi.TabIndex = 4;
            this.gbHastaSecimi.TabStop = false;
            this.gbHastaSecimi.Text = "Hasta Seçimi";
            // 
            // btnListeyiGuncelle
            // 
            this.btnListeyiGuncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnListeyiGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnListeyiGuncelle.ForeColor = System.Drawing.Color.Blue;
            this.btnListeyiGuncelle.Location = new System.Drawing.Point(247, 344);
            this.btnListeyiGuncelle.Margin = new System.Windows.Forms.Padding(2);
            this.btnListeyiGuncelle.Name = "btnListeyiGuncelle";
            this.btnListeyiGuncelle.Size = new System.Drawing.Size(186, 57);
            this.btnListeyiGuncelle.TabIndex = 3;
            this.btnListeyiGuncelle.Text = "Listeyi Güncelle";
            this.btnListeyiGuncelle.UseVisualStyleBackColor = false;
            this.btnListeyiGuncelle.Click += new System.EventHandler(this.btnListeyiGuncelle_Click);
            // 
            // btnHastaEkle
            // 
            this.btnHastaEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnHastaEkle.ForeColor = System.Drawing.Color.Blue;
            this.btnHastaEkle.Location = new System.Drawing.Point(18, 344);
            this.btnHastaEkle.Margin = new System.Windows.Forms.Padding(2);
            this.btnHastaEkle.Name = "btnHastaEkle";
            this.btnHastaEkle.Size = new System.Drawing.Size(182, 57);
            this.btnHastaEkle.TabIndex = 2;
            this.btnHastaEkle.Text = "Hasta Ekle";
            this.btnHastaEkle.UseVisualStyleBackColor = false;
            this.btnHastaEkle.Click += new System.EventHandler(this.btnHastaEkle_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(16, 35);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Hasta Adı Giriniz";
            // 
            // gbSaatler
            // 
            this.gbSaatler.Controls.Add(this.panel1);
            this.gbSaatler.Controls.Add(this.button28);
            this.gbSaatler.Controls.Add(this.button24);
            this.gbSaatler.Controls.Add(this.button12);
            this.gbSaatler.Controls.Add(this.button20);
            this.gbSaatler.Controls.Add(this.button8);
            this.gbSaatler.Controls.Add(this.button16);
            this.gbSaatler.Controls.Add(this.button4);
            this.gbSaatler.Controls.Add(this.button27);
            this.gbSaatler.Controls.Add(this.button23);
            this.gbSaatler.Controls.Add(this.button11);
            this.gbSaatler.Controls.Add(this.button19);
            this.gbSaatler.Controls.Add(this.button7);
            this.gbSaatler.Controls.Add(this.button15);
            this.gbSaatler.Controls.Add(this.button3);
            this.gbSaatler.Controls.Add(this.button26);
            this.gbSaatler.Controls.Add(this.button22);
            this.gbSaatler.Controls.Add(this.button10);
            this.gbSaatler.Controls.Add(this.button18);
            this.gbSaatler.Controls.Add(this.button6);
            this.gbSaatler.Controls.Add(this.button14);
            this.gbSaatler.Controls.Add(this.button2);
            this.gbSaatler.Controls.Add(this.button25);
            this.gbSaatler.Controls.Add(this.button21);
            this.gbSaatler.Controls.Add(this.button17);
            this.gbSaatler.Controls.Add(this.button9);
            this.gbSaatler.Controls.Add(this.button13);
            this.gbSaatler.Controls.Add(this.button5);
            this.gbSaatler.Controls.Add(this.button1);
            this.gbSaatler.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbSaatler.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.gbSaatler.Location = new System.Drawing.Point(493, 21);
            this.gbSaatler.Margin = new System.Windows.Forms.Padding(2);
            this.gbSaatler.Name = "gbSaatler";
            this.gbSaatler.Padding = new System.Windows.Forms.Padding(2);
            this.gbSaatler.Size = new System.Drawing.Size(480, 482);
            this.gbSaatler.TabIndex = 4;
            this.gbSaatler.TabStop = false;
            this.gbSaatler.Text = "Saat Seçiniz";
            this.gbSaatler.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(28, 197);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(428, 36);
            this.panel1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(2, 1);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(467, 37);
            this.label2.TabIndex = 0;
            this.label2.Text = "/////////////////////////////////////////////";
            // 
            // button28
            // 
            this.button28.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button28.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button28.Location = new System.Drawing.Point(374, 429);
            this.button28.Margin = new System.Windows.Forms.Padding(2);
            this.button28.Name = "button28";
            this.button28.Size = new System.Drawing.Size(82, 31);
            this.button28.TabIndex = 27;
            this.button28.Text = "16:45";
            this.button28.UseVisualStyleBackColor = false;
            this.button28.Click += new System.EventHandler(this.button12_Click);
            // 
            // button24
            // 
            this.button24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button24.Location = new System.Drawing.Point(374, 370);
            this.button24.Margin = new System.Windows.Forms.Padding(2);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(82, 31);
            this.button24.TabIndex = 23;
            this.button24.Text = "15:45";
            this.button24.UseVisualStyleBackColor = false;
            this.button24.Click += new System.EventHandler(this.button12_Click);
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button12.Location = new System.Drawing.Point(374, 162);
            this.button12.Margin = new System.Windows.Forms.Padding(2);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(82, 31);
            this.button12.TabIndex = 11;
            this.button12.Text = "11:45";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button20
            // 
            this.button20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button20.Location = new System.Drawing.Point(374, 304);
            this.button20.Margin = new System.Windows.Forms.Padding(2);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(82, 31);
            this.button20.TabIndex = 19;
            this.button20.Text = "14:45";
            this.button20.UseVisualStyleBackColor = false;
            this.button20.Click += new System.EventHandler(this.button12_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button8.Location = new System.Drawing.Point(374, 93);
            this.button8.Margin = new System.Windows.Forms.Padding(2);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(82, 31);
            this.button8.TabIndex = 7;
            this.button8.Text = "10:45";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button12_Click);
            // 
            // button16
            // 
            this.button16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button16.Location = new System.Drawing.Point(374, 238);
            this.button16.Margin = new System.Windows.Forms.Padding(2);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(82, 31);
            this.button16.TabIndex = 15;
            this.button16.Text = "13:45";
            this.button16.UseVisualStyleBackColor = false;
            this.button16.Click += new System.EventHandler(this.button12_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button4.Location = new System.Drawing.Point(374, 31);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(82, 31);
            this.button4.TabIndex = 3;
            this.button4.Text = "9:45";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button12_Click);
            // 
            // button27
            // 
            this.button27.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button27.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button27.Location = new System.Drawing.Point(261, 429);
            this.button27.Margin = new System.Windows.Forms.Padding(2);
            this.button27.Name = "button27";
            this.button27.Size = new System.Drawing.Size(82, 31);
            this.button27.TabIndex = 26;
            this.button27.Text = "16:30";
            this.button27.UseVisualStyleBackColor = false;
            this.button27.Click += new System.EventHandler(this.button12_Click);
            // 
            // button23
            // 
            this.button23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button23.Location = new System.Drawing.Point(261, 370);
            this.button23.Margin = new System.Windows.Forms.Padding(2);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(82, 31);
            this.button23.TabIndex = 22;
            this.button23.Text = "15:30";
            this.button23.UseVisualStyleBackColor = false;
            this.button23.Click += new System.EventHandler(this.button12_Click);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button11.Location = new System.Drawing.Point(261, 162);
            this.button11.Margin = new System.Windows.Forms.Padding(2);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(82, 31);
            this.button11.TabIndex = 10;
            this.button11.Text = "11:30";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button12_Click);
            // 
            // button19
            // 
            this.button19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button19.Location = new System.Drawing.Point(261, 304);
            this.button19.Margin = new System.Windows.Forms.Padding(2);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(82, 31);
            this.button19.TabIndex = 18;
            this.button19.Text = "14:30";
            this.button19.UseVisualStyleBackColor = false;
            this.button19.Click += new System.EventHandler(this.button12_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button7.Location = new System.Drawing.Point(261, 93);
            this.button7.Margin = new System.Windows.Forms.Padding(2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(82, 31);
            this.button7.TabIndex = 6;
            this.button7.Text = "10:30";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button12_Click);
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button15.Location = new System.Drawing.Point(261, 238);
            this.button15.Margin = new System.Windows.Forms.Padding(2);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(82, 31);
            this.button15.TabIndex = 14;
            this.button15.Text = "13:30";
            this.button15.UseVisualStyleBackColor = false;
            this.button15.Click += new System.EventHandler(this.button12_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button3.Location = new System.Drawing.Point(261, 31);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(82, 31);
            this.button3.TabIndex = 2;
            this.button3.Text = "9:30";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button12_Click);
            // 
            // button26
            // 
            this.button26.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button26.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button26.Location = new System.Drawing.Point(141, 429);
            this.button26.Margin = new System.Windows.Forms.Padding(2);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(82, 31);
            this.button26.TabIndex = 25;
            this.button26.Text = "16:15";
            this.button26.UseVisualStyleBackColor = false;
            this.button26.Click += new System.EventHandler(this.button12_Click);
            // 
            // button22
            // 
            this.button22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button22.Location = new System.Drawing.Point(141, 370);
            this.button22.Margin = new System.Windows.Forms.Padding(2);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(82, 31);
            this.button22.TabIndex = 21;
            this.button22.Text = "15:15";
            this.button22.UseVisualStyleBackColor = false;
            this.button22.Click += new System.EventHandler(this.button12_Click);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button10.Location = new System.Drawing.Point(141, 162);
            this.button10.Margin = new System.Windows.Forms.Padding(2);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(82, 31);
            this.button10.TabIndex = 9;
            this.button10.Text = "11:15";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button12_Click);
            // 
            // button18
            // 
            this.button18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button18.Location = new System.Drawing.Point(141, 304);
            this.button18.Margin = new System.Windows.Forms.Padding(2);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(82, 31);
            this.button18.TabIndex = 17;
            this.button18.Text = "14:15";
            this.button18.UseVisualStyleBackColor = false;
            this.button18.Click += new System.EventHandler(this.button12_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button6.Location = new System.Drawing.Point(141, 93);
            this.button6.Margin = new System.Windows.Forms.Padding(2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(82, 31);
            this.button6.TabIndex = 5;
            this.button6.Text = "10:15";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button12_Click);
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button14.Location = new System.Drawing.Point(141, 238);
            this.button14.Margin = new System.Windows.Forms.Padding(2);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(82, 31);
            this.button14.TabIndex = 13;
            this.button14.Text = "13:15";
            this.button14.UseVisualStyleBackColor = false;
            this.button14.Click += new System.EventHandler(this.button12_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button2.Location = new System.Drawing.Point(141, 31);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(82, 31);
            this.button2.TabIndex = 1;
            this.button2.Text = "9:15";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button12_Click);
            // 
            // button25
            // 
            this.button25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button25.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button25.Location = new System.Drawing.Point(28, 429);
            this.button25.Margin = new System.Windows.Forms.Padding(2);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(82, 31);
            this.button25.TabIndex = 24;
            this.button25.Text = "16:00";
            this.button25.UseVisualStyleBackColor = false;
            this.button25.Click += new System.EventHandler(this.button12_Click);
            // 
            // button21
            // 
            this.button21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button21.Location = new System.Drawing.Point(28, 370);
            this.button21.Margin = new System.Windows.Forms.Padding(2);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(82, 31);
            this.button21.TabIndex = 20;
            this.button21.Text = "15:00";
            this.button21.UseVisualStyleBackColor = false;
            this.button21.Click += new System.EventHandler(this.button12_Click);
            // 
            // button17
            // 
            this.button17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button17.Location = new System.Drawing.Point(28, 304);
            this.button17.Margin = new System.Windows.Forms.Padding(2);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(82, 31);
            this.button17.TabIndex = 16;
            this.button17.Text = "14:00";
            this.button17.UseVisualStyleBackColor = false;
            this.button17.Click += new System.EventHandler(this.button12_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button9.Location = new System.Drawing.Point(28, 162);
            this.button9.Margin = new System.Windows.Forms.Padding(2);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(82, 31);
            this.button9.TabIndex = 8;
            this.button9.Text = "11:00";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button12_Click);
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button13.Location = new System.Drawing.Point(28, 238);
            this.button13.Margin = new System.Windows.Forms.Padding(2);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(82, 31);
            this.button13.TabIndex = 12;
            this.button13.Text = "13:00";
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Click += new System.EventHandler(this.button12_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button5.Location = new System.Drawing.Point(28, 93);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(82, 31);
            this.button5.TabIndex = 4;
            this.button5.Text = "10:00";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button12_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button1.Location = new System.Drawing.Point(28, 31);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 31);
            this.button1.TabIndex = 0;
            this.button1.Text = "9:00";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button12_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbDoktor);
            this.groupBox1.Controls.Add(this.cmbBrans);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.groupBox1.Location = new System.Drawing.Point(23, 437);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(450, 135);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tedavi Seçimi";
            // 
            // btnRandevuyuKaydet
            // 
            this.btnRandevuyuKaydet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnRandevuyuKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRandevuyuKaydet.ForeColor = System.Drawing.Color.Blue;
            this.btnRandevuyuKaydet.Location = new System.Drawing.Point(521, 514);
            this.btnRandevuyuKaydet.Margin = new System.Windows.Forms.Padding(2);
            this.btnRandevuyuKaydet.Name = "btnRandevuyuKaydet";
            this.btnRandevuyuKaydet.Size = new System.Drawing.Size(195, 56);
            this.btnRandevuyuKaydet.TabIndex = 6;
            this.btnRandevuyuKaydet.Text = "Randevuyu Kaydet";
            this.btnRandevuyuKaydet.UseVisualStyleBackColor = false;
            this.btnRandevuyuKaydet.Click += new System.EventHandler(this.btnRandevuyuKaydet_Click_1);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // RandevuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(984, 592);
            this.Controls.Add(this.btnRandevuyuKaydet);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbSaatler);
            this.Controls.Add(this.gbHastaSecimi);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "RandevuForm";
            this.Text = "RandevuForm";
            this.Load += new System.EventHandler(this.RandevuForm_Load);
            this.gbHastaSecimi.ResumeLayout(false);
            this.gbHastaSecimi.PerformLayout();
            this.gbSaatler.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbBrans;
        private System.Windows.Forms.ComboBox cmbDoktor;
        private System.Windows.Forms.ListBox lstKisi;
        private System.Windows.Forms.TextBox txtHastaArama;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbHastaSecimi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gbSaatler;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button28;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button27;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button26;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button25;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnListeyiGuncelle;
        private System.Windows.Forms.Button btnHastaEkle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRandevuyuKaydet;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}