using System;
using System.Collections.Generic;

namespace DEV2
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            string str;
            Console.WriteLine("Input your string or symbols:");
            str = Console.ReadLine();
            str = str.ToLower();
            int length = str.Length;
            int LanguageCheckIndex = 0; //Cyrrylic index is "2"; English index is "1" 

            //language check method
            for (int i = 0; 1 < length; i++)
            {

                if (str[(int)i] >= 97 && str[(int)i] <= 122)
                {
                    LanguageCheckIndex = 1;//english
                    break;
                }
                else
                {
                    if (str[(int)i] >= 1072 && str[(int)i] <= 1103 || str[(int)i] == 184)
                    {
                        LanguageCheckIndex = 2;//russian
                        break;
                    }
                    else
                    {
                        LanguageCheckIndex = 0;//error
                    }
                }

            }
            switch (LanguageCheckIndex)
            {
                case 1:

                    Console.WriteLine("Transform translit to cyrrilic ");
                    var LetterTrToCyr = new Dictionary<string, string>();

                    LetterTrToCyr.Add("a", "а");
                    LetterTrToCyr.Add("b", "б");
                    LetterTrToCyr.Add("v", "в");
                    LetterTrToCyr.Add("g", "г");
                    LetterTrToCyr.Add("d", "д");
                    LetterTrToCyr.Add("e", "е");
                    LetterTrToCyr.Add("yo", "ё");
                    LetterTrToCyr.Add("zh", "ж");
                    LetterTrToCyr.Add("z", "з");
                    LetterTrToCyr.Add("i", "и");
                    LetterTrToCyr.Add("y", "й");
                    LetterTrToCyr.Add("k", "к");
                    LetterTrToCyr.Add("l", "л");
                    LetterTrToCyr.Add("m", "м");
                    LetterTrToCyr.Add("n", "н");
                    LetterTrToCyr.Add("o", "о");
                    LetterTrToCyr.Add("p", "п");
                    LetterTrToCyr.Add("r", "р");
                    LetterTrToCyr.Add("s", "с");
                    LetterTrToCyr.Add("t", "т");
                    LetterTrToCyr.Add("u", "у");
                    LetterTrToCyr.Add("f", "ф");
                    LetterTrToCyr.Add("kh", "х");
                    LetterTrToCyr.Add("ts", "ц");
                    LetterTrToCyr.Add("ch", "ч");
                    LetterTrToCyr.Add("sh", "ш");
                    LetterTrToCyr.Add("sch", "щ");
                    LetterTrToCyr.Add("yu", "ю");
                    LetterTrToCyr.Add(" ", " ");
                    LetterTrToCyr.Add("ya", "я");

                    foreach (KeyValuePair<String, String> entry in LetterTrToCyr)
                    {
                        if (str.Contains(entry.Key))
                        {
                            string value = entry.Value;
                            str = str.Replace(entry.Key, value);
                        }
                    }
                    Console.WriteLine(str);
                    break;

                case 2:

                    Console.WriteLine("Transform cyrrilic to translit ");
                    var LetterCyrToTr = new Dictionary<string, string>();

                    LetterCyrToTr.Add("а", "a");
                    LetterCyrToTr.Add("б", "b");
                    LetterCyrToTr.Add("в", "v");
                    LetterCyrToTr.Add("г", "g");
                    LetterCyrToTr.Add("д", "d");
                    LetterCyrToTr.Add("е", "e");
                    LetterCyrToTr.Add("ё", "yo");
                    LetterCyrToTr.Add("ж", "zh");
                    LetterCyrToTr.Add("з", "z");
                    LetterCyrToTr.Add("и", "i");
                    LetterCyrToTr.Add("й", "y");
                    LetterCyrToTr.Add("к", "k");
                    LetterCyrToTr.Add("л", "l");
                    LetterCyrToTr.Add("м", "m");
                    LetterCyrToTr.Add("н", "n");
                    LetterCyrToTr.Add("о", "o");
                    LetterCyrToTr.Add("п", "p");
                    LetterCyrToTr.Add("р", "r");
                    LetterCyrToTr.Add("с", "s");
                    LetterCyrToTr.Add("т", "t");
                    LetterCyrToTr.Add("у", "u");
                    LetterCyrToTr.Add("ф", "f");
                    LetterCyrToTr.Add("х", "kh");
                    LetterCyrToTr.Add("ц", "ts");
                    LetterCyrToTr.Add("ч", "ch");
                    LetterCyrToTr.Add("ш", "sh");
                    LetterCyrToTr.Add("щ", "sch");
                    LetterCyrToTr.Add("ъ", "");
                    LetterCyrToTr.Add("ы", "y");
                    LetterCyrToTr.Add("ь", "'");//takes ' sign after soft consonant letter
                    LetterCyrToTr.Add("э", "e");
                    LetterCyrToTr.Add("ю", "yu");
                    LetterCyrToTr.Add("я", "ya");
                    LetterCyrToTr.Add(" ", " ");//goes out of exception of spaces


                    foreach (KeyValuePair<String, String> entry in LetterCyrToTr)
                    {
                        if (str.Contains(entry.Key))
                        {
                            string value = entry.Value;
                            str = str.Replace(entry.Key, value);
                        }
                    }
                    Console.WriteLine(str);
                    break;

                case 0:
                    Console.WriteLine("The string must be started with letter symbols");
                    break;
            }

        }
    }
}
