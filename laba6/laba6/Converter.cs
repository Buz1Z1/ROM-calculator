using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba6
{
    internal class Converter
    {
        public static string ConvToROME(string a)
        {
            int lenght = a.Length;
            string result = "";
            int tmp = lenght;
            for (int i = 0; i < lenght; i++)
            {

                if (tmp == 2)
                {
                    if (a[i] == '1')
                    {
                        result += "X";

                        tmp--;
                        continue;

                    };
                    if (a[i] == '2')
                    {
                        result += "XX";

                        tmp--; continue;

                    };
                    if (a[i] == '3')
                    {
                        result += "XXX";

                        tmp--; continue;

                    };
                    if (a[i] == '4')
                    {
                        result += "XL";

                        tmp--; continue;

                    };
                    if (a[i] == '5')
                    {
                        result += "L";

                        tmp--; continue;

                    };
                    if (a[i] == '6')
                    {
                        result += "LX";

                        tmp--; continue;

                    };
                    if (a[i] == '7')
                    {
                        result += "LXX";

                        tmp--; continue;

                    };
                    if (a[i] == '8')
                    {
                        result += "LXXX";

                        tmp--; continue;

                    };
                    if (a[i] == '9')
                    {
                        result += "XC";

                        tmp--; continue;

                    };
                    if (a[i] == '0')
                    {
                        tmp--;
                        continue;
                    }
                }
                if (tmp == 3)
                {
                    if (a[i] == '1')
                    {
                        result += "C";

                        tmp--;
                        continue;
                    };
                    if (a[i] == '2')
                    {
                        result += "CC";

                        tmp--;
                        continue;
                    };
                    if (a[i] == '3')
                    {
                        result += "CCC";

                        tmp--;
                        continue;
                    };
                    if (a[i] == '4')
                    {
                        result += "CD";

                        tmp--;
                        continue;
                    };
                    if (a[i] == '5')
                    {
                        result += "D";

                        tmp--;
                        continue;
                    };
                    if (a[i] == '6')
                    {
                        result += "DC";

                        tmp--;
                        continue;
                    };
                    if (a[i] == '7')
                    {
                        result += "DCC";

                        tmp--;
                        continue;
                    };
                    if (a[i] == '8')
                    {
                        result += "DCCC";

                        tmp--;
                        continue;
                    };
                    if (a[i] == '9')
                    {
                        result += "CM";

                        tmp--;
                        continue;
                    };
                    if (a[i] == '0')
                    {
                        tmp--;
                        continue;
                    }
                }
                if (tmp >= 4)
                {
                    int q = a[i] - '0';
                    for (int j = 0; j < q; j++)
                        result += "M";
                   tmp--;
                }
                if (tmp == 1)
                {
                    if (a[i] == '1')
                        result += "I";
                    if (a[i] == '2')
                        result += "II";
                    if (a[i] == '3')
                        result += "III";
                    if (a[i] == '4')
                        result += "IV";
                    if (a[i] == '5')
                        result += "V";
                    if (a[i] == '6')
                        result += "VI";
                    if (a[i] == '7')
                        result += "VII";
                    if (a[i] == '8')
                        result += "VIII";
                    if (a[i] == '9')
                        result += "IX";
                }
            }
            return result;
        }
        public static int ConvToInt(string s)
        {
            int result=0;
            Dictionary<char, int> rom = new Dictionary<char, int> {
            { 'I', 1 },
            { 'V', 5 },
            { 'X', 10 },
            { 'L', 50 },
            { 'C', 100 },
            { 'D', 500 },
            { 'M', 1000 }
        };
            for(int i=0;i<s.Length;i++)
            {
                if (i + 1 < s.Length && rom[s[i]] < rom[s[i + 1]])
                    result -= rom[s[i]];
                else
                    result += rom[s[i]];
            }
            return result;
        }
    }
}
