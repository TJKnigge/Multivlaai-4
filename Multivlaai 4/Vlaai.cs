using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Multivlaai_4
{
    public class Vlaai
    {

        public string FormattedAmount
        {
            get { return string.Format(new CultureInfo("nl-NL"), "{0:C2}", Verkoop, Inkoop, Winst); }
        }

        public static int aantal = 0;

        public int Id;
        public string SoortVlaai;
        public decimal Inkoop;
        public decimal Verkoop;
        public decimal Winst;
                       

        public Vlaai()
        {
            Vlaai.aantal++;

            Console.WriteLine("Id van product:");
            Id = int.Parse(Console.ReadLine());

            Console.WriteLine("Soortvlaai:");
            SoortVlaai = Console.ReadLine();

            Console.WriteLine("Inkoopprijs:" );
            Inkoop = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Verkoopprijs:");
            Verkoop = decimal.Parse(Console.ReadLine());

            Console.WriteLine($"Winst: ");
            Winst = Verkoop - Inkoop;
            Console.WriteLine(Winst);
        }

        public void toon()
        {
            Console.WriteLine("verkoop: {0} {1} {2} {3} {4}", Id, SoortVlaai, Inkoop, Verkoop, Winst);
        }
    }
}
