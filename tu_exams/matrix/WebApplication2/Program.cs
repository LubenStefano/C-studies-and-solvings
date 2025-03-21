Console.Write("Въведете path до файла: ");
string filePath = Console.ReadLine();

int[] letterCounts = new int[26];

string[] lines = File.ReadAllLines(filePath);
foreach (string word in lines)
{
    int[] currentWordCounts = new int[26];
    
    foreach (char c in word.ToLower())
    {
        if (c >= 'a' && c <= 'z')
        {
            currentWordCounts[c - 'a']++;
        }
    }
    
    for (int i = 0; i < 26; i++)
    {
        if (currentWordCounts[i] > letterCounts[i])
        {
            letterCounts[i] = currentWordCounts[i];
        }
    }
}

string result = "";
for (int i = 0; i < 26; i++)
{
    char letter = (char)('a' + i);
    for (int j = 0; j < letterCounts[i]; j++)
    {
        if (result.Length > 0)
        {
            result += ",";
        }
        result += letter;
    }
}

Console.WriteLine(result);