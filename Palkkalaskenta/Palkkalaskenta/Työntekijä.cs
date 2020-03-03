namespace Palkkalaskenta
{
     class Tyontekija
    {

        private string nimi;
        private double palkka;

        public Tyontekija(string nimi, double palkka)
        {
            this.nimi = nimi;
            this.palkka = palkka;
        }
        public string Nimi
        {
            get { return nimi; }
            set { nimi = value; }
        }

        public double Palkka
        {
            get { return palkka; }
            set { palkka = value; }
        }
    }
}