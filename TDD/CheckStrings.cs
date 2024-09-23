using System;

namespace TDD
{
    public class CheckStrings
    {
        public int CountChars(string text)
        {
            return text.Length;
        }

        public int CountNumbers(string text)
        {
            int count = 0;
            foreach (char c in text)
            {
                if (char.IsDigit(c))
                    count++;
            }
            return count;
        }

        public int CountWords(string text)
        {
            return text.Split(' ').Length;
        }

        public int FindSubstring(string text)
        {
            int count = 0;

            for (int i = 0; i < text.Length - 1; i++)
            {
                if (text.Substring(i, 2) == "ам")
                    count++;
            }
            return count;
        }

        public int LargestConsecutiveNumbers(string text)
        {
            int currentLength = 0;
            int maxLength = 0;

            foreach (char c in text)
            {
                if (char.IsDigit(c))
                {
                    currentLength++;
                }
                else
                {
                    if (currentLength > maxLength)
                        maxLength = currentLength;
                    currentLength = 0;
                }
            }
            if (currentLength > maxLength)
                maxLength = currentLength;
            return maxLength;
        }

        public char? NinthChar(string text)
        {
            if (text.Length >= 9)
            {
                return text[8];
            }
            return null;
        }

        public string ShortestWord(string text)
        {
            string[] words = text.Split(new[] { ' ', '\t', '\n', '\r', '!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '-', '_', '=', '+', '[', '{', ']', '}', ';', ':', '\'', '"', ',', '<', '.', '>', '.', '?' }, StringSplitOptions.RemoveEmptyEntries); ;
            string shortestWord = null;
            foreach (string word in words)
            {
                if (shortestWord == null)
                    shortestWord = word;
                else if (word.Length < shortestWord.Length)
                {
                    shortestWord = word;
                }
            }
            return shortestWord;
        }
    }
}