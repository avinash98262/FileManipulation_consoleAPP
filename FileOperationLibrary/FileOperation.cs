using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileOperationLibrary
{
    public class FileOperation : IFileOperation
    {
        public  void WriteToFile(string filePath, string content, bool append = false)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath, append))
                {
                    writer.WriteLine(content);
                }

                Console.WriteLine("Content written to the file successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error writing to the file: " + ex.Message);
            }
        }

        public  string ReadFromFile(string filePath)
        {
            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    return reader.ReadToEnd();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error reading from the file: " + ex.Message);
                return string.Empty;
            }
        }

        public  void DeleteFile(string filePath)
        {
            try
            {
                File.Delete(filePath);
                Console.WriteLine("File deleted successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error deleting the file: " + ex.Message);
            }
        }

        public  void CopyFile(string sourceFilePath, string destinationFilePath)
        {
            try
            {
                File.Copy(sourceFilePath, destinationFilePath);
                Console.WriteLine("File copied successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error copying the file: " + ex.Message);
            }
        }

        public  void MoveOrRenameFile(string sourceFilePath, string newFilePath)
        {
            try
            {
                File.Move(sourceFilePath, newFilePath);
                Console.WriteLine("File moved/renamed successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error moving/renaming the file: " + ex.Message);
            }
        }

        public  void GetFileInfo(string filePath)
        {
            try
            {
                FileInfo fileInfo = new FileInfo(filePath);
                Console.WriteLine($"File Name: {fileInfo.Name}");
                Console.WriteLine($"File Size: {fileInfo.Length} bytes");
                Console.WriteLine($"Creation Time: {fileInfo.CreationTime}");
                Console.WriteLine($"Last Access Time: {fileInfo.LastAccessTime}");
                Console.WriteLine($"Last Write Time: {fileInfo.LastWriteTime}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error getting file information: " + ex.Message);
            }
        }
        // Method to append content to a file
        public  void AppendToFile(string filePath, string content)
        {
            try
            {
                // Open the file for appending (creates the file if it doesn't exist)
                using (StreamWriter writer = new StreamWriter(filePath, append: true))
                {
                    // Write the content to the file
                    writer.WriteLine(content);
                }

                Console.WriteLine("Content appended to the file successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error appending to the file: " + ex.Message);
            }
        }

        // Method to create a directory
        public void CreateDirectory(string directoryPath)
        {
            try
            {
                // Check if the directory doesn't exist
                if (!Directory.Exists(directoryPath))
                {
                    // Create the directory
                    Directory.CreateDirectory(directoryPath);
                    Console.WriteLine("Directory created successfully.");
                }
                else
                {
                    Console.WriteLine("Directory already exists.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error creating directory: " + ex.Message);
            }
        }

    }
}
