using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 25. Вычислить частичную сумму ряда S=1/(1*3)+1 / (3 * 5) + 1 / (5 * 7) +⋯
    Вычисление прекратить, когда модуль очередного слагаемого станет меньше 0,001. 
    Проверьте, насколько сумма приблизилась к значению 1/2 */

namespace Lab_3_1_25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n = 2;
            double sum = 0;
            double S = 1 / ((n - 1) * (n + 1));
            while (S > 0.001)
            {
                n += 2;
                S = 1 / ((n - 1)*(n + 1));
                sum += S;                
                Console.WriteLine($"S={S}, sum={sum}");
            }
            Console.ReadKey();
        }
    }
}
