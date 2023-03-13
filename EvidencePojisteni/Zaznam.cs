using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidencePojisteni
{
    class Zaznam
    {
        public string Jmeno { get; set; }
        public string Prijmeni { get; set; }
        public int TelefonniCislo { get; set; }
        public int Vek { get; set; }
        public Zaznam (string jmeno, string prijmeni, int telefonniCislo, int vek)
        {
            Jmeno = jmeno;
            Prijmeni = prijmeni;
            TelefonniCislo = telefonniCislo;
            Vek = vek;
        }
        public override string ToString()
        {
            return Jmeno + " " + Prijmeni + " " + Vek + " " + TelefonniCislo;
        }
    }
}
