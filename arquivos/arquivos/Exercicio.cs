using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace arquivos
{
    class Exercicio
    {

        private static StreamReader sr = null;
        private static string path = @"d:\file1.txt";
        private static string targetPath = @"d:\file2.txt";
        public static void Exe()
        {
            try
            {
                using (sr = File.OpenText(path))
                {
                    string[] lines = File.ReadAllLines(path);
                    using (StreamWriter sw = File.AppendText(targetPath))
                    {
                        foreach (string line in lines)
                        {
                            string name = line.Split(',')[0];
                            string price = line.Split(',')[1];
                            sw.WriteLine(name + "," + price);
                        }
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Um erro ocorreu: ");
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (sr != null) sr.Close();
            }
        }
        
    }
}
