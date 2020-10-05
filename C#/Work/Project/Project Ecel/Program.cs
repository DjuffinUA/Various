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
            string PathIN = @"D:\GitHub\Various\C#\Work\test.csv";

            string PathOut = @"D:\GitHub\Various\C#\Work\TestOut.csv";

            string text = Reader(PathIN); // файл в строку

            string[,] Newtext = MultiArray(text); // строку в двумерный масив

            Write(PathOut, Newtext);

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
                    string textline = a1 + ";" + a2 + ";" + a3 + ";" + a4 + ";" + a5 + ";" + "\n";

                    text += textline;
                }

                return text;
            }
        }

        private static string[,] MultiArray(string text) // FUNCTION
        {
            const int st = 5;  // количество столбцов в конечной таблице
            string[] masivtext = text.Split('\n');
            string[,] NewMasive = (string[,])Array.CreateInstance(typeof(string), masivtext.Length - 1, st); // создание масива по количеству строк
            
            for ( int i = 0; i < masivtext.Length - 1; i++)
            {
                string NewText = string.Join(";", masivtext[i]);
                string[] masivNewText = NewText.Split(';');
                    for (int l = 0; l < st; l++)
                    {
                        NewMasive[i, l] = masivNewText[l];
                    }
            }

            return NewMasive;
        }

        private static void Write(string path, string[,] text)
        {
            string NewText = text[0, 0] + ";" + text[0, 1] + ";" + text[0, 2] + ";" + text[0, 3] + ";" + text[0, 4] + ";" + "\n";

            string[] count = (string[])Array.CreateInstance(typeof(string), text.GetLength(0));

            for (int i = 1; i < text.GetLength(0); i++)
            {
                if (text[i, 0] != count[i])
                {
                    for (int n = i + 1; n < text.GetLength(0); n++)
                    {
                        if (text[i, 1] == text[n, 1] && text[i, 2] == text[n, 2] && text[i, 3] == text[n, 3] && text[i, 4] == text[n, 4])
                        {
                            text[i, 0] = (text[i, 0] + ", " + text[n, 0]);
                            count[n] = text[n, 0];
                        }
                    }

                    NewText = NewText + text[i, 0] + ";" + text[i, 1] + ";" + text[i, 2] + ";" + text[i, 3] + ";" + text[i, 4] + ";" + "\n";

                }
            }

            using (StreamWriter sw = new StreamWriter(path, false, System.Text.Encoding.Default))
            {
                sw.WriteLine(NewText);
            }
        }
    }
}