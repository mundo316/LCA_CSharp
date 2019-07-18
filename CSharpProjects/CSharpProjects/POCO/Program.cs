using System;
using System.Collections.Generic;


namespace POCO
{
    class MainClass
    {
        DriversLicense firstone = new DriversLicense("ann", "smith", "f", 98765432);
        Book firstbook = new Book("Sherlock Holmes", "Some Dude", 345, "SH34829472389", "PubCo", 9.99);

                
    }

    class DriversLicense
    {
        public string firstname;
        public string lastname;
        public string Gender;
        public int Licensenumber;
        public string fullname;

        //constructor
        public DriversLicense(string fname, string lname, string gender, int licensenumber)
        {
            firstname = fname;
            lastname = lname;
            Gender = gender;
            Licensenumber = licensenumber;
        }

        public string GetFullName()
        {
            fullname = firstname + lastname;
            return fullname;

        }
    }

    //book class is located in seperate file

    class Airplane
    {

        public string Manufacturer;
        public string Model;
        public string Variant;
        public int Capacity; //this should hold the seating capacity
        public int Engines; //this should hold the number of engines

        public Airplane()
        {
            Manufacturer = ".  ";
            Model = ".  ";
            Variant = ".  ";
            Capacity = 0;
            Engines = 0;
        }
    }
}
