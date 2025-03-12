using System.Collections.Generic;

namespace MostFrequentNumberInArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Testa funktionen
            Console.WriteLine(MostFrequentDigitInArray(new int[] { 1, 3, 2, 3, 4, 1, 3, 2, 2, 2, 5 })); // 2
            Console.WriteLine(MostFrequentDigitInArray(new int[] { 7, 7, 5, 5, 1, 1, 1, 2, 2, 2 })); // 1

            Console.WriteLine(MostFrequentDigitInArray(new int[] { 123, -321, 112, 44, 99 })); // 1

            Console.ReadLine();
        }

        //Skriv en metod som tar emot en array av heltal och returnerar den mest förekommande siffran i array.
        //Om flera siffror har samma frekvens, returnera den lägsta siffran.
        //Regler: Listan kan innehålla positiva och negativa heltal. Använd en Dictionary eller en lista för att hålla koll på förekomster.
        //Optimera koden för att kunna hantera stora listor effektivt.

        public static int MostFrequentDigitInArray(int[] numbersInArray)
        {
            // Felhantering om arrayen är tom eller null
            if (numbersInArray == null || numbersInArray.Length == 0)
            {
                return -1; // Visar att ingen siffra kunde hittas
            }

            // Dictionary för att lagra siffror och hur många gånger varje siffra förekommer
            Dictionary<int, int> digitOccurrences = new Dictionary<int, int>();

            // Loopa igenom alla tal i arrayen
            foreach (int number in numbersInArray)
            {
                int currentNumber = Math.Abs(number); // Gör negativa tal positiva

                // Gå igenom varje siffra i det aktuella talet
                while (currentNumber > 0)
                {
                    int lastDigit = currentNumber % 10; // Hämta sista siffran i talet, för att dela upp om talet är större än 10

                    // Lägg till eller uppdatera antalet gånger siffran förekommer
                    if (digitOccurrences.ContainsKey(lastDigit))
                    {
                        digitOccurrences[lastDigit]++;
                    }
                    else
                    {
                        digitOccurrences[lastDigit] = 1;
                    }

                    currentNumber /= 10; // Ta bort sista siffran genom att dela med 10
                }
            }

            // Hitta den mest förekommande siffran
            int mostFrequentDigit = -1;
            int highestFrequency = 0;

            foreach (var digitEntry in digitOccurrences)
            {
                int digit = digitEntry.Key; // Själva siffran
                int frequency = digitEntry.Value; // Hur ofta den förekommer

                // Uppdatera om vi hittar en siffra med högre förekomst
                // Om samma frekvens, välj den lägsta siffran
                if (frequency > highestFrequency || (frequency == highestFrequency && digit < mostFrequentDigit))
                {
                    mostFrequentDigit = digit;
                    highestFrequency = frequency;
                }
            }

            return mostFrequentDigit;
        }

    }
}
