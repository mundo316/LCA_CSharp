using System;
namespace CarLot
{
    public class Truck : Vehicle
    {
        //truck specific characteristics
        public string CabSize;
        public string BedSize;

        public Truck (string LicenseNumber, string make, string model, double price, string Cab, string Bed) : base(LicenseNumber, make, model, price)
        {
            //constructor for truck characteristics
            CabSize = Cab;
            BedSize = Bed;
        }

        public override void VehicleDescription()
        {
            //overrides basic vehicle info and adds truck specific paramaters
            Console.WriteLine(LiceNum);
            Console.WriteLine(Manufacturer);
            Console.WriteLine(Model);
            Console.WriteLine(Price);
            Console.WriteLine(CabSize);
            Console.WriteLine(BedSize);
        }
    }
}
