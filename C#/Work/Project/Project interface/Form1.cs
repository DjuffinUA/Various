using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_interface
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //Open.Click += Open_Click;
            //Save.Click += Save_Click;
            //Run.Click += Run_Click;
        }

        string PathIN = null;
        string PathOut = null;

        private void Open_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "csv files (*.csv)|*.csv";
            if (openFile.ShowDialog() == DialogResult.Cancel)
                return;
             PathIN = Path.GetFullPath(openFile.FileName);

            
        }

        private void Save_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "csv files (*.csv)|*.csv";
            if (saveFile.ShowDialog() == DialogResult.Cancel)
                return;
            PathOut = Path.GetFullPath(saveFile.FileName);

        }

        public void Run_Click(object sender, EventArgs e)
        {
            //string PathIN = Open_Click.PathIN;
            //PathIN = @"D:\GitHub\Various\C#\Work\test.csv";

            //string PathOut = @"D:\GitHub\Various\C#\Work\TestOut.csv";

            string text = Reader(PathIN); // файл в строку

            string[,] Newtext = MultiArray(text); // строку в двумерный масив

            Write(PathOut, Newtext);

            //Console.ReadLine();
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
            //string[] masivtext = text.Split('\n');
            for (int i = 0; i < masivtext.Length - 1; i++)
            {
                string NewText = string.Join(";", masivtext[i]);
                string[] masivNewText = NewText.Split(';');
                //if (masivNewText[i] != "")
                //{
                for (int l = 0; l < st; l++)
                {
                    NewMasive[i, l] = masivNewText[l];
                }
                //} else
                //{
                //break;
                //}

            }

            return NewMasive;
        }

        private static void Write(string path, string[,] text) // FUNCTION
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

                    //i = i + count;

                    /*int n = i - 1;
                    if (text[n, 1] == text[i, 1] && text[n, 2] == text[i, 2] && text[n, 3] == text[i, 3] && text[n, 4] == text[i, 4])
                    {
                        text[n, 0] = text[n, 0] + text[i, 0];
                        NewText = NewText + text[n, 0] + ";" + text[n, 1] + ";" + text[n, 2] + ";" + text[n, 3] + ";" + text[i, 4] + ";" + "\n";
                        //i++;
                    }
                    else
                    {
                        NewText = NewText + text[i, 0] + ";" + text[i, 1] + ";" + text[i, 2] + ";" + text[i, 3] + ";" + text[i, 4] + ";" + "\n";
                    }*/
                }
            }

            using (StreamWriter sw = new StreamWriter(path, false, System.Text.Encoding.Default))
            {
                sw.WriteLine(NewText);
            }
        }
    }
}
