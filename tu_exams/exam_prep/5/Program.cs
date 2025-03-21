using System.IO;
namespace _5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "C:/Users/lubo_/Desktop/Studying/hello.txt";
            if(!File.Exists(path)){
                return;
            }

            string[] sentences = File.ReadAllLines(path);

            for (int i = 0;  i < sentences.Length; i++)
            {
                Console.WriteLine(sentences[i]);
                Console.WriteLine("---");
            }

        }
    }
}