using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace task43
{
    //данный класс предназначен для описания линейной функции, здесь есть метод, который позволяет получить точку пересечения
    internal struct StraightLine
    {
        double k;
        double b;
        public StraightLine(double k, double b)
        {
            this.k = k;
            this.b = b;
        }
        public double getY(double x)
        {
            return k * x + b;
        }
        //метод возвращающий точку пересечения между текущей функцией и переданной в качестве параметра line, если точки пересечения нет, то бросает исключение
        public Point2D getIntersectionPoint(StraightLine line)
        {
            if (this.k == line.k){ //нет точки пересечения, т.к. эта прямая и прямая line - параллельны
                throw new NoInterSectionPointException("Нет точки пересечения, т.к. прямые параллельны или совпадают!");
            }
            else
            {
                Point2D intersectionPoint = new Point2D();
                intersectionPoint.X = (line.b - this.b) / (this.k - line.k);
                intersectionPoint.Y = getY(intersectionPoint.X);
                return intersectionPoint;
            }
        }
        public override string ToString()
        {
            return $"y(x) = {k}*x + {b}";
        }
    }
    //мой собственный класс для моего исключения, оно бросается если нет точки пересечения
    internal class NoInterSectionPointException : Exception
    {
        string msg;
        public NoInterSectionPointException(string msg)
        {
            this.msg = msg;
        }
        public string getMessage()
        {
            return msg;
        }
    }
}
