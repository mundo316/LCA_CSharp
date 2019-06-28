using System;

namespace project1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //hello();

            //addition();

            //catDog();

            //oddEven();

            //inches();

            //echo();

            //killgrams();

            age();

            //guess();

        }
        public static void hello()
        {
            Console.WriteLine("Hello! What's your name?");

            string name = Console.ReadLine();
            Console.WriteLine("bye " + name);
        }
        public static void addition()
        {
            Console.WriteLine("What\'s your first number? ");
            string firstnum = Console.ReadLine();
            Console.WriteLine("What\'s your second number? ");
            string secondnum = Console.ReadLine();
            int first = Convert.ToInt32(firstnum);
            int second = Convert.ToInt32(secondnum);
            Console.WriteLine(first + second);

        }
        public static void catDog()
        {
            Console.WriteLine("Which do you prefer? Cats, or Dogs? ");
            string answer = Console.ReadLine();
            if (answer == "cats")
            { Console.WriteLine("Meow!"); }
            else if (answer == "dogs")
            { Console.WriteLine("Bark Bark!"); }
            else { Console.WriteLine("!!!WRONG!!!"); }
        }
        public static void oddEven()
        {
            Console.WriteLine("Hey! You! Give me a number!");
            string number = Console.ReadLine();
            int num = Convert.ToInt32(number);
            int.Parse(number);
            if (num % 2 == 0)
            {
                Console.Write("The Number Entered is an Even Number");
                Console.Read();
            }
            else
            {
                Console.Write("The Entered Number is an Odd Number");
                Console.Read();
            }
        }
        public static void inches()
        {
            Console.WriteLine("I can convert Feet to Inches. Try me!");
            Console.WriteLine("Type in a number of Feet");
            string height = Console.ReadLine();

            int feet = Convert.ToInt32(height);
            Console.WriteLine(feet * 12);
        }
        public static void echo ()
        {
            Console.WriteLine("I am Echo, give me a word.");
            string word = Console.ReadLine();
            Console.WriteLine(word.ToUpper());
            Console.WriteLine(word.ToLower());
            Console.WriteLine(word.ToLower());
        }
        public static void killgrams()
        {
            Console.WriteLine("How many pounds would you like to convert to kilograms?");
            int lbs = Convert.ToInt16(Console.ReadLine());
            double kg = (0.45359237 * (double)lbs);
            Console.WriteLine("Converted to " + kg + "kg");
        }
        public static void date()
        {
            Console.WriteLine("Current date and time is:");
            Console.WriteLine(DateTime.Today);
        }
        public static void age()
        {
            Console.WriteLine("What year were you born?");
            int byear = Convert.ToInt32( Console.ReadLine());
            int age = DateTime.Today.Year - byear;
            Console.WriteLine("You are " + age + " years old.");
        }
        public static void guess()
        {

        }







    }

}
