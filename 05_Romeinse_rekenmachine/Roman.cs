using System.Collections.Generic;
using System.Text;

namespace _05_Romeinse_rekenmachine
{
    public static class Roman
    {
        public static readonly Dictionary<char, int> RomanNumberDict;
        public static readonly Dictionary<int, string> NumberRomanDict;

        static Roman()
        {
            RomanNumberDict = new Dictionary<char, int>
            {
                { 'I', 1 },
                { 'V', 5 },
                { 'X', 10 },
                { 'L', 50 },
                { 'C', 100 },
                { 'D', 500 },
                { 'M', 1000 },
            };

            NumberRomanDict = new Dictionary<int, string>
            {
                { 1000, "M" },
                { 900, "CM" },
                { 500,  "D" },
                { 400,  "CD" },
                { 100,  "C" },
                { 90,   "XC" },
                { 50,   "L" },
                { 40,   "XL" },
                { 10,   "X" },
                { 5,    "V" },
                { 4,    "IV" },
                { 1,    "I" }
            };
        }

        public static string ToRoman(int number)
        {
            var roman = new StringBuilder();
            
            foreach (var current in NumberRomanDict)
            {
                while (number >= current.Key)
                {
                    roman.Append(current);
                    number -= current.Key;
                }
            }

            return roman.ToString();
        }

        public static int FromRoman(string str)
        {
            int result = 0;

            for (int i = 0; i < str.Length; i++)
            {
                int s1 = RomanNumberDict[str[i]];

                if (i + 1 < str.Length)
                {
                    int s2 = RomanNumberDict[str[i + 1]];

                    if (s1 >= s2)
                    {
                        result = result + s1;
                    }
                    else
                    {
                        result = result + s2 - s1;
                        i++;
                    }
                }
                else
                {
                    result = result + s1;
                    i++;
                }
            }
            return result;
        }
    }
}
