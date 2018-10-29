using System;

namespace Rectangles
{
    public static class RectanglesTask
    {
        // Пересекаются ли два прямоугольника (пересечение только по границе также считается пересечением)
        public static bool AreIntersected(Rectangle r1, Rectangle r2)
        {
            // так можно обратиться к координатам левого верхнего угла первого прямоугольника: r1.Left, r1.Top
            return (r1.Left + r1.Width < r2.Left || r2.Left + r2.Width < r1.Left || r1.Top + r1.Height < r2.Top ||
                    r2.Top + r2.Height < r1.Top) ? false : true;
            // само условие копипастнул отсюда:
            // https://stackoverflow.com/questions/13390333/two-rectangles-intersection/44120056#44120056

        }
        // Площадь пересечения прямоугольников
        public static int IntersectionSquare(Rectangle r1, Rectangle r2)
        {
            var s = 0;
            var left = Math.Max(r1.Left, r2.Left);
            var right = Math.Min(r1.Left + r1.Width, r2.Left + r2.Width);
            var top = Math.Max(r1.Top, r2.Top);
            var bottom = Math.Min(r1.Top + r1.Height, r2.Top + r2.Height);
            s = (right - left) * (bottom - top);
            return (AreIntersected(r1, r2)) ? s : 0; //если есть пересечение
        }

        // Если один из прямоугольников целиком находится внутри другого — вернуть номер (с нуля) внутреннего.
        // Иначе вернуть -1
        // Если прямоугольники совпадают, можно вернуть номер любого из них.
        public static int IndexOfInnerRectangle(Rectangle r1, Rectangle r2)
        {
            int squareR1, squareR2;
            squareR1 = r1.Height * r1.Width;
            squareR2 = r2.Height * r2.Width;

            // Проверка площадей и правых нижних с верхними левыми по X и Y соотв.
            if (squareR1 > squareR2)
            {
                if (r1.Right >= r2.Right && r1.Left <= r2.Left &&
                    r1.Top <= r2.Top && r1.Bottom >= r2.Bottom) return 1;
            }
            else
            {
                if (r1.Right <= r2.Right && r1.Left >= r2.Left &&
                    r1.Top >= r2.Top && r1.Bottom <= r2.Bottom) return 0;
            }
            return -1;
        }
    }
}
