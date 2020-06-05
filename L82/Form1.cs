using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace L82
{
    public partial class Form1 : Form
    {
        List<Library> A = new List<Library>();
        Form2 a;
        Form3 b;
        Form4 c;
        Form5 d;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            a = new Form2();
            a.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            a = new Form2();
            a.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            b = new Form3();
            b.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            c = new Form4();
            c.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            d = new Form5();
            d.Show();
        }
    }
    class Library
    {
        public string Name;
        public string Surname;
        public string Book;
        public int Class;
        public int Number;

        public Library() { }
        public Library(string name, string surname, string book, int clas, int number)
        {
            Name = name;
            Surname = surname;
            Book = book;
            Class = clas;
            Number = number;
        }
        static public void FileInformationRewrite(string path, List<Library> users)
        {
            File.WriteAllText(path, String.Empty);
            using (StreamWriter s = new StreamWriter(path))
            {
                foreach (Library informationUnit in users)
                {
                    s.WriteLine(informationUnit.ToString());
                }
            }
        }
    }
}
