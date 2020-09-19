using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Work_Excel
{
    class Program
    {
        static async Task Main(string[] args)
        {
            string pathIn = @"D:\GitHub\C#\Work\test.csv";

            //using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Default))
            //{
            //    string line;
            //    while ((line = sr.ReadLine()) != null)
            //    {
            //        Console.WriteLine(line);
            //    }
            //}
            // асинхронное чтение
            using (StreamReader sr = new StreamReader(pathIn, System.Text.Encoding.Default))
            {
                string line;
                int i = 0;

                while ((line = await sr.ReadLineAsync()) != null) // line - stroka
                {
                    string[] text = line.Split(';');

                    string a1 = text[0];
                    string a2 = text[1];
                    string a3 = text[2];
                    string a4 = text[5];
                    string a5 = text[7];

                    

                    string NewLine = (a1 + ";" + a2 + ";" + a3 + ";" + a4 + ";" + a5);
                    

                    Write(NewLine);  

                    Console.WriteLine(NewLine);
                    //Console.ReadLine();
                    i++;

                }
            }
            Console.ReadLine();
        }

        static void Write(string n)
        {
            string writePath = @"D:\GitHub\C#\Work\TestOut.csv";

            try
            {
                using (StreamWriter sw = new StreamWriter(writePath, true, System.Text.Encoding.Default))
                {
                    sw.WriteLine(n);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        
    }

}
