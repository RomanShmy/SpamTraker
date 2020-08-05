using System.Linq;
using System.Collections.Generic;
using System;

namespace SpamTraker
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = {"hello", "hello", "hello", "World", "world"};
            Dictionary<string, int> wordsAndCount = CountWordFrequency(words);
            Console.WriteLine("1. Count of dictionary: " + (wordsAndCount.Count == 2 ? "+" : "-"));
            Console.WriteLine("2. Count of word hello: "  + (wordsAndCount["hello"] == 3 ? "+" : "-"));
            Console.WriteLine("3. Count of word world: " + (wordsAndCount["world"] == 2 ? "+" : "-"));
            string[] words2 = {};
            Dictionary<string, int> wordsAndCount2 = CountWordFrequency(words2);
            Console.WriteLine("4. Count of empty dictionary: " + (wordsAndCount2.Count == 0 ? "+" : "-"));
        }

        public static Dictionary<string, int> CountWordFrequency(string[] words){

            Dictionary<string, int> spam = new Dictionary<string, int>();
            int count = 1;
            foreach (var word in words)
            {
                string w = word.ToLower();
                if(spam.ContainsKey(w))
                {
                    spam[w] = ++count;
                }
                else
                {
                    count = 1;
                    spam.Add(w, count);
                }  
            }
            
            return spam;
        }

    }
}
