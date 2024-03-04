using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4Fedorov
{
    public class Price<T> : ICloneable, IComparable
    {
        public T? IdProduct { get; set; }
        public string? NameShop { get; set; }
        public int PriceRub { get; set; }
        public static int Count = 0;
        public object Clone()
        {
            return new Price<T>()
            {
                IdProduct = this.IdProduct,
                NameShop = this.NameShop,
                PriceRub = this.PriceRub,
                
            };
        }
        public int CompareTo(object? obj)
        {
            if (obj is Price<T>)
            {
                Price<T>? monster = obj as Price<T>;
                return this.PriceRub.CompareTo(monster!.PriceRub);
            }
            else throw new Exception("Невозможно сравнить два объекта");
        }
    }
}
