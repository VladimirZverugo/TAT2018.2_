using System;
using System.Collections.Generic;
using DEV5_car_base;

namespace DEV5_car_base
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            bool finish = false;
            bool finishInput = false;
            CarData[] cars = new CarData[0];
           
            do
            {
                while (!finishInput)
                {
                    Array.Resize(ref cars, cars.Length + 1);
                    cars[cars.Length - 1] = new CarData();
                    cars[cars.Length - 1].inPut();
                    Console.WriteLine("Is it all?(y/n");
                    string answer = Console.ReadLine().ToLower();
                    if(answer == "y")
                    {
                        finishInput = true;
                    }
                }

                Console.WriteLine("What you want to do?");
                string answerForQuestion = Console.ReadLine().ToLower();
                String[] brandFromText = answerForQuestion.Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries);//deletes empty innerstrings;
               
                if (brandFromText.Length > 2)
                {
                    answerForQuestion = "average price /";
                }
                ////
                /// 
                /// 
                ////
                switch (answerForQuestion)
                {
                    case "count types":
                        CarFunc.CountTypes( cars);
                        break;
                    case "count all":
                        CarFunc.CountAll(ref cars);
                        break;
                    case "average price":
                        CarFunc.AveragePrice(ref cars);
                        break;
                    case "average price /":
                        CarFunc.AveragePriceType(ref cars, ref brandFromText[2]);
                        break;
                    case "exit":
                        finish = true;
                        break;
                }

            } while (!finish);

        }

    }
}

