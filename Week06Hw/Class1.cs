using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace StreamReadWrite
{
    class Program
    {
        static void Main(string[] args)
        {
            // Get the directories currently on the C drive.
            DirectoryInfo[] cDirs = new DirectoryInfo(@"c:\").GetDirectories();
            int line1 = 0;
            // Write each directory name to a file.
            using (StreamWriter sw = new StreamWriter("target.txt"))
            {
                foreach (DirectoryInfo dir in cDirs)
                {
                    line1++;
                    sw.WriteLine($"Line{line1} : {dir.Name}");
                }
            }

            // Read and show each line from the file.
            int line2 = 0;
            string line = "";
            using (StreamReader sr = new StreamReader("source.txt"))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    line2++;
                    Console.WriteLine($"Line {line2} : {line}");
                }
            }
        }
    }
}