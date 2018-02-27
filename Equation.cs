using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace TP_lab2_square
{
    // класс для вычисления значений дискриминанта, Х1 и Х2
    public class Equation
    {
        // строка для результата
        public static string res = "";
        // метод который вычисляет все значения и возвращает все данные в строке в отдельном классе 
        public string Equations(double a, double b, double c)
        {
            res = "";
            double D = b * b - 4 * a * c;
            double x1 = 0, x2 = 0;
            if (D > 0)
            {
                x1 = (-b - Math.Sqrt(D)) / (2 * a);
                x2 = (-b + Math.Sqrt(D)) / (2 * a);
                res += Math.Round(x1, 2).ToString() + "\n";
                res += Math.Round(x2, 2).ToString() + "\n";
            }
            else if (D == 0)
            {
                x1 = (-b) / (2 * a);
                x2 = x1;
                res += Math.Round(x1, 2).ToString() + "\n";
                res += Math.Round(x2, 2).ToString() + "\n";
            }
            else
            {
                var result = Solve(a, b, c);
                res += String.Format(new ComplexFormatter(), "{0:I0}", result.Item1) + "\n";
                res += String.Format(new ComplexFormatter(), "{0:I0}", result.Item2) + "\n";
            }
            res += "D = " + Math.Round(D, 2).ToString() + "\n";
            return res;
        }
        // метод для комплексных чисел
        private static Tuple<Complex, Complex> Solve(double a, double b, double c)
        {
            Complex d = b * b - 4 * a * c;
            var real = -b / (2 * a);
            var im = Complex.Sqrt(d) / (2 * a);
            return new Tuple<Complex, Complex>(real + im, real - im);
        }
    }
}
