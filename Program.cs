using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string filePath = "countries.csv";

        try
        {
            string[] lines = File.ReadAllLines(filePath);

            foreach (string line in lines)
            {
                string[] fields = line.Split(',');

                if (fields.Length >= 6)
                {
                    string countryCode = fields[4].Trim('"');
                    string countryName = fields[5].Trim('"');

                    Console.WriteLine($"Country Code: {countryCode}, Country Name: {countryName}");
                }
            }
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("File not found.");
        }
        catch (IOException ex)
        {
            Console.WriteLine($"IO Error: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}