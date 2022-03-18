using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(TextBoxValidate(textBox1, textBox2))
            {
                int a = int.Parse(textBox1.Text);
                int b = int.Parse(textBox2.Text);
                    a = Math.Abs(a);
                    b = Math.Abs(b);
                    double AR = (a + b) / 2;
                    double G = Math.Pow(Math.Sqrt(a * b), 2);
                    ResultLabel_Ar.Text = AR + "";
                    ResultLabel_G.Text = G + "";
            }
        }
        private bool TextBoxValidate(params TextBox[] textBox)
        {

            bool result = true;

            foreach (TextBox t in textBox)
            {
                if (t.Text == "")
                {
                    errorProvider1.SetError(t, "введите поле");
                    result = false;

                }
                else errorProvider1.SetError(t, "");

            }
            return result;
        }
    }
}
