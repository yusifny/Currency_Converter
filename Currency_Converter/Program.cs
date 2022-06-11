using System;
using Currency_Converter.Enums;

namespace Currency_Converter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double Exchange(Currency currency, double azn)
            {
                double result = 0;
                if (currency == Enums.Currency.USD)
                {
                    result = azn * 0.59;
                }
                if (currency == Enums.Currency.TRY)
                {
                    result = azn * 8.72;
                }
                if (currency == Enums.Currency.EURO)
                {
                    result = azn * 0.5;
                }

                return result;
            }
            Console.WriteLine("Valyuta Deyeri");
            Console.WriteLine(Exchange(Currency.USD, 100));
        }
    }
}