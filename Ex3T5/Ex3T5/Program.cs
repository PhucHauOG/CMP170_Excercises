using System;
using System.IO;

namespace Ex3T5
{
        class Program
        {
            static void Main(string[] args)
            {
                DriveInfo[] drives = DriveInfo.GetDrives();
                foreach (DriveInfo drive in drives)
                {
                    if (drive.IsReady)
                    {
                        Console.WriteLine($"Drive name: {drive.Name}");
                        Console.WriteLine($"Format: {drive.DriveFormat}");
                        Console.WriteLine($"Type: {drive.DriveType}");
                        Console.WriteLine($"Root directory: {drive.RootDirectory}");
                        Console.WriteLine($"Volume label: {drive.VolumeLabel}");
                        Console.WriteLine($"Free space: {drive.TotalFreeSpace}");
                        Console.WriteLine($"Available space: { drive.AvailableFreeSpace} ");
                        Console.WriteLine($"Total size: {drive.TotalSize}");
                        Console.WriteLine();

                    }
                }
                Console.WriteLine();
                Console.WriteLine("List of all file in MyDocuments folder:");
                DirectoryInfo c = new DirectoryInfo(@"C:\Users\Admin\Documents");

                FileInfo[] Files = c.GetFiles();


                foreach (FileInfo file in Files)
                {
                    Console.WriteLine($"Name file: {file.Name}");
                }

                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Read a text file name (TestFile) in MyDocuments");
                string[] lines = File.ReadAllLines(@"C:\Users\Admin\Documents\TestFile.txt");
                int i = 1;
                foreach (var line in lines)
                {
                    Console.WriteLine($"{ i++}. {line}");
                }

            }
        }
}
    

