using System;
namespace CarLot
{
    public abstract class Vehicle
    {
        public string LiceNum;
        public string Manufacturer;
        public string Model;
        public double Price;

        public Vehicle(string LicenseNumber, string make, string model, double price)
        {
            LiceNum = LicenseNumber;
            Manufacturer = make;
            Model = model;
            Price = price;
        }

        public virtual void VehicleDescription()
        {
            Console.WriteLine(LiceNum);
            Console.WriteLine(Manufacturer);
            Console.WriteLine(Model);
            Console.WriteLine(Price);
        }

        



        
    }
}
