using Lab3_Interface_FixBug;
using System.ComponentModel;

namespace Lab3_Library
{
    [Description("Obliczanie silni dla podanego argumentu. Podany argument powinien należeć do przedziału < 0 ; 10 >")]
    public class Factorial : ISimpleMathMethod
    {
        public int SimpleMethod(int number)
        {
            if (number < 0 || number > 10)
            {
                return 0;
            }

            else if (number == 0 || number == 1)
            {
                return 1;
            }

            else
            {
                return number * SimpleMethod(number - 1);
            }
        }
    }
}
