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

namespace Excel_v1._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
            string fileText = File.ReadAllText(PathIN);
            Box_Open.Text = fileText;
        }
         
        private void Save_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "csv files (*.csv)|*.csv";
            if (saveFile.ShowDialog() == DialogResult.Cancel)
                return;
            PathOut = Path.GetFullPath(saveFile.FileName);
        }

        private void Run_Click(object sender, EventArgs e)
        {
            string text = Reader(PathIN); // файл в строку

            string[,] Newtext = MultiArray(text); // строку в двумерный масив


            Write(PathOut, Newtext);

            //string fileText = File.ReadAllText(PathOut);
            //Box_Save.Text = fileText;

            /*DataGridViewColumn column1 = New_Colum("RefSes");
            DataGridViewColumn column2 = New_Colum("Name");
            DataGridViewColumn column3 = New_Colum("Pattern");
            DataGridViewColumn column4 = New_Colum("Side");
            DataGridViewColumn column5 = New_Colum("Value");
            DataGridViewColumn column6 = New_Colum("Total");

            Table_Run.Columns.Add(column1);
            Table_Run.Columns.Add(column2);
            Table_Run.Columns.Add(column3);
            Table_Run.Columns.Add(column4);
            Table_Run.Columns.Add(column5);
            Table_Run.Columns.Add(column6);

            Table_Run.AllowUserToAddRows = false; //запрешаем пользователю самому добавлять строки*/


            /*for (int i = 0; i < 5; ++i)
            {
                //Добавляем строку, указывая значения колонок поочереди слева направо
                Table_Run.Rows.Add("Пример 1, Товар " + i, i * 1000, i);
            }

            /*for (int i = 0; i < 5; ++i)
            {
                //Добавляем строку, указывая значения каждой ячейки по имени (можно использовать индекс 0, 1, 2 вместо имен)
                Table_Run.Rows.Add();
                Table_Run["name", Table_Run.Rows.Count - 1].Value = "Пример 2, Товар " + i;
                Table_Run["price", Table_Run.Rows.Count - 1].Value = i * 1000;
                Table_Run["count", Table_Run.Rows.Count - 1].Value = i;
            }

            //А теперь простой пройдемся циклом по всем ячейкам
            for (int i = 0; i < Table_Run.Rows.Count; ++i)
            {
                for (int j = 0; j < Table_Run.Columns.Count; ++j)
                {
                    //Значения ячеек хряняться в типе object
                    //это позволяет хранить любые данные в таблице
                    object o = Table_Run[j, i].Value;
                }
            }*/


        }

        private static DataGridViewColumn New_Colum( string name)
        {
            var column = new DataGridViewColumn();
            column.HeaderText = name; //текст в шапке
            column.Width = 100; //ширина колонки
            column.ReadOnly = true; //значение в этой колонке нельзя править
            column.Name = name; //текстовое имя колонки, его можно использовать вместо обращений по индексу
            column.Frozen = true; //флаг, что данная колонка всегда отображается на своем месте
            column.CellTemplate = new DataGridViewTextBoxCell(); //тип нашей колонки
            return column;
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

            for (int i = 0; i < masivtext.Length - 1; i++)
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

        private static void Write(string path, string[,] text) // FUNCTION
        {
            string NewText = text[0, 0] + ";" + text[0, 1] + ";" + text[0, 2] + ";" + text[0, 3] + ";" + text[0, 4] + ";" + "Total" + ";" + "\n\r";

            string[] count = (string[])Array.CreateInstance(typeof(string), text.GetLength(0));


            for (int i = 1; i < text.GetLength(0); i++)
            {
                int total = 1;
                if (text[i, 0] != count[i])
                {
                    for (int n = i + 1; n < text.GetLength(0); n++)
                    {
                        if (text[i, 1] == text[n, 1] && text[i, 2] == text[n, 2] && text[i, 3] == text[n, 3] && text[i, 4] == text[n, 4])
                        {
                            text[i, 0] = (text[i, 0] + ", " + text[n, 0]);
                            count[n] = text[n, 0];
                            total++;
                           
                        }
                    }

                    NewText = NewText + text[i, 0] + ";" + text[i, 1] + ";" + text[i, 2] + ";" + text[i, 3] + ";" + text[i, 4] + ";" + total + ";" + "\n\r";
                    
                    
                }
            }

            using (StreamWriter sw = new StreamWriter(path, false, System.Text.Encoding.Default))
            {
                sw.WriteLine(NewText);
            }
        }
    }
}
