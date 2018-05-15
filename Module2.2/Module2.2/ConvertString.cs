using System;
using System.Text.RegularExpressions;

namespace Module2._2
{
    public static class ConvertString
    {
        public static int ConvertStringToInt(this string str)
        {
            int finalNumeric = 0;
            if ((Regex.Match(str, @"(^(\d)(\d))|(^(\-\d)(\d))").Success) && (str != null))
            {
                int pow = str.Length - 1;
                for (int i = pow; i >= 0; i--)
                {
                    char[] charElements = str.ToCharArray();
                    if (charElements[i] != '-')
                    {
                        checked
                        {
                            try
                            {
                                finalNumeric += (int)Char.GetNumericValue(charElements[i]) * (int)Math.Pow(10, pow - i);
                            }
                            catch (OverflowException e)
                            {
                                throw new OverflowException("Число с переполнением: " + unchecked(finalNumeric));
                            }
                        }
                    }
                    else
                    {
                        finalNumeric *= (-1);
                    }
                }

                return finalNumeric;
            }
            else { throw new ArgumentException("Введите число!"); }
        }
    }
}


