using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabFedorov.model
{
    public abstract class Currency
    {
        protected Currency(int quality, double rate)
        {
            this.quality = quality;
            this.rate = rate;
        }

        public int quality {  get; set; }
        public  double rate { get; set; }
        public abstract double Trade();
    }

}
