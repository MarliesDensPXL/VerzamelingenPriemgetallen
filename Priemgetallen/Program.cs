using System.Security.Cryptography.X509Certificates;

namespace Priemgetallen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] primeNumbers = new int[100];

            for (int i = 0; i < 100; i++)
                {
              // code toevoegen om eerste 100 priemgetallen te verkrijgen
            }
                        
        }

        public static bool IsPrimeNumber(int number)
        {
            if (number == 0 || number == 1)
                {
                return false;
            }
            
            for (int i = 1; i <= (number / 2); i++)
            {
                if (number != i && number % i == 0)
                {
                    return false;                    
                }                
            }
            return true;
        }
    }
}
