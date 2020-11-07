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
        }

        private void Buton_Rename_Click(object sender, EventArgs e)
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

        private void Button_Replace_Click(object sender, EventArgs e)
        {
            IEnumerable<FileInfo> filesToRename = Directory.GetFiles(Dir).Select(f => new FileInfo(f));
            foreach (FileInfo file in filesToRename)
            {
                if (TextBox_ToFind.Text == Path.GetFileNameWithoutExtension(file.Name))
                {
                    string newFileName = $@"{TextBox_Replace.Text}{file.Extension}";
                    string newFileFullPath = Path.Combine(file.DirectoryName, newFileName);
                    File.Move(file.FullName, newFileFullPath);
                }
            }
        }
    }
}
