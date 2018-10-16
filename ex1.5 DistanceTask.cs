using System;
using System.Collections.Specialized;

namespace DistanceTask
{
	public static class DistanceTask
	{
        // Расстояние от точки (x, y) до отрезка AB с координатами A(ax, ay), B(bx, by)
	    public static double GetDistanceToSegment(double ax, double ay, double bx, double by, double x, double y)
		{
           
		    var segmentLenght = Math.Sqrt(Math.Pow(bx - ax, 2) + Math.Pow(by - ay, 2));
		    var vector1Lenght = Math.Sqrt(Math.Pow(ax - x, 2) + Math.Pow(ay - y, 2));
		    var vector2Lenght = Math.Sqrt(Math.Pow(bx - x, 2) + Math.Pow(by - y, 2));
		    var p = (segmentLenght + vector1Lenght + vector2Lenght)/2;
		   
		    var cos1 = (x - ax)*(bx-ax) + (y-ay)*(by-ay); //векторное произведение через координаты
		    var cos2 = (x-bx)*(ax-bx) + (y-by)*(ay-by);
		    var h = 2 * Math.Sqrt(p * (p - segmentLenght) * (p - vector1Lenght) * (p - vector2Lenght))/segmentLenght;
		    if (cos1 < 0)
		        return vector1Lenght;
            else if (cos2 < 0)
		        return vector2Lenght;
            else if(segmentLenght==0)
                return vector2Lenght;
            return h;
		}
	}
}