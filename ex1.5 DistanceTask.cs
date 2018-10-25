using System;
using System.Collections.Specialized;

namespace DistanceTask
{
    public static class DistanceTask
    {
        // Расстояние от точки (x, y) до отрезка AB с координатами A(ax, ay), B(bx, by)
        public static double GetLenght(double ax, double ay, double bx, double by)
        {
            return Math.Sqrt((bx - ax) * (bx - ax) + (by - ay) * (by - ay));
        }

        public static double GetCos(double ax, double ay, double bx, double by, double x, double y)
        {
            return (x - ax) * (bx - ax) + (y - ay) * (by - ay);
        }

        public static double GetDistanceToSegment(double ax, double ay, double bx, double by, double x, double y)
        {
            var vectorABLenght = GetLenght(ax, ay, bx, by);
            var vectorCALenght = GetLenght(x, y, ax, ay);
            var vectorCBLenght = GetLenght(x, y, bx, by);
            var p = (vectorABLenght + vectorCALenght + vectorCBLenght) / 2;
            var cosACandAB = GetCos(ax, ay, bx, by, x, y); //векторное произведение через координаты
            var cosBAandBC = GetCos(bx, by, ax, ay, x, y);
            var h = 2 * Math.Sqrt(p * (p - vectorABLenght) * (p - vectorCALenght) * 
                                  (p - vectorCBLenght)) / vectorABLenght;
            if (cosACandAB < 0)
                return vectorCALenght;
            else if (cosBAandBC < 0)
                return vectorCBLenght;
            else if (vectorABLenght == 0)
                return vectorCBLenght;
            return h;
        }
    }
}