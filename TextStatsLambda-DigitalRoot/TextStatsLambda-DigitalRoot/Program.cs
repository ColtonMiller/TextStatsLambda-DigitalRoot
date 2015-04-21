using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextStatsLambda_DigitalRoot
{
    class Program
    {
        static void Main(string[] args)
        {
            DigitalRoot("31337");
        }

        public static int DigitalRoot(string rootThisNumber)
        {
            
            //make a sum
            int sum = 0;
            //make digital root
            int digitalSum = 0;
            //add to sum
            foreach (char number in rootThisNumber)
            {
                int tempNumber = int.Parse(number.ToString());
                sum += tempNumber;
                
            }
            //add two numbers of sum to digital root
            foreach (char number in sum.ToString())
            {
                int tempNumber = int.Parse(number.ToString());
                digitalSum += tempNumber;
            }
            //return digit root
            return digitalSum;
        }

        public static int NumberOfWords(string inputString)
        {
            //split by space into array and count
           int words = inputString.Split(' ').Count();
            //return words
           return words;
        }

        public static int NumberOfVowels(string inputString)
        {
            //make counter 
            int counterVowel = 0;
            //check all vowels in input and adds to counter
            foreach (char letter in inputString.Where(x => "aeiou".Contains(x.ToString().ToLower())))
            {
                counterVowel++;
            }
            return counterVowel;
        }

        public static int NumberOfConsonants(string inputString)
        {
            //make counter
            int counterConsonants = 0;
            //check all consonants in input and adds to counter
            foreach (char letter in inputString.Where(x => "bcdfghjklmnpqrstvwxyz".Contains(x.ToString().ToLower())))
            {
                counterConsonants++;
            }
            return counterConsonants;
        }

        public static int NumberOfSpecialCharacters(string inputString)
        {
            // .,?;'!@#$%^&*() and spaces are considered special characters
            //make counter
            int counterSpecial = 0;
            //check all special in input and add to counter
            foreach (char Special in inputString.Where(x => " .,?;'!@#$%^&*()".Contains(x.ToString())))
            {
                counterSpecial++;
            }
            return counterSpecial;
        }

        public static string LongestWord(string inputString)
        {
            //split input to array
         

            return inputString.Split(' ').ToList<string>().OrderByDescending(x => x.Length).First().ToString();
        }

        public static string ShortestWord(string inputString)
        {
            return inputString.Split(' ').ToList<string>().OrderBy(x => x.Length).First().ToString();
        }


    }
}
