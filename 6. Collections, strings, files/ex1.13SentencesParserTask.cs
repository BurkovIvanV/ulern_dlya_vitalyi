using System;
using System.Collections.Generic;

namespace TextAnalysis
{
   public static class SentencesParserTask
    {
        public static List<List<string>> ParseSentences(string text)
        {
            var sentencesList = new List<List<string>>();
            string[] sentenceString;
            sentenceString = text.Split('.', '!', '?', ':', ';', '(', ')');
            foreach (var s in sentenceString)
            {
                if (ParseSymbols(s).Count != 0)
                    sentencesList.Add(ParseSymbols(s));
            }
            return sentencesList;
        }

        private static List<string> ParseSymbols(string sentence)
        {
            var wordsInSentence = new List<string>();
            var tempWord = "";

            foreach (var symbol in sentence)
            {
                if (char.IsLetter(symbol) || symbol == '\'')
                {
                    tempWord += Char.ToLower(symbol);
                }
                else if (tempWord != "")
                    {
                        wordsInSentence.Add(tempWord);
                        tempWord = "";
                    }
            }
            if (tempWord.Length != 0)
                wordsInSentence.Add(tempWord);

            return wordsInSentence;
        }
    }
}