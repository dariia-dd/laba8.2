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

namespace L82
{
    public partial class Form3 : Form
    {
        List<Library> A = new List<Library>();
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamWriter sw = File.CreateText(openFileDialog1.FileName);
            using (StreamReader s = new StreamReader("doctor.txt"))
            {
                string str;
                string[] a;
                while (s.EndOfStream == false)
                {
                    str = s.ReadLine();
                    if (str != "" && str != " ")
                    {
                        a = str.Split();
                        A.Add(new Library(a[0], a[1], a[2], int.Parse(a[3]), int.Parse(a[4])));
                    }
                }
            }
            string line;
            for (int i = 0; i < richTextBox1.Lines.Length; i++)
            {
                line = richTextBox1.Lines[i].ToString();
                sw.WriteLine(line);

            }

            for (int i = 0; i < richTextBox1.Lines.Length; i += 5)
            {
                A.Add(new Library() { Name = richTextBox1.Lines[i].ToString(), Surname = richTextBox1.Lines[i + 1].ToString(), Book = richTextBox1.Lines[i + 2].ToString(), Class = int.Parse(richTextBox1.Lines[i + 3]), Number = int.Parse(richTextBox1.Lines[i + 4]) });
                Library.FileInformationRewrite("doctor.txt", A);
            }
            sw.Close();

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
