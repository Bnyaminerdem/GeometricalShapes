using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricalShapes
{
    internal class Geo
    {
        static void Main()
        {
            for (int i = 0; i < 5; i++)
            {            
            Console.WriteLine("Geometrik Şekil Alan Hesaplamaları");
            Console.WriteLine("1- Kare");
            Console.WriteLine("2- Üçgen");
            Console.WriteLine("3- Daire");
            Console.WriteLine("4-Dikdörtgen");
            Console.Write("Seçiminizi yapın (1, 2, 3 veya 4 ): ");

                int vote;
                if (!int.TryParse(Console.ReadLine(), out vote))
                {
                    Console.WriteLine("Geçersiz seçim. Lütfen 1, 2, 3 veya 4 seçeneğini girin.");
                    return;
                }
                switch (vote)
                {
                    case 1:
                        Square kare = new Square();
                        Console.Write("Kare nin kenar uzunluğunu girin: ");
                        kare.KenarUzunluğu = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Kare'nin Alanı: " + kare.AlanHesapla());
                        break;

                    case 2:
                        Triangle ucgen = new Triangle();
                        Console.Write("Üçgenin 1. kenar uzunluğunu girin: ");
                        ucgen.Kenar1 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Üçgenin 2. kenar uzunluğunu girin: ");
                        ucgen.Kenar2 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Üçgenin 3. kenar uzunluğunu girin: ");
                        ucgen.Kenar3 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Üçgenin Alanı: " + ucgen.AlanHesapla());
                        break;

                    case 3:
                        Apartment daire = new Apartment();
                        Console.Write("Dairenin yarıçapını girin: ");
                        daire.Yaricap = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Dairenin Alanı: " + daire.AlanHesapla());
                        break;

                    case 4:
                        Rectangle dikdörtgen = new Rectangle();
                        Console.WriteLine("Dikdörtgenin uzun kenarını giriniz");
                        dikdörtgen.UzunKenar = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Dikdörtgenin kısa kenarını giriniz");
                        dikdörtgen.KısaKenar = Convert.ToDouble(Console.ReadLine());
                        double dikdörtgenAlan = dikdörtgen.AlanHesapla();
                        Console.WriteLine("Dikdörtgenin Alanı: " + dikdörtgenAlan);
                        break;

                    default:
                        Console.WriteLine("Geçersiz seçim. Lütfen 1, 2, 3 veya 4  seçeneğini girin.");
                        break;
                }
            }
        }
    }
}
