using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Podaci;

namespace Forme
{
    public partial class Vozac : Form
    {
        #region Atributes

        ListaKategorijaIZabrana kiz = new ListaKategorijaIZabrana();

        #endregion

        #region Properties

        public Podaci.Vozac Osoba
        {
            get;
            set;
        }

        #endregion

        #region Constructors
        public Vozac()
        {
            InitializeComponent();
            Init();
        }
        public Vozac(Podaci.Vozac v)
        {
            InitializeComponent();
            Osoba = v;
            IzObjektaUKontrole();
            Init();
        }

        #endregion

        #region Methods

        public void Init()
        {
            UcitajKategorije();
            UcitajZabrane();
        }
        public void UcitajKategorije()
        {
            dgv_kategorija.DataSource = kiz.kategorijeValues().ToList();
        }
        public void UcitajZabrane()
        {
            dgv_zabranaUpravljanja.DataSource = kiz.zabraneValues().ToList();
        }

        public bool Validacija()
        {
            if (string.IsNullOrEmpty(tb_ime.Text))
            {
                MessageBox.Show("Polje Ime ne sme biti prazno.",
                                "Obavestenje",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                return false;
            }
            if (string.IsNullOrEmpty(tb_prezime.Text)) {
                MessageBox.Show("Polje Prezime ne sme biti prazno.",
                               "Obavestenje",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Information);
                return false;
            }
            if (string.IsNullOrEmpty(tb_brVozacke.Text))
            {
                MessageBox.Show("Polje Br. vozacke dozvole ne sme biti prazno.",
                               "Obavestenje",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Information);
                return false;
            }
            if (string.IsNullOrEmpty(tb_mestoIzdavanja.Text))
            {
                MessageBox.Show("Polje Mesto izdavanja ne sme biti prazno.",
                              "Obavestenje",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Information);
                return false;
            }
            if (string.IsNullOrEmpty(tb_mestoIzdavanja.Text))
            {
                MessageBox.Show("Polje Pol ne sme biti prazno.",
                              "Obavestenje",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Information);
                return false;
            }
            if (pb_Slika.ImageLocation == null)
            {
                MessageBox.Show("Polje za sliku ne sme biti prazno.",
                              "Obavestenje",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Information);
                return false;
            }
            return true;
        }

        public bool Dodaj()
        {
            var o = new Podaci.Vozac(tb_ime.Text, tb_prezime.Text, dtp_datumRodj.Value, dtp_vazenjeDozvoleOd.Value, dtp_vazenjeDozvoleDo.Value, tb_brVozacke.Text, tb_mestoIzdavanja.Text, cb_pol.Text[0], pb_Slika.ImageLocation , kiz);

            return ListaVozaca.Instance.dodajVozaca(o);
        }

        public void Azuriraj()
        {
            var o = new Podaci.Vozac(tb_ime.Text, tb_prezime.Text, dtp_datumRodj.Value, dtp_vazenjeDozvoleOd.Value, dtp_vazenjeDozvoleDo.Value, tb_brVozacke.Text, tb_mestoIzdavanja.Text, cb_pol.Text[0], pb_Slika.ImageLocation, kiz);
            ListaVozaca.Instance.postavniNoviInfoVozaca(Osoba, o);
        }

        public void IzObjektaUKontrole()
        {
            tb_ime.Text = Osoba.Ime;
            tb_prezime.Text = Osoba.Prezime;
            tb_brVozacke.Text = Osoba.BrVozackeDozvole;
            tb_mestoIzdavanja.Text = Osoba.MestoIzdavanja;
            cb_pol.Text =Osoba.Pol.ToString();
            dtp_datumRodj.Value = Osoba.DatumRodjenja;
            dtp_vazenjeDozvoleOd.Value = Osoba.VazenjeDozvoleOd;
            dtp_vazenjeDozvoleDo.Value = Osoba.VazenjeDozvoleDo;
            pb_Slika.ImageLocation = Osoba.PutanjaDoSlike;
            kiz = Osoba.KategorijaIZabrana;
        }

        #endregion

        #region EventHandlers

        private void tb_ime_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void tb_prezime_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void btn_dodajSliku_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == openFileDialog1.ShowDialog())
            {
                pb_Slika.ImageLocation = openFileDialog1.FileName;
            }
        }


        private void btn_prosledi_Click(object sender, EventArgs e)
        {
            if (!Validacija())
                return;
            if (Osoba == null)
            {
                if (Dodaj())
                {
                    this.Close();
                    this.DialogResult = System.Windows.Forms.DialogResult.OK;
                }
                else
                    MessageBox.Show("Vec postoji vozac sa tim brojem dozvole.", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Azuriraj();
                this.Close();
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }


        }
        private void btn_zatvori_Click(object sender, EventArgs e)
        {
            this.Close();
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }


        private void btn_dodajNovuKategoriju_Click(object sender, EventArgs e)
        {
            Kategorija fKategorija = new Kategorija();
            if (fKategorija.ShowDialog() == DialogResult.OK)
            {
                if(kiz.dodajKategoriju(fKategorija.kat))
                    UcitajKategorije();
                else
                    MessageBox.Show("Vec postoji ta kategorija.", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btn_obrisiKategoriju_Click(object sender, EventArgs e)
        {
            if (dgv_kategorija.SelectedRows.Count == 0)
                return;

            DialogResult dlg = MessageBox.Show("Da li ste sigurni da zelite da obrisete izabranu stavku?",
                                               "Obavestenje",
                                               MessageBoxButtons.YesNo,
                                               MessageBoxIcon.Question);

            if (dlg == System.Windows.Forms.DialogResult.No)
                return;

            int sel = dgv_kategorija.SelectedRows[0].Index;
            if (!kiz.obrisiKategoriju(sel))
            {
                MessageBox.Show("Neuspesno brisanje kategorije. Pokusajte ponovo.", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            UcitajKategorije();
        }


        private void btn_dodajNovuZabranu_Click(object sender, EventArgs e)
        {
            Zabrana fZabrana = new Zabrana(kiz.kategorijeValues());
            if (fZabrana.ShowDialog() == DialogResult.OK)
            {
                if (kiz.dodajZabranu(fZabrana.kat))
                    UcitajZabrane();
                else
                    MessageBox.Show("Vec postoji ta zabrana.", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btn_obrisiZabranu_Click(object sender, EventArgs e)
        {

            if (dgv_zabranaUpravljanja.SelectedRows.Count == 0)
                return;

            DialogResult dlg = MessageBox.Show("Da li ste sigurni da zelite da obrisete izabranu stavku?",
                                               "Obavestenje",
                                               MessageBoxButtons.YesNo,
                                               MessageBoxIcon.Question);

            if (dlg == System.Windows.Forms.DialogResult.No)
                return;

            int sel = dgv_zabranaUpravljanja.SelectedRows[0].Index;
            if (!kiz.obrisiZabranu(sel))
            {
                MessageBox.Show("Neuspesno brisanje kategorije. Pokusajte ponovo.", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            UcitajZabrane();
        }

        #endregion
                
    }
}
