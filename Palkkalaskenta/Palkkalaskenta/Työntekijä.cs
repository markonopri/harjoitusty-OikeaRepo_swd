namespace Palkkalaskenta
{
     class Tyontekija
    {

        private string nimi;
        private int palkka;

        public Tyontekija(string nimi, int palkka)
        {
            this.nimi = nimi;
            this.palkka = palkka;
        }
        public string Nimi
        {
            get { return nimi; }
            set { nimi = value; }
        }

        public int Palkka
        {
            get { return palkka; }
            set { palkka = value; }
        }
    }
}