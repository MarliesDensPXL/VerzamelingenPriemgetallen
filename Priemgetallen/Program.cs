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

            int index = 0;
            for (int i = 2; primeNumbers[99] == 0; i++)
            {                
                bool isPrimeNumber = IsPrimeNumber(i);
                if (isPrimeNumber)
                {
                    primeNumbers[index] = i;
                    index += 1;
                }
            }

            // lengte langste priemgetal bepalen om uitlijning te bepalen -> hoe kan ik dit getal gebruiken? 
            int length = primeNumbers[99].ToString().Length;
            

            Console.WriteLine("Dit zijn de eerste honderd priemgetallen: ");
            Console.WriteLine();
            
           for (int i = 1; i <= primeNumbers.Length; i++)
            {
                Console.Write($"{primeNumbers[i-1], 5}");
                if (i%10 == 0)
                {
                    Console.WriteLine();
                }
            }
            
        }

        public static bool IsPrimeNumber(int number)
        {
            if (number <= 1)
                {
                return false;
                }

            int modulus = 1;
            
            for (int i = 2; i <= (number / 2); i++)
            {
                modulus = number % i;
                if (modulus == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
