using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSettimanale
{
    internal class Contribuente
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public DateTime DataDiNascita { get; set; }
        public string CodiceFiscale { get; set; }
        public string Sesso { get; set; }
        public string ComuneResidenza { get; set; }
        public double RedditoAnnuale { get; set; }

        public double Imposta;
        public static List<Contribuente> Lista = new List<Contribuente>();
        public Contribuente() { }

        public Contribuente(string nome, string cognome, DateTime dataDiNascita, string codiceFiscale, string sesso, string comuneResidenza, double redditoAnnuale)
        {
            Nome = nome;
            Cognome = cognome;
            DataDiNascita = dataDiNascita;
            CodiceFiscale = codiceFiscale;
            Sesso = sesso;
            ComuneResidenza = comuneResidenza;
            RedditoAnnuale = redditoAnnuale;
        }
        public static void Start()
        {
            Console.WriteLine("========================");
            Console.WriteLine("==========MENU==========");
            Console.WriteLine("========================");
            Console.WriteLine("Scegli cosa vuoi fare");
            Console.WriteLine("1-- Nuovo contribuente");
            Console.WriteLine("2-- Lista contribuenti");

            int scelta = int.Parse(Console.ReadLine());

            if (scelta == 1)
            {
                CompilazioneDati();
            }
            else if (scelta == 2)
            {
                Stampa();
            }
            else { Console.WriteLine("Scegli un'altro numero"); }
        }

        public static void CompilazioneDati()
        {
            Console.WriteLine("Compila i dati anagrafici");

            Console.WriteLine("1-- Inserisci nome");
            String Nome = Console.ReadLine();

            Console.WriteLine("2-- Inserisci cognome");
            String Cognome = Console.ReadLine();

            Console.WriteLine("3-- Inserisci data di nascita");
            DateTime DataDiNascita = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("4-- Inserisci codice fiscale");
            String CodiceFiscale = Console.ReadLine();

            Console.WriteLine("5-- Sesso");
            String Sesso = Console.ReadLine();

            Console.WriteLine("6-- Inserisici comune di residenza");
            String ComuneDiResidenza = Console.ReadLine();

            Console.WriteLine("7-- Inserisci reddito annuale");
            Double RedditoAnnuale = Convert.ToDouble(Console.ReadLine());
            Contribuente contribuente = new Contribuente(Nome, Cognome, DataDiNascita, CodiceFiscale, Sesso, ComuneDiResidenza, RedditoAnnuale);
            if (RedditoAnnuale <= 15000)
            {
                contribuente.Imposta = RedditoAnnuale * 0.23;
                Lista.Add(contribuente);
                Stampa();
                Start();
            }
            else if (RedditoAnnuale >= 15001 && RedditoAnnuale <= 28000)
            {
                contribuente.Imposta = (RedditoAnnuale - 15000) * 0.27 + 3450;
                Contribuente.Lista.Add(contribuente);
                Stampa();
                Start();
            }
            else if (RedditoAnnuale >= 28001 && RedditoAnnuale <= 55000)
            {
                contribuente.Imposta = (RedditoAnnuale - 28000) * 0.38 + 6960;
                Contribuente.Lista.Add(contribuente);
                Stampa();
                Start();
            }
            else if (RedditoAnnuale >= 55001 && RedditoAnnuale <= 75000)
            {
                contribuente.Imposta = (RedditoAnnuale - 55000) * 0.41 + 17220;
                Contribuente.Lista.Add(contribuente);
                Stampa();
                Start();
            }
            else if (RedditoAnnuale >= 75001)
            {
                contribuente.Imposta = (RedditoAnnuale - 75000) * 0.4 + 25420;
                Contribuente.Lista.Add(contribuente);
                Stampa();
                Start();
            }
        }

        

        public static void Stampa()
        {
            Console.WriteLine("Dati");
            foreach (Contribuente x in Lista)
            {
                Console.WriteLine(x.Nome);
                Console.WriteLine(x.Cognome);
                Console.WriteLine(x.DataDiNascita);
                Console.WriteLine(x.CodiceFiscale);
                Console.WriteLine(x.Sesso);
                Console.WriteLine(x.ComuneResidenza);
                Console.WriteLine(x.RedditoAnnuale);
                Console.WriteLine(x.Imposta);
            }
        }

       
    }
}
