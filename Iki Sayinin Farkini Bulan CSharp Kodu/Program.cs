using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iki_Sayinin_Farkini_Bulan_CSharp_Kodu
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Konsolda sayıları direkt yanına yazmasını istediğim için WriteLine yerine Write yazdım.

            Console.Write("Birinci Sayıyı Giriniz: ");
            int Sayı1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("İkinci Sayıyı Giriniz: ");
            int Sayı2 = Convert.ToInt32(Console.ReadLine());

            int Fark = Sayı1 - Sayı2;

            Console.Write("Girdiğiniz Sayıların Farkı: " + Fark);

            Console.ReadKey();

        }
    }
}