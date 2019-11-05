using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;

namespace TioRACLab.DosBox.Package
{
    public class Class1
    {
        public static void aaa()
        {
            using (FileStream zipToOpen = new FileStream(@"D:\OldPC\Package\Duke3D.dosbox", FileMode.Open))
            {
                using (ZipArchive archive = new ZipArchive(zipToOpen, ZipArchiveMode.Read))
                {
                    archive.ExtractToDirectory(@"D:\OldPC\TestPackage");
                    
                    /*ZipArchiveEntry readmeEntry = archive.CreateEntry("Readme.txt");
                    using (StreamWriter writer = new StreamWriter(readmeEntry.Open()))
                    {
                        writer.WriteLine("Information about this package.");
                        writer.WriteLine("========================");
                    }*/
                }
            }
        }
    }
}
