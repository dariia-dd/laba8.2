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
    public partial class Form5 : Form
    {
        List<Library> A = new List<Library>();
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (StreamReader s = new StreamReader("lib.txt"))
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

            int n = Convert.ToInt32(textBox6.Text);
            Library A1 = new Library();
            string name = textBox1.Text;
            A1.Name = name;
            string sur = textBox2.Text;
            A1.Surname = sur;
            string dis = textBox3.Text;
            A1.Book = dis;
            int age = Convert.ToInt32(textBox4.Text);
            A1.Class = age;
            int num = Convert.ToInt32(textBox5.Text);
            A1.Number = num;
            A.RemoveAt(n - 1);
            A.Insert(n - 1, A1);
            Library.FileInformationRewrite("lib.txt", A);
        }

    }
}
