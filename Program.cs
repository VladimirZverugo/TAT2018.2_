using System;

namespace Volodya1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string str;
            int counter = 0;
            int answer = 1;
            Console.WriteLine("Input your symbol sequence:");
            str=Console.ReadLine();
            int length = str.Length;
            Console.WriteLine("string lenght is:{0}", length);
            for (int i = 1; i < length; i++) 
             {

                if (str[i-1]!=str[i])
                {
                     counter++;
                } 
                else 
                {
                    if (counter > answer) 
                    {
                        answer = counter;
                    }
                    counter = 0;
                }
             }
            if (counter > answer)
             {
                answer = counter;
             }
            Console.WriteLine("answer:{0}", answer);
        }
    }
}