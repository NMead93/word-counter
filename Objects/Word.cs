using System;
using System.Collections.Generic;

namespace WordCounter.Objects
{
    public class RepeatCounter
    {
        private string _word;
        private string _sentence;

        public RepeatCounter(string word, string sentence)
        {
            _word = word;
            _sentence = sentence;
        }

        public string GetWord()
        {
            return _word;
        }

        public string GetSentence()
        {
            return _sentence;
        }

        public void SetWord(string word)
        {
            _word = word;
        }

        public void SetSentence(string sentence)
        {
            _sentence = sentence;
        }

        public int CountRepeats()
        {
            int wordCount = 0;
            string[] separators = {" ", ".", ",", "-", "!", "_", "?", "''", ":", ";", "~", "@", "#", "$", "%", "^", "&", "*", "(", ")", "=", "+", ""};
            string[] words = GetSentence().Split(separators, StringSplitOptions.RemoveEmptyEntries);
            foreach (var word in words)
            {
                Console.WriteLine(word);
                if (GetWord().ToLower() == word.ToLower())
                {
                    wordCount++;
                }
            }
            return wordCount;
        }
    }
}
