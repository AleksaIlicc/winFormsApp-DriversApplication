using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forme
{
    public partial class Zabrana : Form
    {
        #region Atributes

        public Podaci.Kategorija kat;
        private List<Podaci.Kategorija> listaDozvoljenih;

        #endregion

        #region Constructors
        public Zabrana(List <Podaci.Kategorija> dozvoljene)
        {
            InitializeComponent();
            listaDozvoljenih = dozvoljene;
            Init();
        }
        #endregion

        #region Methods
        public void Init()
        {
            for (int i = 0; i < listaDozvoljenih.Count; i++)
            {
                cb_kategorija.Items.Add(listaDozvoljenih[i].KategorijaValue);
            }
        }

        #endregion

        #region EventHandlers
        private void btn_prosledi_Click(object sender, EventArgs e)
        {
            if (cb_kategorija.Items.Count == 0) { 
                MessageBox.Show("Nije moguce dodati zabrane vozacu jer nema kategorije.", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.Cancel;
                return;
            }
            kat = new Podaci.Kategorija(dtp_datumOd.Value, dtp_datumDo.Value, cb_kategorija.Text);
            this.Close();
            this.DialogResult = DialogResult.OK;
        }

        #endregion
    }
}
