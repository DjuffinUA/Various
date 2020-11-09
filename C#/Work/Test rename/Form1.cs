using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

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
            if (TextBox_Find.Text != null)
            {
                if (TextBox_Rename.Text != null)
                {
                    string Find = TextBox_Find.Text;
                    char[] Symbol = Find.ToCharArray();

                    if (Symbol[0] == '*')
                    {

                    }

                    for (int i = 0; i < FileName.Count; i++)
                    {
                       
                    }
                }
                else
                {
                    MessageBox.Show("");
                }
                    
            }
            else 
            {
                MessageBox.Show("");
            }
        }
    }
}
