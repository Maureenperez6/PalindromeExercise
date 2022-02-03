using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace PalindromeExercise
{
    public class WordSmith
    {
        public bool IsAPalindrome(string word)
        {
            //    var reversed = "";
            //    //reverses the inputted word
            //    for (int i = word.Length - 1; i >= 0; i--)
            //    {
            //        reversed += word.ToLower()[i];
            //    }
            //    //checks if they match
            //    if (reversed == word.ToLower())
            //    {
            //        return true;
            //    }
            //    else
            //    {
            //        return false;
            //    }


            //LINQ
            // return word.ToLower().SequenceEqual(word.ToLower().Reverse());       ----> would use if it was just words.
            return word.Replace(" ", "").ToLower().SequenceEqual(word.Replace(" ", "").ToLower().Reverse());     // Would use if it is a sentence to remove spaces with .Replace(" ", "").

        }

    }
}
