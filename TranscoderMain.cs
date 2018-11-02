using System;

namespace DEV3
{
    class MainClass
    {   
        static void Main(string[] args)
        {
            int num; // takes Number in 10th scale of notation
            int numBase; // new scale of notation
            BaseConverter mda = new BaseConverter();

            try
            {
                Console.WriteLine("input symbols");
                num = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("input your base");
                numBase = Convert.ToInt32(Console.ReadLine());
                mda.Converter(num, numBase);
            }
            catch(Exception e)
            {
                Console.WriteLine("Some Exception. SORRY!!! {0}",e);
            }
        }
    }
}
