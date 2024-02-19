using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Lab3Fedorov
{
    class Money
    {
        public long Rubles { get; set; }
        public byte Cent { get; set; }
    //    private byte cent; 


    //public byte сent
    //{
    //    get { return cent; }
    //    set
    //    {
    //        if (value >= 0 && value <= 99) 
    //        {
    //            cent = value;
    //        }
    //        else
    //        {
    //            throw new ArgumentOutOfRangeException("Cent должен быть в диапазоне от 0 до 99.");
    //        }
    //    }
    //}

        public static Money operator +(Money m1, Money m2)
        {
            double a1 = m1.Rubles + (m1.Cent / Math.Pow(10, m1.Cent.ToString().Length));
            double a2 = m2.Rubles + (m2.Cent / Math.Pow(10, m2.Cent.ToString().Length));
            double res = Math.Round(a1 + a2, 3);
            string[] parts = res.ToString().Split(',');
            byte cents = 0;
            if (parts.Length > 1)
            {
                byte.TryParse(parts[1], out cents);
            }

            return new Money() { Rubles = (long)Math.Floor(res), Cent = cents };
        }

        public static Money operator -(Money m1, Money m2)
        {
            double a1 = m1.Rubles + (m1.Cent / Math.Pow(10, m1.Cent.ToString().Length));
            double a2 = m2.Rubles + (m2.Cent / Math.Pow(10, m2.Cent.ToString().Length));
            double res = Math.Round(a1 - a2, 3);
            string[] parts = res.ToString().Split(',');
            byte cents = 0;
            if (parts.Length > 1)
            {
                byte.TryParse(parts[1], out cents);
            }

            return new Money() { Rubles = (long)Math.Floor(res), Cent = cents };

        }

        public static Money operator *(Money m1, Money m2)
        {
            double a1 = m1.Rubles + (m1.Cent / Math.Pow(10, m1.Cent.ToString().Length));
            double a2 = m2.Rubles + (m2.Cent / Math.Pow(10, m2.Cent.ToString().Length));
            double res = Math.Round(a1 * a2, 3);
            string[] parts = res.ToString().Split(',');
            byte cents = 0;
            if (parts.Length > 1)
            {
                byte.TryParse(parts[1], out cents);
            }

            return new Money() { Rubles = (long)Math.Floor(res), Cent = cents };
        }

        public static Money operator /(Money m1, Money m2)
        {
            double a1 = m1.Rubles + (m1.Cent / Math.Pow(10, m1.Cent.ToString().Length));
            double a2 = m2.Rubles + (m2.Cent / Math.Pow(10, m2.Cent.ToString().Length));
            double res = Math.Round(a1 / a2, 3);
            string[] parts = res.ToString().Split(',');
            byte cents = 0;
            if (parts.Length > 1)
            {
                byte.TryParse(parts[1], out cents);
            }

            return new Money() { Rubles = (long)Math.Floor(res), Cent = cents };
        }

        public static bool operator ==(Money m1, Money m2)
        {
            if (m1.Rubles == m2.Rubles && m1.Cent == m2.Cent)
                return true;
            else return false;
        }
        public static bool operator !=(Money m1, Money m2)
        {
            if (m1.Rubles != m2.Rubles || m1.Cent != m2.Cent)
                return true;
            else return false;
        }

        public override string ToString()
        {
            return $"{Rubles},{Cent}";
        }
    }

}



