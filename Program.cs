using System;

namespace CarClass
{
    class Program
    {
        static void Main(string[] args)
        {
            var car = new Cars();
            car.Make = "Warren Tran";
            car.Model = "Honda";
            car.Year = 2017;

            car.Description();
        }
    }
}
