using Lab3_Interface_FixBug;
using System.ComponentModel;

namespace Lab3_Library2
{
    [Description("Obliczanie ciągu arytmetycznego dla podanego argumentu. Podany argument powinien należeć do przedziału < 1 ; 100 >. Wyraz początkowy ciągu = 1, różnica = 4")]
    public class Arithmetic : ISimpleMathMethod
    {
        public int SimpleMethod(int number)
        {
            int a1 = 1;
            int r = 4;

            if (number < 1 || number > 100)
            {
                return 0;
            }

            else
            {
                return a1 + (number - 1) + r;
            }
        }
    }
}
