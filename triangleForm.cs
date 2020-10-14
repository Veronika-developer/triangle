using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tund
{
    class triangleForm
    {
        public double a; // первая сторона
        public double b; // вторая сторона
        public double c; // третья сторона
        public double h; // высота
        public string answer;
        public triangleForm(double A, double B, double C, double H)
        {
            a = A;
            b = B;
            c = C;
            h = H;
        }
        public string outputA() // выводим сторону а, данный метод возвращает строковое значение
        {
            return Convert.ToString(a); // a - ссылка на внутренее поле обьекта класса
        }
        public string outputB()
        {
            return Convert.ToString(b);
        }
        public string outputC()
        {
            return Convert.ToString(c);
        }
        public string outputH()
        {
            return Convert.ToString(h);
        }
        public double AreaOfTriangle() // нахождение площади
        {
            double S;
            S = 1 / 2 * b * h;
            return S;
        }
        public string TypeOfTriangle()//определение типа треугольника
        {
            if ((a * a == b * b + c * c) || (b * b == c * c + a * a) || (c * c == a * a + b * b))
            {
                answer = "прямоугольный";
            }
            else if ((a * a > b * b + c * c) || (c * c > a * a + b * b) || (b * b > a * a + c * c))
            {
                answer = "тупоугольный";
            }
            else
            {
                answer = "остроугольный";
            }
            return answer;
        }
        public string FindOutTheSide()
        {
            if(answer == "прямоугольный")
            {

            }
        }
    }
}
