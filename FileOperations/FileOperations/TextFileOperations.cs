using System;
using System.IO;

namespace FileHandlingApp
{
    public class TextFileOperations
    {
        // Method to write to a text file
        public void WriteToTextFile(string filePath, string content)
        {
            try
            {
                File.WriteAllText(filePath, content);
                Console.WriteLine("Content written to text file successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error writing to text file: {ex.Message}");
            }
        }

        // Method to read from a text file
        public void ReadFromTextFile(string filePath)
        {
            try
            {
                string content = File.ReadAllText(filePath);
                Console.WriteLine("Content read from text file:");
                Console.WriteLine(content);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error reading from text file: {ex.Message}");
            }
        }

        // Method to append content to a text file
        public void AppendToTextFile(string filePath, string content)
        {
            try
            {
                File.AppendAllText(filePath, content);
                Console.WriteLine("Content appended to text file successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error appending to text file: {ex.Message}");
            }
        }
    }
}
