namespace Pluralize
{
    public static class PluralizeTask
    {
        public static string PluralizeRubles(int count)
        {
            if (2 <= count % 10 && count % 10 <= 4 && (count % 100 > 14 || count % 100 < 5))
                return "рубля";
            return (count % 10 == 1 && count % 100 != 11) ? "рубль" : "рублей";
        }
    }
}