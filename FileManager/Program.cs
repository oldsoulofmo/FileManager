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
    files = Directory.EnumerateFiles(@path,"*.cs",SearchOption.AllDirectories);
    foreach (var file in files) 
    {
        Console.WriteLine(file);
    }
} else if (type == "folder")
{
    Console.WriteLine("Enter the path to the folder");
    string path = Console.ReadLine();
    listOfDirectories = Directory.EnumerateDirectories(path);
    foreach (var VARIABLE in listOfDirectories)
    {
        Console.WriteLine(VARIABLE);
    }


}






    