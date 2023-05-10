using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Podaci
{
    public class ListaKategorijaIZabrana
    {
        #region Atributes

        private List<Kategorija> kategorije,zabrane;

        #endregion

        #region Constructors
        public ListaKategorijaIZabrana()
        {
            kategorije = new List<Kategorija>();
            zabrane = new List<Kategorija>();
        }
        #endregion

        #region Methods

        public bool dodajKategoriju(Kategorija k)
        {
            if (vecPostojiKategorija(k))
            {
                return false;
            }
            kategorije.Add(k);
            return true;
        }
        public bool dodajZabranu(Kategorija z)
        {
            if (vecPostojiZabrana(z))
            {
                return false;
            }
            zabrane.Add(z);
            return true;
        }

        public bool obrisiKategoriju(int indeks) {
            if (indeks >= 0 && indeks < kategorije.Count)
            {
                kategorije.RemoveAt(indeks);
                return true;
            }
            return false;
        }
        public bool obrisiZabranu(int indeks)
        {
            if (indeks >= 0 && indeks < kategorije.Count)
            {
                zabrane.RemoveAt(indeks);
                return true;
            }
            return false;
        }

        public bool vecPostojiKategorija(Kategorija kat)
        {
            foreach (var k in kategorije)
            {
                if (k.KategorijaValue == kat.KategorijaValue)
                {
                    return true;
                }
            }
            return false;
        }
        public bool vecPostojiZabrana(Kategorija kat)
        {
            foreach (var k in zabrane)
            {
                if (k.KategorijaValue == kat.KategorijaValue)
                {
                    return true;
                }
            }
            return false;
        }

        public List<Kategorija> kategorijeValues()
        {
            return kategorije;
        }
        public List<Kategorija> zabraneValues()
        {
            return zabrane;
        }

        #endregion 

    }
}
