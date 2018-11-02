using System;
namespace DEV5_car_base
{
    public class CarFunc
    {
        /// <summary>
        /// Counts all the brands.
        /// </summary>
        /// <param name="cars">Cars.</param>
        public static void CountTypes(CarData[] cars)
        {
            int countBrand = cars.Length;

            for (int j = 0; j < cars.Length-1; j++)
            {
                for (int i = 1; i < cars.Length; i++)
                {
                    if (cars[j].brand.Equals(cars[i].brand) && i != j)
                    {
                        countBrand--;
                    }
                }
            }
            Console.WriteLine("The amount of brands is: " + countBrand);
        }
        /// <summary>
        /// Counts all cars.
        /// </summary>
        /// <param name="cars">Cars.</param>
        public static void CountAll(ref CarData[] cars)
        {
            int countCars = 0;

            foreach( CarData car in cars){
                countCars += car.stock;
            }
            Console.WriteLine("The amount of all cars is: " + countCars);
        }
        /// <summary>
        /// Averages the price.
        /// </summary>
        /// <param name="cars">Cars.</param>
        public static void AveragePrice(ref CarData[] cars)
        {
            double averagePrice = 0;
            foreach (CarData car in cars){
                averagePrice += car.price;
            }
            Console.WriteLine("The average price of car is: " + averagePrice / cars.Length);
        }
        /// <summary>
        /// Averages price of the brand.
        /// </summary>
        /// <param name="cars">Cars.</param>
        /// <param name="brandFromFunc">Brand from func.</param>
        public static void AveragePriceType(ref CarData[] cars, ref string brandFromFunc)
        {
            double averagePriceBrand = 0;
            int countOfBrand = 0;
            Console.WriteLine(brandFromFunc);

            foreach (CarData car in cars)
            {
                if (car.brand.ToLower() == brandFromFunc.ToLower())
                {
                    countOfBrand++;
                    averagePriceBrand += car.price;
                }
            }
            Console.WriteLine("The average price of car is: " + averagePriceBrand / countOfBrand);
        }
    }
}
