using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringManipulation.FindDuplicate
{
    public class CountWordOccurrances
    {
        public int WordAccurrances(string word, string sentence)
        {
            //you trying to find duplicate characters in a word
            string[] words = sentence.Split(' ');
            int Count = 0;

            foreach (string w in words)
            {
                if (w.Equals(word, StringComparison.OrdinalIgnoreCase))
                {
                    Count++;
                }
            }
            return Count;

        }
    }
}
