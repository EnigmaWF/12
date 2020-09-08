using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string t = Convert.ToString(textBox1.Text); //123 123 123 123
            for (int i = 3; i < t.Length; i+=4)
            {
                t=t.Insert(i, " ");
            }
            label1.Text = "" + t;
            /*12.  Дана строка, содержащая длинное целое число. 
             * Расставить пробелы в результирующей строке между каждыми тремя цифрами.*/
        }
    }
}
