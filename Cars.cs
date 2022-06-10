using System;
namespace CarClass
{
    public class Cars
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        public void Description()
        {
            Console.WriteLine($"The {Model} was made in {Year} and was made by Warren{Make}");
        }
    }
}
