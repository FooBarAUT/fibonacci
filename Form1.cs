using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fibonacci
{
    public partial class Form1 : Form
    {
        public static int fibonacci(int n)
        {
            int a = 0;
            int b = 1;
            for (int i = 0; i < n; i++)
            {
                int temp = a;
                a = b;
                b = temp + b;
            }
            return a;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.BackColor = System.Drawing.SystemColors.Window;
        }

        private void start_Click(object sender, EventArgs e)
        {
            int numVal = Convert.ToInt32(numericUpDown.Value);
            int count = 1;
            for (int i = 0; i < numVal; i++) {
                string fibNum = fibonacci(i).ToString();
                textBox1.AppendText(count + ". " + fibNum + "\n");
                count++;
            }
        }
    }
}
