namespace Pluralize
{
    public static class PluralizeTask
    {
        public static string PluralizeRubles(int count)
        {
            // Напишите функцию склонения слова "рублей" в зависимости от предшествующего числительного count.
            
            if (5 <= count % 100 && count % 100 <= 20)
                return "рублей";
            else if (2 <= count % 10 && count % 10 <= 4)
                return "рубля";
            else if (count % 10 == 1)
                return "рубль";
            else
                return "рублей";

        }
    }
}