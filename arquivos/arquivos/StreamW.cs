using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace arquivos
{
    class StreamW
    {
        private static string path = @"d:\file1.txt";
        private static string targetPath = @"d:\file2.txt";

        public static void testStreamW()
        {
            try
            {
                string[] lines = File.ReadAllLines(path);

                using (StreamWriter sw = File.AppendText(targetPath))
                {
                    foreach (string line in lines)
                    {
                        sw.WriteLine(line.ToUpper());
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("A error a ocurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
