using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadSaViseFormiGabrielMatosevic01102021
{
    class Studenti
    {
        private string ime;

        private string prezime;

        private string brojIndeksa;

        private string smjer;

        private DateTime datumRodjenja;

        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }
        public string BrojIndeksa { get => brojIndeksa; set => brojIndeksa = value; }
        public string Smjer { get => smjer; set => smjer = value; }
        public DateTime DatumRodjenja { get => datumRodjenja; set => datumRodjenja = value; }

        public Studenti(string ime, string prezime, string brojIndeksa, string smjer, DateTime datumRodjenja)
        {
            Ime = ime;
            Prezime = prezime;
            BrojIndeksa = brojIndeksa;
            Smjer = smjer;
            DatumRodjenja = datumRodjenja;
        }
        public override string ToString()

        {

            return ime + " " + prezime + " " +
            brojIndeksa + " " +
            datumRodjenja.ToShortDateString() + " " + smjer;

        }
    }
}
