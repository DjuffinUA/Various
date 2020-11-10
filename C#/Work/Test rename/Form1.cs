using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Test_rename
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string Dir = null;
        List<string> FileName = new List<string>();
        string TextName = null;

        private void Button_Dir_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog FBD = new FolderBrowserDialog();
            FBD.ShowNewFolderButton = false;
            if (FBD.ShowDialog() == DialogResult.OK)
            {
                Dir = FBD.SelectedPath;
            }

            var dir = new DirectoryInfo(Dir); // папка с файлами 

            foreach (FileInfo file in dir.GetFiles())
            {
                FileName.Add(Path.GetFileNameWithoutExtension(file.FullName));
            }

            foreach (string i in FileName)
            {
                TextName = TextName + i + "; ";
            }

            TextBox_NameList_In.Text = TextName;
        }

        private void Button_Run_Click(object sender, EventArgs e)
        {
            if (TextBox_Find.Text == "")
            {
                MessageBox.Show("Пустое поле поиска");
            }
            else
            {
                if (TextBox_Rename.Text == "")
                {
                    MessageBox.Show("Пустое поле замены");
                }
                else
                {
                    string[] AllFiles = Directory.GetFiles(Dir, TextBox_Find.Text);
                    string LogText = null;

                    List<string> FullNameFile = new List<string>();
                    List<string> NameFile = new List<string>();
                    List<string> PointEXE = new List<string>();

                    if (AllFiles.Length > 0)
                    {
                        for (int i = 0; i < AllFiles.Length; i++)
                        {
                            string[] list = AllFiles[i].Split('\\');
                            FullNameFile.Add(list[list.Length - 1]);
                        }

                        foreach (string i in FullNameFile)
                        {
                            string[] abc = i.Split('.');
                            NameFile.Add(abc[0]);
                            PointEXE.Add(abc[1]);
                        }

                        for (int i = 0; i < AllFiles.Length; i++)
                        {
                            string OldFile = Dir + "\\" + NameFile[i] + "." + PointEXE[i];
                            string NewFile = Dir + "\\" + TextBox_Rename.Text + "." + PointEXE[i];
                            LogText = LogText + DateTime.Now + " Был переименован файл - " + OldFile + " на " + NewFile + "; \n";
                            File.Move(OldFile, NewFile);
                        }
                        File.AppendAllText(Dir + "\\LogRename.txt", LogText);
                        MessageBox.Show("Готово!");
                    }
                    else
                    {
                        MessageBox.Show("Совпадений не найденно!");
                    }
                }
            }
        }
    }
}
