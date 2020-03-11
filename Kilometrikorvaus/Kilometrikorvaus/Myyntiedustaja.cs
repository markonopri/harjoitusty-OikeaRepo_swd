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

        public Myyntiedustaja(string nimi, double matkakulut, string matkakululistaus)
        {
            this.nimi = nimi;
            this.matkakulut = matkakulut;
            this.matkakululistaus = matkakululistaus;
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
    }
}
