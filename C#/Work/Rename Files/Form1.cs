using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Rename_Files
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string Dir = null;
        string LogText = null;
        int i = 0;
        int a = 0;

        private void Button_Dir_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog FBD = new FolderBrowserDialog();
            FBD.ShowNewFolderButton = false;
            if (FBD.ShowDialog() == DialogResult.OK)
            {
                Dir = FBD.SelectedPath;
            }

            if (Dir != null & Dir != "")
            {
                Buton_Rename.Visible = true;
                Button_Replace.Visible = true;

                DirColor(Dir);
            }
            else
            {
                MessageBox.Show("Папка не выбрана!");
            }
        }

        private void Buton_Rename_Click(object sender, EventArgs e)
        {
            a = 1;

            if (Lable_Dir.BackColor == Color.Red)
            {
                MessageBox.Show("Выбрана одна из системных дерикторий!");
            }
            else
            {
                IEnumerable<FileInfo> filesToRename = Directory.GetFiles(Dir).Select(f => new FileInfo(f));
                foreach (FileInfo file in filesToRename)
                {
                    if (Path.GetFileNameWithoutExtension(file.Name) != "LogRename" & Path.GetFileNameWithoutExtension(file.Name) != "logrename")
                    {
                        string newFileName = $@"{TextBox_NewName.Text}{Path.GetFileNameWithoutExtension(file.Name)}{file.Extension}";
                        string newFileFullPath = Path.Combine(file.DirectoryName, newFileName);
                        File.Move(file.FullName, newFileFullPath);
                        LogText = LogText + DateTime.Now + " " + file.FullName + " -> " + newFileFullPath + " ;\n";
                        i++;
                    }
                }

                MessageBoxRun(i, a, LogText);

            }

            i = 0;
            a = 0;

        }

        private void Button_Replace_Click(object sender, EventArgs e)
        {
            a = 2;

            if (Dir == null)
            {
                MessageBox.Show("Выбирите папку!");
            }
            else
            {
                if (TextBox_ToFind.Text == "")
                {
                    MessageBox.Show("Пустое поле поиска");
                }
                else
                {
                    if (TextBox_Replace.Text == "")
                    {
                        MessageBox.Show("Пустое поле замены");
                    }
                    else
                    {
                        string ToFind = TextBox_ToFind.Text.ToLower();

                        IEnumerable<FileInfo> filesToRename = Directory.GetFiles(Dir).Select(f => new FileInfo(f));
                        foreach (FileInfo file in filesToRename)
                        {
                            if (Path.GetFileNameWithoutExtension(file.Name) != "LogRename" & Path.GetFileNameWithoutExtension(file.Name) != "logrename")
                            {
                                if (Path.GetFileNameWithoutExtension(file.Name).IndexOf(ToFind) != -1)
                                {
                                    string newFileName = $@"{Path.GetFileNameWithoutExtension(file.Name).ToLower().Replace(ToFind, TextBox_Replace.Text)}{file.Extension}";
                                    string newFileFullPath = Path.Combine(file.DirectoryName, newFileName);
                                    File.Move(file.FullName, newFileFullPath);
                                    LogText = LogText + DateTime.Now + " " + file.FullName + " -> " + newFileFullPath + " ;\n";
                                    i++;
                                }
                                else if ((Path.GetFileNameWithoutExtension(file.Name).ToLower().IndexOf(ToFind) != -1))
                                {
                                    string newFileName = $@"{Path.GetFileNameWithoutExtension(file.Name).ToLower().Replace(ToFind, TextBox_Replace.Text)}{file.Extension}";
                                    string newFileFullPath = Path.Combine(file.DirectoryName, newFileName);
                                    File.Move(file.FullName, newFileFullPath);
                                    LogText = LogText + DateTime.Now + " " + file.FullName + " -> " + newFileFullPath + " ;\n";
                                    i++;
                                }
                            }
                        }
                    }

                    MessageBoxRun(i, a, LogText);

                }
            }

            i = 0;
            a = 0;

        }

        private void Lable_Dir_MouseDown(object sender, MouseEventArgs e)
        {
            if (Lable_Dir.BackColor == Color.Red)
            {
                MessageBox.Show("Выбрана одна из системных дерикторий!");
            }
            else
            {
                if (Dir != null)
                {
                    MessageBox.Show(Dir);
                }
                else
                {
                    MessageBox.Show("Выбирите папку!");
                }
            }


        }

        private void MessageBoxRun(int i, int a, string LogText)
        {
            if (i == 0)
            {
                if (a == 2)
                {
                    MessageBox.Show("Совпадения не найдены!");
                }
                else if (a == 1)
                {
                    MessageBox.Show("Нет файлов в папке!");
                }
            }
            else
            {
                File.AppendAllText(Dir + "\\LogRename.txt", LogText);
                MessageBox.Show("Готово!");
            }
        }

        private void DirColor(string Dir)
        {

            List<string> FullDir = new List<string>
            {
                 Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                 Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData),
                 Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                 Environment.GetFolderPath(Environment.SpecialFolder.AdminTools),
                 Environment.GetFolderPath(Environment.SpecialFolder.CommonAdminTools),
                 Environment.GetFolderPath(Environment.SpecialFolder.Cookies),
                 Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory),
                 Environment.GetFolderPath(Environment.SpecialFolder.Fonts),
                 Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles),
                 Environment.GetEnvironmentVariable("ProgramW6432"),
                 Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86),
                 Environment.GetFolderPath(Environment.SpecialFolder.Programs),
                 Environment.GetFolderPath(Environment.SpecialFolder.StartMenu),
                 Environment.GetFolderPath(Environment.SpecialFolder.Startup),
                 Environment.GetFolderPath(Environment.SpecialFolder.System),
                 Environment.GetFolderPath(Environment.SpecialFolder.SystemX86),
                 Environment.GetFolderPath(Environment.SpecialFolder.Windows)
            };

            foreach (string path in FullDir)
            {
                if (path.IndexOf(Dir) != -1)
                {
                    Lable_Dir.BackColor = Color.Red;
                    Lable_Dir.Text = Dir;
                    break;
                }
                else
                {
                    Lable_Dir.Text = Dir;
                    Lable_Dir.BackColor = Color.Transparent;
                }
            }

        }
    }
}
