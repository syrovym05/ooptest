using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testOOP
{
    class Zamestanec
    {
        private string jmeno;
        private string prijmeni;
        private string obor;
        private int plat = 50000;
        private int pocetpacientu;

        public Zamestanec()
        {
            this.jmeno = "John";
            this.obor = "Lékař";
            this.prijmeni = "Doe";
            this.pocetpacientu = 0;
        }

        public Zamestanec(string jmeno, string prijmeni, int pocetpacientu, string obor)
        {
            this.jmeno = jmeno;
            this.obor = obor;
            this.prijmeni = prijmeni;
            this.pocetpacientu = pocetpacientu;
        }

        public string Obor
        {
            get
            {
                return obor;
            }

        }

        public int PocetPacientu
        {
            get
            {
                return pocetpacientu;
            }
            set
            {
                pocetpacientu = value;
            }
        }

        public void ZmenPlat(int plat)
        {
            this.plat = plat;
        }


        public string ZjistiJmeno()
        {
            return jmeno;
        }

        public override string ToString()
        {
            return String.Format("{0} {1} má {2} pacientů a má plat {3} kč", obor, prijmeni, pocetpacientu, plat);  //např.: Onkolog Syrový mýá 25 pacientu a má plat 52000 kc.
        }







    }
}
