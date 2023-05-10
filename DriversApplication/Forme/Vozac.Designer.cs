namespace Forme
{
    partial class Vozac
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pb_Slika = new System.Windows.Forms.PictureBox();
            this.btn_dodajSliku = new System.Windows.Forms.Button();
            this.dtp_vazenjeDozvoleDo = new System.Windows.Forms.DateTimePicker();
            this.dtp_vazenjeDozvoleOd = new System.Windows.Forms.DateTimePicker();
            this.tb_brVozacke = new System.Windows.Forms.TextBox();
            this.tb_ime = new System.Windows.Forms.TextBox();
            this.tb_mestoIzdavanja = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_pol = new System.Windows.Forms.ComboBox();
            this.dtp_datumRodj = new System.Windows.Forms.DateTimePicker();
            this.tb_prezime = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_obrisiKategoriju = new System.Windows.Forms.Button();
            this.btn_dodajNovuKategoriju = new System.Windows.Forms.Button();
            this.btn_zatvori = new System.Windows.Forms.Button();
            this.btn_prosledi = new System.Windows.Forms.Button();
            this.dgv_kategorija = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgv_zabranaUpravljanja = new System.Windows.Forms.DataGridView();
            this.btn_obrisiZabranu = new System.Windows.Forms.Button();
            this.btn_dodajNovuZabranu = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Slika)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_kategorija)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_zabranaUpravljanja)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pb_Slika);
            this.groupBox1.Controls.Add(this.btn_dodajSliku);
            this.groupBox1.Controls.Add(this.dtp_vazenjeDozvoleDo);
            this.groupBox1.Controls.Add(this.dtp_vazenjeDozvoleOd);
            this.groupBox1.Controls.Add(this.tb_brVozacke);
            this.groupBox1.Controls.Add(this.tb_ime);
            this.groupBox1.Controls.Add(this.tb_mestoIzdavanja);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cb_pol);
            this.groupBox1.Controls.Add(this.dtp_datumRodj);
            this.groupBox1.Controls.Add(this.tb_prezime);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(440, 247);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Osnovni podaci";
            // 
            // pb_Slika
            // 
            this.pb_Slika.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_Slika.Location = new System.Drawing.Point(283, 35);
            this.pb_Slika.Name = "pb_Slika";
            this.pb_Slika.Size = new System.Drawing.Size(112, 112);
            this.pb_Slika.TabIndex = 11;
            this.pb_Slika.TabStop = false;
            // 
            // btn_dodajSliku
            // 
            this.btn_dodajSliku.Location = new System.Drawing.Point(301, 152);
            this.btn_dodajSliku.Name = "btn_dodajSliku";
            this.btn_dodajSliku.Size = new System.Drawing.Size(72, 24);
            this.btn_dodajSliku.TabIndex = 8;
            this.btn_dodajSliku.Text = "Dodaj sliku";
            this.btn_dodajSliku.UseVisualStyleBackColor = true;
            this.btn_dodajSliku.Click += new System.EventHandler(this.btn_dodajSliku_Click);
            // 
            // dtp_vazenjeDozvoleDo
            // 
            this.dtp_vazenjeDozvoleDo.CustomFormat = "dd.MM.yyyy.";
            this.dtp_vazenjeDozvoleDo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_vazenjeDozvoleDo.Location = new System.Drawing.Point(136, 130);
            this.dtp_vazenjeDozvoleDo.MaxDate = new System.DateTime(2100, 1, 1, 0, 0, 0, 0);
            this.dtp_vazenjeDozvoleDo.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtp_vazenjeDozvoleDo.Name = "dtp_vazenjeDozvoleDo";
            this.dtp_vazenjeDozvoleDo.Size = new System.Drawing.Size(96, 20);
            this.dtp_vazenjeDozvoleDo.TabIndex = 4;
            this.dtp_vazenjeDozvoleDo.Value = new System.DateTime(2023, 5, 7, 0, 0, 0, 0);
            // 
            // dtp_vazenjeDozvoleOd
            // 
            this.dtp_vazenjeDozvoleOd.CustomFormat = "dd.MM.yyyy.";
            this.dtp_vazenjeDozvoleOd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_vazenjeDozvoleOd.Location = new System.Drawing.Point(136, 104);
            this.dtp_vazenjeDozvoleOd.MaxDate = new System.DateTime(2100, 1, 1, 0, 0, 0, 0);
            this.dtp_vazenjeDozvoleOd.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtp_vazenjeDozvoleOd.Name = "dtp_vazenjeDozvoleOd";
            this.dtp_vazenjeDozvoleOd.Size = new System.Drawing.Size(96, 20);
            this.dtp_vazenjeDozvoleOd.TabIndex = 3;
            this.dtp_vazenjeDozvoleOd.Value = new System.DateTime(2023, 5, 7, 0, 0, 0, 0);
            // 
            // tb_brVozacke
            // 
            this.tb_brVozacke.Location = new System.Drawing.Point(136, 156);
            this.tb_brVozacke.Name = "tb_brVozacke";
            this.tb_brVozacke.Size = new System.Drawing.Size(96, 20);
            this.tb_brVozacke.TabIndex = 5;
            // 
            // tb_ime
            // 
            this.tb_ime.Location = new System.Drawing.Point(136, 24);
            this.tb_ime.Name = "tb_ime";
            this.tb_ime.Size = new System.Drawing.Size(96, 20);
            this.tb_ime.TabIndex = 0;
            this.tb_ime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_ime_KeyPress);
            // 
            // tb_mestoIzdavanja
            // 
            this.tb_mestoIzdavanja.Location = new System.Drawing.Point(136, 182);
            this.tb_mestoIzdavanja.Name = "tb_mestoIzdavanja";
            this.tb_mestoIzdavanja.Size = new System.Drawing.Size(96, 20);
            this.tb_mestoIzdavanja.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(37, 186);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Mesto izdavanja:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(97, 212);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Pol:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Br. vozacke dozvole:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Vazenje dozvole od";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(103, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "do";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Datum rodjenja:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Prezime:";
            // 
            // cb_pol
            // 
            this.cb_pol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_pol.FormattingEnabled = true;
            this.cb_pol.Items.AddRange(new object[] {
            "M",
            "Z"});
            this.cb_pol.Location = new System.Drawing.Point(136, 208);
            this.cb_pol.Name = "cb_pol";
            this.cb_pol.Size = new System.Drawing.Size(96, 21);
            this.cb_pol.TabIndex = 7;
            // 
            // dtp_datumRodj
            // 
            this.dtp_datumRodj.CustomFormat = "dd.MM.yyyy.";
            this.dtp_datumRodj.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_datumRodj.Location = new System.Drawing.Point(136, 78);
            this.dtp_datumRodj.MaxDate = new System.DateTime(2100, 1, 1, 0, 0, 0, 0);
            this.dtp_datumRodj.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtp_datumRodj.Name = "dtp_datumRodj";
            this.dtp_datumRodj.Size = new System.Drawing.Size(96, 20);
            this.dtp_datumRodj.TabIndex = 2;
            this.dtp_datumRodj.Value = new System.DateTime(2023, 5, 7, 0, 0, 0, 0);
            // 
            // tb_prezime
            // 
            this.tb_prezime.Location = new System.Drawing.Point(136, 50);
            this.tb_prezime.Name = "tb_prezime";
            this.tb_prezime.Size = new System.Drawing.Size(96, 20);
            this.tb_prezime.TabIndex = 1;
            this.tb_prezime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_prezime_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime:";
            // 
            // btn_obrisiKategoriju
            // 
            this.btn_obrisiKategoriju.Location = new System.Drawing.Point(335, 109);
            this.btn_obrisiKategoriju.Name = "btn_obrisiKategoriju";
            this.btn_obrisiKategoriju.Size = new System.Drawing.Size(99, 34);
            this.btn_obrisiKategoriju.TabIndex = 1;
            this.btn_obrisiKategoriju.Text = "Obrisi kategoriju";
            this.btn_obrisiKategoriju.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_obrisiKategoriju.UseVisualStyleBackColor = true;
            this.btn_obrisiKategoriju.Click += new System.EventHandler(this.btn_obrisiKategoriju_Click);
            // 
            // btn_dodajNovuKategoriju
            // 
            this.btn_dodajNovuKategoriju.Location = new System.Drawing.Point(6, 109);
            this.btn_dodajNovuKategoriju.Name = "btn_dodajNovuKategoriju";
            this.btn_dodajNovuKategoriju.Size = new System.Drawing.Size(99, 34);
            this.btn_dodajNovuKategoriju.TabIndex = 0;
            this.btn_dodajNovuKategoriju.Text = "Dodaj novu kategoriju";
            this.btn_dodajNovuKategoriju.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_dodajNovuKategoriju.UseVisualStyleBackColor = true;
            this.btn_dodajNovuKategoriju.Click += new System.EventHandler(this.btn_dodajNovuKategoriju_Click);
            // 
            // btn_zatvori
            // 
            this.btn_zatvori.Location = new System.Drawing.Point(235, 594);
            this.btn_zatvori.Name = "btn_zatvori";
            this.btn_zatvori.Size = new System.Drawing.Size(69, 21);
            this.btn_zatvori.TabIndex = 4;
            this.btn_zatvori.Text = "Zatvori";
            this.btn_zatvori.UseVisualStyleBackColor = true;
            this.btn_zatvori.Click += new System.EventHandler(this.btn_zatvori_Click);
            // 
            // btn_prosledi
            // 
            this.btn_prosledi.Location = new System.Drawing.Point(138, 594);
            this.btn_prosledi.Name = "btn_prosledi";
            this.btn_prosledi.Size = new System.Drawing.Size(69, 21);
            this.btn_prosledi.TabIndex = 3;
            this.btn_prosledi.Text = "Prosledi";
            this.btn_prosledi.UseVisualStyleBackColor = true;
            this.btn_prosledi.Click += new System.EventHandler(this.btn_prosledi_Click);
            // 
            // dgv_kategorija
            // 
            this.dgv_kategorija.AllowUserToAddRows = false;
            this.dgv_kategorija.AllowUserToDeleteRows = false;
            this.dgv_kategorija.BackgroundColor = System.Drawing.Color.White;
            this.dgv_kategorija.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_kategorija.Location = new System.Drawing.Point(6, 16);
            this.dgv_kategorija.Name = "dgv_kategorija";
            this.dgv_kategorija.ReadOnly = true;
            this.dgv_kategorija.RowHeadersVisible = false;
            this.dgv_kategorija.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_kategorija.Size = new System.Drawing.Size(428, 87);
            this.dgv_kategorija.TabIndex = 30;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv_kategorija);
            this.groupBox2.Controls.Add(this.btn_obrisiKategoriju);
            this.groupBox2.Controls.Add(this.btn_dodajNovuKategoriju);
            this.groupBox2.Location = new System.Drawing.Point(12, 265);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(440, 151);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kategorija";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgv_zabranaUpravljanja);
            this.groupBox3.Controls.Add(this.btn_obrisiZabranu);
            this.groupBox3.Controls.Add(this.btn_dodajNovuZabranu);
            this.groupBox3.Location = new System.Drawing.Point(12, 422);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(440, 151);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Zabrana upravljanja";
            // 
            // dgv_zabranaUpravljanja
            // 
            this.dgv_zabranaUpravljanja.AllowUserToAddRows = false;
            this.dgv_zabranaUpravljanja.AllowUserToDeleteRows = false;
            this.dgv_zabranaUpravljanja.BackgroundColor = System.Drawing.Color.White;
            this.dgv_zabranaUpravljanja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_zabranaUpravljanja.Location = new System.Drawing.Point(6, 16);
            this.dgv_zabranaUpravljanja.Name = "dgv_zabranaUpravljanja";
            this.dgv_zabranaUpravljanja.ReadOnly = true;
            this.dgv_zabranaUpravljanja.RowHeadersVisible = false;
            this.dgv_zabranaUpravljanja.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_zabranaUpravljanja.Size = new System.Drawing.Size(428, 87);
            this.dgv_zabranaUpravljanja.TabIndex = 30;
            // 
            // btn_obrisiZabranu
            // 
            this.btn_obrisiZabranu.Location = new System.Drawing.Point(335, 108);
            this.btn_obrisiZabranu.Name = "btn_obrisiZabranu";
            this.btn_obrisiZabranu.Size = new System.Drawing.Size(99, 35);
            this.btn_obrisiZabranu.TabIndex = 1;
            this.btn_obrisiZabranu.Text = "Obrisi zabranu";
            this.btn_obrisiZabranu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_obrisiZabranu.UseVisualStyleBackColor = true;
            this.btn_obrisiZabranu.Click += new System.EventHandler(this.btn_obrisiZabranu_Click);
            // 
            // btn_dodajNovuZabranu
            // 
            this.btn_dodajNovuZabranu.Location = new System.Drawing.Point(6, 109);
            this.btn_dodajNovuZabranu.Name = "btn_dodajNovuZabranu";
            this.btn_dodajNovuZabranu.Size = new System.Drawing.Size(99, 34);
            this.btn_dodajNovuZabranu.TabIndex = 0;
            this.btn_dodajNovuZabranu.Text = "Dodaj novu zabranu";
            this.btn_dodajNovuZabranu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_dodajNovuZabranu.UseVisualStyleBackColor = true;
            this.btn_dodajNovuZabranu.Click += new System.EventHandler(this.btn_dodajNovuZabranu_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "jpg files(*.jpg)|*.jpg|png files(*.png)|*.png";
            // 
            // Vozac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 634);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_zatvori);
            this.Controls.Add(this.btn_prosledi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Vozac";
            this.Text = "Vozac";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Slika)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_kategorija)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_zabranaUpravljanja)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_dodajSliku;
        private System.Windows.Forms.DateTimePicker dtp_vazenjeDozvoleDo;
        private System.Windows.Forms.DateTimePicker dtp_vazenjeDozvoleOd;
        private System.Windows.Forms.TextBox tb_brVozacke;
        private System.Windows.Forms.TextBox tb_ime;
        private System.Windows.Forms.TextBox tb_mestoIzdavanja;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_pol;
        private System.Windows.Forms.DateTimePicker dtp_datumRodj;
        private System.Windows.Forms.TextBox tb_prezime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_obrisiKategoriju;
        private System.Windows.Forms.Button btn_dodajNovuKategoriju;
        private System.Windows.Forms.Button btn_zatvori;
        private System.Windows.Forms.Button btn_prosledi;
        private System.Windows.Forms.DataGridView dgv_kategorija;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgv_zabranaUpravljanja;
        private System.Windows.Forms.Button btn_obrisiZabranu;
        private System.Windows.Forms.Button btn_dodajNovuZabranu;
        private System.Windows.Forms.PictureBox pb_Slika;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

