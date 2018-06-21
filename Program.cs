using System;
using System.IO;

namespace twPhotoStatic2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("twPhotoStatic2: Starting");
            Console.WriteLine($"In: {Config.DataDirIn}");
            Console.WriteLine($"Out: {Config.DataDirOut}");
            var fs = new FileScan(Config.DataDirIn);
            fs.Run();
            WriteSite();
        }

        static void WriteSite()
        {
            Console.WriteLine($"Make believe writing file");
            var fileNameOut = Config.DataDirOut + "/" + "test.txt";
            Console.WriteLine($"File: {fileNameOut}");
            using (var sw = new System.IO.StreamWriter(System.IO.File.Create(fileNameOut)))
            {
                sw.WriteLine("Test01");
                sw.WriteLine("Test02");
                sw.Flush();
                sw.Close();
            }
        }
    }
}
