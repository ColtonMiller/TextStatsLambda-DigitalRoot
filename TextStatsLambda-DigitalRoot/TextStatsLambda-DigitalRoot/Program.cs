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
            return inputString.Count(x => "aeiou".Contains(char.ToLower(x)));
        }

        public static int NumberOfConsonants(string inputString)
        {
            return inputString.Count(x => "bcdfghjklmnpqrstvwxyz".Contains(char.ToLower(x)));
        }

        public static int NumberOfSpecialCharacters(string inputString)
        {
            // .,?;'!@#$%^&*() and spaces are considered special characters
            //make counter
            return inputString.Count(x => " .,?;'!@#$%^&*()".Contains(char.ToLower(x)));
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
