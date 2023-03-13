using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidencePojisteni
{
    class Evidence
    {
        private Databaze databaze;
		private string jmeno;
		private string prijmeni;

		public Evidence()
        {
            databaze = new Databaze();
        }
        public void VypisPojistence()
        {
            Console.WriteLine();
            List<Pojistenec> pojistenec = databaze.NajdiPojistence();
            foreach (Pojistenec z in pojistenec)
                Console.WriteLine(z);
            Console.WriteLine();
            Console.WriteLine("Pokračujte libovolnou klávesou...");
        }
        public void PridejPojistence()
        {
            Console.WriteLine("Zadejte jméno pojištěného: ");
            string jmeno;
            while (string.IsNullOrEmpty(jmeno = Console.ReadLine())) 
            {
                Console.WriteLine("Zadejte jméno znovu: ");
            }
            Console.WriteLine("Zadejte příjmení: ");
            string prijmeni;
            while (string.IsNullOrEmpty(prijmeni = Console.ReadLine()))
            {
                Console.WriteLine("Zadejte příjmení znovu: ");
            }
            Console.WriteLine("Zadejte telefonní číslo: ");
            int telefonniCislo = int.Parse(Console.ReadLine());
            Console.WriteLine("Zadejte svůj věk: ");
            int vek = int.Parse(Console.ReadLine());
            Console.WriteLine("Data byla uložena, pokračujte libovolnou klávesou...");
            databaze.PridejPojistence(jmeno, prijmeni, telefonniCislo, vek);
        }
        public void VyhledejPojistence()
        {
            Console.WriteLine("Zadejte jméno pojištěného: ");
            string hledaneJmeno = Console.ReadLine();
            Console.WriteLine("Zadejte příjmení: ");
            string hledanePrijmeni = Console.ReadLine();
            Console.WriteLine();
            List<Pojistenec> pojistenec = databaze.NajdiHledanehoPojistence(hledaneJmeno, hledanePrijmeni);
            foreach (Pojistenec v in pojistenec)
            {
                Console.WriteLine(v);
            }
            Console.WriteLine("Pokračujte libovolnou klávesou...");
        }
        public void VypisNadpis()
        {
            Console.Clear();
            Console.WriteLine("------------------------------");
            Console.WriteLine("Evidence pojištěných");
            Console.WriteLine("------------------------------");
        }
    }
}
