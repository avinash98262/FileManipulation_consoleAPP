using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileOperationLibrary
{
    public interface IFileOperation
    {
        public  void WriteToFile(string filePath, string content, bool append = false);

        public string ReadFromFile(string filePath);
        public  void DeleteFile(string filePath);
        public void CopyFile(string sourceFilePath, string destinationFilePath);
        public  void MoveOrRenameFile(string sourceFilePath, string newFilePath);
        public void GetFileInfo(string filePath);
        public  void AppendToFile(string filePath, string content);
        public void CreateDirectory(string directoryPath);
    }
}
