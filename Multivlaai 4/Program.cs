using System;
using System.Collections.Generic;

namespace Multivlaai_4
{
    enum Winkel
    {
        Klanten,
        Medewerker,
        Bestaklnt,
        Bestwerk,
        Verkoop,
    }


    class Program
    {


        static List<Klant> klanten = new List<Klant>();
        static List<Medewerker> medewerker = new List<Medewerker>();
        static List<BestaandKlant> bestaklnt = new List<BestaandKlant>();
        static List<BestaandMedewerker> bestwerk = new List<BestaandMedewerker>();
        static List<Vlaai> verkoop = new List<Vlaai>();


        static void Main(string[] args)
        {
            bool doorgaan = true;

            Console.WriteLine(" 0 voor niewe klant. \n 1 voor nieuwe medewerker. \n 2 voor soorten vlaai's.");
            Winkel kies = (Winkel)int.Parse(Console.ReadLine());

            switch (kies)
            {
                case Winkel.Klanten:
                    foreach (var klant in klanten)
                    {
                        klant.toon();
                    }
                    break;

                case Winkel.Medewerker:
                    foreach (var werker in medewerker)
                    {
                        werker.toon();
                    }
                    break;

                case Winkel.Verkoop:
                    foreach (var verkocht in verkoop)
                    {
                        verkocht.toon();
                    }
                    break;

                default:

                    foreach (var klant in klanten)
                    {
                        klant.toon();
                    }
                    foreach (var werker in medewerker)
                    {
                        werker.toon();
                    }
                    foreach (var verkocht in verkoop)
                    {
                        verkocht.toon();
                    }

                    break;
            }


            Console.WriteLine("invoeren klant gegevens");

            while (doorgaan)
            {
                var klant = new Klant();
                klanten.Add(klant);

                check(ref doorgaan);
            }

            doorgaan = true;
            Console.WriteLine("invoeren medewerker gegevens");

            while (doorgaan)
            {
                var werker = new Medewerker();
                medewerker.Add(werker);

                check(ref doorgaan);
            }

            doorgaan = true;
            Console.WriteLine("invoeren soorten vlaai");

            while (doorgaan)
            {
                var verkocht = new Vlaai();
                verkoop.Add(verkocht);

                check(ref doorgaan);
            }           

        }       

        static void check(ref bool doorgaan)
        {

            Console.WriteLine("Wilt u door gaan j/n");

            if (Console.ReadLine() == "n")
            {
                doorgaan = false;
                
            }

        }


    }      
}
