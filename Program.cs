using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;

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

            var testModel = new
            {
                p1 = "val1",
                p2 = "val2",
                images = new List<Object>() 
                {
                    new
                    {
                        name = "image01",
                        file = "image01.jpg",
                        desc = "Us at the fishing hole",
                    },
                    new
                    {
                        name = "image02",
                        file = "image02.jpg",
                        desc = "Us not at the fishing hole",
                    },
                }
            };

            using (var sw = new System.IO.StreamWriter(System.IO.File.Create(fileNameOut)))
            {
                var testModelOut = JsonConvert.SerializeObject(testModel, Formatting.Indented);
                sw.WriteLine(testModelOut);
                sw.Flush();
                sw.Close();
            }


        }
    }
}
