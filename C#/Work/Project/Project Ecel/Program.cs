using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace HelloApp
{
    class Program
    {
        static void Main(string[] args) // MAIN
        {
            string path = @"D:\GitHub\Various\C#\Work\test1.csv";

            string text = Reader(path); // text file

            string[,] Newtext = MultiArray(text);


            Console.WriteLine(Newtext[0,0] + ";" + Newtext[1,0]);
            Console.ReadLine();
        }

        private static string Reader(string n) // FUNCTION
        {
            string path = n;
            using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Default))
            {
                string line;
                string text = "";

                for (int i = 0; (line = sr.ReadLine()) != null; i++)
                {
                    string[] masivtext = line.Split(';');
                    string a1 = masivtext[0]; // RefDes
                    string a2 = masivtext[1]; // Name
                    string a3 = masivtext[2]; // Pattern
                    string a4 = masivtext[5]; // Side
                    string a5 = masivtext[7]; // Value

                    //string[] LineText = new string[] { line };
                    string textline = $"{a1};{a2};{a3};{a4};{a5};\n";

                    text += textline;
                }

                return text;
            }
        }

        private static string[,] MultiArray(string text)
        {
            string[] masivtext = text.Split('\n');
            string[,] NewMasive = (string[,])Array.CreateInstance(typeof(string), masivtext.Length, 6);
            //string[] masivtext = text.Split('\n');
            for ( int i = 0; i < masivtext.Length; i++)
            {
                string NewText = string.Join(";", masivtext[i]);
                string[] masivNewText = NewText.Split(';');
                if (masivNewText[i] != "")
                {
                    for (int l = 0; l < 6; l++)
                    {
                        NewMasive[i, l] = masivNewText[l];
                    }
                } else
                {
                    break;
                }
                
            }

            return NewMasive;
        }
    }
}