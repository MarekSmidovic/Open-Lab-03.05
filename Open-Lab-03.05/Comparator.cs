using System;

namespace Open_Lab_03._05
{
    public class Comparator
    {
        public bool MatchCaseInsensitive(string str1, string str2)
        {
            if (str1.Length == str2.Length)
            {
                return true;
            }
            else
                return false;

        }
    }
}
