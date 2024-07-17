using System;
namespace Vehicle
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Vehicle originalVehicle = new Vehicle("Sedan", "Red", "Automatic");
            Console.WriteLine("Original Vehicle:");
            originalVehicle.DisplayInfo();
            
            Vehicle clonedVehicle = (Vehicle)originalVehicle.Clone();
            clonedVehicle.ChangeColor("Blue");
            Console.WriteLine("\nCloned Vehicle:");
            clonedVehicle.DisplayInfo();
        }
    }
}