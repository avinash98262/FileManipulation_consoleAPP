using FileOperationLibrary;

class Program
{
    static void Main()
    {
        IFileOperation fileOperation = new FileOperation();
       

        // Specify the file path
         string filePath = "test.txt";

        // Specify the file path
        Console.Write("Enter 1 if You want to create the new txt file else type 0 -> ");
        string flag = Console.ReadLine();
        if (flag == "1")
        {
            Console.Write("Enter the file name: ");
             filePath = Console.ReadLine();

        }

      
        Console.Write("Enter the content to write to the file: ");
        string contentToWrite = Console.ReadLine();

        string content = fileOperation.ReadFromFile(filePath);
        Console.WriteLine("Content read from the file: ->" + content);


        fileOperation.AppendToFile(filePath, contentToWrite);
        //     FileOperations.WriteToFile(filePath, contentToWrite); // Write to a file( means here you're not appending)
        fileOperation.CopyFile(filePath, Path.Combine(Directory.GetCurrentDirectory(), $"CopyOf{filePath}.txt"));
        fileOperation.MoveOrRenameFile(filePath, Path.Combine(Directory.GetCurrentDirectory(), $"New{filePath}.txt"));
        fileOperation.GetFileInfo($"New{filePath}.txt");
        // FileOperations.DeleteFile($"CopyOf{filePath}.txt");
        fileOperation.AppendToFile($"New{filePath}.txt", contentToWrite);



        string content1 = fileOperation.ReadFromFile($"New{filePath}.txt");
        Console.WriteLine("Content read from the file: ->" + content1);

    }
}