using System.Security.Cryptography.X509Certificates;

namespace Priemgetallen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] primeNumbers = new int[100];

            // testje of methode werkt.
            //int number = 7;

            //bool isValid = IsPrimeNumber(number);
            //Console.WriteLine(isValid ? $"{number} is een priemgetal." : $"{number} is geen priemgetal.");

            // naamgeving is beter zo:
            int index = 0;
            for (int numberToCheck = 2; primeNumbers[99] == 0; numberToCheck++)
            {                
                bool isPrimeNumber = IsPrimeNumber(numberToCheck);
                if (isPrimeNumber)
                {
                    primeNumbers[index] = numberToCheck;
                    index++;
                }
            }

            // lengte langste priemgetal bepalen om uitlijning te bepalen -> @Wim: is het de bedoeling dat ik hiermee iets doe? Want dat krijg ik niet op de wereld. 
            int length = primeNumbers[99].ToString().Length + 2;
            // het laatste getal is per definitie ook hetgeen met het meeste cijfers, dus dit klopt inderdaad.

            Console.WriteLine("Dit zijn de eerste honderd priemgetallen: ");
            Console.WriteLine();
            
            //for (int i = 1; i <= primeNumbers.Length; i++)
            for (int i = 0; i < primeNumbers.Length; i++) // Eerste index is ALTIJD 0
            {
                //Console.Write($"{primeNumbers[i], 5}"); // @Wim: ik vermoed dat ik die '5' hier moet vervangen door de lengte maar dat geeft errors.
                // Klopt helemaal maar werkt gewoon niet met string interpolatie.
                // die ", 5" is eigenlijk een verkorte notatie van PadLeft, dus dat is wat ik nu heb gedaan.
                Console.Write($"{primeNumbers[i].ToString().PadLeft(length)}");
                
                if ((i + 1) %10 == 0) 
                {
                    Console.WriteLine();
                }
            }
            
        }

        public static bool IsPrimeNumber(int number)
        {
            //if (number <= 1)
            //{
            //    return false;
            //}
            
            for (int i = 2; i <= (number / 2); i++)
            {
                int modulus = number % i;
                if (modulus == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
