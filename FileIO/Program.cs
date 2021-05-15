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
        public const string PATH_1= @"C:\Users\prat\source\repos\FileIO\FileIO\Example.txt";
        public const string COPY_TO= @"C:\Users\prat\source\repos\FileIO\FileIO\ExampleNew.txt";
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
            
            if (File.Exists(path))
                Console.WriteLine("File exists");
            else
                Console.WriteLine("File doesnt exist");
        }
        public static void ReadAllLines()
        {
            string[] lines;
            lines = File.ReadAllLines(PATH_1);
            Console.WriteLine(lines[0]);
            Console.WriteLine(lines[1]);
        }
        public static void ReadAllText()
        {
            string lines;
            lines = File.ReadAllText(PATH_1);
            Console.WriteLine(lines);
        } 
        public static void FileCopy()
        {
            File.Copy(PATH_1,COPY_TO);
        }
        public static void DeleteFile()
        {
            File.Delete(PATH_1);
        }
        public static void ReadFromStreamReader()
        {
            using (StreamReader sr = File.OpenText(COPY_TO))
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
            using (StreamWriter sr = File.AppendText(COPY_TO))
            {
                sr.WriteLine("Hello World .Net is awesome");
                sr.Close();
                Console.WriteLine(File.ReadAllText(COPY_TO));
            }
        }
    }
}
