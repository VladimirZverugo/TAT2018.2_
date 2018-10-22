using System;
using System.Collections.Generic;
using DEV2;


namespace DEV2
{
    public class TranslatorClass
    {
        String stringCheck = "";

    
        // Language check method, uses a CheckIndex as an argument
        // of iterpretated languge: "1" is English(Latin)
        // "2" is Russian (Cyrrilic).

        public TranslatorClass()
        {
            string str;
            Console.WriteLine("Input your string or symbols:");
            str = Console.ReadLine();
            str = str.ToLower();
            int length = str.Length;

            stringCheck = String.Copy(str);
            for (int i = 0; 1 < length; i++)
            {
                if (str[(int)i] >= 97 && str[(int)i] <= 122)
                {
                    TransformEnCyrr(ref stringCheck);
                    break;
                }
                {
                    if (str[(int)i] >= 1072 && str[(int)i] <= 1103 || str[(int)i] == 184)
                    {
                        TransformCyrrEn(ref stringCheck);
                        break;
                    }
                    {
                        Console.WriteLine("The string must contain only Russian or English letters");
                        System.Environment.Exit(0);
                    }
                }
            }
        }

        public void TransformEnCyrr(ref String stringCheck)
        {
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
                if (stringCheck.Contains(entry.Key))
                {
                    string value = entry.Value;
                    stringCheck = stringCheck.Replace(entry.Key, value);
                }
            }
        }

        public void TransformCyrrEn(ref String stringCheck)
        {
            Console.WriteLine("Transform cyrrilic to translit ");
            var LetterCyrToTr = new Dictionary<string, string>
            {
                { "а", "a" },
                { "б", "b" },
                { "в", "v" },
                { "г", "g" },
                { "д", "d" },
                { "е", "e" },
                { "ё", "yo" },
                { "ж", "zh" },
                { "з", "z" },
                { "и", "i" },
                { "й", "y" },
                { "к", "k" },
                { "л", "l" },
                { "м", "m" },
                { "н", "n" },
                { "о", "o" },
                { "п", "p" },
                { "р", "r" },
                { "с", "s" },
                { "т", "t" },
                { "у", "u" },
                { "ф", "f" },
                { "х", "kh" },
                { "ц", "ts" },
                { "ч", "ch" },
                { "ш", "sh" },
                { "щ", "sch" },
                { "ъ", "" },
                { "ы", "y" },
                { "ь", "'" },//takes ' sign after soft consonant letter
                { "э", "e" },
                { "ю", "yu" },
                { "я", "ya" },
                { " ", " " }//goes out of exception of spaces
            };
            foreach (KeyValuePair<String, String> entry in LetterCyrToTr)
            {
                if (stringCheck.Contains(entry.Key))
                {
                    string value = entry.Value;
                    stringCheck = stringCheck.Replace(entry.Key, value);
                }
            }
        }
        //Output method
        public void Out()
        {
            Console.WriteLine(stringCheck);
        }
    }

}