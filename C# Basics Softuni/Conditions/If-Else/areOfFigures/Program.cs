
        int N = 2;
        int H = 3;
        int W = 1;
        // Write an answer using Console.WriteLine()
        // To debug: Console.Error.WriteLine("Debug messages...");
        string buff = "";
        string width = "";
        string length = "";
        for(int i = 1; i <= N; i++)
        {
            for(int j = 1; j <= W; j++)
            {
                width += "-";
            }
            for(int k = 1; k <= H; k++)
            {
                length += "|\n";
                length.Substring(0, (length.Length- 2));
            }
            buff += "|" + width + "|\n";
            buff += length;
            buff += "|" + width + "|\n";
        }
        Console.WriteLine(buff);