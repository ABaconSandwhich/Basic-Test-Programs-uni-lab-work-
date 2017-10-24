using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetterCounter
{
    class Program
    {
        static string formating = "************************************************************";

        static void Main(string[] args)
        {
            String sentence = "";
            bool loop = true;
            //starts the program loop
            do
            {   
                //Asks for the scentence that the user wants formating then saves it into sentence.
                Console.WriteLine(formating + "\nPlease input the scentence you would like to be counted:\n" + formating);
                sentence = Console.ReadLine();
                Console.WriteLine("____________________________________________________________");
                //sends the sentence that the user wants formating to the counting method.
                Count(sentence);

                //Pauses then wipes the screen and returns to the start of the program
                Console.WriteLine("Press any key to continue.");
                Console.Read();
                Console.Clear();
                Console.Read();
            } while (loop == true);
        Console.Read();

        }
        public static void Count(string s)
        {
            SortedDictionary<char, int> sentenceCounter = new SortedDictionary<char, int>();
            //Creates a sorted dictionary to store all the counted letters.

            foreach (var letter in s) //Looks for any variable in the given sentence (s) and loops it for that many times
            {
                if (!sentenceCounter.ContainsKey(letter))//Checks to see if the one type of letter has already been counted, if it has not, it adds the letter.
                {
                    sentenceCounter.Add(letter, 1);
                }
                else //If that letter has already been counted once, then the counter for that letter is added by one.
                {
                    sentenceCounter[letter]++;
                }
            }


            //Output the how many letters there are in the scentence
            Console.WriteLine("Amount of letters in the scentence:\n" + formating);
            //Loops for each letter in sentence counter to output how many times each letter was in the scentence
            foreach (var letter in sentenceCounter)
            {
                Console.WriteLine(letter.Key + " == " + letter.Value);
            }
            Console.WriteLine(formating);
        }
    }
}
