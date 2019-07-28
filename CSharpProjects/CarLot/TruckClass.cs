using System;
namespace CarLot
{
    public class Truck : Vehicle
    {
        public string CabSize;
        public string BedSize;

        public Truck (string LicenseNumber, string make, string model, double price, string Cab, string Bed) : base(LicenseNumber, make, model, price)
        {
            CabSize = Cab;
            BedSize = Bed;
        }

        public override void VehicleDescription()
        {
            Console.WriteLine(LiceNum);
            Console.WriteLine(Manufacturer);
            Console.WriteLine(Model);
            Console.WriteLine(Price);
            Console.WriteLine(CabSize);
            Console.WriteLine(BedSize);
        }
    }
}
