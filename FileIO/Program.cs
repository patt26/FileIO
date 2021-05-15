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
            FileCopy();
            // DeleteFile();
            //ReadFromStreamReader();
           // WriteUsingStreamWriter();
            Console.ReadKey();

        }
        public static void FileExists()
        {
            
            if (File.Exists(PATH_1))
                Console.WriteLine("File exists");
            else
                Console.WriteLine("File does not Exist");
        }
        public static void ReadAllLines()
        {
            if (File.Exists(PATH_1))
            {
                string[] lines;
                lines = File.ReadAllLines(PATH_1);
                Console.WriteLine(lines[0]);
                Console.WriteLine(lines[1]);
            }
            else
            {
                Console.WriteLine("File does not Exist");
            }
            
        }
        public static void ReadAllText()
        {
            if (File.Exists(PATH_1))
            {
                string lines;
                lines = File.ReadAllText(PATH_1);
                Console.WriteLine(lines);
            }
            else
            {
                Console.WriteLine("File does not Exist");
            }

        } 
        public static void FileCopy()
        {
            if (File.Exists(PATH_1) && File.Exists(COPY_TO))
            {
                File.Copy(PATH_1, COPY_TO);
            }
            else
            {
                Console.WriteLine("File does not Exist");
            }

        }
        public static void DeleteFile()
        {
            if (File.Exists(PATH_1))
            {
                File.Delete(PATH_1);
            }
            else
            {
                Console.WriteLine("File does not Exist");
            }

        }
        public static void ReadFromStreamReader()
        {
            if (File.Exists(COPY_TO))
            {
                using (StreamReader sr = File.OpenText(COPY_TO))
                {
                    string s = "";
                    while ((s = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(s);
                    }
                }
                
            }
            else
            {
                Console.WriteLine("File does not Exist");
            }
        }
        public static void WriteUsingStreamWriter()
        {
            if (File.Exists(COPY_TO))
            {
                using (StreamWriter sr = File.AppendText(COPY_TO))
                {
                    sr.WriteLine("Hello World .Net is awesome");
                    sr.Close();
                    Console.WriteLine(File.ReadAllText(COPY_TO));
                }
            }
            else
            {
                Console.WriteLine("File does not Exist");
            }

        }
    }
}
