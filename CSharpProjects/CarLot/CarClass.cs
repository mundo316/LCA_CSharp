using System;
namespace CarLot
{
    public class Car : Vehicle
    {
        public string BodyStyle;
        public string Doors;

        public Car(string LicenseNumber, string make, string model, double price, string Style, string NumofDoors) : base(LicenseNumber, make, model, price)
        {
            BodyStyle = Style;
            Doors = NumofDoors;
        }

        public override void VehicleDescription()
        {
            Console.WriteLine(LiceNum);
            Console.WriteLine(Manufacturer);
            Console.WriteLine(Model);
            Console.WriteLine(Price);
            Console.WriteLine(BodyStyle);
            Console.WriteLine(Doors);
        }


    }
}

