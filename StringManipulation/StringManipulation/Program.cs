using StringManipulation.Palindrome;
using StringManipulation.CountCharacters;
using StringManipulation.FindDuplicate;
using StringManipulation.CountAccurances;

namespace StringMan {

    public class Program
    {
        static void Main(string[] args)
        {
            //Palindrome
            Console.WriteLine("Is Palindrome:");
            Palindrome palindrome = new Palindrome();
            bool check = palindrome.IsPalindrome("civic");
            Console.WriteLine(check);


            //Count characters
            Console.WriteLine("Characters count:");
            CountCharacters countString = new CountCharacters();
            int many = countString.Counting("Mthobisi");
            Console.WriteLine(many);

            //Count Word Occurrances
            Console.WriteLine("Count word occurances:");
            CountWordOccurrances countwordoccurrances = new CountWordOccurrances();
            int CWO = countwordoccurrances.WordAccurrances("God", "God has always been God");
            Console.WriteLine(CWO);

            //Count Character Occurances
            Console.WriteLine("Count character occurrances");
            CountCharacterOccurrances countcharacteroccurrances = new CountCharacterOccurrances();
            int CCO = countcharacteroccurrances.CharacterOccurances('J', "Jesus is Jehova");
            Console.WriteLine(CCO);

        }
    }
}
