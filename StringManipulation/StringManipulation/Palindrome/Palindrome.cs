using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringManipulation.Palindrome
{
    public class Palindrome
    {
       public bool IsPalindrome(string word)
       {
            int right = word.Length - 1;
            int left = 0;

            while(right > left)
            {
                if (word[right] != word[left])
                {
                    return false;
                }
                right--;
                left++;
            }
            return true;
       }
    }
}
