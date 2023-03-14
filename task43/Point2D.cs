using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task43
{
    //данная структура описывает точку в двухмерном пространстве
    internal struct Point2D
    {
        public double X;
        public double Y;
        public Point2D(double x, double y)
        {
            X = x;
            Y = y;
        }
        public override string ToString() => $"({X}, {Y})";
    }
    
}
