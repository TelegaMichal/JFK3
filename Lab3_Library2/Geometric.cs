using Lab3_Interface_FixBug;
using System;
using System.ComponentModel;

namespace Lab3_Library2
{
    [Description("Obliczanie ciągu geometrycznego dla podanego argumentu. Podany argument powinien należeć do przedziału < 1 ; 30 >. Wyraz początkowy ciągu = 1, iloraz = 2")]
    public class Geometric : ISimpleMathMethod
    {
        public int SimpleMethod(int number)
        {
            int a1 = 1;
            int q = 2;

            if (number < 1 || number > 30)
            {
                return 0;
            }

            else
            {
                return a1 * (int)Math.Pow(q, number - 1);
            }
        }
    }
}
