using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Multivlaai_4
{
    class Medewerker: Persoongegevens
    {

        public string wachtwoord;

        public static int aantal = 0;
        
        
        private string _Gebdatum;
        private int _Leeftijd;


        public string Gebdatum
        {
            set
            {
                _Gebdatum = value;
            }
            get
            {
                return _Gebdatum;
            }
        }

        public int Leeftijd
        {
            set
            {
                _Leeftijd = value;
            }
            get
            {
                return _Leeftijd;
            }
        }



        public Medewerker()
        {
            
            Console.WriteLine("geef aub je wachtwoord op (Login): ");
            wachtwoord = Console.ReadLine();
            var i = 0;

            while (wachtwoord != "Login" && i < 3)
            {
                Console.WriteLine("probeer op nieuw, probeer nog een keer: ");
                wachtwoord = Console.ReadLine();
                i++;
            }

            if (i < 3)
            { }
            

            bool geboorte = false;

            var nlCulture = new CultureInfo("nl-NL");
            Console.WriteLine("Geboorte datum: " + "dd-mm-yyyy", nlCulture.DateTimeFormat.ShortDatePattern);
            Gebdatum = Console.ReadLine();
            DateTime Date = DateTime.Today;

            try
            {
                DateTime Datum = Convert.ToDateTime(Gebdatum);
                geboorte = true;
            }
            catch (Exception)
            {
                Console.WriteLine("het format van de opgegeven geboordedatum is niet correct.");
            }
            DateTime userDate;
            while (geboorte == false)

            {
                Console.WriteLine("Geboorte datum: " + "dd-mm-yyyy", nlCulture.DateTimeFormat.ShortDatePattern);
                Gebdatum = Console.ReadLine();

                if (DateTime.TryParse(Gebdatum, nlCulture.DateTimeFormat, DateTimeStyles.None, out userDate))

                {
                    geboorte = true;
                }
                else
                {
                    Console.WriteLine("Geen getal, probeer het nog eens.");
                }
            }

            Console.WriteLine("Leeftijd: ");
            DateTime TimeDate = DateTime.Today;
            DateTime GeboorteDatum = Convert.ToDateTime(Gebdatum);
            Leeftijd = TimeDate.Year - GeboorteDatum.Year;
            if (TimeDate.Month < GeboorteDatum.Month || (TimeDate.Month == GeboorteDatum.Month && TimeDate.Day < GeboorteDatum.Day)) Leeftijd--;
            Console.WriteLine(Leeftijd);

            Medewerker.aantal++;
        }

        public void toon()
        {
            Console.WriteLine(" {0} {1} {2} {3} ", Naam, AchterNaam, Straat, Huisnr);
        }
    }
}
