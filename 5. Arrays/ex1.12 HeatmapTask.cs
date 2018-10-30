using System;
namespace Names
{
    internal static class HeatmapTask
    {
        public static string[] ArrayInit(int length, int minValue)
        {
            var fullArray = new string[length];
            for (int i = 0; i < length; i++)
                fullArray[i] = (i + minValue).ToString();
            return fullArray;
        }
        public static HeatmapData GetBirthsPerDateHeatmap(NameData[] names)
        {
            var label = ArrayInit(30, 2);
            var months = ArrayInit(12, 1);
            var heatMap = new double[30, 12];
            for (int i = 0; i < names.Length; i++)
            {
                if (names[i].BirthDate.Day != 1)
                    heatMap[names[i].BirthDate.Day-2, names[i].BirthDate.Month-1]++;
            }
            var result = new HeatmapData("Тепловая карта рождаемости в зависимости от дня и месяца для заданного имени",
                heatMap, label, months);
            return result;
        }
    }
}