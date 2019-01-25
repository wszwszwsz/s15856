﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumeral
{
    public class Roman
    {
        public static int fromRoman(String num) {

            var naz = num;
            var roz = naz.Length;
            int wyn = 0;

            for (int i = 0; i < roz; i++)
            {
                var d = naz[i];

                switch (d)
                {
                    case 'M':
                        wyn = wyn + 1000;
                        break;
                    case 'D':
                        wyn = wyn + 500;
                        break;
                    case 'C':
                        wyn = wyn + 100;
                        break;
                    case 'L':
                        wyn = wyn + 50;
                        break;
                    case 'X':
                        wyn = wyn + 10;
                        break;
                    case 'V':
                        wyn = wyn + 5;
                        break;
                    case 'I':
                        wyn = wyn + 1;
                        break;
                }
                
            }

            return wyn;

        }

        public static String toRoman(int num) {

            if ((num < 0) || (num > 3999)) throw new ArgumentOutOfRangeException("Value must be between 1 and 3999");
            if (num < 1) return string.Empty;
            if (num >= 1000) return "M" + toRoman(num - 1000);
            if (num >= 900) return "CM" + toRoman(num - 900); 
            if (num >= 500) return "D" + toRoman(num - 500);
            if (num >= 400) return "CD" + toRoman(num - 400);
            if (num >= 100) return "C" + toRoman(num - 100);
            if (num >= 90) return "XC" + toRoman(num - 90);
            if (num >= 50) return "L" + toRoman(num - 50);
            if (num >= 40) return "XL" + toRoman(num - 40);
            if (num >= 10) return "X" + toRoman(num - 10);
            if (num >= 9) return "IX" + toRoman(num - 9);
            if (num >= 5) return "V" + toRoman(num - 5);
            if (num >= 4) return "IV" + toRoman(num - 4);
            if (num >= 1) return "I" + toRoman(num - 1);
            throw new ArgumentOutOfRangeException("Value must be between 1 and 3999");
            
        }
    }
}
