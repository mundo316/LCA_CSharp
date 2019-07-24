using System;
using System.Collections.Generic;

namespace PersonSuperheroVillain
{
    class MainClass
    {
        

        public static void Main(String[] args)
        {
            List<Person> Humans = new List<Person>();
            Humans.Add(new Person("Bob", "Bo"));
            Humans.Add(new Person("William Johansen Montgomery III", "Slim"));
            Humans.Add(new Superhero("Clark Kent", "Super Strength, Lazer Vision, and Bullet Invulnerability", "Superman"));
            Humans.Add(new Superhero("Tony Stark", "Incredible wealth, which allows me to do incedible things.", "Iron Man"));
            Humans.Add(new Villain("Kingpin","Spiderman"));
            Humans.Add(new Villain("Loki","Thor"));

            //driver program
            foreach (Person item in Humans)
            {
                item.PrintGreeting();
            }
        }
    }

        //defines person class
        public class Person
    {
        public string Name;
        public string Nickname;

        public Person (string name, string nickname)
        {
            Name = name;
            Nickname = nickname;


        }
        //passes through to driver program
        public virtual void PrintGreeting()
        {
            Console.WriteLine($"Hi, my name is {Name}, but you can call me {Nickname}");
        }
        
    }
        //subclass of person
        public class Superhero : Person
    {
        //public string name = "";
        public string Realname;
        public string Superpower;

        public Superhero(string realname, string superpower, string name) : base(name, null)
        {
            Realname = realname;
            Superpower = superpower;
        }
        //passes through to driver program
        public override void PrintGreeting()
        {
            Console.WriteLine($"I am {Realname}, when I am {Name} my superpower is {Superpower}");

        }
    }
        //subclass of person
        public class Villain : Person
        {
        public string Nemesis;

            public Villain(string name, string nemesis) : base(name,null)
        {
            Nemesis = nemesis;

        }
        //passes through to driver program
        public override void PrintGreeting()
        {
            Console.WriteLine($"I am {Name}! Have you seen {Nemesis}?");
        }

        }
}
