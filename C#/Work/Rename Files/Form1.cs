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

namespace Rename_Files
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string Dir = null;
        
        private void Button_Dir_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog FBD = new FolderBrowserDialog();
            FBD.ShowNewFolderButton = false;
            if (FBD.ShowDialog() == DialogResult.OK)
            {
                Dir =  FBD.SelectedPath;
            }
            Label_DirLable.Visible = true;
            Lable_Dir.Visible = true;
            Lable_Rename.Visible = true;
            TextBox_NewName.Visible = true;
            Buton_Rename.Visible = true;
            if ( Dir == "C:\\Windows" | Dir == "C:\\Program Files (x86)" | Dir == "C:\\Program Files" | Dir == "C:\\Users" | Dir == "C:\\" )
            {
                Lable_Dir.BackColor = Color.Red;
                Lable_Dir.Text = Dir;
            } 
            else
            {
                Lable_Dir.Text = Dir;
                Lable_Dir.BackColor = Color.Transparent;
            }
        }

        private void Buton_Rename_Click(object sender, EventArgs e)
        {
            if (Lable_Dir.BackColor == Color.Red) 
            {
                MessageBox.Show("Выбрана одна из системных дерикторий!");
            }
            else
            {
                IEnumerable<FileInfo> filesToRename = Directory.GetFiles(Dir).Select(f => new FileInfo(f));
                foreach (FileInfo file in filesToRename)
                    {
                    string newFileName = $@"{TextBox_NewName.Text}{Path.GetFileNameWithoutExtension(file.Name)}{file.Extension}";
                    string newFileFullPath = Path.Combine(file.DirectoryName, newFileName);
                    File.Move(file.FullName, newFileFullPath);
                }

                MessageBox.Show("Готово!");
            }
        }

        private void Button_Replace_Click(object sender, EventArgs e)
        {
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
                        string LogText = null;
                        int i = 0;

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

                        if (i == 0)
                        {
                            MessageBox.Show("Совпадения не найдены!");
                        }
                        else
                        {
                            File.AppendAllText(Dir + "\\LogRename.txt", LogText);
                            MessageBox.Show("Готово!");
                        }
                    }
                }
            }
            
        }

        private void Lable_Dir_MouseDown(object sender, MouseEventArgs e)
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
}
