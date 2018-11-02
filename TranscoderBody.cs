using System;



namespace DEV3
{

    public class BaseConverter
    {
        /// <summary>
        /// Converter: Number from 10th scale of notation to new base scale
        /// Reverse: inverts answer string to it's right form
        /// </summary>

        static string baseNum = "0123456789ABCDEFGHIJ";

        public void Converter(int num, int numBase)
        {
            string answer = "";

            while (num >= numBase)
            {
                answer += baseNum[num % numBase];
                num /= numBase;
            }
            answer += baseNum[num];
            answer = Reverse(answer);
            Console.WriteLine(answer);
        }

        private string Reverse(string num)
        {
            char[] charArray = num.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }  
    }
}
