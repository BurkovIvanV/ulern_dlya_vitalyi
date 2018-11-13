using System.Collections;
using System.Collections.Generic;

namespace TextAnalysis
{
    static class FrequencyAnalysisTask
    {
        public static Dictionary<string, Dictionary<string, int>> AddingToDictionaryOne(List<List<string>> text)
        {
            var tempDictionary = new Dictionary<string, Dictionary<string, int>>();
            foreach (List<string> ngramm in text)
                for (int j = 0; j < ngramm.Count; j++)
                {
                    if (ngramm.Count - j > 1) //биграмма
                    {
                        CheckExceptions(tempDictionary, ngramm[j], ngramm[j + 1]);
                    }
                    if (ngramm.Count - j > 2) //триграммы
                    {
                        CheckExceptions(tempDictionary, ngramm[j] + " " + ngramm[j + 1], ngramm[j + 2]);
                    }
                }

            return tempDictionary;
        }

        public static void CheckExceptions(Dictionary<string, Dictionary<string, int>> dictionary, string a, string b)
        {
            if (!dictionary.ContainsKey(a))
                dictionary[a] = new Dictionary<string, int>();
            if (!dictionary[a].ContainsKey(b))
                dictionary[a][b] = 0;
            dictionary[a][b]++;
        }

        public static string ResultString(List<string> list)
        {
            string comparingVar = list[0];
            foreach (var e in list)
                if (string.CompareOrdinal(e, comparingVar) < 0)
                    comparingVar = e;
            return comparingVar;
        }

        public static Dictionary<string, string> GetMostFrequentNextWords(List<List<string>> text)
        {
            var tempDictionaryOne = AddingToDictionaryOne(text);
            var tempDictionaryTwo = new Dictionary<string, List<string>>();
            var result = new Dictionary<string, string>();

            foreach (var e in tempDictionaryOne)
            {
                int maxValue = 0;
                foreach (var k in e.Value)
                    if (k.Value > maxValue) maxValue = k.Value;
                foreach (var k in e.Value)
                    if (k.Value == maxValue)
                    {
                        if (!tempDictionaryTwo.ContainsKey(e.Key))
                            tempDictionaryTwo[e.Key] = new List<string>();
                        tempDictionaryTwo[e.Key].Add(k.Key);
                    }
            }
            foreach (var e in tempDictionaryTwo)
                result[e.Key] = ResultString(e.Value);
            return result;
        }
    }
}