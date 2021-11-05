using System;
using System.Collections.Generic;
using System.Text;

namespace Multivlaai_4
{
    class Klant: Persoongegevens
    {

        public static int aantal = 0;

        private string _Bestelling;

        public string Bestelling
        {
            set
            {
                _Bestelling = value;
            }
            get
            {
                return _Bestelling;
            }
        }


        public Klant()
        {

            Klant.aantal++;
                        

            Console.WriteLine($"{Naam   } U kunt uw betelling op geven!");
            Bestelling = Console.ReadLine();

        }

        public void toon()
        {
            Console.WriteLine(" {0} {1} {2} {3} ", Naam, AchterNaam, Straat, Huisnr);
        }
    }
}
