using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace arquivos
{
    class Using
    {

        private static StreamReader sr = null;
        private static string path = @"d:\file1.txt";

        public static void usingBlock()
        {
            try
            {
                using (sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        Console.WriteLine(line);
                    }
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
            }
            /*try
            {
                using (fs = new FileStream(path, FileMode.Open))
                {
                    using (sr = new StreamReader(fs))
                    {
                        while (!sr.EndOfStream)
                        {
                            string line = sr.ReadLine();
                            Console.WriteLine(line);
                        }

                    }
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
            }*/
        }
    }
}
