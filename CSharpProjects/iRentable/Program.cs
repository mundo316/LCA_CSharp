using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(String[] args)
    {
        List<iRentable> listed = new List<iRentable>();
        listed.Add(new Car());
        listed.Add(new Boat());
        listed.Add(new House());

        foreach (iRentable Car in listed)
        {
        

        }
    }
}

public interface iRentable
{
    void getdailyrate();
    void getDescription();
}

public class Car : iRentable
{
    String name;
    double dailyrate;
    public Car(String initName, double DailyRate)
    {
        this.name = initName;
        DailyRate = 98.99;
    }
    public void getdailyrate()
    {
        Console.WriteLine(98.99); 
    }
    public void getDescription()
    {
        Console.WriteLine();
    }

}

public class Boat : iRentable
{
    String name;
    double hourlyrate;
    public Boat(String initName double Rate)
    {
        this.name = initName;
        Rate = rate;
    }
    public void getdailyrate()
    {
        Console.WriteLine(rate, name);
    }
    public void getDescription();
    {

    }
}

public class House : iRentable
{
    String name;
    public House(String initName)
    {
        this.name = initName;
    }
    public void getdailyrate()
    {
        Console.WriteLine(".", name);
    }
    public void getDescription();
    {

    }

}