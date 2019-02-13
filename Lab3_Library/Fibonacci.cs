using Lab3_Interface_FixBug;
using System.ComponentModel;

namespace Lab3_Library
{
    [Description("Obliczanie ciągu Fibonacciego dla podanego argumentu. Podany argument powinien należeć do przedziału < 1 ; 30 >")]
    public class Fibonacci : ISimpleMathMethod
    {
        public int SimpleMethod(int number)
        {
            if (number < 1 || number > 30)
            {
                return 0;
            }

            else if (number == 1 || number == 2)
            {
                return 1;
            }

            else
            {
                return SimpleMethod(number - 1) + SimpleMethod(number - 2);
            }
        }
    }
}
