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
    public partial class Form4 : Form
    {
        List<Library> A = new List<Library>();
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
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

            int n = Convert.ToInt32(textBox2.Text);
            A.RemoveAt(n - 1);
            Library.FileInformationRewrite("lib.txt", A);

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
