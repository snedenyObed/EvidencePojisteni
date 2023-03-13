using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidencePojisteni
{
    class Databaze
    {
        private List<Pojistenec> pojistenec;
        public Databaze()
        {
            pojistenec = new List<Pojistenec>();
        }
        public void PridejPojistence(string jmeno, string prijmeni, int telefonniCislo, int vek)
        {
            pojistenec.Add(new Pojistenec(jmeno, prijmeni, telefonniCislo, vek));
        }
        public List<Pojistenec> NajdiPojistence()
        {
            List<Pojistenec> nalezene = new List<Pojistenec>();
            foreach (Pojistenec z in pojistenec)
            {
                nalezene.Add(z);
            }
            return nalezene;
        }     
        public List<Pojistenec> NajdiHledanehoPojistence(string hledaneJmeno, string hledanePrijmeni)
        {
            List<Pojistenec> vyhledany = new List<Pojistenec>();
            foreach (Pojistenec v in pojistenec)
            {
				if ((v.Jmeno == hledaneJmeno) && (v.Prijmeni == hledanePrijmeni) || (v.Jmeno.Trim().ToLower() == hledaneJmeno) && (v.Prijmeni.Trim().ToLower() == hledanePrijmeni))
					vyhledany.Add(v);
                else
                    Console.WriteLine("Neznámý pojištěnec");
            }
            return vyhledany;
        }
    }
}
