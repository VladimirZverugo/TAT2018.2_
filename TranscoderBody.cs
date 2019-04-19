using System;

namespace DEV3
{

    public class BaseConverter
    {
        /// <summary>
        /// Converter: Number from 10th scale of notation to new base scale
        /// Reverse: inverts answer string to it's right form
        /// </summary>

        public string Convert(string[] args)
        {
            bool error = CheckInput(args);

            if (error == false)
            {
                string converted = "";
                int num = Int32.Parse(args[0]);
                int numBase = Int32.Parse(args[1]);
                bool isNegative = false;
                string baseNum = "0123456789ABCDEFGHIJ";

                if (num < 0)
                {
                    isNegative = true;
                    num *= -1;
                }
                    
                while (num >= numBase)
                {
                    converted += baseNum[num % numBase];
                    num /= numBase;
                }
                converted += baseNum[num];
                converted = Reverse(converted);

                if (isNegative == true)
                {
                   converted = converted.Insert(0, "-");
                }
                return converted;
            }

            else
            {
                return "Incorrect input";
            }
        }

        public bool CheckInput(string[] args)
        {
            if (args.Length != 2)
            {
                return true;
            }

            else
            {
                try
                {
                    if ((Int32.Parse(args[1]) <= 20) && (Int32.Parse(args[1]) >= 2))
                    {

                        if ((Int32.Parse(args[0]) / 1 == Int32.Parse(args[0])) || (Int32.Parse(args[0]) == 0))
                        {

                            return false;
                        }

                        else return true;
                    }

                    else return true;
                }

                catch
                {
                    return true;
                }
            }
        }

        public string Reverse(string num)
        {
            char[] charArray = num.ToCharArray();
            Array.Reverse(charArray);

            return new string (charArray);
        }
    }
}
