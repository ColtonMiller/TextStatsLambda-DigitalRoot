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

        }

        public static int DigitalRoot(string rootThisNumber)
        {
            //make a sum
            string sum = string.Empty;
            //make digital root
            int digitalSum = 0;
            //add to sum
            foreach (int number in rootThisNumber)
            {
                sum += number;
            }
            //add two numbers of sum to digital root
            foreach (int number in sum)
            {
                digitalSum += number;
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
            return 0;
        }

        public static string LongestWord(string inputString)
        {
            return string.Empty;
        }

        public static string ShortestWord(string inputString)
        {
            return string.Empty;
        }


    }
}
