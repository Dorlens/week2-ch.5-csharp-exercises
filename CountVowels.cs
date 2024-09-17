using static System.Console;

//Write a program named CountVowels that accepts a phrase from the user and counts the number of vowels in 
//the phrase. For this exercise, count both uppercase and lowercase vowels, but do not consider 
//y to be a vowel.
class CountVowels
{

    static void Main()
    {

         Console.Write("Enter a phrase: ");
         string phrase = Console.ReadLine();

        //string containing vowel characters
        string vowels = "aeiouAEIOU";

        //  a counter for vowels
        int vowelCount = 0;

        // Iterate through each character in the phrase
        foreach (char ch in phrase)
        {
            // Check if the character is a vowel
            if (vowels.Contains(ch))
            {
                vowelCount++;
            }
        }

        
        Console.WriteLine("Number of vowels: " + vowelCount);
    }
}
