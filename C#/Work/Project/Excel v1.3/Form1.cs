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

namespace Excel_v1._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string PathIN = null;
        string PathOut = null;
        string Kolonka2 = null;
        string Kolonka3 = null;
        string Kolonka4 = null;
        string Kolonka5 = null;
        int k2, k3, k4, k5;
        List<string[]> Colum_All = new List<string[]>();
        string Colum_Text = null;

        private void B_Open_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "csv files (*.csv)|*.csv";
            if (openFile.ShowDialog() == DialogResult.Cancel)
                return;
            PathIN = Path.GetFullPath(openFile.FileName);
            string fileText = File.ReadAllText(PathIN);
            B_Text.Text = fileText;

            string line;
            StreamReader file =new StreamReader(PathIN);
            for (int i = 0; i < 1; i++)
            {
                line = file.ReadLine();
                Colum_Text = line;
            }
            string[] masiv = Colum_Text.Split(';');
            for (int i = 1; i < masiv.Length; i++)
            {
                Colum_2.Items.Add(masiv[i]);
                Colum_3.Items.Add(masiv[i]);
                Colum_4.Items.Add(masiv[i]);
                Colum_5.Items.Add(masiv[i]);
            }

        }

        private void B_Save_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "csv files (*.csv)|*.csv";
            if (saveFile.ShowDialog() == DialogResult.Cancel)
                return;
            PathOut = Path.GetFullPath(saveFile.FileName);
        }

        private void B_Run_Click(object sender, EventArgs e)
        {
            int n = 1;
            string new_text = "", title = "";
            

            if (Kolonka2 != null) n++;
            if (Kolonka3 != null) n++;
            if (Kolonka4 != null) n++;
            if (Kolonka5 != null) n++;
            List<string> new_table = new List<string>();

            StreamReader file = new StreamReader(PathIN, System.Text.Encoding.Default); // Title
            for (int i = 0; i < 1; i++)
            {
                title = file.ReadLine();
            }
            string[] masiv_title = title.Split(';');
            for (int i = 0; i < masiv_title.Length; i++)
            {
                if (Kolonka2 == masiv_title[i]) k2 = i;
                if (Kolonka3 == masiv_title[i]) k3 = i;
                if (Kolonka4 == masiv_title[i]) k4 = i;
                if (Kolonka5 == masiv_title[i]) k5 = i;
            }

            StreamReader sr = new StreamReader(PathIN, System.Text.Encoding.Default); // new string file format(colum)
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                string[] masiv_strok = line.Split(';');

                string text = masiv_strok[0] + ";";
                if (Kolonka2 != null)
                {
                    text = text + masiv_strok[k2] + ";";
                } 
                else
                {
                    text = text + null + ";";
                }
                if (Kolonka3 != null)
                {
                    text = text + masiv_strok[k3] + ";";
                }
                else
                {
                    text = text + null + ";";
                }
                if (Kolonka4 != null)
                {
                    text = text + masiv_strok[k4] + ";";
                }
                else
                {
                    text = text + null + ";";
                }
                if (Kolonka5 != null)
                {
                    text = text + masiv_strok[k5] + ";" + "\n";
                }
                else
                {
                    text = text + null + ";" + "\n";
                }
                
                new_text = new_text + text;
            }

            string[] new_text_masiv = new_text.Split('\n');
            string[,] NewMasive = (string[,])Array.CreateInstance(typeof(string), new_text_masiv.Length - 1, n); // создание масива по количеству строк

            for (int i = 0; i < new_text_masiv.Length - 1; i++)
            {
                string NewText = string.Join(";", new_text_masiv[i]);
                string[] masivNewText = NewText.Split(';');

                for (int l = 0; l < n; l++)
                {
                    NewMasive[i, l] = masivNewText[l];
                }

            }

            string New_Text = "";
            if (n == 2)
            {
                New_Text = NewMasive[0, 0] + ";" + NewMasive[0, 1] + ";" + "Total" + ";" + "\n";
                string[] count = (string[])Array.CreateInstance(typeof(string), NewMasive.GetLength(0));
                for (int i = 1; i < NewMasive.GetLength(0); i++)
                {
                    int total = 1;
                    if (NewMasive[i, 0] != count[i])
                    {
                        for (int k = i + 1; k < NewMasive.GetLength(0); k++)
                        {
                            if ( NewMasive[i, 1] == NewMasive[k, 1] )
                            {
                                NewMasive[i, 0] = (NewMasive[i, 0] + ", " + NewMasive[k, 0]);
                                count[k] = NewMasive[k, 0];
                                total++;
                            }
                        }

                        New_Text = New_Text + NewMasive[i, 0] + ";" + NewMasive[i, 1] + ";" + total + ";" + "\n";

                    }
                }
            } 
            else if (n == 3)
            {
                New_Text = NewMasive[0, 0] + ";" + NewMasive[0, 1] + ";" + NewMasive[0, 2] + ";" + "Total" + ";" + "\n";
                string[] count = (string[])Array.CreateInstance(typeof(string), NewMasive.GetLength(0));
                for (int i = 1; i < NewMasive.GetLength(0); i++)
                {
                    int total = 1;
                    if (NewMasive[i, 0] != count[i])
                    {
                        for (int k = i + 1; k < NewMasive.GetLength(0); k++)
                        {
                            if ( NewMasive[i, 1] == NewMasive[k, 1] && NewMasive[i, 2] == NewMasive[k, 2] )
                            {
                                NewMasive[i, 0] = (NewMasive[i, 0] + ", " + NewMasive[k, 0]);
                                count[k] = NewMasive[k, 0];
                                total++;
                            }
                        }

                        New_Text = New_Text + NewMasive[i, 0] + ";" + NewMasive[i, 1] + ";" + NewMasive[i, 2] + ";" + total + ";" + "\n";

                    }
                }
            }
            else if (n == 4)
            {
                New_Text = NewMasive[0, 0] + ";" + NewMasive[0, 1] + ";" + NewMasive[0, 2] + ";" + NewMasive[0, 3] + ";" + "Total" + ";" + "\n";
                string[] count = (string[])Array.CreateInstance(typeof(string), NewMasive.GetLength(0));
                for (int i = 1; i < NewMasive.GetLength(0); i++)
                {
                    int total = 1;
                    if (NewMasive[i, 0] != count[i])
                    {
                        for (int k = i + 1; k < NewMasive.GetLength(0); k++)
                        {
                            if ( NewMasive[i, 1] == NewMasive[k, 1] && NewMasive[i, 2] == NewMasive[k, 2] && NewMasive[i, 3] == NewMasive[k, 3] )
                            {
                                NewMasive[i, 0] = (NewMasive[i, 0] + ", " + NewMasive[k, 0]);
                                count[k] = NewMasive[k, 0];
                                total++;
                            }
                        }

                        New_Text = New_Text + NewMasive[i, 0] + ";" + NewMasive[i, 1] + ";" + NewMasive[i, 2] + ";" + NewMasive[i, 3] + ";" + total + ";" + "\n";

                    }
                }
            }
            else if (n == 5)
            {
                New_Text = NewMasive[0, 0] + ";" + NewMasive[0, 1] + ";" + NewMasive[0, 2] + ";" + NewMasive[0, 3] + ";" + NewMasive[0, 4] + ";" + "Total" + ";" + "\n";
                string[] count = (string[])Array.CreateInstance(typeof(string), NewMasive.GetLength(0));
                for (int i = 1; i < NewMasive.GetLength(0); i++)
                {
                    int total = 1;
                    if (NewMasive[i, 0] != count[i])
                    {
                        for (int k = i + 1; k < NewMasive.GetLength(0); k++)
                        {
                            if (NewMasive[i, 1] == NewMasive[k, 1] && NewMasive[i, 2] == NewMasive[k, 2] && NewMasive[i, 3] == NewMasive[k, 3] && NewMasive[i, 4] == NewMasive[k, 4])
                            {
                                NewMasive[i, 0] = (NewMasive[i, 0] + ", " + NewMasive[k, 0]);
                                count[k] = NewMasive[k, 0];
                                total++;
                            }
                        }

                        New_Text = New_Text + NewMasive[i, 0] + ";" + NewMasive[i, 1] + ";" + NewMasive[i, 2] + ";" + NewMasive[i, 3] + ";" + NewMasive[i, 4] + ";" + total + ";" + "\n";

                    }
                }
            }

            using (StreamWriter sw = new StreamWriter(PathOut, false, System.Text.Encoding.Default))
            {
                sw.WriteLine(New_Text);
            }

        }

        private void B_Help_Click(object sender, EventArgs e)
        {
            F_Help newForm = new F_Help();
            newForm.Show();
        }

        private void Colum_2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedState = Colum_2.SelectedItem.ToString();
            Kolonka2 = selectedState;
        }

        private void Colum_3_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedState = Colum_3.SelectedItem.ToString();
            Kolonka3 = selectedState;
        }

        private void Colum_4_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedState = Colum_4.SelectedItem.ToString();
            Kolonka4 = selectedState;
        }

        private void Colum_5_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedState = Colum_5.SelectedItem.ToString();
            Kolonka5 = selectedState;
        }
    }
}
