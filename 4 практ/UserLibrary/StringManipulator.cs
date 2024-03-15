using System;

namespace UserLibrary
{
    public class StringManipulator
    {
        public static string RemoveAll(string input, string substring)
        {
            return input.Replace(substring, "");
        }

        public static string RemoveExtraSpaces(string input)
        {
            string[] words = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            return string.Join(" ", words);
        }

        public static string SortWords(string input)
        {
            string[] words = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            Array.Sort(words);
            return string.Join(" ", words);
        }
    }
}
