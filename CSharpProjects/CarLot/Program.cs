using System;
using System.Collections.Generic;

namespace CarLot
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //creating the lots
            CarLot lot1 = new CarLot("Ray's Lightly Used Motors");
            CarLot lot2 = new CarLot("Lil' Car Lot");

            //creating car objects to be added 
            Truck Truck1 = new Truck("6541B21", "Chevrolet", "Silverado", 49999.00, "4 Door Crew Cab", "Short Bed");
            Truck Truck2 = new Truck("324EL67", "Ford", "F-150", 55599.99, "2 Door Single Cab", "Long Bed");
            Truck Truck3 = new Truck("56H87W1", "Toyota", "Tundra", 40299.99, "3 Door Extended Cab", "Short Bed");
            Truck Truck4 = new Truck("234K3UY", "Jeep", "Patriot", 59900.99, "4 Door Crew Cab", "Standard Bed");
            Truck Truck5 = new Truck("DMW24L6", "Dodge", "Ram", 39999.50, "4 Door Mega Cab", "Long Bed");
            Car Car1 = new Car("234SD34", "Acura", "RSX-S", 9000.99, "Hatchback", "2 Doors");
            Car Car2 = new Car("FD452NY", "Mazda", "FD RX-7", 25999.99, "Hatchback", "2 Doors");
            Car Car3 = new Car("90LOR67", "Subaru", "Impreza WRX", 35000.00, "Sedan", "4 Doors");
            Car Car4 = new Car("KML238X", "Mitsubishi", "Lancer Evolution X", 28999.99, "Sedan", "4 Doors");
            Car Car5 = new Car("KLTAN42", "Honda", "Civic", 26998.02, "Sedan", "4 Doors");

            //adding cars to respective lots
            lot1.AddVehicle(Truck1);
            lot2.AddVehicle(Truck2);
            lot1.AddVehicle(Truck3);
            lot2.AddVehicle(Truck4);
            lot1.AddVehicle(Truck5);
            lot2.AddVehicle(Car1);
            lot1.AddVehicle(Car2);
            lot2.AddVehicle(Car3);
            lot1.AddVehicle(Car4);
            lot2.AddVehicle(Car5);

            //calling print lot
            lot1.PrintLot();
            lot2.PrintLot();
        }
    }

    class CarLot
    {
        public string Name;

        //everytime a CarLot is created, a list called lot is made as well
        List<Vehicle> lot = new List<Vehicle>();


        public CarLot(string name)
        {
            //pulls the string that i named each lot to be able to be printed
            Name = name;
        }

        public void AddVehicle(Vehicle vehicle)
        {
            //saves space when adding vehicles
            lot.Add(vehicle);
        }

        public void PrintLot()
        {
            //method that formats and prints each cars info
            Console.WriteLine("|||||||||||||||||||||||||||||||");
            Console.WriteLine(Name + ": " + lot.Count + " Cars in Lot");
            Console.WriteLine("|||||||||||||||||||||||||||||||");

            foreach (Vehicle vehicle in lot)
            {
                vehicle.VehicleDescription();
                Console.WriteLine("-------------------------------");
            }
        }
    }
}
