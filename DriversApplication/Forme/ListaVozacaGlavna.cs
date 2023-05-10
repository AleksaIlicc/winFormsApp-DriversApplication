using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using Podaci;
namespace Forme
{
    public partial class ListaVozacaGlavna : Form
    {
        #region Constructors
        public ListaVozacaGlavna()
        {
            InitializeComponent();
            Init();
        }
        #endregion

        #region Methods

        private void Init()
        {
            ListaVozaca.Instance.SortListDelegate = new ListaVozaca.SortDelegate(this.SortList);
            cb_sortiraj.SelectedIndex = 0;
        }

        private void ucitajVozace()
        {
            dataGridView1.DataSource = ListaVozaca.Instance.ListaVozacaValues.ToList();
        }

        private void SortList(List<Podaci.Vozac> lista, int value)
        {
            if (value == 1)
                Sort(ListaVozaca.Instance.ListaVozacaValues, 1);
            if (value == 2)
                Sort(ListaVozaca.Instance.ListaVozacaValues, 2);
            if (value == 3)
                Sort(ListaVozaca.Instance.ListaVozacaValues, 3);
        }
        public void Sort(List<Podaci.Vozac> vozaci, int value)
        {
            switch (value)
            {
                case 1:
                    vozaci.Sort((v1, v2) => v1.BrVozackeDozvole.CompareTo(v2.BrVozackeDozvole));
                    break;
                case 2:
                    vozaci.Sort((v1, v2) => v1.Ime.CompareTo(v2.Ime));
                    break;
                case 3:
                    vozaci.Sort((v1, v2) => v1.Prezime.CompareTo(v2.Prezime));
                    break;
            }
        }

        #endregion

        #region EventHandlers

        private void ListaVozaca_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Da li sigurno zelite napustiti program?",
                      "Zatvaranje programa", MessageBoxButtons.YesNo);
            if (dr == DialogResult.No)
                e.Cancel = true;
        }

        private void btn_dodajVozaca_Click(object sender, EventArgs e)
        {
            Vozac vForma = new Vozac();
            if (vForma.ShowDialog()== DialogResult.OK)
            {
                ucitajVozace();
            }
        }

        private void btn_izmeniVozaca_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
                return;
            int indexOfSelected = dataGridView1.SelectedRows[0].Index;
            Podaci.Vozac vozac = ListaVozaca.Instance.pronadjiVozaca(indexOfSelected);
            if (vozac == null)
                return;
            Vozac vForma = new Vozac(vozac);
            if (vForma.ShowDialog()==DialogResult.OK)
            {
                ucitajVozace();
            }
        }

        private void btn_obrisiVozaca_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
                return;

            DialogResult dlg = MessageBox.Show("Da li ste sigurni da zelite da obrisete izabranu stavku?",
                                               "Obavestenje",
                                               MessageBoxButtons.YesNo,
                                               MessageBoxIcon.Question);

            if (dlg == System.Windows.Forms.DialogResult.No)
                return;

            int indexOfSelected = dataGridView1.SelectedRows[0].Index;
            if (ListaVozaca.Instance.obrisiVozaca(indexOfSelected))
            {
                ucitajVozace();
                MessageBox.Show("Uspesno ste obrisali stavku.");
            }
            else
            {
                MessageBox.Show("Neuspesno brisanje stavke. Pokusajte ponovo.");
            }

        }

        private void btn_sortiraj_Click(object sender, EventArgs e)
        {
            int value = 1;
            if (cb_sortiraj.SelectedItem.ToString() == "Broj vozacke dozvole")
                value = 1;
            else if (cb_sortiraj.SelectedItem.ToString() == "Ime")
                value = 2;
            else
                value = 3;

            ListaVozaca.Instance.SortList(value);
            ucitajVozace();
        }

        #endregion

        #region Timer
        private void ListaVozaca_Load(object sender, EventArgs e)
        {
            timer1.Start();
            ucitajVozace();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tb_timer.Text = DateTime.Now.ToString("HH:mm:ss dd.MM.yyyy");
        }

        #endregion

    }
}
