using System.Linq;

namespace VP_Pract3
{
    public struct StringInfo
    {

        private int lenght;
        private int digitCount;
        private int letterCount;
        public int Length
        {
            get
            {
                return lenght;
            }
            set
            {
                if (value > 0)
                {
                    lenght = value;
                }
                else
                {
                    throw new Exception("Length must be greater than 0");
                }
            } 
        }
        public int DigitCount 
        {
            get
            {
                return digitCount;
            }
            set
            {
                if (value > 0)
                {
                    digitCount = value;
                }
                else
                {
                    throw new Exception("DigitCount must be greater than 0");
                }
            }
        }
        public int LetterCount 
        {
            get
            {
                return letterCount;
            }
            set
            {
                if (value > 0)
                {
                    letterCount = value;
                }
                else
                {
                    throw new Exception("LetterCount must be greater than 0");
                }
            }
        }
    }

    public static class StringExtensions
    {
        public static StringInfo GetStringInfo(this string input)
        {
            StringInfo info = new StringInfo
            {
                Length = input.Length,
                DigitCount = input.Count(char.IsDigit),
                LetterCount = input.Count(char.IsLetter)
            };

            return info;
        }
    }
}