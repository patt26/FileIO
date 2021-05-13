using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIO
{
    class Program
    {
        static void Main(string[] args)
        {
            //FileExists();
            //ReadAllLines();
            //ReadAllText();
            //FileCopy();
            // DeleteFile();
            ReadFromStreamReader();
            WriteUsingStreamWriter();

        }
        public static void FileExists()
        {
            String path = "Example.txt";
            if (File.Exists(path))
                Console.WriteLine("File exists");
            else
                Console.WriteLine("File doesnt exist");
        }
        public static void ReadAllLines()
        {
            string path = @"C:\Users\prat\source\repos\FileIO\FileIO\Example.txt";
            string[] lines;

            lines = File.ReadAllLines(path);
            Console.WriteLine(lines[0]);
            Console.WriteLine(lines[1]);
        }
        public static void ReadAllText()
        {
            string path = @"C:\Users\prat\source\repos\FileIO\FileIO\Example.txt";
            string lines;
            lines = File.ReadAllText(path);
            Console.WriteLine(lines);
        } 
        public static void FileCopy()
        {
            string path = @"C:\Users\prat\source\repos\FileIO\FileIO\Example.txt";
            string copypath = @"C:\Users\prat\source\repos\FileIO\FileIO\ExampleNew.txt";
            File.Copy(path, copypath);
        }
        public static void DeleteFile()
        {
            string path = @"C:\Users\prat\source\repos\FileIO\FileIO\Example.txt";
            File.Delete(path);
        }
        public static void ReadFromStreamReader()
        {
            string path = @"C:\Users\prat\source\repos\FileIO\FileIO\ExampleNew.txt";
            using (StreamReader sr = File.OpenText(path))
            {
                string s = "";
                while ((s = sr.ReadLine())!= null)
                {
                    Console.WriteLine(s);
                }
            }
        }
        public static void WriteUsingStreamWriter()
        {
            string path = @"C:\Users\prat\source\repos\FileIO\FileIO\ExampleNew.txt";
            using (StreamWriter sr = File.AppendText(path))
            {
                sr.WriteLine("Hello World .Net is awesome");
                sr.Close();
                Console.WriteLine(File.ReadAllText(path));
            }
        }
    }
}
