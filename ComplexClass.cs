using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace TP_lab2_square
{
    // класс для форматирования чисел типа Complex и представления их в строковом виде
    public class ComplexFormatter : IFormatProvider, ICustomFormatter
    {
        // метод определяет формат
        public object GetFormat(Type formatType)
        {
            if (formatType == typeof(ICustomFormatter))
                return this;
            else
                return null;
        }
        // метод форматирует комплексные числа
        public string Format(string format, object arg, IFormatProvider provider)
        {
            if (arg is Complex)
            {
                Complex c1 = (Complex)arg;
                // Проверяем, имеет ли строка спецификатор точности.
                int precision;
                string fmtString = String.Empty;
                if (format.Length > 1)
                {
                    try
                    {
                        precision = Int32.Parse(format.Substring(1));
                    }
                    catch (FormatException)
                    {
                        precision = 0;
                    }
                    fmtString = "N" + precision.ToString();
                }
                if (format.Substring(0, 1).Equals("I", StringComparison.OrdinalIgnoreCase))
                    return c1.Real.ToString(fmtString) + " + " + c1.Imaginary.ToString(fmtString) + "i";
                else if (format.Substring(0, 1).Equals("J", StringComparison.OrdinalIgnoreCase))
                    return c1.Real.ToString(fmtString) + " + " + c1.Imaginary.ToString(fmtString) + "j";
                else
                    return c1.ToString(format, provider);
            }
            else
            {
                if (arg is IFormattable)
                    return ((IFormattable)arg).ToString(format, provider);
                else if (arg != null)
                    return arg.ToString();
                else
                    return String.Empty;
            }
        }
    }
}
