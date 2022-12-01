using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testOOP
{
    class Pacient
    {
        private string jmeno;
        private string prijmeni;
        private string telefon;
        private int pokoj;
        bool nestandartnipristup = false;

        public Pacient()
        {
            this.jmeno = "John";
            this.telefon = "Nevyplněno";
            this.prijmeni = "Doe";
        }

        public Pacient(string jmeno, string prijmeni, string telefon, int pokoj)
        {
            this.jmeno = jmeno;
            this.telefon = telefon;
            this.prijmeni = prijmeni;
            this.pokoj = pokoj;
        }

        public bool NestandartniPristup
        {
            get
            {
                return nestandartnipristup;
            }
            set
            {
                nestandartnipristup = value;
            }
        }

        public int Pokoj
        {
            get
            {
                return pokoj;
            }
            set
            {                
                pokoj = value;
            }       
        }



        public string ZjistiJmeno()
        {
            return jmeno;
        }


        public void ZmenTelefon(string telefon)
        {
            this.telefon = telefon;
        }


        public override string ToString()
        {
            if (NestandartniPristup) return String.Format("Pacient {0} na pokoji {1} s nestandartnim přístupem - telefon: {2}", prijmeni, pokoj, telefon);
            else return String.Format("Pacient {0} na pokoji {1} se standartńim přístupem  telefon: {2}", prijmeni, pokoj, telefon);
        }


    }
}
