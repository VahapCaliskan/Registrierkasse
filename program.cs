using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registrier_Kasse
{
  class Program
  {
    static void Main(string[] args)
    {
      string saName1, saName2, saName3;
      double saPreis1, saPreis2, saPreis3;
      string eingabe1, eingabe2, eingabe3;
      Console.WriteLine("Geben Sie den Namen von Artikel 1 ein:");
      saName1 = Console.ReadLine();
      Console.WriteLine("Geben Sie den Preis von {0} ein:", saName1);
      eingabe1 = Console.ReadLine();
      if (!Double.TryParse(eingabe1, out saPreis1)) { Console.WriteLine("Es wurden falsche Eingaben gemacht.\nDrücke Q zum Beenden."); while(Console.ReadKey(true).Key != ConsoleKey.Q); return;  }
      saPreis1 = Double.Parse(eingabe1);
      Console.WriteLine("Geben Sie den Namen von Artikel 2 ein:");
      saName2 = Console.ReadLine();
      Console.WriteLine("Geben Sie den Preis von {0} ein:", saName2);
      eingabe2 = Console.ReadLine();
      if (!Double.TryParse(eingabe2, out saPreis2)) { Console.WriteLine("Es wurden falsche Eingaben gemacht.\nDrücke Q zum Beenden."); while (Console.ReadKey(true).Key != ConsoleKey.Q) ; return; }
      Console.WriteLine("Geben Sie den Namen von Artikel 3 ein:");
      saName3 = Console.ReadLine();
      Console.WriteLine("Geben Sie den Preis von {0} ein:", saName3);
      eingabe3 = Console.ReadLine();
      if (!Double.TryParse(eingabe3, out saPreis3)) { Console.WriteLine("Es wurden falsche Eingaben gemacht.\nDrücke Q zum Beenden."); while (Console.ReadKey(true).Key != ConsoleKey.Q) ; return; }
      Console.WriteLine("-------------");
      Console.WriteLine("Artikel Nr 1: " + saName1 + " - Preis: " + saPreis1.ToString() + " Euro");
      Console.WriteLine("Artikel Nr 2: " + saName2 + " - Preis: " + saPreis2.ToString() + " Euro");
      Console.WriteLine("Artikel Nr 3: " + saName3 + " - Preis: " + saPreis3.ToString() + " Euro");
      Console.WriteLine("Gesamtsumme: " + (saPreis1 + saPreis2 + saPreis3).ToString() + " Euro");
      Console.Read();
    }
  }
}
