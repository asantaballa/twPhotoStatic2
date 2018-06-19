using System;

namespace macdotnet01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("macdotnet01: Starting");
            var config = new Config();
            var fs = new FileScan(config.DataDir);
            fs.Run();
        }
    }
}
