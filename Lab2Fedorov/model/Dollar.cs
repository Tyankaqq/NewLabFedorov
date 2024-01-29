using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2Fedorov.model
{
    internal class Dollar : ICurrency
    {
        public int quality { get; set; }
        public double rate { get; set; }
        public Dollar(int quality, double rate)
        {
            this.quality = quality;
            this.rate = rate;
        }
        public double Trade()
        {
            double result = quality * rate;
            Console.WriteLine("Курс в рублях" + result);
            return result;
        }
        
    }
}
