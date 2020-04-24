using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aksenov_Examen_S22
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a;
            int b = 0;
            a = Convert.ToDouble(textBox1.Text);

            if (a == 0)
            {
                label2.Text = "***";
            }

            else if (a % 1 == 0)
            {
                label2.Text = "Целое";
            }

            else
            {
                label2.Text = "Не целое";
            }



            if (a > 0)
            {
                label4.Text = "Положительное";
            }

            else if (a < 0)
            {
                label4.Text = "Отрицательное";
            }

            else if (a == 0)
            {
                label4.Text = "Равно нулю";
            }



            if (a == 0)
            {
                label6.Text = "***";
            }

            else if ((a % 2) == 0)
            {
                label6.Text = "Четное";
            }

            else
            {
                label6.Text = "Нечетное";
            }
        }
    }
}
