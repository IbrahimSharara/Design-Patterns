using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class CurrencyConverter
    {
        //Make Constructor Private to prevent access outside the class
        private CurrencyConverter()
        {
            // load Data For Testing 
            //دا عشان التطبيق ليس اكثر DP  السطر دا ملوش علاقة بال
            LoadData();
        }

        // Make static Var of the same class
        private static CurrencyConverter _instance;
        // make Lock obj to make it save will using multiThreding and wait every thread to be executed
        private static object _lock = new();
        // put this private field in a public static prop 
        public static CurrencyConverter Instance
        {
            get
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new();
                    }
                    return _instance;
                }
            }
        }

        // test the DP
        private IEnumerable<ExchangeRate> _exchangeRate;
        private void LoadData()
        {
            _exchangeRate = [new ExchangeRate("USD", "SAR", 3.75m)
                ,
                new ExchangeRate("USD", "EGP", 30.60m)
                ,
                new ExchangeRate("SAR", "EGP", 8.16m)];
        }

        public decimal Convert( string baseCurrency , string targetCurrency , decimal value)
        {
            var exchangeRate = this._exchangeRate.FirstOrDefault(x => x.TargetCurrency == targetCurrency && x.BaseCurrency == baseCurrency).Rate;
            return exchangeRate * value;
        }
    }
}
