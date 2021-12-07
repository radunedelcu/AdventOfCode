using System;
using System.IO;

class AOC
{
    public const string inputPath = @"C:\Users\40760\Desktop\C#\AOC\AOC\input.txt";
    public const string outputPath = @"C:\Users\40760\Desktop\C#\AOC\AOC\output.txt";
    private static int i;

    static void Main(string[] args)
    {
        string[] lines = File.ReadAllLines(inputPath);
        var positions = lines[0].Split(",");

        int m = 0;
        int sum = 0;
        int sum2 = 20000000;
        int k = 0;
        for (int n = 1; n <=2000; n++)
        {
            sum = 0;
            for (i = 0; i < positions.Length; i++)
            {
                m = Math.Abs(int.Parse(positions[i]) - n);
                sum = sum + m;
            }
            if (sum2 < sum)
                k = sum2;
            else
            {
                k = sum;
                sum2 = sum;
            }
            
        }
        
            Console.WriteLine("{0}", sum2);
    }
}
