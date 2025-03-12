using System.Collections.Generic;

namespace MostFrequentNumberInArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Testa funktionen
            Console.WriteLine(MostFrequentNumber(new int[] { 1, 3, 2, 3, 4, 1, 3, 2, 2, 2, 5 })); // 2
            Console.WriteLine(MostFrequentNumber(new int[] { 7, 7, 5, 5, 1, 1, 1, 2, 2, 2 })); // 1

            Console.ReadLine();
        }

        //Skriv en metod som tar emot en array av heltal och returnerar den mest förekommande siffran i array.
        //Om flera siffror har samma frekvens, returnera den lägsta siffran.
        //Regler: Listan kan innehålla positiva och negativa heltal. Använd en Dictionary eller en lista för att hålla koll på förekomster.
        //Optimera koden för att kunna hantera stora listor effektivt.
        public static int MostFrequentNumber(int[] array)
        {
            
        }

    }
}
