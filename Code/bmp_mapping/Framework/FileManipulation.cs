using System;
using System.Linq;
using System.Text;
using System.IO;

namespace FileManipulation.Framework
{
    class WriteFile
    {
        /*
         * Starts the constructor class with the file content, file name and the file extension
         * This will generate the Entire File
         * After this release the memory, there will not be more use for it
        */
        public WriteFile(string[] FileContent, string FileName, string FileExtension)
        {
            using (System.IO.StreamWriter file =
                       new System.IO.StreamWriter(AppDomain.CurrentDomain.BaseDirectory + FileName + "." + FileExtension, true))
            {
                try
                {
                    for (int i = 0; i < FileContent.Length; i++)
                    {
                        file.WriteLine(FileContent[i]);
                    }

                }
                catch (Exception error)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\nOcorreu um erro, entre em contato com o desenvolvedor... (eu)\nNão esquecer do print por favor\n");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("fb.com/MartialBuda\n");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(error.Source + "\n");
                    Console.WriteLine(error.Message + "\n");

                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Clique em qualquer tecla para fechar...");
                    Console.ReadKey();
                }

            }
        }

    }

    class ReadFile
    {
        /*
         * Start the constructor in same location where the file will be used
         * the Atribute Text to made the read
        */
        public string[] Text;
        public int totalLines;
        public ReadFile(string FileName, string FileExtension)
        {
            using (StreamReader File = new StreamReader(FileName + "." + FileExtension))
            {
                try
                {
                    //while (!sr.EndOfStream)
                    //{
                    //    this.Text = sr.ReadLine();

                    //}
                    this.Text = File.ReadToEnd().Split('\n');
                    this.totalLines = Text.Length;
                }
                catch (Exception error)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\nOcorreu um erro, entre em contato com o desenvolvedor... (eu)\nNão esquecer do print por favor\n");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("fb.com/MartialBuda\n");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(error.Source + "\n");
                    Console.WriteLine(error.Message + "\n");

                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Clique em qualquer tecla para fechar...");
                    Console.ReadKey();
                }
            }
        }
    }

}
