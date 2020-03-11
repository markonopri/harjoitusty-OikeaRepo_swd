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

        public Myyntiedustaja(string nimi, double matkakulut, string matkakululistaus, int kilometrit, int paivarahat)
        {
            this.nimi = nimi;
            this.matkakulut = matkakulut;
            this.matkakululistaus = matkakululistaus;
            this.kilometrit = kilometrit;
            this.paivarahat = paivarahat;
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
    }
}
