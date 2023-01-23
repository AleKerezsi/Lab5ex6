using System;

namespace Lab5ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Ex 6 Scrieti un program care va numara vocalele dintr-un sir de caractere citit de la tastatura */

            Console.WriteLine("Introduceti sirul de caractere=  ");
            string sir = Console.ReadLine();

            if (string.IsNullOrEmpty(sir) || string.IsNullOrWhiteSpace(sir))
            {
                Console.WriteLine("Nu ai introdus nimic, sau ai introdus spatiu gol. Ruleaza din nou programul.");
                return;
            }

            string[] vocaleCautate = DeterminaVocaleleCautate(sir).Split(' ');

            Console.WriteLine("Numarul total de vocale este " + AfiseazaNumarTotalDeVocaleDinSir(sir, vocaleCautate));

            AfiseazaRecurentelePentruFiecareVocala(sir, vocaleCautate);

        }

        public static int AfiseazaNumarTotalDeVocaleDinSir(string sir, string[] vocaleCautate)
        {
            int nrVocaleTotale = 0;

            foreach (var vocala in vocaleCautate)
            {
                nrVocaleTotale = nrVocaleTotale + DeterminaAparitiiVocalaInSir(sir, vocala);
            }

            return nrVocaleTotale;
        }

        public static void AfiseazaRecurentelePentruFiecareVocala(string sir, string[] vocaleCautate) 
        {
            foreach (var vocala in vocaleCautate)
            {
                Console.WriteLine("Vocala " + vocala + " apare de " + DeterminaAparitiiVocalaInSir(sir, vocala) + " ori ");
            }
        }

        public static string DeterminaVocaleleCautate(string sir) 
        {
            string rezultat = string.Empty;
            char[] vocale = new char[] { 'a', 'e', 'i', 'o', 'u' };
            foreach (char vocala in vocale) 
            {
                if (sir.Contains(vocala.ToString())) rezultat = rezultat + vocala.ToString() + " ";
            }
            return rezultat.TrimEnd();
        }


        public static int DeterminaAparitiiVocalaInSir(string sir, string vocala)
        {
            int nrAparitiiVocala = 0;

            for(int i = 0; i < sir.Length; i ++)
            {
                if (sir[i].ToString() == vocala) nrAparitiiVocala = nrAparitiiVocala + 1;
            }

            return nrAparitiiVocala;
        }
    }
}
