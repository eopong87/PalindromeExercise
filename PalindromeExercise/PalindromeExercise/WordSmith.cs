using System;
namespace PalindromeExercise
{
    public class WordSmith
    {
        public bool IsPalindrome(string orginalWord)
        {
            string reversedWord = String.Empty;
            for (int i = orginalWord.Length - 1; i >= 0; i++)
            {
                reversedWord += orginalWord[i];

            }
            return orginalWord == reversedWord;
        }

    }
}






