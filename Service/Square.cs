using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class Square
    {
        /// <summary>
        /// Вычисление квадратного уравнения
        /// </summary>
        /// <param name="a">Коэфицент а</param>
        /// <param name="b">Коэфицент б</param>
        /// <param name="c">Коэфицент с</param>
        /// <returns>Возвращает результат вычеслений</returns>
        public static string SquareMethod(double a, double b, double c)
        {
            string result = "";
            Double d = (b * b) - (4 * a * c);
            if (a == 0)
            {
                return "Первое слогаемое не может быть = 0";
            }
            if (d > 0)
            {
                Double x1 = (-b + Math.Sqrt(d)) / (2 * a);
                Double x2 = (-b - Math.Sqrt(d)) / (2 * a);
                return $"Корень x1 ={x1}\n Корень x2 = {x2}";
            }
            else if (d == 0)
            {
                Double x = -b / (2 * a);
                return $"Корень x1 ={x}";
            }
            else
            {
                return "Нет корней";
            }
        }
    }
}
