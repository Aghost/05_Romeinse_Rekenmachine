using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                    roman.Append(current.Value);
                    number -= current.Key;
                }
            }

            return roman.ToString();
        }

        public static int FromRoman(string roman)
        {
            int total = 0;

            int current, previous = 0;
            char currentRom, previousRom = '\0';

            for (int i = 0; i < roman.Length; i++)
            {
                currentRom = roman[i];

                previous = previousRom != '\0' ? RomanNumberDict[previousRom] : '\0';
                current = RomanNumberDict[currentRom];

                if (previous != 0 && current > previous)
                    total = total - (2 * previous) + current;
                else
                    total += current;

                previous = currentRom;
            }

            return total;
        }
    }
}
