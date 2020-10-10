using System;
using System.Collections.Generic;
using System.IO;

namespace _05_ExReadDoc
{
    class Program
    {
            public static void Main(string[] args)
            {
                try
                {
                    string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

                    List<string> dirs = new List<string>(Directory.EnumerateDirectories(docPath));

                    foreach (var dir in dirs)
                    {
                        Console.WriteLine($"{dir.Substring(dir.LastIndexOf(Path.DirectorySeparatorChar) + 1)}");
                    }
                    Console.WriteLine($"{dirs.Count} directories found.");
                }
                catch (UnauthorizedAccessException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (PathTooLongException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
}
