using System;
using System.IO;

namespace FileHandlingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create instances of the classes
            TextFileOperations textFileOps = new TextFileOperations();
            BinaryFileOperations binaryFileOps = new BinaryFileOperations();
            DirectoryFileInfoOperations directoryFileInfoOps = new DirectoryFileInfoOperations();

            // Specify file paths (You can modify these paths as per your need)
            string textFilePath = "sample.txt";
            string binaryFilePath = "sample.bin";
            string directoryPath = @"C:\TestDirectory";

            // Program A: Text File Operations (Read, Write, Append)
            Console.WriteLine("Text File Operations:");
            textFileOps.WriteToTextFile(textFilePath, "This is the first line in the text file.");
            textFileOps.ReadFromTextFile(textFilePath);
            textFileOps.AppendToTextFile(textFilePath, "\nThis is an appended line.");
            textFileOps.ReadFromTextFile(textFilePath);

            Console.WriteLine("\n-----------------------------------------------");

            // Program B: Binary File Operations (Read, Write)
            Console.WriteLine("Binary File Operations:");
            byte[] binaryData = { 0x1, 0x2, 0x3, 0x4, 0x5 };
            binaryFileOps.WriteToBinaryFile(binaryFilePath, binaryData);
            binaryFileOps.ReadFromBinaryFile(binaryFilePath);

            Console.WriteLine("\n-----------------------------------------------");

            // Program C: Directory and File Info Operations
            Console.WriteLine("Directory and File Info Operations:");
            directoryFileInfoOps.DisplayDirectoryInfo(directoryPath);

            Console.ReadLine(); // Keep the console open
        }
    }
}
