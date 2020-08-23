using System;
using System.Collections.Generic;
using System.Linq;

namespace Net.Coffee.Server.Domain
{
    public static class CurrencyRepository
    {
        private static Dictionary<string, Currency> currencies;

        static CurrencyRepository()
        {
            currencies = new Dictionary<string, Currency>()
            {
                { "EUR", new Currency("EUR,", "Euro","€") },
                { "TIME", new Currency("TIME,", "Time","Hours") },
                { "NIOC", new Currency("NIOC,", "Nioc","Nc") },
            };
        }

        public static Currency Get(string code)
        {
            if (!currencies.ContainsKey(code))
                throw new ArgumentException("Currency Code is not valid.", nameof(code));

            return currencies[code];
        }
    }
}

