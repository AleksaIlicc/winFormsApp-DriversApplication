using Podaci;
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
    public partial class Kategorija : Form
    {
        #region Atributes

        public Podaci.Kategorija kat;

        #endregion

        #region Constructors

        public Kategorija()
        {
            InitializeComponent();
        }

        #endregion

        #region EventHandlers

        private void btn_prosledi_Click(object sender, EventArgs e)
        {
            kat = new Podaci.Kategorija(dtp_datumOd.Value, dtp_datumDo.Value, cb_kategorija.Text);
            this.Close();
            this.DialogResult = DialogResult.OK;
        }

        #endregion

    }
}
