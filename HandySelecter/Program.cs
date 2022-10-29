using System;

namespace HandySelecter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Deklarierung und Initalisierung der Marken.
            string[] Marken = {"Apple", "Samsung", "Huawei", "Oppo", "Xiaomi", "BlackBerry" }; 
            
            int AnzahlMaken = Marken.Length; //Auslesen wie viele marken es gibt. In diesem Beispiel 6.

            Random zufällig = new Random(); //Deklarierung vom Typ Random.
            int num = zufällig.Next(AnzahlMaken); //Generieren einer zahl zwischen 0 und 5.

            Console.WriteLine(Marken[num]); //Passend zur generierten Zahl wird nun eine Marke ausgegeben.
        }
    }
}
