using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4Fedorov
{
    class PriceComparator : IComparer
    {
        public int Compare(object? x, object? y)
        {
            if (x is Price<int> && y is Price<int>)
            {
                var price1 = x as Price<int>;
                var price2 = y as Price<int>;
                if (price1?.PriceRub > price2?.PriceRub) return 1;
                else if (price1?.PriceRub < price2?.PriceRub) return -1;
                return 0;
            }
            throw new Exception("Невозможно сравнить");
        }
    }
}
