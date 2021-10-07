using System;
using System.Collections.Generic;

namespace CEXR14
{
    class Program : Util
    {
        delegate void MyDel();

        static void Main(string[] args)
        {
            string plainText = GetPlainText();
            string singleKey = GetSingleKey();
            string multiKey = GetMultiKey();
            Console.WriteLine();

            Console.WriteLine($"You entered [{plainText}] as plain text");
            Console.WriteLine($"You entered [{singleKey}] as your single key");
            Console.WriteLine($"You entered [{multiKey}] as your multi key\n");

            int[] cleanText = Clean(plainText);
            int[] cleanSkey = Clean(singleKey);
            int[] cleanMkey = Clean(multiKey);

            string encSingle = SingleEnc(cleanText, cleanSkey);
            string encMulti = MultiEnc(cleanText, cleanMkey);
            string encConti = ContiEnc(cleanText, cleanMkey);

            Console.WriteLine($"Encrypted message with single key is [{encSingle}]");
            Console.WriteLine($"Encrypted message with multi key is [{encMulti}]");
            Console.WriteLine($"Encrypted message with continuous key is [{encConti}]");
            Console.WriteLine();

            string decSingle = SingleDec(encSingle, cleanSkey);
            string decMulti = MultiDec(encMulti, cleanMkey);
            string decConti = ContiDec(encConti, cleanMkey);

            Console.WriteLine($"Decrypted message with single key is [{decSingle}]");
            Console.WriteLine($"Decrypted message with multi key is [{decMulti}]");
            Console.WriteLine($"Decrypted message with continuous key is [{decConti}]");
            Console.WriteLine();
        }
    }
    class Util
    {
        internal static string GetPlainText()
        {
            Console.Write($"Enter plain text: ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            string plainText = Console.ReadLine();
            Console.ResetColor();
            return plainText;
        }

        internal static string GetSingleKey()
        {
            Console.Write("\nEnter your single key as an alpha character: ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            string singleKey = Console.ReadLine();
            Console.ResetColor();
            return singleKey;
        }
        internal static string GetMultiKey()
        {
            Console.Write("\nEnter your multi key as alpha characters: ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            string multiKey = Console.ReadLine();
            Console.ResetColor();
            return multiKey;
        }

        internal static int[] Clean(string text)
        {
            char[] charDirty = text.ToCharArray();
            List<int> intList = new List<int>();
            int index = 0;
            for (int i = 0; i < charDirty.Length; i++)
            {
                int intChar = (int)charDirty[i];

                if (intChar >= 65 && intChar <= 90)
                {
                    intList.Add(intChar);
                    index++;
                }
                else if (intChar >= 97 && intChar <= 122)
                {
                    intList.Add(intChar - 32);
                    index++;
                }
            }
            int[] intClean = intList.ToArray();
            return intClean;
        }

        internal static string SingleEnc(int[] cleanText, int[] cleanSkey)
        {
            int skey = cleanSkey[0] - 64;
            char[] temp = new char[cleanText.Length];
            for (int i = 0; i < cleanText.Length; i++)
            {
                temp[i] = (char)(cleanText[i] + skey);
            }
            string encSingle = new(temp);
            return encSingle;
        }

        internal static string SingleDec(string encSingle, int[] cleanSkey)
        {
            char[] encArray = encSingle.ToCharArray();
            int skey = cleanSkey[0] - 64;
            char[] temp = new char[encArray.Length];
            for (int i = 0; i < encArray.Length; i++)
            {
                temp[i] = (char)(encArray[i] - skey);
            }
            string decSingle = new(temp);
            return decSingle;

        }

        internal static string MultiEnc(int[] cleanText, int[] cleanMkey)
        {
            char[] temp = new char[cleanText.Length];
            int j = 0;
            for (int i = 0; i < cleanText.Length; i++)
            {
                int mkey = cleanMkey[j] - 64;
                if (j < cleanMkey.Length - 1)
                {
                    temp[i] = (char)(cleanText[i] + mkey);
                    j++;
                }
                else
                {
                    temp[i] = (char)(cleanText[i] + mkey);
                    j = 0;
                }
            }
            string encMulti = new(temp);
            return encMulti;
        }

        internal static string MultiDec(string encMulti, int[] cleanMkey)
        {
            char[] encArray = encMulti.ToCharArray();
            char[] temp = new char[encArray.Length];
            int j = 0;
            for (int i = 0; i < encArray.Length; i++)
            {
                int mkey = cleanMkey[j] - 64;
                if (j < cleanMkey.Length - 1)
                {
                    temp[i] = (char)(encArray[i] - mkey);
                    j++;
                }
                else
                {
                    temp[i] = (char)(encArray[i] - mkey);
                    j = 0;
                }
            }
            string decMulti = new(temp);
            return decMulti;
        }

        internal static string ContiEnc(int[] cleanText, int[] cleanMkey)
        {
            int[] tempKey = new int[cleanText.Length];
            int clean_diff = tempKey.Length - cleanMkey.Length;
            List<int> tempList = new List<int>();
            foreach (var item in cleanMkey)
            {
                tempList.Add(item - 64);
            }
            for (int i = 0; i < clean_diff; i++)
            {
                tempList.Add(cleanText[i] - 64);
            }
            tempKey = tempList.ToArray();
            char[] encArr = new char[tempKey.Length];
            for (int i = 0; i < encArr.Length; i++)
            {
                int encCode = cleanText[i] + tempKey[i];
                if (encCode > 90)
                {
                    encCode -= 26;
                    encArr[i] = (char)encCode;
                }
                else
                {
                    encArr[i] = (char)encCode;
                }
            }
            string encConti = new(encArr);
            return encConti;
        }

        internal static string ContiDec(string encConti, int[] cleanMkey)
        {
            char[] ch_code = encConti.ToCharArray();
            int[] int_code = new int[ch_code.Length];
            int[] int_asc = new int[ch_code.Length];
            for (int i = 0; i < cleanMkey.Length; i++)
            {
                int_code[i] = cleanMkey[i] - 64;
                int_asc[i] = (int)ch_code[i] - int_code[i];
            }
            for (int i = cleanMkey.Length; i < ch_code.Length; i++)
            {
                int_code[i] = int_asc[i - cleanMkey.Length] - 64;
                if ((int)ch_code[i] - int_code[i] < 65)
                {
                    int_asc[i] = (int)ch_code[i] - int_code[i] + 26;
                }
                else
                {
                    int_asc[i] = (int)ch_code[i] - int_code[i];
                }
            }
            for (int i = 0; i < ch_code.Length; i++)
            {
                ch_code[i] = (char)int_asc[i];
            }
            string decConti = new(ch_code);
            return decConti;
        }
    }
}

