using System.Collections;
using System.IO.Enumeration;

IEnumerable <string> files;
IEnumerable<string> listOfDirectories;

Console.WriteLine("Do you want to look for a file or folder ?");
string type = Console.ReadLine();

if (type == "file")
{
    Console.WriteLine("Enter the path to the file");
    string path = Console.ReadLine();
    try
    {
        files = Directory.EnumerateFiles(@path, "*.cs", SearchOption.AllDirectories);
        foreach (var file in files)
        {
            Console.WriteLine(file);
        }
    }
    catch (Exception e)
    {
        Console.WriteLine($"Error: {e.Message}");
    }
} else if (type == "folder")
{
    Console.WriteLine("Enter the path to the folder");
    string path = Console.ReadLine();
    try
    {
        listOfDirectories = Directory.EnumerateDirectories(path);
        foreach (var dir in listOfDirectories)
        {
            Console.WriteLine(dir);
        }
    }
    catch (Exception e)
    {
        Console.WriteLine($"Error: {e.Message}");
    }


}






    