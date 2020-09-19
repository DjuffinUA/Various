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

namespace LoginForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.PassBox.AutoSize = false;
            this.PassBox.Size = new Size(this.PassBox.Size.Width, 49);
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CloseButton_MouseEnter(object sender, EventArgs e)
        {
            CloseButton.ForeColor = Color.Green;
        }

        private void CloseButton_MouseLeave(object sender, EventArgs e)
        {
            CloseButton.ForeColor = Color.White;
        }

        Point lastPoint;
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog OpenFile = new OpenFileDialog();
            if (OpenFile.ShowDialog() == DialogResult.Cancel)
                return;
            richTextBox1.Text = File.ReadAllText(OpenFile.FileName);
            string fullPath = Path.GetFullPath(OpenFile.FileName);

            _ = Convert(fullPath);
        }

        private static async Task Convert(string path)
        {
            string pathIn = path;

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

        private static void Write(string n)
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
