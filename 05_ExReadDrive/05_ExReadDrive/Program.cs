using System;
using System.IO;

namespace _05_ExReadDrive
{
    class Program
    {
        static void Main(string[] args)
        {
            DriveInfo[] drives = DriveInfo.GetDrives();
            foreach (DriveInfo drive in drives)
            {
                Console.WriteLine(" ============================== ");
                Console.WriteLine("Drive {0}", drive.Name);
                Console.WriteLine("  Drive type: {0}", drive.DriveType);
                if (drive.IsReady)
                {
                    Console.WriteLine("Volume label: {0}", drive.VolumeLabel);
                    Console.WriteLine(" File system: {0}", drive.DriveFormat);
                    Console.WriteLine(" Available space to current user:{0, 15} bytes", drive.AvailableFreeSpace);
                    Console.WriteLine(" Total available space:{0, 15} bytes", drive.TotalFreeSpace);
                    Console.WriteLine("Total size of drive:{0, 15} bytes ", drive.TotalSize);
                }
            }
            Console.Read();
        }
    }
}
