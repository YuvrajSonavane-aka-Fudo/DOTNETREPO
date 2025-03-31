using System;
using System.IO;

namespace FileHandlingApp
{
    public class BinaryFileOperations
    {
        // Method to write to a binary file
        public void WriteToBinaryFile(string filePath, byte[] data)
        {
            try
            {
                using (FileStream fs = new FileStream(filePath, FileMode.Create))
                {
                    fs.Write(data, 0, data.Length);
                }
                Console.WriteLine("Binary data written to file successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error writing to binary file: {ex.Message}");
            }
        }

        // Method to read from a binary file
        public void ReadFromBinaryFile(string filePath)
        {
            try
            {
                byte[] data = File.ReadAllBytes(filePath);
                Console.WriteLine("Binary data read from file:");
                foreach (byte b in data)
                {
                    Console.Write(b + " ");
                }
                Console.WriteLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error reading from binary file: {ex.Message}");
            }
        }
    }
}
