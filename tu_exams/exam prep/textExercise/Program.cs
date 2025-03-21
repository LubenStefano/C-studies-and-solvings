using System;

namespace textExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentences = "";

            Console.WriteLine("Enter the sentences one by one (press Enter on an empty line to finish): ");
            string sentence = Console.ReadLine();

            while (sentence != "")
            {

                sentences += sentence + " ";
                sentence = Console.ReadLine();
            }

            // Example input: "IASFG 9IAYGB. 9. FSIHIJSFH SFOJHBFS O FSOUHSF."

            string[] text = sentences.Split(' '); // Split text into words

            // Count words
            int wordsCount = CountWords(text);
            Console.WriteLine($"The number of words is: {wordsCount}");

            // Count digits
            int digitCount = CountDigits(text);
            Console.WriteLine($"The number of digits is: {digitCount}");
        }

        static int CountWords(string[] text) 
        {
            int count = 0;

            for (int i = 0; i < text.Length - 1; i++)
            {
                bool isWord = true;


                for (int j = 0; j < text[i].Length; j++)
                {
                    // If any character in the word is a digit, it's not considered a word
                    if (text[i][j] >= '0' && text[i][j] <= '9' || text[i].Length == 0)
                    {
                        isWord = false;
                        break; // Exit loop early as it's already not a word
                    }
                }

                if (isWord)
                {
                    count++;
                }
            }
            return count;
        }

        static int CountDigits(string[] text)
        {
            int count = 0;

            for (int i = 0; i < text.Length; i++)
            {
                for (int j = 0; j < text[i].Length; j++)
                {
                    // If a character is a digit, count it
                    if (text[i][j] >= '0' && text[i][j] <= '9')
                    {
                        count++;
                    }
                }
            }

            return count;
        }
    }
}
