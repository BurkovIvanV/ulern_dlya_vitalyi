using System;
using System.Linq;
using System.Management.Instrumentation;

namespace Names
{
    internal static class HistogramTask
    {
        public static HistogramData GetBirthsPerDayHistogram(NameData[] names, string name)
        {
            var labels = new string[31];
            for (int i = 0; i < 31; i++)
            {
                labels[i] = (i + 1).ToString();
            }
            var days = new double[31];
            for (int i = 0; i < names.Length; i++)
            {
                if (names[i].Name == name && names[i].BirthDate.Day != 1)
                {
                    days[names[i].BirthDate.Day - 1]++;
                }
            }
            return new HistogramData(string.Format("Рождаемость людей с именем '{0}'", name), labels, days);
        }
    }
}