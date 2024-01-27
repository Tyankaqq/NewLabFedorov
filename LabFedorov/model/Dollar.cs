using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabFedorov.model
{
    internal class Dollar : Currency
    {
        public Dollar(int quality, double rate) : base(quality, rate)
        {
        }

        public override double Trade()
        {
            double result = quality * rate;
            Console.WriteLine("Курс в рублях" + result);
            return result;
        }
        
    }
}
