using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string inputFilePath = @"D:\\Projects\\ReadFileProject\\readfile2\\sample.csv"; //input file path (change accordingly)
        string outputFilePath = @"D:\\Projects\\ReadFileProject\\readfile2\\output.csv"; //input file path 

        // Read the CSV file
        string[] lines = File.ReadAllLines(inputFilePath);

        // Write the output CSV file
        using (StreamWriter writer = new StreamWriter(outputFilePath))
        {
            foreach (string line in lines)
            {
                // Split the line into fields
                string[] fields = line.Split(',');

                //write filtering Logic here
                if (fields[2] == "28-Apr-22")
                {
                    writer.WriteLine(string.Join(',', fields));
                }

            }
        }

        Console.WriteLine("Done.");
    }
}