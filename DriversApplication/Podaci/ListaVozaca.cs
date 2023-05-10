using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Podaci
{
    public class ListaVozaca
    {

        public delegate void SortDelegate(List<Vozac> persons, int value);
        public SortDelegate SortListDelegate { get; set; }

        #region Atributes

        private List<Vozac> listaVozaca;

        #endregion

        #region Contructors
        private ListaVozaca()
        {
            listaVozaca= new List<Vozac>();
        }

        #endregion

        #region Methods

        public bool dodajVozaca(Vozac v)
        {
            if (vecPostojiUListi(v))
            {
                return false;
            }
            listaVozaca.Add(v);
            return true;
        }
        public bool obrisiVozaca(int indeks)
        {
            if (indeks >= 0 && indeks < listaVozaca.Count)
            {
                listaVozaca.RemoveAt(indeks);
                return true;
            }
            return false;
        }

        public Vozac pronadjiVozaca(int indeks)
        {
            if (indeks >= 0 && indeks < listaVozaca.Count)
            {
                return listaVozaca.ElementAt(indeks);
            }
            return null;
        }

        public void postavniNoviInfoVozaca(Vozac stari, Vozac novi)
        {
            stari.Ime = novi.Ime;
            stari.MestoIzdavanja = novi.MestoIzdavanja;
            stari.DatumRodjenja = novi.DatumRodjenja;
            stari.VazenjeDozvoleDo = novi.VazenjeDozvoleDo;
            stari.VazenjeDozvoleOd = novi.VazenjeDozvoleOd;
            stari.BrVozackeDozvole = novi.BrVozackeDozvole;
            stari.Prezime = novi.Prezime;
            stari.Pol = novi.Pol;
            stari.PutanjaDoSlike = novi.PutanjaDoSlike;
            stari.KategorijaIZabrana = novi.KategorijaIZabrana;
        }

        public bool vecPostojiUListi(Vozac v)
        {
            foreach (var vozac in listaVozaca)
            {
                if (vozac.BrVozackeDozvole==v.BrVozackeDozvole)
                {
                    return true;
                }
            }
            return false;
        }

        public void SortList(int value)
        {
            if (SortListDelegate != null)
            {
                SortListDelegate(listaVozaca, value);
            }
        }

        #endregion

        #region Singleton

        public List<Vozac> ListaVozacaValues
        {
            get
            {
                return listaVozaca;
            }
        }

        private static ListaVozaca _instance = null;

        public static ListaVozaca Instance
        {
            get
            {
                if (_instance==null)
                {
                    _instance = new ListaVozaca();
                }
                return _instance;
            }
        }

        #endregion

    }

}
