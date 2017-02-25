using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnagramCheck
{
    /// <summary>
    /// Check if two strings are Anagrams
    /// </summary>
    public class CheckAnagram
    {
        bool check = false;
        public bool CheckAnagramData(string word1, string word2)
        {
            if (word1 == null || word2 == null)
                return check;           

            //step 1  
            char[] char1 = word1.ToLower().ToCharArray();
            char[] char2 = word2.ToLower().ToCharArray();

            //Step 2  
            Array.Sort(char1);
            Array.Sort(char2);

            //Step 3  
            string NewWord1 = new string(char1);
            string NewWord2 = new string(char2);

            if (NewWord1 == NewWord2)
            {
                return true;
            }

            return check;
        }
    }
}
