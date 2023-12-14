using System;
using System.IO;

namespace CSVColumnSplitter
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\rehman_yousuf\source\repos\Data Sorting - BPA Prep 1\Data Sorting - BPA Prep 1\Sample_Data_Age.csv";

            if (File.Exists(filePath))
            {
                try
                {
                    string[] lines = File.ReadAllLines(filePath);

                    foreach (string line in lines)
                    {
                        string[] columns = line.Split(',');
                        foreach (string column in columns)
                        {
                            Console.Write($"{column.Trim()} | ");
                        }
                        Console.WriteLine();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
            else
            {
                Console.WriteLine($"File not found: {filePath}");
            }

            Console.ReadLine();
        }
    }
}