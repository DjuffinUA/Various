using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace newTest
{
    class Program
    {
        static async Task Main(string[] args)
        {
            string pathIn = @"D:\GitHub\C#\Work\test.csv";

            using (StreamReader sr = new StreamReader(pathIn, System.Text.Encoding.Default))
            {
                string line;
                for (int i = 0; (line = await sr.ReadLineAsync()) != null ; i++) // line - stroka
                {
                    string[] text = line.Split(';');

                    string a1 = text[0];
                    string a2 = text[1];
                    string a3 = text[2];
                    string a4 = text[5];
                    string a5 = text[7];

                    Massiv(a1, a2, a3, a4, a5, i);

                    string NewLine = (a1 + ";" + a2 + ";" + a3 + ";" + a4 + ";" + a5);


                    Write(NewLine);

                    Console.WriteLine(NewLine);
                    //Console.ReadLine();

                }
                Console.ReadLine();
            }
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

        static void Massiv(string a1, string a2, string a3, string a4, string a5, int i)
        {
            string[][] MnogoMass = new string[i + 1][];
            MnogoMass[i] = new string[] { a1, a2, a3, a4, a5 };
            Console.WriteLine(MnogoMass[i][1]);
        }
    }
}
