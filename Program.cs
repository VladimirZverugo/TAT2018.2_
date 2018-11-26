using System;

namespace DEV3
{
    static class Program
    {
        static void Main(string[] args)
        {
            BaseConverter baseConverter = new BaseConverter();
            string converted = baseConverter.Convert(args);
            Console.WriteLine(converted);

            Console.Read();
        }
    }
}
