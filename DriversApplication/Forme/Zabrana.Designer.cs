namespace Forme
{
    partial class Zabrana
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_zatvori = new System.Windows.Forms.Button();
            this.btn_prosledi = new System.Windows.Forms.Button();
            this.dtp_datumDo = new System.Windows.Forms.DateTimePicker();
            this.dtp_datumOd = new System.Windows.Forms.DateTimePicker();
            this.cb_kategorija = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Datum do:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Datum od:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Kategorija:";
            // 
            // btn_zatvori
            // 
            this.btn_zatvori.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_zatvori.Location = new System.Drawing.Point(136, 117);
            this.btn_zatvori.Name = "btn_zatvori";
            this.btn_zatvori.Size = new System.Drawing.Size(75, 23);
            this.btn_zatvori.TabIndex = 4;
            this.btn_zatvori.Text = "Zatvori";
            this.btn_zatvori.UseVisualStyleBackColor = true;
            // 
            // btn_prosledi
            // 
            this.btn_prosledi.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_prosledi.Location = new System.Drawing.Point(48, 117);
            this.btn_prosledi.Name = "btn_prosledi";
            this.btn_prosledi.Size = new System.Drawing.Size(75, 23);
            this.btn_prosledi.TabIndex = 3;
            this.btn_prosledi.Text = "Prosledi";
            this.btn_prosledi.UseVisualStyleBackColor = true;
            this.btn_prosledi.Click += new System.EventHandler(this.btn_prosledi_Click);
            // 
            // dtp_datumDo
            // 
            this.dtp_datumDo.CustomFormat = "dd.MM.yyyy.";
            this.dtp_datumDo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_datumDo.Location = new System.Drawing.Point(95, 77);
            this.dtp_datumDo.Name = "dtp_datumDo";
            this.dtp_datumDo.Size = new System.Drawing.Size(96, 20);
            this.dtp_datumDo.TabIndex = 2;
            this.dtp_datumDo.Value = new System.DateTime(2023, 5, 3, 22, 5, 47, 0);
            // 
            // dtp_datumOd
            // 
            this.dtp_datumOd.CustomFormat = "dd.MM.yyyy.";
            this.dtp_datumOd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_datumOd.Location = new System.Drawing.Point(94, 51);
            this.dtp_datumOd.Name = "dtp_datumOd";
            this.dtp_datumOd.Size = new System.Drawing.Size(97, 20);
            this.dtp_datumOd.TabIndex = 1;
            this.dtp_datumOd.Value = new System.DateTime(2023, 5, 3, 22, 5, 52, 0);
            // 
            // cb_kategorija
            // 
            this.cb_kategorija.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cb_kategorija.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_kategorija.FormattingEnabled = true;
            this.cb_kategorija.Location = new System.Drawing.Point(95, 24);
            this.cb_kategorija.Name = "cb_kategorija";
            this.cb_kategorija.Size = new System.Drawing.Size(119, 21);
            this.cb_kategorija.TabIndex = 0;
            // 
            // Zabrana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 158);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_zatvori);
            this.Controls.Add(this.btn_prosledi);
            this.Controls.Add(this.dtp_datumDo);
            this.Controls.Add(this.dtp_datumOd);
            this.Controls.Add(this.cb_kategorija);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Zabrana";
            this.Text = "Zabrana";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_zatvori;
        private System.Windows.Forms.Button btn_prosledi;
        private System.Windows.Forms.DateTimePicker dtp_datumDo;
        private System.Windows.Forms.DateTimePicker dtp_datumOd;
        private System.Windows.Forms.ComboBox cb_kategorija;
    }
}

