using System;
using System.IO;

namespace twPhotoStatic2
{
    public class FileScan
    {
        private string _srcDir = "";

        public FileScan(string srcDir) 
        { 
            //Console.WriteLine("FileScan: Constructor"); 
            _srcDir = srcDir;
        }
        
        public void Run()
        {
            //Console.WriteLine("FileScan: Run");
            ProcessDirectory(_srcDir);
        }

        public static void ProcessDirectory(string targetDirectory) 
        {
        
            string [] fileEntries = Directory.GetFiles(targetDirectory);
            foreach(string fileName in fileEntries)
                ProcessFile(fileName);

            string [] subdirectoryEntries = Directory.GetDirectories(targetDirectory);
            foreach(string subdirectory in subdirectoryEntries)
                ProcessDirectory(subdirectory);
        }

        public static void ProcessFile(string path)
        {
            Console.WriteLine($"Processed file '{path}'.");
        }

    }
}
