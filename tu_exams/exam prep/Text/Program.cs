using System;

namespace Text
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the sentences one by one:");

            string buff = ""; //text

            string sentence = Console.ReadLine(); //sentence from the input. i = 0

            while (sentence != "") // i < length
            {
                buff += sentence;

                sentence = Console.ReadLine(); //i++ . Ако го нямаше този ред ще изпаднеш в StackOverflow(безкрайен цикъл)
            }

            //buff = "every sentence..."

            string[] text = buff.Split(" ");
            
            foreach(string a in text)
            {
                Console.WriteLine($"{a} ");
                
            }
            //text = {"every", "sentence", "6"} 

            int wordsCount = CountWords(text);
            
            Console.WriteLine(wordsCount);
            
            int countDigits = CountDigits(text);
            Console.WriteLine(countDigits);
            
            LettersHystogram(text);
        }

        static int CountWords(string[] text)
        {
            return text.Length;
        }

        static int CountDigits(string[] text)
        {
            int count = 0;

            // {"safaf ", "asfasfas", "0", "safasf", "9", "safaf ", "asfasfas", "0", "safasf", "9", "safaf ", "asfasfas", "0", "safasf", "9"}

            for (int i = 0; i < text.Length; i++)
            {
                for(int j = 0; j < text[i].Length; j++)
                {
                    if (text[i][j] >= '0' && text[i][j] <= '9') // '' for char, "" for string. '0' is from the ASCII table. '0' is 48, '9' is 57
                    {
                        count++;
                    }
                }
            }

            return count;
        }

        static void LettersHystogram(string[] text)
        {
            char letter = 'a'; //97 в ASCII table
            int[] hystogram = new int[26];

            for (int i = 0; i < text.Length; i++) //през всеки ред от текста
            {
                for (int j = 0; j < text[i].Length; j++) //през всеки символ от реда
                {
                    if (text[i][j] >= 'a' && text[i][j] <= 'z')
                    {
                        hystogram[text[i][j] - 'a']++;
                    }
                    
                    if (text[i][j] >= 'A' && text[i][j] <= 'Z')
                    {
                        hystogram[text[i][j] - 'A']++;
                    }
                }
            }

            for (int i = 0; i < hystogram.Length; i++)
            {
                Console.WriteLine($"{(char)(letter + i)} - {hystogram[i]}");
            }

        }
    }
}
