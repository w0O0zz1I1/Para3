using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class Line
    {/// <summary>
     /// Метод для вычислния линейного уравнения
     /// </summary>
     /// <param name="k">коэфицент к</param>
     /// <param name="b">коэфицент б</param>
     /// <returns>результат вычисления</returns>
        public static string LineMethod(double k, double b)
        {
            if (k == 0 && b == 0)
            {
                return "Совпадение с осью, ответ R";
            }
            if (k == 0)
            {
                return "Нет решений";
            }
            else
            {
                var x = -b / k;
                return $"Ответ {x}";
            }
        }
    }
}
