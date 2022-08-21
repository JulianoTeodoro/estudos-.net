using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace arquivos
{
    class FSSR
    {
        private static string path = @"d:/file1.txt";
        private static StreamReader sr = null;
        private static FileStream fs = null;

        public static void testFSSR()
        {
            try
            {
                fs = new FileStream(path, FileMode.Open);
                sr = new StreamReader(fs);
                //sr = File.OpenText(path);
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    Console.WriteLine(line);
                }

            }
            catch (IOException e)
            {
                Console.WriteLine("A error a ocurred");
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (sr != null) sr.Close();
                if (fs != null) fs.Close();
            }
        }
    }
}
