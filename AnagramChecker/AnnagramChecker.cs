using System.Runtime.CompilerServices;

namespace AnagramChecker
{
    public class AnnagramChecker
    {
        public bool WordsAreAnagrams(string word1, string word2)
        {
            //Check for null or empty characters
            if(string.IsNullOrEmpty(word1) || string.IsNullOrEmpty(word2))
            {
                throw new ArgumentException("Arguments cannot be null or empty");
            }

            //Check for non-alpha characters
            if (!IsAlpha(word1) || !IsAlpha(word2))
            {
                throw new ArgumentException("Arguments can only contain A to Z characters");
            }

            //Check for anagrams
            return AreAnagrams(word1.ToLower(), word2.ToLower());
        }

        private bool AreAnagrams(string word1, string word2)
        {
            //check for identical words
            if(word1.Equals(word2, StringComparison.OrdinalIgnoreCase)) 
            {
                return false;
            }

            //check if the sorted characters are the same
            char[] charArray1 = word1.ToCharArray();
            char[] charArray2 = word2.ToCharArray();
            Array.Sort(charArray1);
            Array.Sort(charArray2);

            //check for non alpha characters
            if(!IsAlpha(new string(charArray1)) || !IsAlpha(new string(charArray2))) 
            {
                throw new ArgumentException("Arguments can only contain A to Z characters.");
            }

            return new string(charArray1).Equals(new string(charArray2), StringComparison.OrdinalIgnoreCase);
        }

        private bool IsAlpha(string word)
        {
            //check if the word contains only alpabetical characters
            foreach(char c in word)
            {
                if (!char.IsLetter(c))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
