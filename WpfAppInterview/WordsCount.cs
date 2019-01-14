using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppInterview
{
    public static class WordsCount
    {
        static Dictionary<string, int> wordsAndCount;

        public static string Count(string inputString)
        {
            string resultString = "";
            wordsAndCount = new Dictionary<string, int>();
            string text = inputString;
            char[] punctuation = text.Where(char.IsPunctuation).Distinct().ToArray();
            IEnumerable<string> words = text.Split().Select(x => x.Trim(punctuation));

            foreach (var word in words)
            {
                if (!wordsAndCount.ContainsKey(word))
                {
                    wordsAndCount.Add(word, 0);
                }
                wordsAndCount[word]++;
            }
            foreach (var item in wordsAndCount)
            {
                resultString += String.Format("{0} = {1}\n", item.Key, item.Value);
            }
            wordsAndCount.Clear();
            return resultString;
        }
    }
}
