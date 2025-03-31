using System;
using System.IO;

namespace FileHandlingApp
{
    public class DirectoryFileInfoOperations
    {
        // Method to display directory and file information using DirectoryInfo and FileInfo
        public void DisplayDirectoryInfo(string path)
        {
            try
            {
                // Get directory info
                DirectoryInfo dirInfo = new DirectoryInfo(path);
                if (dirInfo.Exists)
                {
                    Console.WriteLine("Directory Information:");
                    Console.WriteLine($"Full Path: {dirInfo.FullName}");
                    Console.WriteLine($"Creation Time: {dirInfo.CreationTime}");
                    Console.WriteLine($"Last Access Time: {dirInfo.LastAccessTime}");
                    Console.WriteLine($"Last Write Time: {dirInfo.LastWriteTime}");
                    Console.WriteLine($"Is it a directory?: {dirInfo.Attributes.HasFlag(FileAttributes.Directory)}");
                }
                else
                {
                    Console.WriteLine("Directory does not exist.");
                }

                // Get all files in the directory
                FileInfo[] files = dirInfo.GetFiles();
                Console.WriteLine("\nFiles in the directory:");
                foreach (var file in files)
                {
                    Console.WriteLine($"File Name: {file.Name}");
                    Console.WriteLine($"Full Path: {file.FullName}");
                    Console.WriteLine($"Size: {file.Length} bytes");
                    Console.WriteLine($"Creation Time: {file.CreationTime}");
                    Console.WriteLine($"Last Modified Time: {file.LastWriteTime}");
                    Console.WriteLine();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error retrieving directory or file info: {ex.Message}");
            }
        }
    }
}
