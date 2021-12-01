//
using System;
using System.IO;

class AOC
{
    public const string inputPath = @"C:\Users\40760\Desktop\AOC\AOC\input.txt";
    public const string outputPath = @"C:\Users\40760\Desktop\AOC\AOC\output.txt";
    private static int i;

    static void Main(string[] args)
    {
        string[] lines = File.ReadAllLines(inputPath);
        int test0 = int.Parse(lines[0]);
        int count;
        count = 0;
        for (i = 1; i < lines.Length; i++)
        {
             int test = int.Parse(lines[i]);
            { 
                if (test > test0)
                {
                    count++;
                }
                test0 = test;
            }
        } 
        Console.WriteLine("{0}", count);
       
    }
}
