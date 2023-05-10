using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Podaci
{
    public class Vozac : Object
    {
        #region Atributes

        private string ime;
        private string prezime;
        private DateTime datumRodjenja;
        private DateTime vazenjeDozvoleOd;
        private DateTime vazenjeDozvoleDo;
        private string brVozackeDozvole;
        private string mestoIzdavanja;
        private char pol;
        private string putanjaDoSlike;
        private ListaKategorijaIZabrana kategorijeiZabrane;

        #endregion

        #region Contructors

        public Vozac(string ime, string prezime, DateTime datumRodjenja, DateTime vazenjeDozvoleOd, DateTime vazenjeDozvoleDo, string brVozackeDozvole, string mestoIzdavanja, char pol, string putanjaDoSlike, ListaKategorijaIZabrana kiz)
        {
            this.ime = ime;
            this.prezime = prezime;
            this.datumRodjenja = datumRodjenja;
            this.vazenjeDozvoleOd = vazenjeDozvoleOd;
            this.vazenjeDozvoleDo = vazenjeDozvoleDo;
            this.brVozackeDozvole = brVozackeDozvole;
            this.mestoIzdavanja = mestoIzdavanja;
            this.pol = pol;
            this.putanjaDoSlike = putanjaDoSlike;
            kategorijeiZabrane = kiz;
        }

        #endregion

        #region Properties

        public string Ime
        {
            get{return ime;}
            set{ime = value;}
        }
        public string Prezime
        {
            get{return prezime;}
            set{prezime = value;}
        }
         [DisplayName("Br Vozacke Dozvole")]
        public string BrVozackeDozvole {
            get{return brVozackeDozvole;}
            set{brVozackeDozvole= value;}
        }
        [Browsable(false)]
        public DateTime DatumRodjenja
        {
            get { return datumRodjenja; }
            set { datumRodjenja = value; }
        }
        [Browsable(false)]
        public DateTime VazenjeDozvoleOd
        {
            get { return vazenjeDozvoleOd; }
            set { vazenjeDozvoleOd = value; }
        }
        [Browsable(false)]
        public DateTime VazenjeDozvoleDo
        {
            get { return vazenjeDozvoleDo; }
            set { vazenjeDozvoleDo = value; }
        }
        [Browsable(false)]
        public string MestoIzdavanja
        {
            get { return mestoIzdavanja; }
            set { mestoIzdavanja = value; }
        }
        [Browsable(false)]
        public char Pol
        {
            get { return pol; }
            set { pol = value; }
        }
        [Browsable(false)]
        public string PutanjaDoSlike
        {
            get { return putanjaDoSlike; }
            set { putanjaDoSlike = value; }
        }
        [Browsable(false)]
        public ListaKategorijaIZabrana KategorijaIZabrana 
        {   
            get { return kategorijeiZabrane; } 
            set { kategorijeiZabrane = value; } 
        }

        #endregion

    }
}
