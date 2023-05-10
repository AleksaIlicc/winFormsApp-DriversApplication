using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Podaci
{
    public class Kategorija
    {
        #region Atributes

        DateTime datumOd;
        DateTime datumDo;
        string kategorija;

        #endregion

        #region Constructors

        public Kategorija(DateTime datumOd, DateTime datumDo, string kategorija)
        {
            this.datumOd = datumOd;
            this.datumDo = datumDo;
            this.kategorija = kategorija;
        }

        #endregion

        #region Properties

        public string KategorijaValue 
        { 
            get { return kategorija; } 
            set { kategorija = value; } 
        }
        public string DatumOdValue
        {
            get { return datumOd.Date.ToString("dd.MM.yyyy"); }
            set { datumOd = DateTime.Parse(value); }
        }
        public string DatumDoValue 
        { 
            get { return datumDo.Date.ToString("dd.MM.yyyy"); } 
            set { datumDo = DateTime.Parse(value); } 
        }

        #endregion

    }
}
