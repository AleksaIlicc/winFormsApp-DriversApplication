namespace Forme
{
    partial class ListaVozacaGlavna
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
            this.components = new System.ComponentModel.Container();
            this.btn_sortiraj = new System.Windows.Forms.Button();
            this.btn_dodajVozaca = new System.Windows.Forms.Button();
            this.btn_izmeniVozaca = new System.Windows.Forms.Button();
            this.btn_obrisiVozaca = new System.Windows.Forms.Button();
            this.gb_listaVozaca = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Ime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrVozackeDozvole = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cb_sortiraj = new System.Windows.Forms.ComboBox();
            this.tb_timer = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.gb_listaVozaca.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_sortiraj
            // 
            this.btn_sortiraj.Location = new System.Drawing.Point(185, 12);
            this.btn_sortiraj.Name = "btn_sortiraj";
            this.btn_sortiraj.Size = new System.Drawing.Size(75, 21);
            this.btn_sortiraj.TabIndex = 1;
            this.btn_sortiraj.Text = "Sortiraj";
            this.btn_sortiraj.UseVisualStyleBackColor = true;
            this.btn_sortiraj.Click += new System.EventHandler(this.btn_sortiraj_Click);
            // 
            // btn_dodajVozaca
            // 
            this.btn_dodajVozaca.Image = global::Forme.Properties.Resources.icons8_add_24;
            this.btn_dodajVozaca.Location = new System.Drawing.Point(8, 215);
            this.btn_dodajVozaca.Name = "btn_dodajVozaca";
            this.btn_dodajVozaca.Size = new System.Drawing.Size(77, 34);
            this.btn_dodajVozaca.TabIndex = 1;
            this.btn_dodajVozaca.Text = "Dodaj vozaca";
            this.btn_dodajVozaca.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_dodajVozaca.UseVisualStyleBackColor = true;
            this.btn_dodajVozaca.Click += new System.EventHandler(this.btn_dodajVozaca_Click);
            // 
            // btn_izmeniVozaca
            // 
            this.btn_izmeniVozaca.Image = global::Forme.Properties.Resources.icons8_edit_24;
            this.btn_izmeniVozaca.Location = new System.Drawing.Point(91, 215);
            this.btn_izmeniVozaca.Name = "btn_izmeniVozaca";
            this.btn_izmeniVozaca.Size = new System.Drawing.Size(77, 34);
            this.btn_izmeniVozaca.TabIndex = 2;
            this.btn_izmeniVozaca.Text = "Izmeni Vozaca";
            this.btn_izmeniVozaca.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_izmeniVozaca.UseVisualStyleBackColor = true;
            this.btn_izmeniVozaca.Click += new System.EventHandler(this.btn_izmeniVozaca_Click);
            // 
            // btn_obrisiVozaca
            // 
            this.btn_obrisiVozaca.Image = global::Forme.Properties.Resources.icons8_delete_24;
            this.btn_obrisiVozaca.Location = new System.Drawing.Point(299, 215);
            this.btn_obrisiVozaca.Name = "btn_obrisiVozaca";
            this.btn_obrisiVozaca.Size = new System.Drawing.Size(77, 34);
            this.btn_obrisiVozaca.TabIndex = 3;
            this.btn_obrisiVozaca.Text = "Obrisi Vozaca";
            this.btn_obrisiVozaca.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_obrisiVozaca.UseVisualStyleBackColor = true;
            this.btn_obrisiVozaca.Click += new System.EventHandler(this.btn_obrisiVozaca_Click);
            // 
            // gb_listaVozaca
            // 
            this.gb_listaVozaca.Controls.Add(this.dataGridView1);
            this.gb_listaVozaca.Controls.Add(this.btn_izmeniVozaca);
            this.gb_listaVozaca.Controls.Add(this.btn_obrisiVozaca);
            this.gb_listaVozaca.Controls.Add(this.btn_dodajVozaca);
            this.gb_listaVozaca.Location = new System.Drawing.Point(12, 39);
            this.gb_listaVozaca.Name = "gb_listaVozaca";
            this.gb_listaVozaca.Size = new System.Drawing.Size(383, 255);
            this.gb_listaVozaca.TabIndex = 3;
            this.gb_listaVozaca.TabStop = false;
            this.gb_listaVozaca.Text = "Lista vozaca";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(373, 193);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.TabStop = false;
            // 
            // Ime
            // 
            this.Ime.HeaderText = "Ime";
            this.Ime.Name = "Ime";
            this.Ime.ReadOnly = true;
            this.Ime.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Ime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // Prezime
            // 
            this.Prezime.HeaderText = "Prezime";
            this.Prezime.Name = "Prezime";
            this.Prezime.ReadOnly = true;
            this.Prezime.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Prezime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // BrVozackeDozvole
            // 
            this.BrVozackeDozvole.HeaderText = "Br. Vozacke Dozvole";
            this.BrVozackeDozvole.Name = "BrVozackeDozvole";
            this.BrVozackeDozvole.ReadOnly = true;
            this.BrVozackeDozvole.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.BrVozackeDozvole.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // cb_sortiraj
            // 
            this.cb_sortiraj.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_sortiraj.FormattingEnabled = true;
            this.cb_sortiraj.Items.AddRange(new object[] {
            "Broj vozacke dozvole",
            "Ime",
            "Prezime"});
            this.cb_sortiraj.Location = new System.Drawing.Point(266, 12);
            this.cb_sortiraj.Name = "cb_sortiraj";
            this.cb_sortiraj.Size = new System.Drawing.Size(129, 21);
            this.cb_sortiraj.TabIndex = 2;
            // 
            // tb_timer
            // 
            this.tb_timer.BackColor = System.Drawing.SystemColors.Menu;
            this.tb_timer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_timer.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_timer.Location = new System.Drawing.Point(20, 17);
            this.tb_timer.Name = "tb_timer";
            this.tb_timer.Size = new System.Drawing.Size(125, 11);
            this.tb_timer.TabIndex = 0;
            this.tb_timer.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ListaVozacaGlavna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 302);
            this.Controls.Add(this.tb_timer);
            this.Controls.Add(this.cb_sortiraj);
            this.Controls.Add(this.gb_listaVozaca);
            this.Controls.Add(this.btn_sortiraj);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ListaVozacaGlavna";
            this.Text = "Lista vozaca";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ListaVozaca_FormClosing);
            this.Load += new System.EventHandler(this.ListaVozaca_Load);
            this.gb_listaVozaca.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_sortiraj;
        private System.Windows.Forms.Button btn_dodajVozaca;
        private System.Windows.Forms.Button btn_izmeniVozaca;
        private System.Windows.Forms.Button btn_obrisiVozaca;
        private System.Windows.Forms.GroupBox gb_listaVozaca;
        private System.Windows.Forms.ComboBox cb_sortiraj;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrVozackeDozvole;
        private System.Windows.Forms.TextBox tb_timer;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

