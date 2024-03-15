using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System;
using System.Text;

namespace UserLibrary
{
    public class StringBuilderManipulator
    {
        public static string InsertStringAfterChar(string input, char c, string insertString)
        {
            StringBuilder sb = new StringBuilder(input);
            int index = 0;
            while ((index = sb.ToString().IndexOf(c, index)) != -1)
            {
                sb.Insert(index + 1, insertString);
                index += insertString.Length + 1;
            }
            return sb.ToString();
        }

        public static void PadStrings(ref string s1, ref string s2)
        {
            int maxLength = Math.Max(s1.Length, s2.Length);

            StringBuilder sb1 = new StringBuilder(s1);
            StringBuilder sb2 = new StringBuilder(s2);

            sb1.Append(' ', maxLength - s1.Length);
            sb2.Append(' ', maxLength - s2.Length);

            s1 = sb1.ToString();
            s2 = sb2.ToString();
        }
        public static string DecimalToBinary(string input)
        {
            int number = int.Parse(input);
            StringBuilder binaryNumber = new StringBuilder();

            while (number > 0)
            {
                binaryNumber.Insert(0, number % 2);
                number /= 2;
            }

            return binaryNumber.ToString();
            //int decimalNumber = int.Parse(input);
            //return Convert.ToString(decimalNumber, 2);
        }
    }


        //public static string DecimalToBinary(string input)
        //{
        //    int decimalNumber = int.Parse(input);
        //    return Convert.ToString(decimalNumber, 2);
        //}
    
}
