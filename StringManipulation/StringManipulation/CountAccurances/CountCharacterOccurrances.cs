using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringManipulation.CountAccurances
{
    public class CountCharacterOccurrances
    {
        public int CharacterOccurances(char character, string sentence)
        {
            int Count = 0;

            foreach(char c in sentence)
            {
                if(c == character)
                {
                    Count++;
                }
            }

            return Count;
        }
    }
}
