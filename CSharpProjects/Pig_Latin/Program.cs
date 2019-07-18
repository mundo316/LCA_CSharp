using System;
using System.Linq;

namespace Pig_Latin
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("I can translate anything to Pig Latin. Give me a word.");
                string word = Console.ReadLine();
                if(word == "stop")
                {
                    break;
                }
                pigLatin(word);
            }
            
            
            Console.ReadLine();

        }
        public static void pigLatin(string word)
        {
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };

            string[] vowels2 = { "a", "e", "i", "o", "u" };


            string firstletter = word.Substring(0, 1);

            string lastletter = word.Substring(word.Length - 1);

            string answer = "";

            //if a word starts with a vowel and ends witha vowel
            if (vowels2.Contains(firstletter) && vowels2.Contains(lastletter))
            {
                answer = word + "yay";
            }

            //if a word starts with a vowel and ends with a consonant
            if (vowels2.Contains(firstletter) && !vowels2.Contains(lastletter))
            {
                answer = word + "ay";
            }

            //if a word contains any vowels
            if (word.IndexOfAny(vowels) == -1)
            {
                answer = word + "ay";
            }

            //if a word starts with a consonant and contains a vowel
            if (word.IndexOfAny(vowels) > -1 && !vowels2.Contains(firstletter))
            {
                string firstpart = word.Substring(0, word.IndexOfAny(vowels));
                string secondpart = word.Substring(word.IndexOfAny(vowels));

                answer = secondpart + firstpart + "ay";
            }

            Console.WriteLine(answer);
        }
    }
}
