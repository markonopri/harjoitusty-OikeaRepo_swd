using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kilometrikorvaus
{
    class Myyntiedustaja
    {
        private string nimi;
        private double matkakulut;
        private string matkakululistaus;
        private int kilometrit;
        private int paivarahat;
        private double maksetutKorvaukset;
        private double maksamattomatKorvaukset;

        public Myyntiedustaja(string nimi, double matkakulut, string matkakululistaus, int kilometrit, int paivarahat, double maksetutKorvaukset, double maksamattomatKorvaukset)
        {
            this.nimi = nimi;
            this.matkakulut = matkakulut;
            this.matkakululistaus = matkakululistaus;
            this.kilometrit = kilometrit;
            this.paivarahat = paivarahat;
            this.maksetutKorvaukset = maksetutKorvaukset;
            this.maksamattomatKorvaukset = maksamattomatKorvaukset;
        }
        public string Nimi
        {
            get { return nimi; }
            set { nimi = value; }
        }
        public double Matkakulut
        {
            get { return matkakulut; }
            set { matkakulut = value; }
        }
        public string Matkakululistaus
        {
            get { return matkakululistaus; }
            set { matkakululistaus = value; }
        }
        public int Kilometrit
        {
            get { return kilometrit; }
            set { kilometrit = value; }
        }
        public int Paivarahat
        {
            get { return paivarahat; }
            set { paivarahat = value; }
        }
        public double MaksetutKorvaukset
        {
            get { return maksetutKorvaukset; }
            set { maksetutKorvaukset = value;  }
        }
        public double MaksamattomatKorvaukset
        {
            get { return maksamattomatKorvaukset; }
            set { maksamattomatKorvaukset = value; }
        }
    }
}
